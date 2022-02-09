using System.Collections.Generic;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Accessories.Vanity;
using CalamityMod.Items.Accessories.Wings;
using CalamityMod.Items.Armor;
using CalamityMod.Items.Potions;
using CalamityMod.Items.Weapons.Summon;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class DeathModeItemsTranslation : CalamityGlobalItemBase
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<CelestialTracers>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip10", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.CelestialTracers.Tooltip10") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<ElysianTracers>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip9", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ElysianTracers.Tooltip9") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<ElysianWings>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ElysianWings.Tooltip5") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<SoulofCryogen>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.SoulofCryogen.Tooltip8") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<Popo>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.Popo.Tooltip1") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<AmbrosialAmpoule>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AmbrosialAmpoule.Tooltip2") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Cold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<AngelTreads>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AngelTreads.Tooltip5") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<BlazingCore>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.BlazingCore.Tooltip5") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<FrigidBulwark>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.FrigidBulwark.Tooltip4") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<FrostBarrier>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.FrostBarrier.Tooltip1") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<FrostFlare>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.FrostFlare.Tooltip4") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<InfinityBoots>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip9", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.InfinityBoots.Tooltip9") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<PermafrostsConcoction>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.PermafrostsConcoction.Tooltip4") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<Sponge>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.Sponge.Tooltip8") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Cold2") : "");
                });
            }
            else if (item.type == ModContent.ItemType<TheAmalgam>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.TheAmalgam.Tooltip8") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<TheCamper>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.TheCamper.Tooltip5") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Cold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<VoidofExtinction>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.VoidofExtinction.Tooltip4") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<YharimsInsignia>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.YharimsInsignia.Tooltip5") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<AtaxiaHeadgear>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AtaxiaHeadgear.Tooltip1") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<AtaxiaHelm>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AtaxiaHelm.Tooltip3") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<AtaxiaHelmet>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AtaxiaHelmet.Tooltip1") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<AtaxiaHood>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AtaxiaHood.Tooltip2") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<AtaxiaMask>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AtaxiaMask.Tooltip1") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<AuricTeslaBodyArmor>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.AuricTeslaBodyArmor.Tooltip2") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<BloodflareHelm>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.BloodflareHelm.Tooltip1") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<BloodflareHelmet>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.BloodflareHelmet.Tooltip1") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<BloodflareHornedHelm>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.BloodflareHornedHelm.Tooltip1") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<BloodflareHornedMask>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.BloodflareHornedMask.Tooltip1") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<BloodflareMask>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.BloodflareMask.Tooltip1") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<TarragonHelm>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.TarragonHelm.Tooltip4") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<TarragonHelmet>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.TarragonHelmet.Tooltip3") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<TarragonHornedHelm>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.TarragonHornedHelm.Tooltip2") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<TarragonMask>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.TarragonMask.Tooltip3") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<TarragonVisage>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.TarragonVisage.Tooltip3") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<XerocMask>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.XerocMask.Tooltip2") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<ColdDivinity>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ColdDivinity.Tooltip4") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<ElementalGauntlet>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.ElementalGauntlet.Tooltip4") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.HeatAndCold") : "");
                });
            }
            else if (item.type == ModContent.ItemType<FabledTortoiseShell>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.FabledTortoiseShell.Tooltip3") +
                                   (ModsCall.DeathMode ? LangHelper.GetTextValue("Calamity.DeathMode.Heat") : "");
                });
            }
            else if (item.type == ModContent.ItemType<PurifiedJam>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.PurifiedJam.Tooltip0",
                        ModsCall.DeathMode || ModsCall.MaliceMode ? 5 : 10);
                });
            }
        }
    }
}