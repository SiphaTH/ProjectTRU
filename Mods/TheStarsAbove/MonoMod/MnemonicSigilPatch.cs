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
// public class MnemonicSigilPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(MnemonicSigil).GetCachedMethod(nameof(MnemonicSigil.UseItem));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "The expanse around you begins to contract...", "Окружающее пространство начинает сжиматься...");
//         TranslationHelper.ModifyIL(il, "Tsukiyomi appears before you!", "Цукиёми появляется перед вами!");
//     };
// }