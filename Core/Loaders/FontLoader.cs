using System.Threading.Tasks;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using ReLogic.Graphics;
using Terraria;

namespace CalamityRuTranslate.Core.Loaders
{
    public class FontLoader : ILoadable
    {
        private TaskCompletionSource<bool> _unloadTCS;
        private bool _hasBackups;
        private DynamicSpriteFont[] _combatTextBackup;
        private DynamicSpriteFont _deathTextBackup;
        private DynamicSpriteFont _itemStackBackup;
        private DynamicSpriteFont _mouseTextBackup;

        public float Priority => 1f;

        public void Load()
        {
            if (Main.dedServ)
                 return;

            if (TRuConfig.Instance.NewRussianTerrariaFont && TranslationHelper.IsRussianLanguage)
            {
                _combatTextBackup = Main.fontCombatText;
                _deathTextBackup = Main.fontDeathText;
                _itemStackBackup = Main.fontItemStack;
                _mouseTextBackup = Main.fontMouseText;
                _hasBackups = true;

                Main.fontItemStack = CalamityRuTranslate.Instance.GetFont("Fonts/Item_Stack");
                Main.fontMouseText = CalamityRuTranslate.Instance.GetFont("Fonts/Mouse_Text");
                Main.fontDeathText = CalamityRuTranslate.Instance.GetFont("Fonts/Death_Text");
                Main.fontCombatText = new[]
                {
                    CalamityRuTranslate.Instance.GetFont("Fonts/Combat_Text"),
                    CalamityRuTranslate.Instance.GetFont("Fonts/Combat_Crit")
                };
            }

            Main.OnPreDraw += PreDraw;
        }

        public void Unload()
        {
            if (!Main.dedServ)
            {
                _unloadTCS = new TaskCompletionSource<bool>();
                _unloadTCS.Task.Wait();

                Main.OnPreDraw -= PreDraw;
            }
        }
        
        private void PreDraw(GameTime obj)
        {
            if (_unloadTCS != null)
            {
                UnloadFonts();

                _unloadTCS.SetResult(true);
                _unloadTCS = null;
            }
        }
        
        private void UnloadFonts()
        {
            if (_hasBackups)
            {
                Main.fontCombatText = _combatTextBackup;
                Main.fontDeathText = _deathTextBackup;
                Main.fontItemStack = _itemStackBackup;
                Main.fontMouseText = _mouseTextBackup;

                _combatTextBackup = null;
                _deathTextBackup = null;
                _itemStackBackup = null;
                _mouseTextBackup = null;

                _hasBackups = false;
            }
        }
    }
}