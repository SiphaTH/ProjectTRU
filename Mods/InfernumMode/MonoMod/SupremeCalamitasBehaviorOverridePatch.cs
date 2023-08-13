// using System;
// using System.Collections.Generic;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.SupremeCalamitas;
// using InfernumMode.Core.GlobalInstances.Systems;
// using MonoMod.Cil;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class SupremeCalamitasBehaviorOverrideDoBehavior_DesperationPhase : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(SupremeCalamitasBehaviorOverride).GetCachedMethod(nameof(SupremeCalamitasBehaviorOverride.DoBehavior_DesperationPhase));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "... Congratulations.", "... Поздравляю.");
//     };
// }
//
// public class SupremeCalamitasBehaviorOverrideGetTips : OnPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(SupremeCalamitasBehaviorOverride).GetCachedMethod(nameof(SupremeCalamitasBehaviorOverride.GetTips));
//
//     private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(SupremeCalamitasBehaviorOverride self);
//
//     public override Delegate Delegate => Translation;
//
//     private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, SupremeCalamitasBehaviorOverride self)
//     {
//         yield return n => TipsManager.ShouldUseJokeText ? "Хочешь мою шляпу ведьмы? Подбирать под неё наряд может быть забавно..." : string.Empty;
//
//     }
// }