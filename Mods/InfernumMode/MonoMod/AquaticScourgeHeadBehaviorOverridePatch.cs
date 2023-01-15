using System;
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
        yield return n => "Если не можешь справиться с уклонением на высоких скоростях, попробуй заставить его кружить вокруг вас!";
    }
}