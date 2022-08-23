using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.DataStructures;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.Localization;

namespace CalamityRuTranslate.Common;

internal static class GlobalArmorSetBonus
{
    internal static List<ArmorSetData> ListOfArmorSet
    {
        get
        {
            List<ArmorSetData> getArmorSetInfo = new List<ArmorSetData>();

            if (ModsCall.Calamity != null)
                getArmorSetInfo.AddRange(ArmorSetBonusLoader.CalamityArmorSets);
            if (ModsCall.FargoSouls != null)
                getArmorSetInfo.AddRange(ArmorSetBonusLoader.FargowiltasSoulsArmorSets);

            return getArmorSetInfo;
        }
    }

    internal static string GetCalamityArmorSetBonusByName(string set)
    {
        switch (set)
        {
            case "AncientForbiddenCirclet":
                return LangHelper.GetTextValue($"CalamityMod.Items.SetBonus.{set}", ModsCall.SetBonusHotKey, (int)(60f * Main.player[Main.myPlayer].manaCost));

            case "BloodflareRanged":
            case "Brimflame":
            case "Demonshade":
            case "OmegaBlue":
            case "PlagueReaper":
            case "Prismatic":
            case "TarragonMelee":
                return LangHelper.GetTextValue($"CalamityMod.Items.SetBonus.{set}", ModsCall.SetBonusHotKey);
            
            case "GodSlayerMelee":
            case "GodSlayerRanged":
            case "GodSlayerRogue":
                 return LangHelper.GetTextValue($"CalamityMod.Items.SetBonus.{set}", ModsCall.GodSlayerDashHotKey);

            case "ShroomiteVisage":
            case "AerospecMagic":
            case "AerospecMelee":
            case "AerospecSummoner":
            case "AerospecRanged":
            case "AerospecRogue":
            case "Astral":
            case "AuricTeslaMelee":
            case "AuricTeslaRanged":
            case "AuricTeslaSummoner":
            case "AuricTeslaMagic":
            case "AuricTeslaRogue":
            case "BloodflareSummoner":
            case "BloodflareMagic":
            case "BloodflareMelee":
            case "BloodflareRogue":
            case "DaedalusMagic":
            case "DaedalusSummoner":
            case "DaedalusMelee":
            case "DaedalusRanged":
            case "DaedalusRogue":
            case "DesertProwler":
            case "Empyrean":
            case "FathomSwarmer":
            case "Fearmonger":
            case "GemTech":
            case "HydrothermicRanged":
            case "HydrothermicMelee":
            case "HydrothermicSummoner":
            case "HydrothermicMagic":
            case "HydrothermicRogue":
            case "MarniteArchitect":
            case "Mollusk":
            case "Plaguebringer":
            case "ReaverExplore":
            case "ReaverMobility":
            case "ReaverTank":
            case "SilvaMagic":
            case "SilvaSummoner":
            case "SnowRuffian":
            case "StatigelMagic":
            case "StatigelMelee":
            case "StatigelRanged":
            case "StatigelSummoner":
            case "StatigelRogue":
            case "Sulphurous":
            case "TarragonMagic":
            case "TarragonRanged":
            case "TarragonSummoner":
            case "TarragonRogue":
            case "TitanHeart":
            case "Umbraphile":
            case "VictideMagic":
            case "VictideMelee":
            case "VictideRanged":
            case "VictideSummoner":
            case "VictideRogue":
            case "Wulfrum":
                return LangHelper.GetTextValue($"CalamityMod.Items.SetBonus.{set}");
        }

        return "";
    }

    internal static string GetFargowiltasSoulsArmorSetBonusByName(string set)
    {
        switch (set)
        {
            case "Nekomi":
            case "Gaia":
            case "Styx":
                return LangHelper.GetTextValue($"FargowiltasSouls.Items.SetBonus.{set}", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
            
            case "Eridanus":
            case "Mutant":
                return LangHelper.GetTextValue($"FargowiltasSouls.Items.SetBonus.{set}");
        }
        
        return "";
    }

    internal static string GetArmorSetName(int itemType, List<ArmorSetData> armorSetData)
    {
        foreach (ArmorSetData armorSet in armorSetData)
        {
            if (armorSet.CheckHeadOfArmorSet(itemType, out string name))
                return name;
        }

        return default;
    }

    internal static bool CheckArmorSetHead(int headType, List<ArmorSetData> armorSetData)
    {
        return armorSetData.Any(armorSet => armorSet.CheckHeadOfArmorSet(headType, out string _));
    }
}