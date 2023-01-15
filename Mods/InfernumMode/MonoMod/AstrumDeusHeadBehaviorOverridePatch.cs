using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.AstrumDeus;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class AstrumDeusHeadBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(AstrumDeusHeadBehaviorOverride).GetCachedMethod(nameof(AstrumDeusHeadBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(AstrumDeusHeadBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, AstrumDeusHeadBehaviorOverride self)
    {
        yield return n => "Этот змей очень быстрый! Для победы важна хорошая мобильность!";
    }
}