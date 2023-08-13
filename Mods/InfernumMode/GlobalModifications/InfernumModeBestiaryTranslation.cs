// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using InfernumMode.Content.BehaviorOverrides.AbyssAIs;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.GreatSandShark;
// using Terraria;
// using Terraria.GameContent.Bestiary;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.GlobalModifications;
//
// public class InfernumModeBestiaryTranslation : GlobalNPC
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModsCall.Calamity != null && ModsCall.Infernum != null && TranslationHelper.IsRussianLanguage;
//     }
//
//     public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
//     {
//         if (npc.type == ModContent.NPCType<BereftVassal>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("InfernumMode.Bestiary.BereftVassal")));
//         }
//         
//         if (npc.type == ModContent.NPCType<DepthFeeder>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("InfernumMode.Bestiary.DepthFeeder")));
//         }
//         
//         if (npc.type == ModContent.NPCType<Herring>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("InfernumMode.Bestiary.Herring")));
//         }
//         
//         if (npc.type == ModContent.NPCType<LionfishEnemy>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("InfernumMode.Bestiary.LionfishEnemy")));
//         }
//     }
// }