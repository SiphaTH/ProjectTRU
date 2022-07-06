using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.Loaders;

public static class LangLoader
{
    public static Dictionary<string, ModTranslation> Translations;

    public static void Load()
    {
        if (TranslationHelper.IsRussianLanguage)
        {
            FieldInfo translationsField = typeof(LocalizationLoader).GetField("translations", BindingFlags.Static | BindingFlags.NonPublic);
            Translations = (Dictionary<string, ModTranslation>) translationsField?.GetValue(CalamityRuTranslate.Instance);
        }
    }

    public static void Unload()
    {
        Translations = null;
    }
}