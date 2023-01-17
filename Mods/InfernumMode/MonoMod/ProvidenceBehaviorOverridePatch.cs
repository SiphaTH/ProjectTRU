using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Providence;
using MonoMod.Cil;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class ProvidenceBehaviorOverridePreAI : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ProvidenceBehaviorOverride).GetCachedMethod(nameof(ProvidenceBehaviorOverride.PreAI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The blazing air rises...", "Вздымает обжигающий воздух...");
        TranslationHelper.ModifyIL(il, "The blue flames roar...", "Ревёт синее пламя...");
    };
}

public class ProvidenceBehaviorOverrideGetTips : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ProvidenceBehaviorOverride).GetCachedMethod(nameof(ProvidenceBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(ProvidenceBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, ProvidenceBehaviorOverride self)
    {
        yield return n => "Не утруждай себя зацепами к стенам или ещё чем. Провиденс даёт неограниченное время полёта!";
    }
}