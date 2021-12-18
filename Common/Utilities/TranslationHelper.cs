using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria.Localization;

namespace CalamityRuTranslate.Common.Utilities
{
    public static class TranslationHelper
    {
        public static bool IsRussianLanguage => LanguageManager.Instance.ActiveCulture == GameCulture.Russian;

        public static void ILTranslation(ILContext il, string original, string translation, int iterations = 1)
        {
            var cursor = new ILCursor(il);
        
            for (int j = 0; j < iterations; j++)
            {
                if (!cursor.TryGotoNext(i => i.MatchLdstr(original)))
                {
                    CalamityRuTranslate.Instance.Logger.Warn($"[IL] Не удалось заменить \"{original}\" на \"{translation}\"");
                    return;
                }
            }

            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldstr, translation);
        }

        public static void ILTranslation(ILContext il, int original, int newValue, int iterations = 1)
        {
            var cursor = new ILCursor(il);
        
            for (int j = 0; j < iterations; j++)
            {
                if (!cursor.TryGotoNext(i => i.MatchLdcI4(original)))
                {
                    CalamityRuTranslate.Instance.Logger.Warn($"[IL] Не удалось заменить \"{original.ToString()}\" на \"{newValue.ToString()}\"");
                    return;
                }
            }
        
            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldc_I4, newValue);
        }

        public static void ILTranslation(ILContext il, float original, float newValue, int iterations = 1)
        {
            var cursor = new ILCursor(il);
        
            for (int j = 0; j < iterations; j++)
            {
                if (!cursor.TryGotoNext(i => i.MatchLdcR4(original)))
                {
                    CalamityRuTranslate.Instance.Logger.Warn($"[IL] Не удалось заменить \"{original.ToString()}\" на \"{newValue.ToString()}\"");
                    return;
                }
            }

            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldc_R4, newValue);
        }
    }
}