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
using CalamityRuTranslate.ThoriumMod.ModSupport;
using ReLogic.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;
using Terraria.UI;

namespace CalamityRuTranslate
{
    public class CalamityRuTranslate : Mod
    {
        public static CalamityRuTranslate Instance { get; private set; }

        private ModRussianTranslation[] _translations =
        {
            new CoreCalamityTranslation(),
            new CoreFargowiltasSoulsTranslation(),
            new CoreFargowiltasTranslation()
        };
        
        public CalamityRuTranslate() => Instance = this;

        public override void Load()
        {
            foreach (ModRussianTranslation translation in _translations)
                translation.TryLoad();
            
            ILManager.Load();
            LoadFont();
            LoadJSON(TRuConfig.Instance.NewVanillaTranslation);
            LangUtils.Load();

            foreach (ModRussianTranslation translation in _translations)
                translation.TryLoad();
        }

        public override void Unload()
        {
            Instance = null;
            TRuConfig.Instance = null;
            LangUtils.Unload();
            CoreThoriumTranslation.Unload();
            ILManager.Unload();
            UnloadFont();
            TRuGlowmask.Unload();
        }
		
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            foreach (ModRussianTranslation translation in _translations)
                translation.TryDialogueTranslation();
            
            if (TranslationUtils.IsRussianLanguage)
            {
                if (TRuConfig.Instance.ThoriumTranslation && ModLoader.GetMod("ThoriumMod") != null)
                {
                    ThoriumSupport.ThoriumNpcChat();
                }
            }
        }
		
        public override void PostSetupContent()
        {
            foreach (ModRussianTranslation translation in _translations)
                translation.TrySetupContentTranslation();
            
            if (TranslationUtils.IsRussianLanguage && !Main.dedServ)
            {
                CoreThoriumTranslation.LoadCrossContent();
            }
        }

        private void LoadJSON(bool isNewJSONTranslation)
        {
            TmodFile tModFile = typeof(CalamityRuTranslate).GetProperty("File", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(Instance) as TmodFile;

            if (TranslationUtils.IsRussianLanguage)
            {
                foreach (TmodFile.FileEntry item in tModFile.Where(entry => Path.GetFileNameWithoutExtension(entry.Name).StartsWith(isNewJSONTranslation ? "Terraria.Localization.Content." : "Terraria.LocalizationOld.Content.")))
                {
                    LanguageManager.Instance.LoadLanguageFromFileText(Encoding.UTF8.GetString(GetFileBytes(item.Name)));
                }
            }
        }
        
        private void LoadFont()
        {
            if (TRuConfig.Instance.NewRussianTerrariaFont && TranslationUtils.IsRussianLanguage && !Main.dedServ)
            {
                Main.fontItemStack = Instance.GetFont("Fonts/Item_Stack");
                Main.fontMouseText = Instance.GetFont("Fonts/Mouse_Text");
                Main.fontDeathText = Instance.GetFont("Fonts/Death_Text");
                Main.fontCombatText[0] = Instance.GetFont("Fonts/Combat_Text");
                Main.fontCombatText[1] = Instance.GetFont("Fonts/Combat_Crit");
            }
        }

        private void UnloadFont()
        {
            if (!Main.dedServ)
            {
                Main.fontItemStack = Main.instance.OurLoad<DynamicSpriteFont>("Fonts" + Path.DirectorySeparatorChar + "Item_Stack");
                Main.fontMouseText = Main.instance.OurLoad<DynamicSpriteFont>("Fonts" + Path.DirectorySeparatorChar + "Mouse_Text");
                Main.fontDeathText = Main.instance.OurLoad<DynamicSpriteFont>("Fonts" + Path.DirectorySeparatorChar + "Death_Text");
                Main.fontCombatText[0] = Main.instance.OurLoad<DynamicSpriteFont>("Fonts" + Path.DirectorySeparatorChar + "Combat_Text");
                Main.fontCombatText[1] = Main.instance.OurLoad<DynamicSpriteFont>("Fonts" + Path.DirectorySeparatorChar + "Combat_Crit");
            }
        }
    }
}