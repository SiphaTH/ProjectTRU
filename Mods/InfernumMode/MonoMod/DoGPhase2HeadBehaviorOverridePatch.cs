using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BehaviorOverrides.BossAIs.DoG;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class DoGPhase2HeadBehaviorOverridePhase2AI : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DoGPhase2HeadBehaviorOverride).GetCachedMethod(nameof(DoGPhase2HeadBehaviorOverride.Phase2AI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A GOD DOES NOT FEAR DEATH!", "БОГ НЕ БОИТСЯ СМЕРТИ!");
    };
}

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class DoGPhase2HeadBehaviorOverrideDoDeathEffects : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DoGPhase2HeadBehaviorOverride).GetCachedMethod(nameof(DoGPhase2HeadBehaviorOverride.DoDeathEffects));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "I WILL NOT BE DESTROYED!!!", "Я НЕ МОГУ ПОГИБНУТЬ!!!");
        TranslationHelper.ModifyIL(il, "I WILL NOT BE DESTROYED!!!", "Я НЕ МОГУ ПОГИБНУТЬ!!!", 2);
        TranslationHelper.ModifyIL(il, "I WILL NOT BE DESTROYED!!!!", "Я НЕ МОГУ ПОГИБНУТЬ!!!!");
        TranslationHelper.ModifyIL(il, "I WILL NOT...", "Я НЕ МОГУ...");
        TranslationHelper.ModifyIL(il, "I...", "Я...");
    };
}