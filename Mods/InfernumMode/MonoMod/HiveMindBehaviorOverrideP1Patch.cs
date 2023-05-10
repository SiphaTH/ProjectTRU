using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.HiveMind;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class HiveMindBehaviorOverrideP1Patch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(HiveMindBehaviorOverride).GetCachedMethod(nameof(HiveMindBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(HiveMindBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, HiveMindBehaviorOverride self)
    {
        yield return n => "В этот раз тебе нужно изучить движения врагов, воспользоваться их подсказками, чтобы получить преимущество!";
        yield return n => "Старайся отвести его дождевой заряд, подбежав к Разуму улья. Это поможет сохранить твою арену чистой!";
        yield return n => "Разум улья начнёт атаковать раньше, если ты атакуешь его; подожди, пока он закончит атаку, прежде чем стрелять!";
        yield return n => TipsManager.ShouldUseJokeText ? "Не сработало, но не волнуйся! Этот сынуля у нас ещё попляшет!" : string.Empty;
        yield return n => TipsManager.ShouldUseJokeText ? "Я бы сделала ехидный комментарий, но мне, пожалуй, стоит заняться своими делами..." : string.Empty;
    }
}