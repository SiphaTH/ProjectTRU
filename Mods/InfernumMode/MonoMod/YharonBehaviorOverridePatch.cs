using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Yharon;
using InfernumMode.Core.GlobalInstances.Systems;
using MonoMod.Cil;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class YharonBehaviorOverridePreAI : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(YharonBehaviorOverride).GetCachedMethod(nameof(YharonBehaviorOverride.PreAI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The air is scorching your skin...", "Воздух обжигает вашу кожу...");
    };
}

public class YharonBehaviorOverrideDoBehavior_FinalDyingRoar : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(YharonBehaviorOverride).GetCachedMethod(nameof(YharonBehaviorOverride.DoBehavior_FinalDyingRoar));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The heat is surging...", "Жара нарастает...");
        TranslationHelper.ModifyIL(il, "The heat is surging...", "Жара нарастает...", 2);
    };
}

public class YharonBehaviorOverrideGetTips : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(YharonBehaviorOverride).GetCachedMethod(nameof(YharonBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(YharonBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, YharonBehaviorOverride self)
    {
        yield return n => n.life < n.lifeMax * 0.025f ? "НО ЕСЛИ МОЙ ДОЛГ ПРИНЕСТИ СЕБЯ В ЖЕРТВУ, УСЛЫШЬ ЖЕ ТЫ МОЙ-... Ааа, ты умер? Да блин, я почти добралась до самой крутой строчки!" : string.Empty;

    }
}