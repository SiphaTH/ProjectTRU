using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common
{
    internal class ArmorSetBonusLoader : ILoadable
    {
        public static List<ArmorSetInfo> CalamityArmorSets = new List<ArmorSetInfo>();
        public static List<ArmorSetInfo> FargoSoulsArmorSets = new List<ArmorSetInfo>();
        public static List<ArmorSetInfo> VanillaArmorSets = new List<ArmorSetInfo>();

        public float Priority => 1.0f;

        public void Load()
        {
            VanillaArmorSetsInfo();
            CalamityArmorSetInfo();
            FargoSoulsArmorSetInfo();

            Mod mod = CalamityRuTranslate.Instance;

            foreach (Type t in mod.Code.GetTypes())
            {
                if (t.IsSubclassOf(typeof(ArmorSetInfo)))
                {
                    CalamityArmorSets.Add((ArmorSetInfo)Activator.CreateInstance(t));
                    FargoSoulsArmorSets.Add((ArmorSetInfo) Activator.CreateInstance(t));
                    VanillaArmorSets.Add((ArmorSetInfo) Activator.CreateInstance(t));
                }
            }
        }

        public void Unload()
        {
            CalamityArmorSets.Clear();
            FargoSoulsArmorSets.Clear();
            VanillaArmorSets.Clear();
        }

        private static void CalamityArmorSetInfo()
        {
            if (ModsCall.Calamity == null)
                return;
            
            CalamityArmorSets.Add(new ArmorSetInfo(ItemID.ObsidianHelm, ItemID.ObsidianShirt, ItemID.ObsidianPants, "Obsidian"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("ForbiddenCirclet"), ItemID.AncientBattleArmorShirt, ItemID.AncientBattleArmorPants, "AncientForbiddenCirclet"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("ShroomiteVisage"), ItemID.ShroomiteBreastplate, ItemID.ShroomiteLeggings, "Shroomite"));
            CalamityArmorSets.Add(new ArmorSetInfo(ItemID.GladiatorHelmet, ItemID.GladiatorBreastplate, ItemID.GladiatorLeggings, "Gladiator"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AerospecHat"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AerospecHeadgear"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AerospecHelm"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AerospecHelmet"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AerospecHood"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AstralHelm"), ModsCall.Calamity.ItemType("AstralBreastplate"), ModsCall.Calamity.ItemType("AstralLeggings"), "Astral"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AtaxiaHeadgear"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AtaxiaHelm"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AtaxiaHelmet"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AtaxiaHood"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AtaxiaMask"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AuricTeslaHelm"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AuricTeslaHoodedFacemask"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AuricTeslaPlumedHelm"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AuricTeslaSpaceHelmet"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("AuricTeslaWireHemmedVisage"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("BloodflareHelm"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("BloodflareHelmet"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("BloodflareHornedHelm"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("BloodflareHornedMask"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("BloodflareMask"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("BrimflameScowl"), ModsCall.Calamity.ItemType("BrimflameRobes"), ModsCall.Calamity.ItemType("BrimflameBoots"), "Brimflame"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("DaedalusHat"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("DaedalusHeadgear"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("DaedalusHelm"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("DaedalusHelmet"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("DaedalusVisor"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("DemonshadeHelm"), ModsCall.Calamity.ItemType("DemonshadeBreastplate"), ModsCall.Calamity.ItemType("DemonshadeGreaves"), "Demonshade"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("DesertProwlerHat"), ModsCall.Calamity.ItemType("DesertProwlerShirt"), ModsCall.Calamity.ItemType("DesertProwlerPants"), "DesertProwler"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("FearmongerGreathelm"), ModsCall.Calamity.ItemType("FearmongerPlateMail"), ModsCall.Calamity.ItemType("FearmongerGreaves"), "Fearmonger"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("FathomSwarmerVisage"), ModsCall.Calamity.ItemType("FathomSwarmerBreastplate"), ModsCall.Calamity.ItemType("FathomSwarmerBoots"), "FathomSwarmer"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("GodSlayerHelm"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("GodSlayerHelmet"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("GodSlayerHornedHelm"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("GodSlayerMask"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("GodSlayerVisage"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("MolluskShellmet"), ModsCall.Calamity.ItemType("MolluskShellplate"), ModsCall.Calamity.ItemType("MolluskShelleggings"), "Mollusk"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("OmegaBlueHelmet"), ModsCall.Calamity.ItemType("OmegaBlueChestplate"), ModsCall.Calamity.ItemType("OmegaBlueLeggings"), "OmegaBlue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("PlagueReaperMask"), ModsCall.Calamity.ItemType("PlagueReaperVest"), ModsCall.Calamity.ItemType("PlagueReaperStriders"), "PlagueReaper"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("PrismaticHelmet"), ModsCall.Calamity.ItemType("PrismaticRegalia"), ModsCall.Calamity.ItemType("PrismaticGreaves"), "Prismatic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("PlaguebringerVisor"), ModsCall.Calamity.ItemType("PlaguebringerCarapace"), ModsCall.Calamity.ItemType("PlaguebringerPistons"), "Plaguebringer"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("ReaverCap"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("ReaverHelm"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("ReaverHelmet"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("ReaverMask"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("ReaverVisage"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("SilvaHelm"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("SilvaHelmet"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("SilvaHornedHelm"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("SilvaMask"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("SilvaMaskedCap"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("SnowRuffianMask"), ModsCall.Calamity.ItemType("SnowRuffianChestplate"), ModsCall.Calamity.ItemType("SnowRuffianGreaves"), "SnowRuffian"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("StatigelCap"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("StatigelHeadgear"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("StatigelHelm"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("StatigelHood"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("StatigelMask"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("SulfurHelmet"), ModsCall.Calamity.ItemType("SulfurBreastplate"), ModsCall.Calamity.ItemType("SulfurLeggings"), "Sulfur"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("TarragonHelm"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("TarragonHelmet"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("TarragonHornedHelm"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("TarragonMask"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("TarragonVisage"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("TitanHeartMask"), ModsCall.Calamity.ItemType("TitanHeartMantle"), ModsCall.Calamity.ItemType("TitanHeartBoots"), "TitanHeart"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("UmbraphileHood"), ModsCall.Calamity.ItemType("UmbraphileRegalia"), ModsCall.Calamity.ItemType("UmbraphileBoots"), "Umbraphile"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("VictideHeadgear"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("VictideHelm"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("VictideHelmet"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("VictideMask"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("VictideVisage"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("WulfrumHeadgear"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumRanged"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("WulfrumHelm"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumMelee"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("WulfrumHelmet"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumSummoner"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("WulfrumHood"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumMagic"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("WulfrumMask"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumRogue"));
            CalamityArmorSets.Add(new ArmorSetInfo(ModsCall.Calamity.ItemType("XerocMask"), ModsCall.Calamity.ItemType("XerocPlateMail"), ModsCall.Calamity.ItemType("XerocCuisses"), "Xeroc"));
            CalamityArmorSets.Add(new ArmorSetInfo(ItemID.EskimoHood, ItemID.EskimoCoat, ItemID.EskimoPants, "Eskimo"));
            CalamityArmorSets.Add(new ArmorSetInfo(ItemID.PinkEskimoHood, ItemID.PinkEskimoCoat, ItemID.PinkEskimoPants, "Eskimo"));
            CalamityArmorSets.Add(new ArmorSetInfo(ItemID.PinkEskimoHood, ItemID.EskimoCoat, ItemID.EskimoPants, "Eskimo"));
            CalamityArmorSets.Add(new ArmorSetInfo(ItemID.PinkEskimoHood, ItemID.PinkEskimoCoat, ItemID.EskimoPants, "Eskimo"));
            CalamityArmorSets.Add(new ArmorSetInfo(ItemID.EskimoHood, ItemID.PinkEskimoCoat, ItemID.EskimoPants, "Eskimo"));
            CalamityArmorSets.Add(new ArmorSetInfo(ItemID.EskimoHood, ItemID.PinkEskimoCoat, ItemID.PinkEskimoPants, "Eskimo"));
            CalamityArmorSets.Add(new ArmorSetInfo(ItemID.EskimoHood, ItemID.EskimoCoat, ItemID.PinkEskimoPants, "Eskimo"));
            CalamityArmorSets.Add(new ArmorSetInfo(ItemID.PinkEskimoHood, ItemID.EskimoCoat, ItemID.PinkEskimoPants, "Eskimo"));
        }
        
        private static void FargoSoulsArmorSetInfo()
        {
            if (ModsCall.FargoSouls == null)
                return;

            FargoSoulsArmorSets.Add(new ArmorSetInfo(ModsCall.FargoSouls.ItemType("EridanusHat"), ModsCall.FargoSouls.ItemType("EridanusBattleplate"), ModsCall.FargoSouls.ItemType("EridanusLegwear"), "EridanusHat"));
            FargoSoulsArmorSets.Add(new ArmorSetInfo(ModsCall.FargoSouls.ItemType("GaiaHelmet"), ModsCall.FargoSouls.ItemType("GaiaPlate"), ModsCall.FargoSouls.ItemType("GaiaGreaves"), "GaiaHelmet"));
            FargoSoulsArmorSets.Add(new ArmorSetInfo(ModsCall.FargoSouls.ItemType("MutantMask"), ModsCall.FargoSouls.ItemType("MutantBody"), ModsCall.FargoSouls.ItemType("MutantPants"), "MutantMask"));
            FargoSoulsArmorSets.Add(new ArmorSetInfo(ModsCall.FargoSouls.ItemType("StyxCrown"), ModsCall.FargoSouls.ItemType("StyxChestplate"), ModsCall.FargoSouls.ItemType("StyxLeggings"), "StyxCrown"));
        }

        private static void VanillaArmorSetsInfo()
        {
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.CopperHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier1"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.IronHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier1"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.AncientIronHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier1"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.TinHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier1"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.SilverHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier2"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.AncientGoldHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier2"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.GoldHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier2"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.LeadHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier2"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.TungstenHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier2"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.CobaltMask, ItemID.None, ItemID.None, "Vanilla:CobaltRanged"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.MythrilHood, ItemID.None, ItemID.None, "Vanilla:MythrilCaster"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.MythrilHelmet, ItemID.None, ItemID.None, "Vanilla:MythrilMelee"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.MythrilHat, ItemID.None, ItemID.None, "Vanilla:MythrilRanged"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.AdamantiteHeadgear, ItemID.None, ItemID.None, "Vanilla:AdamantiteCaster"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.AdamantiteHelmet, ItemID.None, ItemID.None, "Vanilla:AdamantiteMelee"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.AdamantiteMask, ItemID.None, ItemID.None, "Vanilla:AdamantiteRanged"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.HallowedHeadgear, ItemID.None, ItemID.None, "Vanilla:HallowCaster"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.HallowedMask, ItemID.None, ItemID.None, "Vanilla:HallowMelee"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.HallowedHelmet, ItemID.None, ItemID.None, "Vanilla:HallowRanged"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.ShadowHelmet, ItemID.None, ItemID.None, "Vanilla:ShadowScale"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.AncientShadowHelmet, ItemID.None, ItemID.None, "Vanilla:ShadowScale"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.WoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.EbonwoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.RichMahoganyHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.PearlwoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.CactusHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.ShadewoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.BorealWoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.PalmWoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.CrimsonHelmet, ItemID.None, ItemID.None, "Vanilla:Crimson"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.FrostHelmet, ItemID.None, ItemID.None, "Vanilla:Frost"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.TikiMask, ItemID.None, ItemID.None, "Vanilla:Tiki"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.PalladiumMask, ItemID.None, ItemID.None, "Vanilla:Palladium"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.PalladiumHelmet, ItemID.None, ItemID.None, "Vanilla:Palladium"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.PalladiumHeadgear, ItemID.None, ItemID.None, "Vanilla:Palladium"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.OrichalcumMask, ItemID.None, ItemID.None, "Vanilla:Orichalcum"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.OrichalcumHelmet, ItemID.None, ItemID.None, "Vanilla:Orichalcum"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.OrichalcumHeadgear, ItemID.None, ItemID.None, "Vanilla:Orichalcum"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.TitaniumMask, ItemID.None, ItemID.None, "Vanilla:Titanium"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.TitaniumHelmet, ItemID.None, ItemID.None, "Vanilla:Titanium"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.TitaniumHeadgear, ItemID.None, ItemID.None, "Vanilla:Titanium"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.ChlorophyteMask, ItemID.None, ItemID.None, "Vanilla:Chlorophyte"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.ChlorophyteHelmet, ItemID.None, ItemID.None, "Vanilla:Chlorophyte"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.ChlorophyteHeadgear, ItemID.None, ItemID.None, "Vanilla:Chlorophyte"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.WizardHat, ItemID.None, ItemID.None, "Vanilla:Wizard"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.TurtleHelmet, ItemID.None, ItemID.None, "Vanilla:Turtle"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.MeteorHelmet, ItemID.None, ItemID.None, "Vanilla:Meteor"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.SpectreHood, ItemID.None, ItemID.None, "Vanilla:SpectreHealing"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.ShroomiteHeadgear, ItemID.None, ItemID.None, "Vanilla:Shroomite"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.ShroomiteMask, ItemID.None, ItemID.None, "Vanilla:Shroomite"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.ShroomiteHelmet, ItemID.None, ItemID.None, "Vanilla:Shroomite"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.PlatinumHelmet, ItemID.None, ItemID.None, "Vanilla:Platinum"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.PumpkinHelmet, ItemID.None, ItemID.None, "Vanilla:Pumpkin"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.SpookyHelmet, ItemID.None, ItemID.None, "Vanilla:Spooky"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.SpectreMask, ItemID.None, ItemID.None, "Vanilla:SpectreDamage"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.MagicHat, ItemID.None, ItemID.None, "Vanilla:MagicHat"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.BeetleShell, ItemID.None, ItemID.None, "Vanilla:BeetleDefense"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.BeetleScaleMail, ItemID.None, ItemID.None, "Vanilla:BeetleDamage"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.BeeHeadgear, ItemID.None, ItemID.None, "Vanilla:Bee"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.NecroHelmet, ItemID.None, ItemID.None, "Vanilla:Bone"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.AncientNecroHelmet, ItemID.None, ItemID.None, "Vanilla:Bone"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.SpiderMask, ItemID.None, ItemID.None, "Vanilla:Spider"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.NinjaHood, ItemID.None, ItemID.None, "Vanilla:Ninja"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.FossilHelm, ItemID.None, ItemID.None, "Vanilla:Fossil"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.SolarFlareHelmet, ItemID.None, ItemID.None, "Vanilla:Solar"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.VortexHelmet, ItemID.None, ItemID.None, "Vanilla:Vortex"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.NebulaHelmet, ItemID.None, ItemID.None, "Vanilla:Nebula"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.StardustHelmet, ItemID.None, ItemID.None, "Vanilla:Stardust"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.AncientBattleArmorHat, ItemID.None, ItemID.None, "Vanilla:Forbidden"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.AncientCobaltHelmet, ItemID.None, ItemID.None, "Vanilla:Jungle"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.JungleHat, ItemID.None, ItemID.None, "Vanilla:Jungle"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.MoltenHelmet, ItemID.None, ItemID.None, "Vanilla:Molten"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.MiningHelmet, ItemID.None, ItemID.None, "Vanilla:Mining"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.CobaltHat, ItemID.None, ItemID.None, "Vanilla:CobaltCaster"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.CobaltHelmet, ItemID.None, ItemID.None, "Vanilla:CobaltMelee"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.ApprenticeHat, ItemID.None, ItemID.None, "Vanilla:ApprenticeTier2"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.ApprenticeAltHead, ItemID.None, ItemID.None, "Vanilla:ApprenticeTier3"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.HuntressWig, ItemID.None, ItemID.None, "Vanilla:HuntressTier2"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.HuntressAltHead, ItemID.None, ItemID.None, "Vanilla:HuntressTier3"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.MonkBrows, ItemID.None, ItemID.None, "Vanilla:MonkTier2"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.MonkAltHead, ItemID.None, ItemID.None, "Vanilla:MonkTier3"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.SquireGreatHelm, ItemID.None, ItemID.None, "Vanilla:SquireTier2"));
            VanillaArmorSets.Add(new ArmorSetInfo(ItemID.SquireAltHead, ItemID.None, ItemID.None, "Vanilla:SquireTier3"));
        }
    }
}