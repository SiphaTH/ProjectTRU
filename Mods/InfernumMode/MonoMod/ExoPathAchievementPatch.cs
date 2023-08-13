// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.Achievements.InfernumAchievements;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class ExoPathAchievementPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(ExoPathAchievement).GetCachedMethod(nameof(ExoPathAchievement.Initialize));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Lab Rat", "Лабораторная крыса");
//         TranslationHelper.ModifyIL(il, "Become Draedon's favorite test subject\n[c/777777:Beat all Infernum Exo Mech combinations]", "Стать любимым подопытным Дрэйдона\n[c/777777:Одержать победу над всеми комбинациями экзо-механизмов в Инфернуме]");
//     };
// }