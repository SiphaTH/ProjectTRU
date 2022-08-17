using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria.Localization;

namespace CalamityRuTranslate.Common.Utilities;

internal static class TranslationHelper
{
    internal static bool IsRussianLanguage => LanguageManager.Instance.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Russian);

    internal static void ModifyIL(ILContext il, string orig, string replace, int iterations = 1)
    {
        ILCursor cursor = new ILCursor(il);

        for (int i = 0; i < iterations; i++)
        {
            if (!cursor.TryGotoNext(MoveType.After,x => x.MatchLdstr(orig)))
            {
                CalamityRuTranslate.Instance.Logger.Warn($"[IL] Не удалось заменить \"{orig}\" на \"{replace}\"");
                return;
            }
        }

        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldstr, replace);
    }

    internal static void ModifyIL(ILContext il, int orig, int replace, int iterations = 1)
    {
        ILCursor cursor = new ILCursor(il);

        for (int i = 0; i < iterations; i++)
        {
            if (!cursor.TryGotoNext(MoveType.After, x => x.MatchLdcI4(orig)))
            {
                CalamityRuTranslate.Instance.Logger.Warn($"[IL] Не удалось заменить \"{orig}\" на \"{replace}\"");
                return;
            }
        }

        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldc_I4, replace);
    }
        
    internal static void ModifyIL(ILContext il, float orig, float replace, int iterations = 1)
    {
        ILCursor cursor = new ILCursor(il);

        for (int i = 0; i < iterations; i++)
        {
            if (!cursor.TryGotoNext(MoveType.After, x => x.MatchLdcR4(orig)))
            {
                CalamityRuTranslate.Instance.Logger.Warn($"[IL] Не удалось заменить \"{orig}\" на \"{replace}\"");
                return;
            }
        }

        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldc_R4, replace);
    }
}