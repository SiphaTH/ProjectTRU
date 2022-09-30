using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.EternityMode.Content.Boss.HM;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

public class BetsyPatchPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Betsy).GetCachedMethod(nameof(Betsy.PreAI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "<User ", "<Пользователь ");
        TranslationHelper.ModifyIL(il, "<User ", "<Пользователь ", 2);
        TranslationHelper.ModifyIL(il, " was banned>", " был забанен>");
        TranslationHelper.ModifyIL(il, " was muted>", " был замьючен>");
    };
}