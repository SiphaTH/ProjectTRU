using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.EternityMode.Content.Boss.HM;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

[JITWhenModsEnabled("FargowiltasSouls")]
public class BetsyPatchPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Betsy).GetCachedMethod(nameof(Betsy.PreAI));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "<User ", "<Пользователь ");
        TranslationHelper.ModifyIL(il, "<User ", "<Пользователь ", 2);
        TranslationHelper.ModifyIL(il, " was banned>", " был забанен>");
        TranslationHelper.ModifyIL(il, " was muted>", " был замьючен>");
    };
}