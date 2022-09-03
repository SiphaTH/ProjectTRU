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
// public class DemonicCruxPatch : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(DemonicCrux).GetCachedMethod(nameof(DemonicCrux.UseItem));
//
//     protected override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "The world shudders in anticipation...", "Мир содрогается в ожидании...");
//         TranslationHelper.ModifyIL(il, "Arbitration descends!", "Арбитраж снизошёл!");
//     };
// }