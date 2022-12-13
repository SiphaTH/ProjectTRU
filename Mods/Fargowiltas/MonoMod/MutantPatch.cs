using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class MutantPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Mutant).GetCachedMethod(nameof(Mutant.SetChatButtons));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Pre Hardmode", "Пре-хардмод");
        TranslationHelper.ModifyIL(il, "Hardmode", "Хардмод");
        TranslationHelper.ModifyIL(il, "Post Moon Lord", "Пост-Лунный лорд");
        TranslationHelper.ModifyIL(il, "Cycle Shop", "Переключить магазин");
    };
}