using System.Collections.Generic;
using System.Reflection;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Utilities
{
    public static class LangUtilities
    {
        internal static Dictionary<string, ModTranslation> Translations;
        
        internal static string GetTextValue(string mod, string key) => GetModTextValue($"{mod}.{key}");

        internal static string GetModTextValue(string key) => GetModTextValue(CalamityRuTranslate.Instance, key);
        
        public static string GetModTextValue(Mod mod, string key) => Language.GetTextValue($"Mods.{mod.Name}.{key}");
        
        public static string TranslationKey(string key) => Translations[$"Mods.CalamityRuTranslate.{key}"].GetTranslation(Language.ActiveCulture);

        public static void Load()
        {
            FieldInfo translationsField = typeof(Mod).GetField("translations", BindingFlags.Instance | BindingFlags.NonPublic);
            Translations = (Dictionary<string, ModTranslation>)translationsField?.GetValue(CalamityRuTranslate.Instance);
        }

        public static void Unload()
        {
            Translations = null;
        }
    }
}