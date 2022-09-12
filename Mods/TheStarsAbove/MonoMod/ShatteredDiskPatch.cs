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
// public class ShatteredDiskPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(ShatteredDisk).GetCachedMethod(nameof(ShatteredDisk.UseItem));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Reality's fabric gives way to a mysterious being...", "Ткань реальности уступает таинственному существу...");
//         TranslationHelper.ModifyIL(il, "The Vagrant of Space and Time descends!", "Ходящий между пространством и временем снизошёл!");
//         TranslationHelper.ModifyIL(il, "Your weapons seem to be powerless...", "Ваше оружие, похоже, бесполезно...");
//     };
// }