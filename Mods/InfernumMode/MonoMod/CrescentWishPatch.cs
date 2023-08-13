// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.Achievements.DevWishes;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class CrescentWishPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(CrescentWish).GetCachedMethod(nameof(CrescentWish.Initialize));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Post-apocalyptic", "Постапокалиптический");
//         TranslationHelper.ModifyIL(il, "The witch's sins could never be fully atoned\n[c/777777:Defeat the Forgotten Shadow of Calamitas in the underworld]", "Грехи ведьмы невозможно полностью искупить\n[c/777777:Одержать победу над Забытой тенью Каламитас в преисподней]");
//     };
// }