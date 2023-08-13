// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Content.Achievements.DevWishes;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class TophatWishPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(TophatWish).GetCachedMethod(nameof(TophatWish.Initialize));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Amazingly Asinine Assistant", "Поразительно придурковатый помощник");
//         TranslationHelper.ModifyIL(il, "You're improving with every failure! Keep going!\n[c/777777:Have 3 deaths in a row to a boss]", "Ты совершенствуешься с каждой неудачей! Продолжай в том же духе!\n[c/777777:Получить 3 смерти подряд от босса]");
//     };
// }