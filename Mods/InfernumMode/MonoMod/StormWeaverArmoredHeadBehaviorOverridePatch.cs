using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.StormWeaver;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class StormWeaverArmoredHeadBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(StormWeaverArmoredHeadBehaviorOverride).GetCachedMethod(nameof(StormWeaverArmoredHeadBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(StormWeaverArmoredHeadBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, StormWeaverArmoredHeadBehaviorOverride self)
    {
        yield return n => "Старайся не отходить слишком далеко во время вращения Штормового ткача на месте, иначе не увидишь заряды до того, как они слишком сильно ускорятся!";

    }
}