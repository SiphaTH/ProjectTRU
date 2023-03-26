using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.EyeOfCthulhu;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class EyeOfCthulhuBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(EyeOfCthulhuBehaviorOverride).GetCachedMethod(nameof(EyeOfCthulhuBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(EyeOfCthulhuBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, EyeOfCthulhuBehaviorOverride self)
    {
        yield return n => "Остерегайся этих зубных бомб! Зубы вылетают из места приземления бомбы, старайся держаться поближе!";
        yield return n => "Крюк или высокая мобильность могут оказаться полезными для уклонения от зарядов Глаза Ктулху!";
        yield return n => HatGirlTipsManager.ShouldUseJokeText ? "Глазам не могу поверить, ты умер." : string.Empty;
    }
}