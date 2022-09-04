// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using StarsAbove;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarsAboveGlobalItemPatch : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//  
//     public override MethodInfo ModifiedMethod => typeof(StarsAboveGlobalItem).GetCachedMethod(nameof(StarsAboveGlobalItem.CanUseItem));
//  
//     protected override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "The weapon fails to react to your Aspect, rendering it unusable.", "Оружие не реагирует на ваш Аспект, делая его недоступным для использования.");
//         TranslationHelper.ModifyIL(il, "The weapon fails to react to your Aspect, rendering it unusable.", "Оружие не реагирует на ваш Аспект, делая его недоступным для использования.");
//     };
// }