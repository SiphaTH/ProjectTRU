using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using FargowiltasSouls.Items.Accessories.Forces;
using FargowiltasSouls.Patreon.Catsounds;
using FargowiltasSouls.Patreon.Daawnz;
using FargowiltasSouls.Patreon.DemonKing;
using FargowiltasSouls.Patreon.DevAesthetic;
using FargowiltasSouls.Patreon.Duck;
using FargowiltasSouls.Patreon.Gittle;
using FargowiltasSouls.Patreon.GreatestKraken;
using FargowiltasSouls.Patreon.LaBonez;
using FargowiltasSouls.Patreon.ManliestDove;
using FargowiltasSouls.Patreon.ParadoxWolf;
using FargowiltasSouls.Patreon.Sam;
using FargowiltasSouls.Patreon.Sasha;
using FargowiltasSouls.Patreon.Shucks;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.GlobalModifications
{
    public class SpecificItemsTooltipTranslation : FargoSoulsGlobalItemBase
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<MedallionoftheFallenKing>() || item.type == ModContent.ItemType<ComputationOrb>() ||
                item.type == ModContent.ItemType<StaffOfUnleashedOcean>() || item.type == ModContent.ItemType<RoombaPet>() ||
                item.type == ModContent.ItemType<PiranhaPlantVoodooDoll>() || item.type == ModContent.ItemType<FigBranch>() ||
                item.type == ModContent.ItemType<ParadoxWolfSoul>() || item.type == ModContent.ItemType<SquidwardDoor>() ||
                item.type == ModContent.ItemType<MissDrakovisFishingPole>() || item.type == ModContent.ItemType<DeviousAestheticus>() ||
                item.type == ModContent.ItemType<ScientificRailgun>() || item.type == ModContent.ItemType<VortexMagnetRitual>() ||
                item.type == ModContent.ItemType<CrimetroidEgg>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "tooltip", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.TooltipName.Tooltip");
                });
            }
            else if (item.type == ModContent.ItemType<CosmoForce>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.CosmoForce.Tooltip0",
                        $"[i:{ModsCall.FargoSouls.ItemType("MeteorEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.CosmoForce.Tooltip1",
                        $"[i:{ModsCall.FargoSouls.ItemType("SolarEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.CosmoForce.Tooltip2",
                        $"[i:{ModsCall.FargoSouls.ItemType("SolarEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.CosmoForce.Tooltip3",
                        $"[i:{ModsCall.FargoSouls.ItemType("VortexEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.CosmoForce.Tooltip4",
                        $"[i:{ModsCall.FargoSouls.ItemType("NebulaEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.CosmoForce.Tooltip5",
                        $"[i:{ModsCall.FargoSouls.ItemType("StardustEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.CosmoForce.Tooltip6",
                        $"[i:{ModsCall.FargoSouls.ItemType("StardustEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.CosmoForce.Tooltip7");
                });
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("EarthForce"))
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip0",
                        $"[i:{ModsCall.FargoSouls.ItemType("CobaltEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip1",
                        $"[i:{ModsCall.FargoSouls.ItemType("MythrilEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip2",
                        $"[i:{ModsCall.FargoSouls.ItemType("PalladiumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip3",
                        $"[i:{ModsCall.FargoSouls.ItemType("PalladiumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip4",
                        $"[i:{ModsCall.FargoSouls.ItemType("OrichalcumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip5",
                        $"[i:{ModsCall.FargoSouls.ItemType("OrichalcumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip6",
                        $"[i:{ModsCall.FargoSouls.ItemType("AdamantiteEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip7",
                        $"[i:{ModsCall.FargoSouls.ItemType("TitaniumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip8");
                });
            }
            else if (item.type == ModContent.ItemType<EarthForce>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip0",
                        $"[i:{ModsCall.FargoSouls.ItemType("CobaltEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip1",
                        $"[i:{ModsCall.FargoSouls.ItemType("MythrilEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip2",
                        $"[i:{ModsCall.FargoSouls.ItemType("PalladiumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip3",
                        $"[i:{ModsCall.FargoSouls.ItemType("PalladiumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip4",
                        $"[i:{ModsCall.FargoSouls.ItemType("OrichalcumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip5",
                        $"[i:{ModsCall.FargoSouls.ItemType("OrichalcumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip6",
                        $"[i:{ModsCall.FargoSouls.ItemType("AdamantiteEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip7",
                        $"[i:{ModsCall.FargoSouls.ItemType("TitaniumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.EarthForce.Tooltip8");
                });
            }
            else if (item.type == ModContent.ItemType<LifeForce>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.LifeForce.Tooltip0",
                        $"[i:{ModsCall.FargoSouls.ItemType("PumpkinEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.LifeForce.Tooltip1",
                        $"[i:{ModsCall.FargoSouls.ItemType("CactusEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.LifeForce.Tooltip2",
                        $"[i:{ModsCall.FargoSouls.ItemType("BeeEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.LifeForce.Tooltip3",
                        $"[i:{ModsCall.FargoSouls.ItemType("SpiderEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.LifeForce.Tooltip4",
                        $"[i:{ModsCall.FargoSouls.ItemType("TurtleEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.LifeForce.Tooltip5",
                        $"[i:{ModsCall.FargoSouls.ItemType("BeetleEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.LifeForce.Tooltip6",
                        $"[i:{ModsCall.FargoSouls.ItemType("BeetleEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.LifeForce.Tooltip7");
                });
            }
            else if (item.type == ModContent.ItemType<NatureForce>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip0",
                        $"[i:{ModsCall.FargoSouls.ItemType("CrimsonEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip1",
                        $"[i:{ModsCall.FargoSouls.ItemType("MoltenEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip2",
                        $"[i:{ModsCall.FargoSouls.ItemType("MoltenEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip3",
                        $"[i:{ModsCall.FargoSouls.ItemType("RainEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip4",
                        $"[i:{ModsCall.FargoSouls.ItemType("FrostEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip5",
                        $"[i:{ModsCall.FargoSouls.ItemType("SnowEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip6",
                        $"[i:{ModsCall.FargoSouls.ItemType("ChlorophyteEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip7",
                        $"[i:{ModsCall.FargoSouls.ItemType("JungleEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip8",
                        $"[i:{ModsCall.FargoSouls.ItemType("ShroomiteEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip9", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip9",
                        $"[i:{ModsCall.FargoSouls.ItemType("ShroomiteEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip10", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.NatureForce.Tooltip10");
                });
            }
            else if (item.type == ModContent.ItemType<ShadowForce>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip0",
                        $"[i:{ModsCall.FargoSouls.ItemType("ShadowEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip1",
                        $"[i:{ModsCall.FargoSouls.ItemType("AncientShadowEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip2",
                        $"[i:{ModsCall.FargoSouls.ItemType("NecroEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip3",
                        $"[i:{ModsCall.FargoSouls.ItemType("SpookyEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip4",
                        $"[i:{ModsCall.FargoSouls.ItemType("NinjaEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip5",
                        $"[i:{ModsCall.FargoSouls.ItemType("MonkEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip6",
                        $"[i:{ModsCall.FargoSouls.ItemType("ShinobiEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip7",
                        $"[i:{ModsCall.FargoSouls.ItemType("DarkArtistEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip8",
                        $"[i:{ModsCall.FargoSouls.ItemType("ApprenticeEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip9", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip9",
                        $"[i:{ModsCall.FargoSouls.ItemType("ApprenticeEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip10", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.ShadowForce.Tooltip10");
                });
            }
            else if (item.type == ModContent.ItemType<SpiritForce>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.SpiritForce.Tooltip0",
                        $"[i:{ModsCall.FargoSouls.ItemType("FossilEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.SpiritForce.Tooltip1",
                        $"[i:{ModsCall.FargoSouls.ItemType("FossilEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.SpiritForce.Tooltip2",
                        $"[i:{ModsCall.FargoSouls.ItemType("ForbiddenEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.SpiritForce.Tooltip3",
                        $"[i:{ModsCall.FargoSouls.ItemType("ForbiddenEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.SpiritForce.Tooltip4",
                        $"[i:{ModsCall.FargoSouls.ItemType("HallowEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.SpiritForce.Tooltip5",
                        $"[i:{ModsCall.FargoSouls.ItemType("HallowEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.SpiritForce.Tooltip6",
                        $"[i:{ModsCall.FargoSouls.ItemType("HallowEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.SpiritForce.Tooltip7",
                        $"[i:{ModsCall.FargoSouls.ItemType("TikiEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.SpiritForce.Tooltip8",
                        $"[i:{ModsCall.FargoSouls.ItemType("SpectreEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip9", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.SpiritForce.Tooltip9");
                });
            }
            else if (item.type == ModsCall.FargoSouls.ItemType("TerraForce"))
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip0",
                        $"[i:{ModsCall.FargoSouls.ItemType("CopperEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip1",
                        $"[i:{ModsCall.FargoSouls.ItemType("TinEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip2",
                        $"[i:{ModsCall.FargoSouls.ItemType("TinEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip3",
                        $"[i:{ModsCall.FargoSouls.ItemType("IronEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip4",
                        $"[i:{ModsCall.FargoSouls.ItemType("IronEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip5",
                        $"[i:{ModsCall.FargoSouls.ItemType("LeadEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip6",
                        $"[i:{ModsCall.FargoSouls.ItemType("TungstenEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip7", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip7",
                        $"[i:{ModsCall.FargoSouls.ItemType("TungstenEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip8", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip8",
                        $"[i:{ModsCall.FargoSouls.ItemType("ObsidianEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip9", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip9",
                        $"[i:{ModsCall.FargoSouls.ItemType("ObsidianEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip10", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TerraForce.Tooltip10");
                });
            }
            else if (item.type == ModContent.ItemType<TimberForce>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TimberForce.Tooltip0",
                        $"[i:{ModsCall.FargoSouls.ItemType("WoodEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TimberForce.Tooltip1",
                        $"[i:{ModsCall.FargoSouls.ItemType("BorealWoodEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TimberForce.Tooltip2",
                        $"[i:{ModsCall.FargoSouls.ItemType("RichMahoganyEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TimberForce.Tooltip3",
                        $"[i:{ModsCall.FargoSouls.ItemType("EbonwoodEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TimberForce.Tooltip4",
                        $"[i:{ModsCall.FargoSouls.ItemType("PalmWoodEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TimberForce.Tooltip5",
                        $"[i:{ModsCall.FargoSouls.ItemType("PearlwoodEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip6", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.TimberForce.Tooltip6");
                });
            }
            else if (item.type == ModContent.ItemType<WillForce>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.WillForce.Tooltip0",
                        $"[i:{ModsCall.FargoSouls.ItemType("GoldEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip1", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.WillForce.Tooltip1",
                        $"[i:{ModsCall.FargoSouls.ItemType("PlatinumEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip2", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.WillForce.Tooltip2",
                        $"[i:{ModsCall.FargoSouls.ItemType("GladiatorEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip3", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.WillForce.Tooltip3",
                        $"[i:{ModsCall.FargoSouls.ItemType("RedRidingEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip4", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.WillForce.Tooltip4",
                        $"[i:{ModsCall.FargoSouls.ItemType("ValhallaKnightEnchant")}]");
                });
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip5", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("FargoSouls.ItemTooltip.WillForce.Tooltip5");
                });
            }
        }
    }
}