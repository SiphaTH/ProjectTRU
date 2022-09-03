// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using StarsAbove.NPCs;
// using Terraria;
// using Terraria.GameContent.Bestiary;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.GlobalModifications;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarsAboveBestiaryTranslation : GlobalNPC
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//     }
//
//     public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
//     {
//         if (npc.type == ModContent.NPCType<Arbitration>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("StarsAbove.Bestiary.Arbitration")));
//         }
//         
//         if (npc.type == ModContent.NPCType<AstralCell>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("StarsAbove.Bestiary.AstralCell")));
//         }
//         
//         if (npc.type == ModContent.NPCType<Nalhaun>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("StarsAbove.Bestiary.Nalhaun")));
//         }
//         
//         if (npc.type == ModContent.NPCType<PaintedAttendantA>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("StarsAbove.Bestiary.PaintedAttendantA")));
//         }
//         
//         if (npc.type == ModContent.NPCType<Penthesilea>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("StarsAbove.Bestiary.Penthesilea")));
//         }
//         
//         if (npc.type == ModContent.NPCType<PrismLoot>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("StarsAbove.Bestiary.PrismLoot")));
//         }
//         
//         if (npc.type == ModContent.NPCType<SpectreOfLight>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("StarsAbove.Bestiary.SpectreOfLight")));
//         }
//         
//         if (npc.type == ModContent.NPCType<Tsukiyomi2>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("StarsAbove.Bestiary.Tsukiyomi2")));
//         }
//         
//         if (npc.type == ModContent.NPCType<VagrantOfSpaceAndTime>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("StarsAbove.Bestiary.VagrantOfSpaceAndTime")));
//         }
//         
//         if (npc.type == ModContent.NPCType<WarriorOfLight>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("StarsAbove.Bestiary.WarriorOfLight")));
//         }
//     }
// }