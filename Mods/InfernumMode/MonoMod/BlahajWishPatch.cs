// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.Achievements.DevWishes;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class BlahajWishPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(BlahajWish).GetCachedMethod(nameof(BlahajWish.Initialize));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Benevolent Force", "Доброта в действии");
//         TranslationHelper.ModifyIL(il, "Warm hugs\n[c/777777:Defeat Infernum Duke Fishron in under 1 minute]", "Тёплые объятия\n[c/777777:Одержать победу над Герцогом Рыброном в Инфернуме менее чем за 1 минуту]");
//     };
// }