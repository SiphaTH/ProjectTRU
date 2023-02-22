using System.Collections.Generic;
using CalamityRuTranslate.Common.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common;

public class ArmorSetBonusLoader : ILoadable
{
    internal static readonly List<ArmorSetData> CalamityArmorSets = new();
    internal static readonly List<ArmorSetData> FargowiltasSoulsArmorSets = new();

    public void Load(Mod mod)
    {
        if (ModsCall.Calamity != null)
        {
            CalamityArmorSetInfo();
        }

        if (ModsCall.FargoSouls != null)
        {
            FargowiltasSoulsArmorSetInfo();
        }
    }

    public void Unload()
    {
        CalamityArmorSets.Clear();
        FargowiltasSoulsArmorSets.Clear();
    }
        
    private void CalamityArmorSetInfo()
    {
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod","ForbiddenCirclet").Type,
            ItemID.AncientBattleArmorShirt,
            ItemID.AncientBattleArmorPants,
            "AncientForbiddenCirclet")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AerospecHat").Type,
            ModContent.Find<ModItem>("CalamityMod", "AerospecBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "AerospecLeggings").Type,
            "AerospecMagic"));
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AerospecHeadgear").Type,
            ModContent.Find<ModItem>("CalamityMod", "AerospecBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "AerospecLeggings").Type,
            "AerospecRogue")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AerospecHelm").Type,
            ModContent.Find<ModItem>("CalamityMod", "AerospecBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "AerospecLeggings").Type,
            "AerospecMelee")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AerospecHelmet").Type,
            ModContent.Find<ModItem>("CalamityMod", "AerospecBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "AerospecLeggings").Type,
            "AerospecSummoner")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AerospecHood").Type,
            ModContent.Find<ModItem>("CalamityMod", "AerospecBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "AerospecLeggings").Type,
            "AerospecRanged")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AstralHelm").Type,
            ModContent.Find<ModItem>("CalamityMod", "AstralBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "AstralLeggings").Type,
            "Astral")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaRoyalHelm").Type,
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaCuisses").Type,
            "AuricTeslaMelee")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaHoodedFacemask").Type,
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaCuisses").Type,
            "AuricTeslaRanged")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaPlumedHelm").Type,
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaCuisses").Type,
            "AuricTeslaRogue")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaSpaceHelmet").Type,
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaCuisses").Type,
            "AuricTeslaSummoner")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaWireHemmedVisage").Type,
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "AuricTeslaCuisses").Type,
            "AuricTeslaMagic")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "BloodflareHeadRogue").Type,
            ModContent.Find<ModItem>("CalamityMod", "BloodflareBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "BloodflareCuisses").Type,
            "BloodflareRogue")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "BloodflareHeadSummon").Type,
            ModContent.Find<ModItem>("CalamityMod", "BloodflareBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "BloodflareCuisses").Type,
            "BloodflareSummoner")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "BloodflareHeadRanged").Type,
            ModContent.Find<ModItem>("CalamityMod", "BloodflareBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "BloodflareCuisses").Type,
            "BloodflareRanged")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "BloodflareHeadMagic").Type,
            ModContent.Find<ModItem>("CalamityMod", "BloodflareBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "BloodflareCuisses").Type,
            "BloodflareMagic")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "BloodflareHeadMelee").Type,
            ModContent.Find<ModItem>("CalamityMod", "BloodflareBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "BloodflareCuisses").Type,
            "BloodflareMelee")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "BrimflameScowl").Type,
            ModContent.Find<ModItem>("CalamityMod", "BrimflameRobes").Type,
            ModContent.Find<ModItem>("CalamityMod", "BrimflameBoots").Type,
            "Brimflame")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "DaedalusHeadMagic").Type,
            ModContent.Find<ModItem>("CalamityMod", "DaedalusBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "DaedalusLeggings").Type,
            "DaedalusMagic")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "DaedalusHeadSummon").Type,
            ModContent.Find<ModItem>("CalamityMod", "DaedalusBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "DaedalusLeggings").Type,
            "DaedalusSummoner")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "DaedalusHeadMelee").Type,
            ModContent.Find<ModItem>("CalamityMod", "DaedalusBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "DaedalusLeggings").Type,
            "DaedalusMelee")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "DaedalusHeadRanged").Type,
            ModContent.Find<ModItem>("CalamityMod", "DaedalusBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "DaedalusLeggings").Type,
            "DaedalusRanged")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "DaedalusHeadRogue").Type,
            ModContent.Find<ModItem>("CalamityMod", "DaedalusBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "DaedalusLeggings").Type,
            "DaedalusRogue")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "DemonshadeHelm").Type,
            ModContent.Find<ModItem>("CalamityMod", "DemonshadeBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "DemonshadeGreaves").Type,
            "Demonshade")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "DesertProwlerHat").Type,
            ModContent.Find<ModItem>("CalamityMod", "DesertProwlerShirt").Type,
            ModContent.Find<ModItem>("CalamityMod", "DesertProwlerPants").Type,
            "DesertProwler")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "EmpyreanMask").Type,
            ModContent.Find<ModItem>("CalamityMod", "EmpyreanCloak").Type,
            ModContent.Find<ModItem>("CalamityMod", "EmpyreanCuisses").Type,
            "Empyrean")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "FathomSwarmerVisage").Type,
            ModContent.Find<ModItem>("CalamityMod", "FathomSwarmerBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "FathomSwarmerBoots").Type,
            "FathomSwarmer")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "FearmongerGreathelm").Type,
            ModContent.Find<ModItem>("CalamityMod", "FearmongerPlateMail").Type,
            ModContent.Find<ModItem>("CalamityMod", "FearmongerGreaves").Type,
            "Fearmonger")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "GemTechHeadgear").Type,
            ModContent.Find<ModItem>("CalamityMod", "GemTechBodyArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "GemTechSchynbaulds").Type,
            "GemTech")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "GodSlayerHeadMelee").Type,
            ModContent.Find<ModItem>("CalamityMod", "GodSlayerChestplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "GodSlayerLeggings").Type,
            "GodSlayerMelee")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "GodSlayerHeadRanged").Type,
            ModContent.Find<ModItem>("CalamityMod", "GodSlayerChestplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "GodSlayerLeggings").Type,
            "GodSlayerRanged")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "GodSlayerHeadRogue").Type,
            ModContent.Find<ModItem>("CalamityMod", "GodSlayerChestplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "GodSlayerLeggings").Type,
            "GodSlayerRogue")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicHeadRanged").Type,
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicSubligar").Type,
            "HydrothermicRanged")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicHeadMelee").Type,
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicSubligar").Type,
            "HydrothermicMelee")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicHeadSummon").Type,
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicSubligar").Type,
            "HydrothermicSummoner")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicHeadRogue").Type,
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicSubligar").Type,
            "HydrothermicRogue")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicHeadMagic").Type,
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "HydrothermicSubligar").Type,
            "HydrothermicMagic")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "MolluskShellmet").Type,
            ModContent.Find<ModItem>("CalamityMod", "MolluskShellplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "MolluskShelleggings").Type,
            "Mollusk")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "OmegaBlueHelmet").Type,
            ModContent.Find<ModItem>("CalamityMod", "OmegaBlueChestplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "OmegaBlueLeggings").Type,
            "OmegaBlue")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "PlaguebringerVisor").Type,
            ModContent.Find<ModItem>("CalamityMod", "PlaguebringerCarapace").Type,
            ModContent.Find<ModItem>("CalamityMod", "PlaguebringerPistons").Type,
            "Plaguebringer")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "PlagueReaperMask").Type,
            ModContent.Find<ModItem>("CalamityMod", "PlagueReaperVest").Type,
            ModContent.Find<ModItem>("CalamityMod", "PlagueReaperStriders").Type,
            "PlagueReaper")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "PrismaticHelmet").Type,
            ModContent.Find<ModItem>("CalamityMod", "PrismaticRegalia").Type,
            ModContent.Find<ModItem>("CalamityMod", "PrismaticGreaves").Type,
            "Prismatic")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "ReaverHeadExplore").Type,
            ModContent.Find<ModItem>("CalamityMod", "ReaverScaleMail").Type,
            ModContent.Find<ModItem>("CalamityMod", "ReaverCuisses").Type,
            "ReaverExplore")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "ReaverHeadMobility").Type,
            ModContent.Find<ModItem>("CalamityMod", "ReaverScaleMail").Type,
            ModContent.Find<ModItem>("CalamityMod", "ReaverCuisses").Type,
            "ReaverMobility")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "ReaverHeadTank").Type,
            ModContent.Find<ModItem>("CalamityMod", "ReaverScaleMail").Type,
            ModContent.Find<ModItem>("CalamityMod", "ReaverCuisses").Type,
            "ReaverTank")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "SilvaHeadMagic").Type,
            ModContent.Find<ModItem>("CalamityMod", "SilvaArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "SilvaLeggings").Type,
            "SilvaMagic")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "SilvaHelmet").Type,
            ModContent.Find<ModItem>("CalamityMod", "SilvaArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "SilvaLeggings").Type,
            "SilvaSummoner")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "SnowRuffianMask").Type,
            ModContent.Find<ModItem>("CalamityMod", "SnowRuffianChestplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "SnowRuffianGreaves").Type,
            "SnowRuffian")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "StatigelHeadMagic").Type,
            ModContent.Find<ModItem>("CalamityMod", "StatigelArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "StatigelGreaves").Type,
            "StatigelMagic")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "StatigelHeadMelee").Type,
            ModContent.Find<ModItem>("CalamityMod", "StatigelArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "StatigelGreaves").Type,
            "StatigelMelee")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "StatigelHeadRanged").Type,
            ModContent.Find<ModItem>("CalamityMod", "StatigelArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "StatigelGreaves").Type,
            "StatigelRanged")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "StatigelHeadRogue").Type,
            ModContent.Find<ModItem>("CalamityMod", "StatigelArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "StatigelGreaves").Type,
            "StatigelRogue")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "StatigelHeadSummon").Type,
            ModContent.Find<ModItem>("CalamityMod", "StatigelArmor").Type,
            ModContent.Find<ModItem>("CalamityMod", "StatigelGreaves").Type,
            "StatigelSummoner")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "SulphurousHelmet").Type,
            ModContent.Find<ModItem>("CalamityMod", "SulfurBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "SulfurLeggings").Type,
            "Sulphurous")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "TarragonHeadMagic").Type,
            ModContent.Find<ModItem>("CalamityMod", "TarragonBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "TarragonLeggings").Type,
            "TarragonMagic")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "TarragonHelm").Type,
            ModContent.Find<ModItem>("CalamityMod", "TarragonBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "TarragonLeggings").Type,
            "TarragonMelee")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "TarragonHeadRanged").Type,
            ModContent.Find<ModItem>("CalamityMod", "TarragonBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "TarragonLeggings").Type,
            "TarragonRanged")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "TarragonHeadRogue").Type,
            ModContent.Find<ModItem>("CalamityMod", "TarragonBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "TarragonLeggings").Type,
            "TarragonRogue")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "TarragonHeadSummon").Type,
            ModContent.Find<ModItem>("CalamityMod", "TarragonBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "TarragonLeggings").Type,
            "TarragonSummoner")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "TitanHeartMask").Type,
            ModContent.Find<ModItem>("CalamityMod", "TitanHeartMantle").Type,
            ModContent.Find<ModItem>("CalamityMod", "TitanHeartBoots").Type,
            "TitanHeart")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "UmbraphileHood").Type,
            ModContent.Find<ModItem>("CalamityMod", "UmbraphileRegalia").Type,
            ModContent.Find<ModItem>("CalamityMod", "UmbraphileBoots").Type,
            "Umbraphile")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "VictideHeadMagic").Type,
            ModContent.Find<ModItem>("CalamityMod", "VictideBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "VictideLeggings").Type,
            "VictideMagic")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "VictideHeadMelee").Type,
            ModContent.Find<ModItem>("CalamityMod", "VictideBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "VictideLeggings").Type,
            "VictideMelee")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "VictideHeadRanged").Type,
            ModContent.Find<ModItem>("CalamityMod", "VictideBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "VictideLeggings").Type,
            "VictideRanged")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "VictideHeadRogue").Type,
            ModContent.Find<ModItem>("CalamityMod", "VictideBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "VictideLeggings").Type,
            "VictideRogue")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "VictideHeadSummon").Type,
            ModContent.Find<ModItem>("CalamityMod", "VictideBreastplate").Type,
            ModContent.Find<ModItem>("CalamityMod", "VictideLeggings").Type,
            "VictideSummoner")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "WulfrumHat").Type,
            ModContent.Find<ModItem>("CalamityMod", "WulfrumJacket").Type,
            ModContent.Find<ModItem>("CalamityMod", "WulfrumOveralls").Type,
            "Wulfrum")
        );
        CalamityArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("CalamityMod", "MarniteArchitectHeadgear").Type,
            ModContent.Find<ModItem>("CalamityMod", "MarniteArchitectToga").Type,
            ItemID.None,
            "MarniteArchitect")
        );
    }

    private void FargowiltasSoulsArmorSetInfo()
    {
        FargowiltasSoulsArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("FargowiltasSouls","EridanusHat").Type,
            ModContent.Find<ModItem>("FargowiltasSouls","EridanusBattleplate").Type,
            ModContent.Find<ModItem>("FargowiltasSouls","EridanusLegwear").Type,
            "Eridanus")
        );
        FargowiltasSoulsArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("FargowiltasSouls","GaiaHelmet").Type,
            ModContent.Find<ModItem>("FargowiltasSouls","GaiaPlate").Type,
            ModContent.Find<ModItem>("FargowiltasSouls","GaiaGreaves").Type,
            "Gaia")
        );
        FargowiltasSoulsArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("FargowiltasSouls","MutantMask").Type,
            ModContent.Find<ModItem>("FargowiltasSouls","MutantBody").Type,
            ModContent.Find<ModItem>("FargowiltasSouls","MutantPants").Type,
            "Mutant")
        );
        FargowiltasSoulsArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("FargowiltasSouls","NekomiHood").Type,
            ModContent.Find<ModItem>("FargowiltasSouls","NekomiHoodie").Type,
            ModContent.Find<ModItem>("FargowiltasSouls","NekomiLeggings").Type,
            "Nekomi")
        );
        FargowiltasSoulsArmorSets.Add(new ArmorSetData(
            ModContent.Find<ModItem>("FargowiltasSouls","StyxCrown").Type,
            ModContent.Find<ModItem>("FargowiltasSouls","StyxChestplate").Type,
            ModContent.Find<ModItem>("FargowiltasSouls","StyxLeggings").Type,
            "Styx")
        );
    }
}