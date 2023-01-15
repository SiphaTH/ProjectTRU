using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.KingSlime;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class KingSlimeBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(KingSlimeBehaviorOverride).GetCachedMethod(nameof(KingSlimeBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(KingSlimeBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, KingSlimeBehaviorOverride self)
    {
        yield return n => "Старайся выучить паттерн прыжков короля слизней! Это поможет тебе лучше спланировать свой следующий шаг.";
        yield return n => "Высоко он прыгает. Интересно, смог бы ты поднырнуть под него?";
        yield return n => HatGirlTipsManager.ShouldUseJokeText ? "Довольно в непростую ситуацию ты угодил..." : string.Empty;
    }
}