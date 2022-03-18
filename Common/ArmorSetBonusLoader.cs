using System.Collections.Generic;
using CalamityRuTranslate.Common.DataStructures;
using CalamityRuTranslate.Core;
using Terraria.ID;

namespace CalamityRuTranslate.Common
{
    public class ArmorSetBonusLoader : ILoadable
    {
        public static List<ArmorSetData> CalamityArmorSets = new List<ArmorSetData>();
        public static List<ArmorSetData> FargoSoulsArmorSets = new List<ArmorSetData>();
        public static List<ArmorSetData> VanillaArmorSets = new List<ArmorSetData>();

        public float Priority => 1f;

        public void Load()
        {
            VanillaArmorSetsInfo();
            CalamityArmorSetInfo();
            FargoSoulsArmorSetInfo();
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
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("ForbiddenCirclet"), ItemID.AncientBattleArmorShirt, ItemID.AncientBattleArmorPants, "AncientForbiddenCirclet"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("ShroomiteVisage"), ItemID.ShroomiteBreastplate, ItemID.ShroomiteLeggings, "Shroomite"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AerospecHat"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecMagic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AerospecHeadgear"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecRogue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AerospecHelm"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecMelee"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AerospecHelmet"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecSummoner"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AerospecHood"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecRanged"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AstralHelm"), ModsCall.Calamity.ItemType("AstralBreastplate"), ModsCall.Calamity.ItemType("AstralLeggings"), "Astral"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AtaxiaHeadgear"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaRanged"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AtaxiaHelm"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaMelee"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AtaxiaHelmet"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaSummoner"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AtaxiaHood"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaRogue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AtaxiaMask"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaMagic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AuricTeslaHelm"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaMelee"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AuricTeslaHoodedFacemask"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaRanged"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AuricTeslaPlumedHelm"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaRogue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AuricTeslaSpaceHelmet"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaSummoner"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("AuricTeslaWireHemmedVisage"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaMagic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("BloodflareHelm"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareRogue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("BloodflareHelmet"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareSummoner"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("BloodflareHornedHelm"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareRanged"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("BloodflareHornedMask"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareMagic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("BloodflareMask"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareMelee"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("BrimflameScowl"), ModsCall.Calamity.ItemType("BrimflameRobes"), ModsCall.Calamity.ItemType("BrimflameBoots"), "Brimflame"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("DaedalusHat"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusMagic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("DaedalusHeadgear"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusSummoner"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("DaedalusHelm"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusMelee"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("DaedalusHelmet"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusRanged"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("DaedalusVisor"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusRogue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("DemonshadeHelm"), ModsCall.Calamity.ItemType("DemonshadeBreastplate"), ModsCall.Calamity.ItemType("DemonshadeGreaves"), "Demonshade"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("DesertProwlerHat"), ModsCall.Calamity.ItemType("DesertProwlerShirt"), ModsCall.Calamity.ItemType("DesertProwlerPants"), "DesertProwler"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("FearmongerGreathelm"), ModsCall.Calamity.ItemType("FearmongerPlateMail"), ModsCall.Calamity.ItemType("FearmongerGreaves"), "Fearmonger"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("FathomSwarmerVisage"), ModsCall.Calamity.ItemType("FathomSwarmerBreastplate"), ModsCall.Calamity.ItemType("FathomSwarmerBoots"), "FathomSwarmer"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("GodSlayerHelm"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerMelee"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("GodSlayerHelmet"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerRanged"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("GodSlayerMask"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerRogue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("MolluskShellmet"), ModsCall.Calamity.ItemType("MolluskShellplate"), ModsCall.Calamity.ItemType("MolluskShelleggings"), "Mollusk"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("OmegaBlueHelmet"), ModsCall.Calamity.ItemType("OmegaBlueChestplate"), ModsCall.Calamity.ItemType("OmegaBlueLeggings"), "OmegaBlue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("PlagueReaperMask"), ModsCall.Calamity.ItemType("PlagueReaperVest"), ModsCall.Calamity.ItemType("PlagueReaperStriders"), "PlagueReaper"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("PrismaticHelmet"), ModsCall.Calamity.ItemType("PrismaticRegalia"), ModsCall.Calamity.ItemType("PrismaticGreaves"), "Prismatic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("PlaguebringerVisor"), ModsCall.Calamity.ItemType("PlaguebringerCarapace"), ModsCall.Calamity.ItemType("PlaguebringerPistons"), "Plaguebringer"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("ReaverHeadgear"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverExplorer"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("ReaverHelm"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverDefenser"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("ReaverVisage"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverSpeeder"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("SilvaHelmet"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaSummoner"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("SilvaMaskedCap"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaMagic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("SnowRuffianMask"), ModsCall.Calamity.ItemType("SnowRuffianChestplate"), ModsCall.Calamity.ItemType("SnowRuffianGreaves"), "SnowRuffian"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("StatigelCap"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelMagic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("StatigelHeadgear"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelRanged"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("StatigelHelm"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelMelee"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("StatigelHood"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelSummoner"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("StatigelMask"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelRogue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("SulfurHelmet"), ModsCall.Calamity.ItemType("SulfurBreastplate"), ModsCall.Calamity.ItemType("SulfurLeggings"), "Sulfur"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("TarragonHelm"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonMelee"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("TarragonHelmet"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonRogue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("TarragonHornedHelm"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonSummoner"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("TarragonMask"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonMagic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("TarragonVisage"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonRanged"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("TitanHeartMask"), ModsCall.Calamity.ItemType("TitanHeartMantle"), ModsCall.Calamity.ItemType("TitanHeartBoots"), "TitanHeart"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("UmbraphileHood"), ModsCall.Calamity.ItemType("UmbraphileRegalia"), ModsCall.Calamity.ItemType("UmbraphileBoots"), "Umbraphile"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("VictideHeadgear"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideRogue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("VictideHelm"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideMelee"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("VictideHelmet"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideSummoner"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("VictideMask"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideMagic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("VictideVisage"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideRanged"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("WulfrumHeadgear"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumRanged"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("WulfrumHelm"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumMelee"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("WulfrumHelmet"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumSummoner"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("WulfrumHood"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumMagic"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("WulfrumMask"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumRogue"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("XerocMask"), ModsCall.Calamity.ItemType("XerocPlateMail"), ModsCall.Calamity.ItemType("XerocCuisses"), "Xeroc"));
            CalamityArmorSets.Add(new ArmorSetData(ModsCall.Calamity.ItemType("GemTechHeadgear"), ModsCall.Calamity.ItemType("GemTechBodyArmor"), ModsCall.Calamity.ItemType("GemTechSchynbaulds"), "GemTech"));
        }
        
        private static void FargoSoulsArmorSetInfo()
        {
            if (ModsCall.FargoSouls == null)
                return;

            FargoSoulsArmorSets.Add(new ArmorSetData(ModsCall.FargoSouls.ItemType("EridanusHat"), ModsCall.FargoSouls.ItemType("EridanusBattleplate"), ModsCall.FargoSouls.ItemType("EridanusLegwear"), "EridanusHat"));
            FargoSoulsArmorSets.Add(new ArmorSetData(ModsCall.FargoSouls.ItemType("GaiaHelmet"), ModsCall.FargoSouls.ItemType("GaiaPlate"), ModsCall.FargoSouls.ItemType("GaiaGreaves"), "GaiaHelmet"));
            FargoSoulsArmorSets.Add(new ArmorSetData(ModsCall.FargoSouls.ItemType("MutantMask"), ModsCall.FargoSouls.ItemType("MutantBody"), ModsCall.FargoSouls.ItemType("MutantPants"), "MutantMask"));
            FargoSoulsArmorSets.Add(new ArmorSetData(ModsCall.FargoSouls.ItemType("StyxCrown"), ModsCall.FargoSouls.ItemType("StyxChestplate"), ModsCall.FargoSouls.ItemType("StyxLeggings"), "StyxCrown"));
        }

        private static void VanillaArmorSetsInfo()
        {
            VanillaArmorSets.Add(new ArmorSetData(ItemID.CopperHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier1"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.IronHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier1"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.AncientIronHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier1"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.TinHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier1"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.SilverHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier2"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.AncientGoldHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier2"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.GoldHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier2"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.LeadHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier2"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.TungstenHelmet, ItemID.None, ItemID.None, "Vanilla:MetalTier2"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.CobaltMask, ItemID.None, ItemID.None, "Vanilla:CobaltRanged"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.MythrilHood, ItemID.None, ItemID.None, "Vanilla:MythrilCaster"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.MythrilHelmet, ItemID.None, ItemID.None, "Vanilla:MythrilMelee"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.MythrilHat, ItemID.None, ItemID.None, "Vanilla:MythrilRanged"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.AdamantiteHeadgear, ItemID.None, ItemID.None, "Vanilla:AdamantiteCaster"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.AdamantiteHelmet, ItemID.None, ItemID.None, "Vanilla:AdamantiteMelee"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.AdamantiteMask, ItemID.None, ItemID.None, "Vanilla:AdamantiteRanged"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.HallowedHeadgear, ItemID.None, ItemID.None, "Vanilla:HallowCaster"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.HallowedMask, ItemID.None, ItemID.None, "Vanilla:HallowMelee"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.HallowedHelmet, ItemID.None, ItemID.None, "Vanilla:HallowRanged"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.ShadowHelmet, ItemID.None, ItemID.None, "Vanilla:ShadowScale"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.AncientShadowHelmet, ItemID.None, ItemID.None, "Vanilla:ShadowScale"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.WoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.EbonwoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.RichMahoganyHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.PearlwoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.CactusHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.ShadewoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.BorealWoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.PalmWoodHelmet, ItemID.None, ItemID.None, "Vanilla:Wood"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.CrimsonHelmet, ItemID.None, ItemID.None, "Vanilla:Crimson"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.FrostHelmet, ItemID.None, ItemID.None, "Vanilla:Frost"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.TikiMask, ItemID.None, ItemID.None, "Vanilla:Tiki"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.PalladiumMask, ItemID.None, ItemID.None, "Vanilla:Palladium"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.PalladiumHelmet, ItemID.None, ItemID.None, "Vanilla:Palladium"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.PalladiumHeadgear, ItemID.None, ItemID.None, "Vanilla:Palladium"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.OrichalcumMask, ItemID.None, ItemID.None, "Vanilla:Orichalcum"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.OrichalcumHelmet, ItemID.None, ItemID.None, "Vanilla:Orichalcum"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.OrichalcumHeadgear, ItemID.None, ItemID.None, "Vanilla:Orichalcum"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.TitaniumMask, ItemID.None, ItemID.None, "Vanilla:Titanium"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.TitaniumHelmet, ItemID.None, ItemID.None, "Vanilla:Titanium"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.TitaniumHeadgear, ItemID.None, ItemID.None, "Vanilla:Titanium"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.ChlorophyteMask, ItemID.None, ItemID.None, "Vanilla:Chlorophyte"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.ChlorophyteHelmet, ItemID.None, ItemID.None, "Vanilla:Chlorophyte"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.ChlorophyteHeadgear, ItemID.None, ItemID.None, "Vanilla:Chlorophyte"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.WizardHat, ItemID.None, ItemID.None, "Vanilla:Wizard"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.TurtleHelmet, ItemID.None, ItemID.None, "Vanilla:Turtle"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.MeteorHelmet, ItemID.None, ItemID.None, "Vanilla:Meteor"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.SpectreHood, ItemID.None, ItemID.None, "Vanilla:SpectreHealing"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.ShroomiteHeadgear, ItemID.None, ItemID.None, "Vanilla:Shroomite"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.ShroomiteMask, ItemID.None, ItemID.None, "Vanilla:Shroomite"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.ShroomiteHelmet, ItemID.None, ItemID.None, "Vanilla:Shroomite"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.PlatinumHelmet, ItemID.None, ItemID.None, "Vanilla:Platinum"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.PumpkinHelmet, ItemID.None, ItemID.None, "Vanilla:Pumpkin"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.SpookyHelmet, ItemID.None, ItemID.None, "Vanilla:Spooky"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.SpectreMask, ItemID.None, ItemID.None, "Vanilla:SpectreDamage"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.MagicHat, ItemID.None, ItemID.None, "Vanilla:MagicHat"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.BeetleShell, ItemID.None, ItemID.None, "Vanilla:BeetleDefense"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.BeetleScaleMail, ItemID.None, ItemID.None, "Vanilla:BeetleDamage"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.BeeHeadgear, ItemID.None, ItemID.None, "Vanilla:Bee"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.NecroHelmet, ItemID.None, ItemID.None, "Vanilla:Bone"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.AncientNecroHelmet, ItemID.None, ItemID.None, "Vanilla:Bone"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.SpiderMask, ItemID.None, ItemID.None, "Vanilla:Spider"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.NinjaHood, ItemID.None, ItemID.None, "Vanilla:Ninja"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.FossilHelm, ItemID.None, ItemID.None, "Vanilla:Fossil"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.SolarFlareHelmet, ItemID.None, ItemID.None, "Vanilla:Solar"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.VortexHelmet, ItemID.None, ItemID.None, "Vanilla:Vortex"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.NebulaHelmet, ItemID.None, ItemID.None, "Vanilla:Nebula"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.StardustHelmet, ItemID.None, ItemID.None, "Vanilla:Stardust"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.AncientBattleArmorHat, ItemID.None, ItemID.None, "Vanilla:Forbidden"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.AncientCobaltHelmet, ItemID.None, ItemID.None, "Vanilla:Jungle"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.JungleHat, ItemID.None, ItemID.None, "Vanilla:Jungle"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.MoltenHelmet, ItemID.None, ItemID.None, "Vanilla:Molten"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.MiningHelmet, ItemID.None, ItemID.None, "Vanilla:Mining"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.CobaltHat, ItemID.None, ItemID.None, "Vanilla:CobaltCaster"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.CobaltHelmet, ItemID.None, ItemID.None, "Vanilla:CobaltMelee"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.ApprenticeHat, ItemID.None, ItemID.None, "Vanilla:ApprenticeTier2"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.ApprenticeAltHead, ItemID.None, ItemID.None, "Vanilla:ApprenticeTier3"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.HuntressWig, ItemID.None, ItemID.None, "Vanilla:HuntressTier2"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.HuntressAltHead, ItemID.None, ItemID.None, "Vanilla:HuntressTier3"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.MonkBrows, ItemID.None, ItemID.None, "Vanilla:MonkTier2"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.MonkAltHead, ItemID.None, ItemID.None, "Vanilla:MonkTier3"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.SquireGreatHelm, ItemID.None, ItemID.None, "Vanilla:SquireTier2"));
            VanillaArmorSets.Add(new ArmorSetData(ItemID.SquireAltHead, ItemID.None, ItemID.None, "Vanilla:SquireTier3"));
        }
    }
}