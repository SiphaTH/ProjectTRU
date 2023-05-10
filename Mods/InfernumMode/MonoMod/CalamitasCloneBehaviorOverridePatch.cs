using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.CalamitasShadow;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class CalamitasCloneBehaviorOverrideDoBehavior_BrothersPhasePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CalamitasShadowBehaviorOverride).GetCachedMethod(nameof(CalamitasShadowBehaviorOverride.DoBehavior_BrothersPhase));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Destroy ", "Уничтожьте ");
        TranslationHelper.ModifyIL(il, "him", "его");
        TranslationHelper.ModifyIL(il, "her", "её");
        TranslationHelper.ModifyIL(il, ", my brothers.", ", братья мои.");
    };
}

public class CalamitasCloneBehaviorOverrideDoBehavior_TransitionToFinalPhasePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CalamitasShadowBehaviorOverride).GetCachedMethod(nameof(CalamitasShadowBehaviorOverride.DoBehavior_TransitionToFinalPhase));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "I'm just getting started!", "Я только разогреваюсь!");
    };
}

public class CalamitasCloneBehaviorOverrideDoBehavior_DeathAnimationPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CalamitasShadowBehaviorOverride).GetCachedMethod(nameof(CalamitasShadowBehaviorOverride.DoBehavior_DeathAnimation));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "I'm not done yet! Brace yourself for my strongest hex!", "Я ещё не закончила! Готовься к моему самому мощному проклятию!");
        TranslationHelper.ModifyIL(il, "Oh.", "Оу.");
    };
}