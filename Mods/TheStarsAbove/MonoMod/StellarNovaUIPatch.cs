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
// public class StellarNovaUIPatch : Patch<ILContext.Manipulator>
//  {
//      public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//  
//      public override MethodInfo ModifiedMethod => ModsCall.StarsAbove.Code
//          .GetType("StarsAbove.UI.StellarNova.StellarNovaUI").GetCachedMethod("DrawSelf");
//  
//      protected override ILContext.Manipulator PatchMethod { get; } = il =>
//      {
//          TranslationHelper.ModifyIL(il, "Prism of the Ruined King", "Призма свергнутого короля");
//          TranslationHelper.ModifyIL(il, "Prism of the Cosmic Phoenix", "Призма космического феникса");
//          TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/theofaniaIcon", "CalamityRuTranslate/Mods/StarsAbove/UI/theofaniaIcon");
//          TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/laevateinnIcon", "CalamityRuTranslate/Mods/StarsAbove/UI/laevateinnIcon");
//          TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/KiwamiRyukenIcon", "CalamityRuTranslate/Mods/StarsAbove/UI/KiwamiRyukenIcon");
//          TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/gardenofavalonIcon", "CalamityRuTranslate/Mods/StarsAbove/UI/gardenofavalonIcon");
//          TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/edingenesisquasarIcon", "CalamityRuTranslate/Mods/StarsAbove/UI/edingenesisquasarIcon");
//      };
//  }