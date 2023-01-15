using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Ravager;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class RavagerBodyBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(RavagerBodyBehaviorOverride).GetCachedMethod(nameof(RavagerBodyBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(RavagerBodyBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, RavagerBodyBehaviorOverride self)
    {
        yield return n => "Некоторые атаки Разрушителя вознаграждают, если ты рядом. Попробуй не убегать!";
    }
}