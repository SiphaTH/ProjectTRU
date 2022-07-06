using System.Threading.Tasks;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.Loaders;

public class FontLoader : ILoadable
{
    private TaskCompletionSource<bool> _unloadTCS;
    private bool _hasBackups;
    private Asset<DynamicSpriteFont>[] _combatTextBackup;
    private Asset<DynamicSpriteFont> _deathTextBackup;
    private Asset<DynamicSpriteFont> _itemStackBackup;
    private Asset<DynamicSpriteFont> _mouseTextBackup;
    public bool IsLoadingEnabled(Mod mod)
    {
        return TRuConfig.Instance.NewRussianTerrariaFont && TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        if (Main.dedServ)
            return;

        _combatTextBackup = FontAssets.CombatText;
        _deathTextBackup = FontAssets.DeathText;
        _itemStackBackup = FontAssets.ItemStack;
        _mouseTextBackup = FontAssets.MouseText;
        _hasBackups = true;

        FontAssets.ItemStack = ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Fonts/Item_Stack", AssetRequestMode.ImmediateLoad);
        FontAssets.MouseText = ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Fonts/Mouse_Text", AssetRequestMode.ImmediateLoad);
        FontAssets.DeathText = ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Fonts/Death_Text", AssetRequestMode.ImmediateLoad);
        FontAssets.CombatText = new[]
        {
            ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Fonts/Combat_Text", AssetRequestMode.ImmediateLoad),
            ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Fonts/Combat_Crit", AssetRequestMode.ImmediateLoad)
        };

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
            FontAssets.CombatText = _combatTextBackup;
            FontAssets.DeathText = _deathTextBackup;
            FontAssets.ItemStack = _itemStackBackup;
            FontAssets.MouseText = _mouseTextBackup;
            _combatTextBackup = null;
            _deathTextBackup = null;
            _itemStackBackup = null;
            _mouseTextBackup = null;
            _hasBackups = false;
        }
    }
}