// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using SpiritMod;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.SpiritMod
// {
//     public class CustomBuffsTranslation : GlobalBuff
//     {
//         public override bool Autoload(ref string name) => ModsCall.Spirit != null && TranslationUtils.IsRussianLanguage;
//
//         public override void ModifyBuffTip(int type, ref string tip, ref int rare)
//         {
//             MyPlayer modPlayer = Main.player[Main.myPlayer].GetSpiritPlayer();
//             
//             if (type == ModsCall.Spirit.BuffType("ExplorerFight"))
//                 tip = LangUtils.GetTextValue("Spirit", "BuffDescription.ExplorerFight.ModifyBuffTip", modPlayer.damageStacks * 3);
//             
//             if (type == ModsCall.Spirit.BuffType("ExplorerMine"))
//                 tip = LangUtils.GetTextValue("Spirit", "BuffDescription.ExplorerMine.ModifyBuffTip", modPlayer.miningStacks);
//             
//             if (type == ModsCall.Spirit.BuffType("ExplorerPot"))
//                 tip = LangUtils.GetTextValue("Spirit", "BuffDescription.ExplorerPot.ModifyBuffTip", modPlayer.movementStacks * 5/4);
//             
//             if (type == ModsCall.Spirit.BuffType("CollapsingVoid"))
//                 tip = LangUtils.GetTextValue("Spirit", "BuffDescription.CollapsingVoid.ModifyBuffTip", modPlayer.voidStacks * 5);
//             
//             if (type == ModsCall.Spirit.BuffType("DivineStrike"))
//                 tip = LangUtils.GetTextValue("Spirit", "BuffDescription.DivineStrike.ModifyBuffTip", modPlayer.divineStacks * 11);
//             
//             if (type == ModsCall.Spirit.BuffType("TemporalShift") && modPlayer.phaseShift)
//                 tip = LangUtils.GetTextValue("Spirit", "BuffDescription.TemporalShift.ModifyBuffTip");
//             
//             if (type == ModsCall.Spirit.BuffType("BeetleFortitude"))
//                 tip = LangUtils.GetTextValue("Spirit", "BuffDescription.BeetleFortitude.ModifyBuffTip", modPlayer.beetleStacks);
//         }
//     }
// }