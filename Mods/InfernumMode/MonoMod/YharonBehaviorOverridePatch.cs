using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BehaviorOverrides.BossAIs.Yharon;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class YharonBehaviorOverridePreAI : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(YharonBehaviorOverride).GetCachedMethod(nameof(YharonBehaviorOverride.PreAI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The air is scorching your skin...", "Воздух обжигает вашу кожу...");
    };
}

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class YharonBehaviorOverrideDoBehavior_FinalDyingRoar : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(YharonBehaviorOverride).GetCachedMethod(nameof(YharonBehaviorOverride.DoBehavior_FinalDyingRoar));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The heat is surging...", "Жара нарастает...");
        TranslationHelper.ModifyIL(il, "The heat is surging...", "Жара нарастает...", 2);
    };
}