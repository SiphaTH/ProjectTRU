using CalamityRuTranslate.Content.Vanity.CCC;
using CalamityRuTranslate.Content.Vanity.StepMolchX;
using CalamityRuTranslate.Content.Vanity.Umbra;
using CalamityRuTranslate.Content.Vanity.Yum;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content
{
    public class TRuGlobalItem : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            switch (context)
            {
                case "bossBag":
                    switch (arg)
                    {
                        case ItemID.TwinsBossBag:
                        case ItemID.DestroyerBossBag:
                        case ItemID.SkeletronPrimeBossBag:
                        case ItemID.PlanteraBossBag:
                        case ItemID.GolemBossBag:
                        case ItemID.FishronBossBag:
                        case ItemID.CultistBossBag:
                        case ItemID.MoonLordBossBag:
                            if (Main.rand.NextBool(5))
                            {
                                player.QuickSpawnItem(ModContent.ItemType<StepMolchXHood>());
                                player.QuickSpawnItem(ModContent.ItemType<StepMolchXChest>());
                                player.QuickSpawnItem(ModContent.ItemType<StepMolchXBoots>());
                            }
                            if (Main.rand.NextBool(5))
                            {
                                player.QuickSpawnItem(ModContent.ItemType<CccMask>());
                                player.QuickSpawnItem(ModContent.ItemType<CccChest>());
                                player.QuickSpawnItem(ModContent.ItemType<CccBoots>());
                            }
                            if (Main.rand.NextBool(5))
                            {
                                player.QuickSpawnItem(ModContent.ItemType<UmbraVoidHood>());
                                player.QuickSpawnItem(ModContent.ItemType<UmbraVoidChest>());
                                player.QuickSpawnItem(ModContent.ItemType<UmbraVoidGreaves>());
                                player.QuickSpawnItem(ModContent.ItemType<UmbraWings>());
                            }
                            if (Main.rand.NextBool(5))
                            {
                                player.QuickSpawnItem(ModContent.ItemType<YumHood>());
                                player.QuickSpawnItem(ModContent.ItemType<YumChest>());
                                player.QuickSpawnItem(ModContent.ItemType<YumBoots>());
                            }
                            break;
                    }
                    break;
            }
        }
    }
}