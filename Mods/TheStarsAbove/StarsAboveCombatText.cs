// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove;
//
// public class StarsAboveCombatText : ContentTranslation
// {
//     public override bool IsTranslationEnabled => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override void LoadTranslation()
//     {
//         for (int i = 0; i < 100; i++)
//         {
//             if (Main.combatText[i].active)
//             {
//                 if (Main.combatText[i].text.Equals("Triple crit!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.1");
//                 }
//                 if (Main.combatText[i].text.Equals("Double crit!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.2");
//                 }
//                 if (Main.combatText[i].text.Equals("The Timeframe vanishes..."))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.3");
//                 }
//                 if (Main.combatText[i].text.Equals("Critical cast!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.4");
//                 }
//                 if (Main.combatText[i].text.Equals("The Eye of Euthymia has 10 seconds left!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.5");
//                 }
//                 if (Main.combatText[i].text.Equals("The Core of Flames has 5 seconds left!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.6");
//                 }
//                 if (Main.combatText[i].text.Equals("Liberation Blazing is ready to strike!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.7");
//                 }
//                 if (Main.combatText[i].text.Equals("Going supercritical!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.8");
//                 }
//                 if (Main.combatText[i].text.Equals("Stellar Nova ready!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.9");
//                 }
//                 if (Main.combatText[i].text.Equals("Blade Will activated!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.10");
//                 }
//                 if (Main.combatText[i].text.Equals("Blasting Form"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.11");
//                 }
//                 if (Main.combatText[i].text.Equals("Striking Form"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.12");
//                 }
//                 if (Main.combatText[i].text.Equals("Fully charged!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.13");
//                 }
//                 if (Main.combatText[i].text.Equals("Mystic Form"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.14");
//                 }
//                 if (Main.combatText[i].text.Equals("Scythe deployed!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.15");
//                 }
//                 if (Main.combatText[i].text.Equals("Shotgun deployed!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.16");
//                 }
//                 if (Main.combatText[i].text.Equals("Blade deployed!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.17");
//                 }
//                 if (Main.combatText[i].text.Equals("Stellar Prism acquired!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.18");
//                 }
//                 if (Main.combatText[i].text.Equals("Covered in red paint!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.19");
//                 }
//                 if (Main.combatText[i].text.Equals("Covered in blue paint!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.20");
//                 }
//                 if (Main.combatText[i].text.Equals("Covered in yellow paint!"))
//                 {
//                     Main.combatText[i].text = LangHelper.GetText("StarsAbove.CombatTexts.21");
//                 }
//             }
//         }
//     }
// }