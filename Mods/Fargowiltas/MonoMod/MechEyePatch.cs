using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class MechEyePatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(MechEye).GetCachedMethod(nameof(MechEye.Shoot));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The Twins have awoken!", "Близнецы пробуждаются!");
        TranslationHelper.ModifyIL(il, "The Twins have awoken!", "Близнецы пробуждаются!", 2);
    };
}