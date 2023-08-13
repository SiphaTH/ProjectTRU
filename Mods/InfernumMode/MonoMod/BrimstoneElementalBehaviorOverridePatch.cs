// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.BrimstoneElemental;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class BrimstoneElementalBehaviorOverridePatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(BrimstoneElementalBehaviorOverride).GetCachedMethod(nameof(BrimstoneElementalBehaviorOverride.DoBehavior_BrimstoneRoseBurst));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, " was violently pricked by roses.", " яростно закалывается розами.");
//     };
// }