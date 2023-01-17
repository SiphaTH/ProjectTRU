using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.ProfanedGuardians;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class AttackerGuardianBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(AttackerGuardianBehaviorOverride).GetCachedMethod(nameof(AttackerGuardianBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(AttackerGuardianBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, AttackerGuardianBehaviorOverride self)
    {
        yield return n => "Не приближайся к энергетическим полям! Находясь рядом с ними, можно навредить себе!";
        yield return n => "Круговые движения помогают против копий атакующего стража!";
    }
}