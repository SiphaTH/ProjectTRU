// using CalamityMod.NPCs.CalClone;
// using CalamityMod.NPCs.GreatSandShark;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using InfernumMode.Core.GlobalInstances.Systems;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.GlobalModifications;
//
// public class InfernumModeGlobalNPC : GlobalNPC
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModsCall.Calamity != null && ModsCall.Infernum != null && TranslationHelper.IsRussianLanguage;
//     }
//     
//     public override void ModifyTypeName(NPC npc, ref string typeName)
//     {
//         if (WorldSaveSystem.InfernumMode)
//         {
//             if (npc.type == ModContent.NPCType<GreatSandShark>())
//                 typeName = "Таурус, Великая песчаная акула";
//             
//             if (npc.type == ModContent.NPCType<CalamitasClone>())
//                 typeName = "Забытая тень Каламитас";
//             
//             if (npc.type == ModContent.NPCType<Cataclysm>())
//                 typeName = "Забытая тень Катаклизма";
//             
//             if (npc.type == ModContent.NPCType<Catastrophe>())
//                 typeName = "Забытая тень Катастрофа";
//         }
//     }
// }