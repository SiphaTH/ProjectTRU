﻿using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.AquaticScourge;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class AquaticScourgeHeadBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(AquaticScourgeHeadBehaviorOverride).GetCachedMethod(nameof(AquaticScourgeHeadBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(AquaticScourgeHeadBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, AquaticScourgeHeadBehaviorOverride self)
    {
        yield return n => "Змеиные беспорядочные движения в воде делают её более простой для преодоления, ты, вероятно, сможешь плавать, даже без помощи рук!";
        yield return n => "Если тебе нужно больше пространства, попробуй освободить место, очистив окружающий сернистый песок!";
    }
}