using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Mods.CalamityMod;
using CalamityRuTranslate.Mods.ThoriumMod;
using CalamityRuTranslate.ThoriumMod.ModSupport;
using CalamityRuTranslate.Utilities;
using CalamityRuTranslate.Vanilla;
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
        public override void Load()
        {
            Instance = this;
            CoreCalamityTranslation.Load();
            CoreThoriumTranslation.Load();
            VanillaIL.LoadIL();
            GlobalDictionaries.LoadDictionaries();
            LoadFont();
            LoadAlternateRussian(LanguageManager.Instance, Config.NewVanillaTranslation ? "Terraria.Localization.Content." : "Terraria.LocalizationOld.Content.");
            
            FieldInfo translationsField = typeof(Mod).GetField("translations", BindingFlags.Instance | BindingFlags.NonPublic);
            translations = (Dictionary<string, ModTranslation>)translationsField.GetValue(this);
        }

        public override void Unload()
        {
            _itemStack = null;
            _mouseText = null;
            _deathText = null;
            _combatText = null;
            _combatCrit = null;
            translations = null;
            Instance = null;
            Config = null;
            
            CoreCalamityTranslation.Unload();
            CoreThoriumTranslation.Unload();
            VanillaIL.UnloadIL();
            UnloadFont();
            GlobalDictionaries.UnloadDictionaries();
        }
		
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            CoreCalamityTranslation.LoadNpcChat();
            if (Translation.IsRussianLanguage)
            {
                if (Config.ThoriumTranslation)
                {
                    if (ModLoader.GetMod("ThoriumMod") != null)
                    {
                        ThoriumSupport.ThoriumNpcChat();
                    }
                }
            }
        }
		
        public override void PostSetupContent()
        {
            CoreCalamityTranslation.LoadCrossContent();
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
            if (Config.NewTerrariaFont && !Main.dedServ)
            {
                _itemStack = GetFont("Fonts/Item_Stack");
                _mouseText = GetFont("Fonts/Mouse_Text");
                _deathText = GetFont("Fonts/Death_Text");
                _combatText = GetFont("Fonts/Combat_Text");
                _combatCrit = GetFont("Fonts/Combat_Crit");
                        
                Main.fontItemStack = _itemStack;
                Main.fontMouseText = _mouseText;
                Main.fontDeathText = _deathText;
                Main.fontCombatText[0] = _combatText;
                Main.fontCombatText[1] = _combatCrit;
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
        
        private DynamicSpriteFont _itemStack;
        private DynamicSpriteFont _mouseText;
        private DynamicSpriteFont _deathText;
        private DynamicSpriteFont _combatText;
        private DynamicSpriteFont _combatCrit;
        internal static Dictionary<string, ModTranslation> translations;
        public static CalamityRuTranslate Instance;
        internal static Config Config;
    }
}