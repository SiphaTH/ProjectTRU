// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using StarsAbove.Items.Consumables;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class BifrostPatch : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(Bifrost).GetCachedMethod(nameof(Bifrost.CanUseItem));
//
//     protected override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Subworlds have issues in Multiplayer currently. Please wait until further notice.", "В настоящее время в мультиплеере Subworlds наблюдаются проблемы. Пожалуйста, подождите дальнейших уведомлений.");
//         TranslationHelper.ModifyIL(il, "Cosmic Voyages are still on cooldown!", "Космическое странствие всё ещё перезаряжается!");
//         TranslationHelper.ModifyIL(il, "Lunar energy prevents the activation of the Bifrost...", "Лунная энергия препятствует активации Биврёста...");
//         TranslationHelper.ModifyIL(il, "Subworlds are still being worked on in tModLoader 1.4! Thanks for your patience.", "Работа над Subworlds в tModLoader 1.4 продолжается! Спасибо за ваше терпение.");
//     };
// }