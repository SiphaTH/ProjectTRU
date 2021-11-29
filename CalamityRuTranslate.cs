using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Content;
using CalamityRuTranslate.Mods.CalamityMod;
using CalamityRuTranslate.Mods.Fargowiltas;
using CalamityRuTranslate.Mods.FargowiltasSouls;
using CalamityRuTranslate.Mods.ThoriumMod;
using CalamityRuTranslate.Mods.ThoriumMod.Buffs;
using CalamityRuTranslate.Mods.ThoriumMod.Items;
using CalamityRuTranslate.Mods.ThoriumMod.Projectiles;
using CalamityRuTranslate.ThoriumMod.Items;
using CalamityRuTranslate.ThoriumMod.ModSupport;
using CalamityRuTranslate.ThoriumMod.NPCs;
using CalamityRuTranslate.ThoriumMod.Tiles;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;
using Terraria.UI;

namespace CalamityRuTranslate
{
    public partial class CalamityRuTranslate : Mod
    {
        public static CalamityRuTranslate Instance { get; private set; }

        private ModRussianTranslation[] _translations =
        {
            new CoreCalamityTranslation(),
            new CoreThoriumTranslation(),
            new CoreFargowiltasSoulsTranslation(),
            new CoreFargowiltasTranslation()
        };

        public CalamityRuTranslate() => Instance = this;

        public override void Load()
        {
            foreach (ModRussianTranslation translation in _translations)
                translation.TryLoad();
            
            ILManager.Load();
            LangUtils.Load();
            LoadJSON();
            LoadFont();
            LoadCache();
            CalamityReflections();
        }

        public override void Unload()
        {
            Instance = null;
            TRuConfig.Instance = null;
            LangUtils.Unload();
            ILManager.Unload();
            TRuGlowmask.Unload();
            UnloadFont();
            UnloadCache();
            CoreThoriumTranslation.Unload();
            GameCulture currentGameCulture = LanguageManager.Instance.ActiveCulture;
            LanguageManager.Instance.SetLanguage(GameCulture.English);
            LanguageManager.Instance.SetLanguage(currentGameCulture);
        }
		
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            foreach (ModRussianTranslation translation in _translations)
            {
                translation.TryDialogueTranslation();
                translation.TryCombatTextTranslation();
            }

            if (TranslationUtils.IsRussianLanguage && !Main.dedServ && ModsCall.Thorium != null)
            {
                ThoriumSupport.ThoriumNpcChat();
            }
        }
        
        public override void PostSetupContent()
        {
            foreach (ModRussianTranslation translation in _translations)
                translation.TrySetupContentTranslation();
            
            if (TranslationUtils.IsRussianLanguage && !Main.dedServ && ModsCall.Thorium != null)
            {
                BuffTranslation.SetupTranslation();
                PrefixNames.SetupTranslation();
                ProjectileNames.SetupTranslation();
                ThoriumItemName.Setup();
                ThoriumItemTooltip.Setup();
                ThoriumNpc.Setup();
                ThoriumTiles.Setup();
                ThoriumSupport.ThoriumAddLocalizations();
            }
        }

        private void LoadJSON()
        {
            if (!TranslationUtils.IsRussianLanguage)
                return;
        
            TmodFile tModFile = typeof(CalamityRuTranslate).GetProperty("File", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(Instance) as TmodFile;

            foreach (var item in tModFile.Where(entry =>
                Path.GetFileNameWithoutExtension(entry.Name).StartsWith("Terraria.Localization.Content.")))
                LanguageManager.Instance.LoadLanguageFromFileText(Encoding.UTF8.GetString(GetFileBytes(item.Name)));
        }
    }
}