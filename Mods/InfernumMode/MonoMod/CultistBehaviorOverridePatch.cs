using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Cultist;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class CultistBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CultistBehaviorOverride).GetCachedMethod(nameof(CultistBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(CultistBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, CultistBehaviorOverride self)
    {
        yield return n => "Этот парень был настоящим сумасшедшим, тебе нужна дополнительная мобильность!";
    }
}