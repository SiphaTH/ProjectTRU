using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class SuspiciousEyePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(SuspiciousEye).GetCachedMethod("get_NPCName");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Eye of Cthulhu", "Глаз Ктулху");
    };
}