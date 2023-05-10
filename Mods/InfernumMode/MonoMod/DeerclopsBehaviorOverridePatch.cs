using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Deerclops;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class DeerclopsBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DeerclopsBehaviorOverride).GetCachedMethod(nameof(DeerclopsBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(DeerclopsBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, DeerclopsBehaviorOverride self)
    {
        yield return n => "Циклоп-олень - близорукий, из-за этого он держит тебя вблизи. Не позволяй ему зажать тебя!";
        yield return n => "Циклоп-олень следует определённому паттерну, просто выучи его!";
        yield return n => TipsManager.ShouldUseJokeText ? "Божечки оленёшечки..." : string.Empty;
    }
}