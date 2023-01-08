using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.Loaders;

public class LangLoader : ContentTranslation, ILoadableContent
{
    public static Dictionary<string, ModTranslation> Translations;

    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;

    public override float Priority => 0.9f;

    public void LoadContent()
    {
        FieldInfo translationsField = typeof(LocalizationLoader).GetField("translations", BindingFlags.Static | BindingFlags.NonPublic);
        Translations = (Dictionary<string, ModTranslation>) translationsField?.GetValue(CalamityRuTranslate.Instance);
    }

    public void UnloadContent()
    {
        if (Translations is not null)
        {
            Translations.Clear();
            Translations = null;
        }
    }
}