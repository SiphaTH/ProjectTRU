using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Cryogen;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class CryogenBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CryogenBehaviorOverride).GetCachedMethod(nameof(CryogenBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(CryogenBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, CryogenBehaviorOverride self)
    {
        yield return n => "По возможности меньше двигайся, пока он находится над тобой. Так он реже делает резкие скачки!";
        yield return n => "Следи за зазорами в сосульках вокруг Криогена, они указывают на безопасное положение!";
    }
}