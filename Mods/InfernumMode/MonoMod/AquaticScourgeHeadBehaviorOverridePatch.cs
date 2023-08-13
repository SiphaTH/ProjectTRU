// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.AquaticScourge;
// using MonoMod.Cil;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class AquaticScourgeHeadBehaviorOverrideGetTips : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(AquaticScourgeHeadBehaviorOverride).GetCachedMethod(nameof(AquaticScourgeHeadBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(AquaticScourgeHeadBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, AquaticScourgeHeadBehaviorOverride self)
//     {
//         yield return n => "Змеиные беспорядочные движения в воде делают её более простой для преодоления, ты, вероятно, сможешь плавать, даже без помощи рук!";
//         yield return n => "Если тебе нужно больше пространства, попробуй освободить место, очистив окружающий сернистый песок!";
//     }
// }
//
// public class AquaticScourgeHeadBehaviorOverrideDoBehavior_EnterFinalPhase : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(AquaticScourgeHeadBehaviorOverride).GetCachedMethod(nameof(AquaticScourgeHeadBehaviorOverride.DoBehavior_EnterFinalPhase));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "A deluge of acid is quickly rising from below!", "Из недр всплывает бурный поток кислоты!");
//     };
// }