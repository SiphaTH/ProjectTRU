// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.InfernumMode;
//
// public class InfenumModeCombatText : ContentTranslation, ICombatText
// {
//     public override bool IsTranslationEnabled => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
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
//                     "Infernum must be enabled to enter the Colosseum!" => LangHelper.GetText("InfernumMode.CombatTexts.1"),
//                     "Gate not set!" => LangHelper.GetText("InfernumMode.CombatTexts.2"),
//                     "Infinite flight granted!" => LangHelper.GetText("InfernumMode.CombatTexts.3"),
//                     "The pressure is too strong to escape!" => LangHelper.GetText("InfernumMode.CombatTexts.4"),
//                     "Thought you could keep me away? Think again!" => LangHelper.GetText("InfernumMode.CombatTexts.5"),
//                     "Huzzah! I return." => LangHelper.GetText("InfernumMode.CombatTexts.6"),
//                     "WOW it smells dusty inside that tablet..." => LangHelper.GetText("InfernumMode.CombatTexts.7"),
//                     "Be careful with me, I'm a special little guy." => LangHelper.GetText("InfernumMode.CombatTexts.8"),
//                     "Back at last! Time to wreak havoc once more!" => LangHelper.GetText("InfernumMode.CombatTexts.9"),
//                     "Gamers don't die, they respawn." => LangHelper.GetText("InfernumMode.CombatTexts.10"),
//                     "Weh!" => LangHelper.GetText("InfernumMode.CombatTexts.11"),
//                     "It's a beautiful day outside. Birds are singing, flowers are blooming..." => LangHelper.GetText("InfernumMode.CombatTexts.12"),
//                     "Wanna come pick flowers with me?" => LangHelper.GetText("InfernumMode.CombatTexts.13"),
//                     "Hey, where do you keep your explosives?" => LangHelper.GetText("InfernumMode.CombatTexts.14"),
//                     "What a boring day." => LangHelper.GetText("InfernumMode.CombatTexts.15"),
//                     "Come on! Let's do something FUN!" => LangHelper.GetText("InfernumMode.CombatTexts.16"),
//                     "What's next on the agenda, compadre?" => LangHelper.GetText("InfernumMode.CombatTexts.17"),
//                     "Sparkle sparkle!" => LangHelper.GetText("InfernumMode.CombatTexts.18"),
//                     "Heh, this'll be over quick." => LangHelper.GetText("InfernumMode.CombatTexts.19"),
//                     "Don't die this time, alright?" => LangHelper.GetText("InfernumMode.CombatTexts.20"),
//                     "Back so soon?" => LangHelper.GetText("InfernumMode.CombatTexts.21"),
//                     "If you lose this time, I'll eat all your furniture. That's a threat." => LangHelper.GetText("InfernumMode.CombatTexts.22"),
//                     "Don't forget potions!" => LangHelper.GetText("InfernumMode.CombatTexts.23"),
//                     "If you die on purpose, I'll give you a twenty." => LangHelper.GetText("InfernumMode.CombatTexts.24"),
//                     "Keh, this'll be a breeze!" => LangHelper.GetText("InfernumMode.CombatTexts.25"),
//                     "Go forth. Make me proud." => LangHelper.GetText("InfernumMode.CombatTexts.26"),
//                     "Show us how it's done, big shot." => LangHelper.GetText("InfernumMode.CombatTexts.27"),
//                     "Remember, fallgodding is ALWAYS an option!" => LangHelper.GetText("InfernumMode.CombatTexts.28"),
//                     "Hey now..." => LangHelper.GetText("InfernumMode.CombatTexts.29"),
//                     "WEH?" => LangHelper.GetText("InfernumMode.CombatTexts.30"),
//                     "Affections!" => LangHelper.GetText("InfernumMode.CombatTexts.31"),
//                     "Wait, don't stop..." => LangHelper.GetText("InfernumMode.CombatTexts.32"),
//                     "Peck!" => LangHelper.GetText("InfernumMode.CombatTexts.33"),
//                     _ => Main.combatText[i].text
//                 };
//             }
//         }
//     }
// }