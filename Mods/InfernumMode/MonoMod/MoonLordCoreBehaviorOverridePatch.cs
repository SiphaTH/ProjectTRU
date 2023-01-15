using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.MoonLord;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;
using Terraria.ID;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class MoonLordCoreBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(MoonLordCoreBehaviorOverride).GetCachedMethod(nameof(MoonLordCoreBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(MoonLordCoreBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, MoonLordCoreBehaviorOverride self)
    {
        yield return n => NPC.CountNPCS(NPCID.MoonLordFreeEye) >= 2 ? "Эти глаза выполняют атаки, требующие кучи уклонений! Не паникуй, когда они случаются!" : string.Empty;
        yield return n => HatGirlTipsManager.ShouldUseJokeText ? ":failure:" : string.Empty;
        yield return n => "Those eyeballs perform attacks that require a lot of weaving! Make sure to not panic when they happen!";
    }
}