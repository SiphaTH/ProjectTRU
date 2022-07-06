// using CalamityRuTranslate.Content.Vanity.BrotKrip;
// using CalamityRuTranslate.Content.Vanity.CCC;
// using CalamityRuTranslate.Content.Vanity.StepMolchX;
// using CalamityRuTranslate.Content.Vanity.Sum;
// using CalamityRuTranslate.Content.Vanity.Umbra;
// using CalamityRuTranslate.Content.Vanity.Veystreks;
// using CalamityRuTranslate.Content.Vanity.Yum;
// using Terraria;
// using Terraria.DataStructures;
// using Terraria.ID;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Content;
//
// public class VanityDrop : GlobalItem
// {
//     public override void OpenVanillaBag(string context, Player player, int arg)
//     {
//         IEntitySource source = player.GetSource_OpenItem(arg);
//         switch (context)
//         {
//             case "bossBag":
//                 switch (arg)
//                 {
//                     case ItemID.TwinsBossBag:
//                     case ItemID.DestroyerBossBag:
//                     case ItemID.SkeletronPrimeBossBag:
//                     case ItemID.PlanteraBossBag:
//                     case ItemID.GolemBossBag:
//                     case ItemID.FishronBossBag:
//                     case ItemID.CultistBossBag:
//                     case ItemID.MoonLordBossBag:
//                         if (Main.rand.NextBool(20))
//                         {
//                             player.QuickSpawnItem(source, ModContent.ItemType<StepMolchXHood>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<StepMolchXChest>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<StepMolchXBoots>());
//                         }
//                         if (Main.rand.NextBool(20))
//                         {
//                             player.QuickSpawnItem(source, ModContent.ItemType<CccMask>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<CccChest>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<CccBoots>());
//                         }
//                         if (Main.rand.NextBool(20))
//                         {
//                             player.QuickSpawnItem(source, ModContent.ItemType<UmbraVoidHood>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<UmbraVoidChest>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<UmbraVoidGreaves>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<UmbraWings>());
//                         }
//                         if (Main.rand.NextBool(20))
//                         {
//                             player.QuickSpawnItem(source, ModContent.ItemType<YumHood>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<YumChest>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<YumBoots>());
//                         }
//                         // if (Main.rand.NextBool(20))
//                         // {
//                         //     player.QuickSpawnItem(ModContent.ItemType<VeystreksScarf>());
//                         //     player.QuickSpawnItem(ModContent.ItemType<VeystreksChest>());
//                         //     player.QuickSpawnItem(ModContent.ItemType<VeystreksBoots>());
//                         // }
//                         if (Main.rand.NextBool(20))
//                         {
//                             player.QuickSpawnItem(source, ModContent.ItemType<MarisaHat>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<MarisaDress>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<MarisaSocks>());
//                         }
//                         if (Main.rand.NextBool(20))
//                         {
//                             player.QuickSpawnItem(source, ModContent.ItemType<PrincessCrown>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<PrincessDress>());
//                             player.QuickSpawnItem(source, ModContent.ItemType<PrincessBoots>());
//                         }
//                         break;
//                 }
//                 break;
//         }
//     }
// }