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
            case "AerospecRogue":
            case "AuricTeslaRogue":
            case "BloodflareRogue":
            case "Empyrean":
            case "DaedalusRogue":
            case "HydrothermicRogue":
            case "SnowRuffian":
            case "StatigelRogue":
            case "Sulphurous":
            case "TarragonRogue":
            case "TitanHeart":
            case "Umbraphile":
            case "VictideRogue":
            case "WulfrumRogue":
                return LangHelper.GetTextValue($"CalamityMod.Items.SetBonus.{set}") + (TRuConfig.Instance.CalamityArmorStealthDescription ? LangHelper.GetTextValue("CalamityMod.Misc.ArmorRogueStealthDescription") : "");

            case "AncientForbiddenCirclet":
                return LangHelper.GetTextValue($"CalamityMod.Items.SetBonus.{set}", ModsCall.SetBonusHotKey, (int)(60f * Main.player[Main.myPlayer].manaCost)) + (TRuConfig.Instance.CalamityArmorStealthDescription ? LangHelper.GetTextValue("CalamityMod.Misc.ArmorRogueStealthDescription") : "");

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
                 return LangHelper.GetTextValue($"CalamityMod.Items.SetBonus.{set}", ModsCall.GodSlayerDashHotKey);

            case "GodSlayerRogue":
                return LangHelper.GetTextValue($"CalamityMod.Items.SetBonus.{set}", ModsCall.GodSlayerDashHotKey) +
                       (TRuConfig.Instance.CalamityArmorStealthDescription ? LangHelper.GetTextValue("CalamityMod.Misc.ArmorRogueStealthDescription") : "");
            
            case "ShroomiteVisage":
            case "AerospecMagic":
            case "AerospecMelee":
            case "AerospecSummoner":
            case "AerospecRanged":
            case "Astral":
            case "AuricTeslaMelee":
            case "AuricTeslaRanged":
            case "AuricTeslaSummoner":
            case "AuricTeslaMagic":
            case "BloodflareSummoner":
            case "BloodflareMagic":
            case "BloodflareMelee":
            case "DaedalusMagic":
            case "DaedalusSummoner":
            case "DaedalusMelee":
            case "DaedalusRanged":
            case "DesertProwler":
            case "FathomSwarmer":
            case "Fearmonger":
            case "GemTech":
            case "HydrothermicRanged":
            case "HydrothermicMelee":
            case "HydrothermicSummoner":
            case "HydrothermicMagic":
            case "Mollusk":
            case "Plaguebringer":
            case "ReaverExplore":
            case "ReaverMobility":
            case "ReaverTank":
            case "SilvaMagic":
            case "SilvaSummoner":
            case "StatigelMagic":
            case "StatigelMelee":
            case "StatigelRanged":
            case "StatigelSummoner":
            case "TarragonMagic":
            case "TarragonRanged":
            case "TarragonSummoner":
            case "VictideMagic":
            case "VictideMelee":
            case "VictideRanged":
            case "VictideSummoner":
            case "WulfrumMagic":
            case "WulfrumMelee":
            case "WulfrumRanged":
            case "WulfrumSummoner":
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