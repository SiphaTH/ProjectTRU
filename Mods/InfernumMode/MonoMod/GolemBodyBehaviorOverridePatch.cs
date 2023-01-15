using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Golem;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class GolemBodyBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(GolemBodyBehaviorOverride).GetCachedMethod(nameof(GolemBodyBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(GolemBodyBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, GolemBodyBehaviorOverride self)
    {
        yield return n => "Цвет глаз Голема меняется в зависимости от атак. Смотри в оба своими!";
    }
}