using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Perforators;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class PerforatorHiveBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(PerforatorHiveBehaviorOverride).GetCachedMethod(nameof(PerforatorHiveBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(PerforatorHiveBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, PerforatorHiveBehaviorOverride self)
    {
        yield return n => "Улей извергает тонну гнилого ихора, так что управление пространством - ключ к победе!";
    }
}