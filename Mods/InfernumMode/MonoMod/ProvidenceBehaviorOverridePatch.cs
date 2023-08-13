// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.Providence;
// using MonoMod.Cil;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class ProvidenceBehaviorOverrideDoBehavior_EnterFireFormBulletHell : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(ProvidenceBehaviorOverride).GetCachedMethod(nameof(ProvidenceBehaviorOverride.DoBehavior_EnterFireFormBulletHell));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Lava is rising from below!", "Из-под земли поднимается лава!");
//     };
// }
//
// public class ProvidenceBehaviorOverrideGetTips : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(ProvidenceBehaviorOverride).GetCachedMethod(nameof(ProvidenceBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(ProvidenceBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, ProvidenceBehaviorOverride self)
//     {
//         yield return n => "Не утруждай себя зацепами к стенам или ещё чем. Провиденс даёт неограниченное время полёта!";
//         yield return n => Main.dayTime && Main.time >= 50400.0 ? "Следи за тем, чтобы не наступили сумерки, если собираешься повторно сразиться с ней!" : !Main.dayTime && Main.time >= 28800.0 ? "Следи за тем, чтобы не наступил рассвет, если собираешься повторно сразиться с ней!" : string.Empty;
//     }
// }