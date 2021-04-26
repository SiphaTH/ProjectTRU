using System;
using System.Collections.Generic;
using System.Text;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria.Localization;
using static System.Linq.Enumerable;

namespace CalamityRuTranslate.Common.Utilities
{
    public static class TranslationUtils
    {
        public static bool IsRussianLanguage => LanguageManager.Instance.ActiveCulture == GameCulture.Russian;
        
        public static string KeyText(string key) => LangUtils.Translations[$"Mods.CalamityRuTranslate.{key}"].GetTranslation(Language.ActiveCulture);
        
        public static string KeyText2(string key) => Language.GetTextValue($"Mods.CalamityRuTranslate.{key}");

        public static void ILTranslate(ILContext il, string original, string translation, int iterations = 1)
        {
            var cursor = new ILCursor(il);

            for (int j = 0; j < iterations; j++)
            {
                if (!cursor.TryGotoNext(i => i.MatchLdstr(original)))
                {
                    CalamityRuTranslate.Instance.Logger.Warn($"[IL] failed when trying edit \"{original}\" with \"{translation}\"");
                    return;
                }
            }

            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldstr, translation);
        }
    }
}