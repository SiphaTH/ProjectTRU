using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.Loaders
{
    public class LangLoader : ILoadable
    {
        public static Dictionary<string, ModTranslation> Translations;

        public float Priority => 1f;

        public void Load()
        {
            if (!TranslationHelper.IsRussianLanguage)
                return;

            FieldInfo translationsField = typeof(Mod).GetField("translations", BindingFlags.Instance | BindingFlags.NonPublic);
            Translations = (Dictionary<string, ModTranslation>) translationsField?.GetValue(CalamityRuTranslate.Instance);
        }

        public void Unload()
        {
            Translations = null;
        }
    }
}