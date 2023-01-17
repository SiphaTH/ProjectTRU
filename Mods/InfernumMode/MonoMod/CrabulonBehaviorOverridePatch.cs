using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Crabulon;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class CrabulonBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CrabulonBehaviorOverride).GetCachedMethod(nameof(CrabulonBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(CrabulonBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, CrabulonBehaviorOverride self)
    {
        yield return n => "Крабулон запускает свои споры каждый третий прыжок, поэтому веди счёт!";
        yield return n => "Сосредоточься на крабовых грибах. Если игнорировать их, они тебя просто задавят!";
        yield return n => HatGirlTipsManager.ShouldUseJokeText ? "На нас троих грибов не хватит, и я могу сказать, кто выиграл рулетку." : string.Empty;
    }
}