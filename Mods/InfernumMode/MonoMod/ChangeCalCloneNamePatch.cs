// using CalamityMod.NPCs.CalClone;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core;
// using InfernumMode.Content.BehaviorOverrides.BossAIs.CalamitasShadow;
// using InfernumMode.Core.GlobalInstances.Systems;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class ChangeCalCloneNamePatch : ContentTranslation, ILoadableContent
// {
//     public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage && ModsCall.Calamity != null && ModsCall.Infernum != null;
//
//     public override float Priority => 1f;
//
//     public void LoadContent()
//     {
//         On_NPC.DoDeathEvents_DropBossPotionsAndHearts += ChangeName;
//     }
//
//     public void UnloadContent()
//     {
//         On_NPC.DoDeathEvents_DropBossPotionsAndHearts -= ChangeName;
//     }
//     
//     private void ChangeName(On_NPC.orig_DoDeathEvents_DropBossPotionsAndHearts orig, NPC npc, ref string typeName)
//     {
//         orig(npc, ref typeName);
//         
//         if (npc.type == ModContent.NPCType<CalamitasClone>() && WorldSaveSystem.InfernumMode)
//             typeName = "Забытая тень Каламитас";
//     }
// }