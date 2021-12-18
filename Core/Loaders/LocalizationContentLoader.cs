using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using CalamityRuTranslate.Common.Utilities;
using Terraria.Localization;
using Terraria.ModLoader.Core;

namespace CalamityRuTranslate.Core.Loaders
{
    public class LocalizationContentLoader : ILoadable
    {
        public float Priority => 1f;

        public void Load()
        {
            if (!TranslationHelper.IsRussianLanguage)
                return;

            TmodFile tModFile = typeof(CalamityRuTranslate).GetProperty("File", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(CalamityRuTranslate.Instance) as TmodFile;

            if (tModFile != null)
            {
                foreach (TmodFile.FileEntry item in tModFile.Where(entry => Path.GetFileNameWithoutExtension(entry.Name).StartsWith("Terraria.Localization.Content.")))
                {
                    LanguageManager.Instance.LoadLanguageFromFileText(Encoding.UTF8.GetString(CalamityRuTranslate.Instance.GetFileBytes(item.Name)));
                }
            }
        }

        public void Unload()
        {
        }
    }
}