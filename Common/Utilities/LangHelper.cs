using CalamityRuTranslate.Core.Loaders;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common.Utilities
{
    public static class LangHelper
    {
        internal static string GetTextValue(string key, params object[] args) => GetModTextValue(CalamityRuTranslate.Instance, key, args);
        private static string GetModTextValue(Mod mod, string key, params object[] args) => Language.GetTextValue($"Mods.{mod.Name}.{key}", args);
        public static string GetText(string key) => LangLoader.Translations[$"Mods.CalamityRuTranslate.{key}"].GetTranslation(Language.ActiveCulture);
    }
}