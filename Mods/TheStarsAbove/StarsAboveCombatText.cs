// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove;
//
// public class StarsAboveCombatText : ContentTranslation, ICombatText
// {
//     public override bool IsTranslationEnabled => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override float Priority => 1f;
//
//     public void CombatTextTranslation()
//     {
//         for (int i = 0; i < 100; i++)
//         {
//             if (Main.combatText[i].active)
//             {
//                 Main.combatText[i].text = Main.combatText[i].text switch
//                 {
//                     "Triple crit!" => LangHelper.GetText("StarsAbove.CombatTexts.1"),
//                     "Double crit!" => LangHelper.GetText("StarsAbove.CombatTexts.2"),
//                     "The Timeframe vanishes..." => LangHelper.GetText("StarsAbove.CombatTexts.3"),
//                     "Critical cast!" => LangHelper.GetText("StarsAbove.CombatTexts.4"),
//                     "The Eye of Euthymia has 10 seconds left!" => LangHelper.GetText("StarsAbove.CombatTexts.5"),
//                     "The Core of Flames has 5 seconds left!" => LangHelper.GetText("StarsAbove.CombatTexts.6"),
//                     "Liberation Blazing is ready to strike!" => LangHelper.GetText("StarsAbove.CombatTexts.7"),
//                     "Going supercritical!" => LangHelper.GetText("StarsAbove.CombatTexts.8"),
//                     "Stellar Nova ready!" => LangHelper.GetText("StarsAbove.CombatTexts.9"),
//                     "Blade Will activated!" => LangHelper.GetText("StarsAbove.CombatTexts.10"),
//                     "Blasting Form" => LangHelper.GetText("StarsAbove.CombatTexts.11"),
//                     "Striking Form" => LangHelper.GetText("StarsAbove.CombatTexts.12"),
//                     "Fully charged!" => LangHelper.GetText("StarsAbove.CombatTexts.13"),
//                     "Mystic Form" => LangHelper.GetText("StarsAbove.CombatTexts.14"),
//                     "Scythe deployed!" => LangHelper.GetText("StarsAbove.CombatTexts.15"),
//                     "Shotgun deployed!" => LangHelper.GetText("StarsAbove.CombatTexts.16"),
//                     "Blade deployed!" => LangHelper.GetText("StarsAbove.CombatTexts.17"),
//                     "Stellar Prism acquired!" => LangHelper.GetText("StarsAbove.CombatTexts.18"),
//                     "Covered in red paint!" => LangHelper.GetText("StarsAbove.CombatTexts.19"),
//                     "Covered in blue paint!" => LangHelper.GetText("StarsAbove.CombatTexts.20"),
//                     "Covered in yellow paint!" => LangHelper.GetText("StarsAbove.CombatTexts.21"),
//                     _ => Main.combatText[i].text
//                 };
//             }
//         }
//     }
// }