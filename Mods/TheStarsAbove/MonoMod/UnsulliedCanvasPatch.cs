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
// public class UnsulliedCanvasPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(UnsulliedCanvas).GetCachedMethod(nameof(UnsulliedCanvas.UseItem));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Magical energy coalesces around you...", "Вокруг вас собирается магическая энергия...");
//         TranslationHelper.ModifyIL(il, "Penthesilea, The Witch of Ink draws near!", "Пентесилея, Ведьма чернил, нарисовалась поблизости!");
//     };
// }