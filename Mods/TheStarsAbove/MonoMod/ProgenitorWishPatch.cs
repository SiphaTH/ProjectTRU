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
// public class ProgenitorWishPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(ProgenitorWish).GetCachedMethod(nameof(ProgenitorWish.UseItem));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "The echoes of past eons begins to ebb and flow...", "Эхо прошлых эпох начинает свои отливы и приливы...");
//         TranslationHelper.ModifyIL(il, "The Warrior of Light descends!", "Воин Света снизошёл!");
//     };
// }