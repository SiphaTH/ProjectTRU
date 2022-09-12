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
// public class AncientShardPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(AncientShard).GetCachedMethod(nameof(AncientShard.UseItem));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "A mysterious throne descends from the heavens...", "С небес снисходит загадочный трон...");
//         TranslationHelper.ModifyIL(il, "Nalhaun, the Burnished King appears!", "Налхан, Воронёный король появился!");
//     };
// }