using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Mods.CalamityMod;
using CalamityRuTranslate.Mods.FargowiltasSouls;
using CalamityRuTranslate.Mods.ThoriumMod;
using CalamityRuTranslate.ThoriumMod.ModSupport;
using CalamityRuTranslate.Utilities;
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

        public CalamityRuTranslate() => Instance = this;

        public override void Load()
        {
            CoreCalamityTranslation.Load();
            CoreThoriumTranslation.Load();
            CoreFargowiltasSoulsTranslation.Load();
            ILManager.Load();
            GlobalDictionaries.LoadDictionaries();
            LoadFont();
            LoadAlternateRussian(LanguageManager.Instance, ProjectTRuConfig.Instance.NewVanillaTranslation ? "Terraria.Localization.Content." : "Terraria.LocalizationOld.Content.");
            LangUtilities.Load();
        }

        public override void Unload()
        {
            Instance = null;
            ProjectTRuConfig.Instance = null;
            LangUtilities.Unload();
            CoreCalamityTranslation.Unload();
            CoreFargowiltasSoulsTranslation.Unload();
            CoreThoriumTranslation.Unload();
            ILManager.Unload();
            UnloadFont();
            GlobalDictionaries.UnloadDictionaries();
        }
		
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            CoreCalamityTranslation.LoadNpcChat();
            if (Translation.IsRussianLanguage && ProjectTRuConfig.Instance.ThoriumTranslation && ModLoader.GetMod("ThoriumMod") != null)
            {
                ThoriumSupport.ThoriumNpcChat();
            }
        }
		
        public override void PostSetupContent()
        {
            CoreCalamityTranslation.LoadCrossContent();
            CoreFargowiltasSoulsTranslation.LoadCrossContent();
            CoreThoriumTranslation.LoadCrossContent();
        }
        
        private void LoadAlternateRussian(LanguageManager languageManager, string prefix)
        {
            if (Translation.IsRussianLanguage)
            {
                foreach (TmodFile.FileEntry item in typeof(Mod).GetProperty("File", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this) as TmodFile)
                {
                    if (Path.GetFileNameWithoutExtension(item.Name).StartsWith(prefix + languageManager.ActiveCulture.CultureInfo.Name) && item.Name.EndsWith(".json"))
                    {
                        try
                        {
                            languageManager.LoadLanguageFromFileText(Encoding.UTF8.GetString(GetFileBytes(item.Name)));
                        }
                        catch
                        {
                            Logger.InfoFormat("Failed to load language file: " + item);
                        }
                    }
                }
            }
        }

        private void LoadFont()
        {
            if (ProjectTRuConfig.Instance.NewRussianTerrariaFont && !Main.dedServ)
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