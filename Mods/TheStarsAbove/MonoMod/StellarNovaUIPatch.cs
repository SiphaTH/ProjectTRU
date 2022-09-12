// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StellarNovaUIPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => ModsCall.StarsAbove.Code.GetType("StarsAbove.UI.StellarNova.StellarNovaUI").GetCachedMethod("DrawSelf");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Prism of the Ruined King", "Призма свергнутого короля");
//         TranslationHelper.ModifyIL(il, "Prism of the Cosmic Phoenix", "Призма космического феникса");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/theofaniaIcon", "CalamityRuTranslate/Assets/theofaniaIcon");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/laevateinnIcon", "CalamityRuTranslate/Assets/laevateinnIcon");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/KiwamiRyukenIcon", "CalamityRuTranslate/Assets/KiwamiRyukenIcon");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/gardenofavalonIcon", "CalamityRuTranslate/Assets/gardenofavalonIcon");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/edingenesisquasarIcon", "CalamityRuTranslate/Assets/edingenesisquasarIcon");
//     };
// }