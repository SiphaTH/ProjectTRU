using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Destroyer;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class DestroyerHeadBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DestroyerHeadBehaviorOverride).GetCachedMethod(nameof(DestroyerHeadBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(DestroyerHeadBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, DestroyerHeadBehaviorOverride self)
    {
        yield return n => "Чем больше его бить, тем больше зондов он выпускает. Не откусывай больше, чем можешь прожевать!";
    }
}