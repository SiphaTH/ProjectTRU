// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.Achievements;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class AchievementOnCompletionPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(Achievement).GetCachedMethod(nameof(Achievement.OnCompletion));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Achievement Completed! [c/ff884d:", "Достижение выполнено! [c/ff884d:");
//     };
// }
//
// public class AchievementWishCompletionEffectsPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(Achievement).GetMethod("WishCompletionEffects", BindingFlags.NonPublic | BindingFlags.Instance);
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Dev Wish Completed! [c/ff884d:", "Желание разработчиков выполнено! [c/ff884d:");
//     };
// }