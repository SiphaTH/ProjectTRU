using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace CalamityRuTranslate.Core.Loaders;

public class LocalizationContentLoader : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        if (typeof(CalamityRuTranslate).GetProperty("File", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(CalamityRuTranslate.Instance) is TmodFile tModFile)
        {
            foreach (TmodFile.FileEntry item in tModFile.Where(entry => Path.GetFileNameWithoutExtension(entry.Name)!.StartsWith("Terraria.Localization.Content.")))
            {
                LanguageManager.Instance.LoadLanguageFromFileTextJson(Encoding.UTF8.GetString(CalamityRuTranslate.Instance.GetFileBytes(item.Name)), false);
            }
        }
    }

    public void Unload()
    {
        LoadFilesForCulture(GameCulture.FromCultureName(GameCulture.CultureName.Russian));
    }
    
    private void LoadFilesForCulture(GameCulture culture)
    {
        foreach (string path in GetLanguageFilesForCulture(culture))
        {
            string fileText = Utils.ReadEmbeddedResource(path);
            LanguageManager.Instance.LoadLanguageFromFileTextJson(fileText, true);
        }
    }
    
    private string[] GetLanguageFilesForCulture(GameCulture culture)
    {
        Assembly.GetExecutingAssembly();
        return Array.FindAll(typeof (Program).Assembly.GetManifestResourceNames(), (Predicate<string>) (element => element.StartsWith("Terraria.Localization.Content." + culture.CultureInfo.Name.Replace('-', '_')) && element.EndsWith(".json")));
    }
}