using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.MoonLord;
using InfernumMode.Core.GlobalInstances.Systems;
using MonoMod.Cil;
using Terraria;
using Terraria.ID;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class MoonLordCoreBehaviorOverrideGetTipsPatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(MoonLordCoreBehaviorOverride).GetCachedMethod(nameof(MoonLordCoreBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(MoonLordCoreBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, MoonLordCoreBehaviorOverride self)
    {
        yield return n => NPC.CountNPCS(NPCID.MoonLordFreeEye) >= 2 ? "Эти глаза выполняют атаки, требующие кучи уклонений! Не паникуй, когда они случаются!" : string.Empty;
        yield return n => TipsManager.ShouldUseJokeText ? ":failure:" : string.Empty;
    }
}

public class MoonLordCoreBehaviorOverrideGenerateProfanedTempleIfNecessaryPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(MoonLordCoreBehaviorOverride).GetMethod("GenerateProfanedTempleIfNecessary", BindingFlags.Instance | BindingFlags.NonPublic);

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A profaned shrine has erupted from the ashes at the underworld's edge!", "Осквернённое святилище вырывается из пепла на границе преисподней!");
    };
}