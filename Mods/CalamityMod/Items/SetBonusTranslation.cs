using System.Collections.Generic;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    public class SetBonusTranslation: GlobalItem
    {
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (CoreCalamityTranslation.CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                if (head.type == ItemID.ObsidianHelm &&
                    body.type == ItemID.ObsidianShirt &&
                    legs.type == ItemID.ObsidianPants)
                {
                    return "Obsidian";
                }
                    
                if ((head.type == ItemID.EskimoHood || head.type == ItemID.PinkEskimoHood) &&
                    (body.type == ItemID.EskimoCoat || body.type == ItemID.PinkEskimoCoat) &&
                    (legs.type == ItemID.EskimoPants || legs.type == ItemID.PinkEskimoPants))
                {
                    return "Eskimo";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("ForbiddenCirclet") &&
                    body.type == ItemID.AncientBattleArmorShirt &&
                    legs.type == ItemID.AncientBattleArmorPants)
                {
                    return "AncientForbiddenCirclet";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("ShroomiteVisage") &&
                    body.type == ItemID.ShroomiteBreastplate &&
                    legs.type == ItemID.ShroomiteLeggings)
                {
                    return "Shroomite";
                }

                if (head.type == ItemID.GladiatorHelmet &&
                    body.type == ItemID.GladiatorBreastplate &&
                    legs.type == ItemID.GladiatorLeggings)
                {
                    return "Gladiator";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecHat") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecLeggings"))
                {
                    return "AerospecMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecHeadgear") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecLeggings"))
                {
                    return "AerospecRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecLeggings"))
                {
                    return "AerospecMelee";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecLeggings"))
                {
                    return "AerospecSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecHood") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AerospecLeggings"))
                {
                    return "AerospecRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AstralHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AstralBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AstralLeggings"))
                {
                    return "Astral";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaHeadgear") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaSubligar"))
                {
                    return "AtaxiaRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaSubligar"))
                {
                    return "AtaxiaMelee";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaSubligar"))
                {
                    return "AtaxiaSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaHood") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaSubligar"))
                {
                    return "AtaxiaRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AtaxiaSubligar"))
                {
                    return "AtaxiaMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaBodyArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaCuisses"))
                {
                    return "AuricTeslaMelee";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaHoodedFacemask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaBodyArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaCuisses"))
                {
                    return "AuricTeslaRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaPlumedHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaBodyArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaCuisses"))
                {
                    return "AuricTeslaRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaSpaceHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaBodyArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaCuisses"))
                {
                    return "AuricTeslaSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaWireHemmedVisage") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaBodyArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("AuricTeslaCuisses"))
                {
                    return "AuricTeslaMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareBodyArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareCuisses"))
                {
                    return "BloodflareRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareBodyArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareCuisses"))
                {
                    return "BloodflareSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareHornedHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareBodyArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareCuisses"))
                {
                    return "BloodflareRanged";
                }
                    
                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareHornedMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareBodyArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareCuisses"))
                {
                    return "BloodflareMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareBodyArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("BloodflareCuisses"))
                {
                    return "BloodflareMelee";
                }
                    
                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("BrimflameScowl") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("BrimflameRobes") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("BrimflameBoots"))
                {
                    return "Brimflame";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusHat") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusLeggings"))
                {
                    return "DaedalusMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusHeadgear") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusLeggings"))
                {
                    return "DaedalusSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusLeggings"))
                {
                    return "DaedalusMelee";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusLeggings"))
                {
                    return "DaedalusRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusVisor") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("DaedalusLeggings"))
                {
                    return "DaedalusRogue";
                }
                    
                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("DemonshadeHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("DemonshadeBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("DemonshadeGreaves"))
                {
                    return "Demonshade";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("DesertProwlerHat") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("DesertProwlerShirt") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("DesertProwlerPants"))
                {
                    return "DesertProwler";
                }
                    
                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("FearmongerGreathelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("FearmongerPlateMail") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("FearmongerGreaves"))
                {
                    return "Fearmonger";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("FathomSwarmerVisage") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("FathomSwarmerBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("FathomSwarmerBoots"))
                {
                    return "FathomSwarmer";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerChestplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerLeggings"))
                {
                    return "GodSlayerMelee";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerChestplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerLeggings"))
                {
                    return "GodSlayerRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerHornedHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerChestplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerLeggings"))
                {
                    return "GodSlayerSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerChestplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerLeggings"))
                {
                    return "GodSlayerRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerVisage") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerChestplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("GodSlayerLeggings"))
                {
                    return "GodSlayerMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("MolluskShellmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("MolluskShellplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("MolluskShelleggings"))
                {
                    return "Mollusk";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("OmegaBlueHelmet") ||
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("OmegaBlueChestplate") ||
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("OmegaBlueLeggings"))
                {
                    return "OmegaBlue";
                }
                    
                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("PlagueReaperMask") ||
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("PlagueReaperVest") ||
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("PlagueReaperStriders"))
                {
                    return "PlagueReaper";
                }
                    
                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("PrismaticHelmet") ||
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("PrismaticRegalia") ||
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("PrismaticGreaves"))
                {
                    return "Prismatic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("PlaguebringerVisor") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("PlaguebringerCarapace") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("PlaguebringerPistons"))
                {
                    return "Plaguebringer";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverCap") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverScaleMail") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverCuisses"))
                {
                    return "ReaverRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverScaleMail") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverCuisses"))
                {
                    return "ReaverMelee";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverScaleMail") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverCuisses"))
                {
                    return "ReaverSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverScaleMail") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverCuisses"))
                {
                    return "ReaverMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverVisage") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverScaleMail") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("ReaverCuisses"))
                {
                    return "ReaverRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaLeggings"))
                {
                    return "SilvaMelee";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaLeggings"))
                {
                    return "SilvaSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaHornedHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaLeggings"))
                {
                    return "SilvaRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaLeggings"))
                {
                    return "SilvaRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaMaskedCap") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("SilvaLeggings"))
                {
                    return "SilvaMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("SnowRuffianMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("SnowRuffianChestplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("SnowRuffianGreaves"))
                {
                    return "SnowRuffian";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelCap") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelGreaves"))
                {
                    return "StatigelMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelHeadgear") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelGreaves"))
                {
                    return "StatigelRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelGreaves"))
                {
                    return "StatigelMelee";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelHood") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelGreaves"))
                {
                    return "StatigelSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("StatigelGreaves"))
                {
                    return "StatigelRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("SulfurHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("SulfurBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("SulfurLeggings"))
                {
                    return "Sulfur";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonLeggings"))
                {
                    return "TarragonMelee";
                }
                    
                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonLeggings"))
                {
                    return "TarragonRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonHornedHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonLeggings"))
                {
                    return "TarragonSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonLeggings"))
                {
                    return "TarragonMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonVisage") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("TarragonLeggings"))
                {
                    return "TarragonRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("TitanHeartMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("TitanHeartMantle") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("TitanHeartBoots"))
                {
                    return "TitanHeart";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("UmbraphileHood") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("UmbraphileRegalia") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("UmbraphileBoots"))
                {
                    return "Umbraphile";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideHeadgear") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideLeggings"))
                {
                    return "VictideRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideLeggings"))
                {
                    return "VictideMelee";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideLeggings"))
                {
                    return "VictideSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideLeggings"))
                {
                    return "VictideMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideVisage") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideBreastplate") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("VictideLeggings"))
                {
                    return "VictideRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumHeadgear") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumLeggings"))
                {
                    return "WulfrumRanged";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumHelm") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumLeggings"))
                {
                    return "WulfrumMelee";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumHelmet") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumLeggings"))
                {
                    return "WulfrumSummoner";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumHood") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumLeggings"))
                {
                    return "WulfrumMagic";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumArmor") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("WulfrumLeggings"))
                {
                    return "WulfrumRogue";
                }

                if (head.type == CoreCalamityTranslation.CalamityMod.ItemType("XerocMask") &&
                    body.type == CoreCalamityTranslation.CalamityMod.ItemType("XerocPlateMail") &&
                    legs.type == CoreCalamityTranslation.CalamityMod.ItemType("XerocCuisses"))
                {
                    return "Xeroc";
                }
            }

            return "";
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                try
                {
                    switch (set)
                    {
                        case "AncientForbiddenCirclet":
                        case "BloodflareRanged":
                        case "Brimflame":
                        case "Demonshade":
                        case "OmegaBlue":
                        case "PlagueReaper":
                        case "Prismatic":
                        case "TarragonMelee":
                            player.setBonus = RussianDictionaries.CalamitySetBonusWithArmorKey[set].Item1 + CoreCalamityTranslation.ArmorSetHotkey + RussianDictionaries.CalamitySetBonusWithArmorKey[set].Item2;
                            break;
                        default:
                            player.setBonus = RussianDictionaries.CalamitySetBonus[set];
                            break;
                    }
                }
                catch
                {
                    Main.NewText($"Ошибка загрузки ключа бонуса комплекта {set}.");
                }
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                if (item.type == ItemID.AncientBattleArmorHat ||
                    item.type == ItemID.AncientBattleArmorShirt ||
                    item.type == ItemID.AncientBattleArmorPants)
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "SetBonus")
                        {
                            tooltipLine.text = tooltipLine.text.Replace("The minion damage nerf is reduced while wielding magic weapons", Translation.KeyText("Calamity.SetBonus.AncientBattleArmor"));
                        }
                    }
                }
            }
        }
    }
}