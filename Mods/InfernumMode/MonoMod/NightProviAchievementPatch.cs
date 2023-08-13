// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.Achievements.InfernumAchievements;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class NightProviAchievementPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(NightProviAchievement).GetCachedMethod(nameof(NightProviAchievement.Initialize));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Night Knight", "Ночной рыцарь");
//         TranslationHelper.ModifyIL(il, "Challenge the Profaned Goddess under the gaze of the stars\n[c/777777:Beat Infernum Night Providence]", "Одолеть Осквернённую богиню под светом звёзд\n[c/777777:Одержать победу над ночной Провиденс в Инфернуме]");
//     };
// }