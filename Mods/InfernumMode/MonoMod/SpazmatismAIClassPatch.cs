using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Twins;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class SpazmatismAIClassPatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(SpazmatismAIClass).GetCachedMethod(nameof(SpazmatismAIClass.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(SpazmatismAIClass self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, SpazmatismAIClass self)
    {
        yield return n => "Есть проблемы с уклонением во время вращения? Трое могут играть в эту игру, вращайся!";

    }
}