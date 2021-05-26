using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.Localization;

namespace CalamityRuTranslate.Common
{
    public static class GlobalArmorSetBonus
    {
        public static List<ArmorSetInfo> ListOfArmorSet
        {
            get
            {
                var getArmorSetInfo = new List<ArmorSetInfo>();
        
                getArmorSetInfo.AddRange(ArmorSetBonusLoader.VanillaArmorSets);
                
                if (ModsCall.Calamity != null)
                    getArmorSetInfo.AddRange(ArmorSetBonusLoader.CalamityArmorSets);
        
                if (ModsCall.FargoSouls != null)
                    getArmorSetInfo.AddRange(ArmorSetBonusLoader.FargoSoulsArmorSets);
                
                return getArmorSetInfo;
            }
        }

        public static string GetCalamityArmorSetBonusByName(string set)
        {
            switch (set)
            {
                case "Obsidian":
                    return LangUtils.GetTextValue("Calamity", $"SetBonus.{set}") + (TRuConfig.Instance.CalamityStealthDescription ? LangUtils.GetTextValue("Calamity", "SetBonus.Stealth") : "") + (ModsCall.DeathMode ? LangUtils.GetTextValue("Calamity", "DeathMode.Heat") : "");

                case "Fearmonger":
                case "Eskimo":
                    return LangUtils.GetTextValue("Calamity", $"SetBonus.{set}") + (ModsCall.DeathMode ? LangUtils.GetTextValue("Calamity", "DeathMode.Cold") : "");

                case "AerospecRogue":
                case "Gladiator":
                case "VictideRogue":
                case "AtaxiaRogue":
                case "AuricTeslaRogue":
                case "BloodflareRogue":
                case "DaedalusRogue":
                case "GodSlayerRogue":
                case "StatigelRogue":
                case "Xeroc":
                case "ReaverRogue":
                case "SnowRuffian":
                case "TitanHeart":
                case "Umbraphile":
                case "WulfrumRogue":
                case "TarragonRogue":
                case "SilvaRogue":
                    return LangUtils.GetTextValue("Calamity", $"SetBonus.{set}") + (TRuConfig.Instance.CalamityStealthDescription ? LangUtils.GetTextValue("Calamity", "SetBonus.Stealth") : "");

                case "AncientForbiddenCirclet":
                    return LangUtils.GetTextValue("Calamity", $"SetBonus.{set}", ModsCall.ArmorSetHotkey, ModsCall.AncientStorm) + (TRuConfig.Instance.CalamityStealthDescription ? LangUtils.GetTextValue("Calamity", "SetBonus.Stealth") : "");

                case "TarragonMelee":
                case "Brimflame":
                case "Demonshade":
                case "OmegaBlue":
                case "PlagueReaper":
                case "Prismatic":
                    return LangUtils.GetTextValue("Calamity", $"SetBonus.{set}", ModsCall.ArmorSetHotkey);

                case "Shroomite":
                case "AerospecMagic":
                case "AerospecMelee":
                case "AerospecSummoner":
                case "AerospecRanged":
                case "Astral":
                case "AtaxiaRanged":
                case "AtaxiaMelee":
                case "AtaxiaSummoner":
                case "AtaxiaMagic":
                case "AuricTeslaMelee":
                case "AuricTeslaRanged":
                case "AuricTeslaSummoner":
                case "AuricTeslaMagic":
                case "BloodflareSummoner":
                case "BloodflareRanged":
                case "BloodflareMagic":
                case "BloodflareMelee":
                case "DaedalusMagic":
                case "DaedalusSummoner":
                case "DaedalusMelee":
                case "DaedalusRanged":
                case "DesertProwler":
                case "FathomSwarmer":
                case "GodSlayerMelee":
                case "GodSlayerRanged":
                case "GodSlayerSummoner":
                case "GodSlayerMagic":
                case "Mollusk":
                case "Plaguebringer":
                case "ReaverMelee":
                case "ReaverSummoner":
                case "ReaverMagic":
                case "ReaverRanged":
                case "SilvaMelee":
                case "SilvaSummoner":
                case "SilvaRanged":
                case "SilvaMagic":
                case "StatigelMagic":
                case "StatigelRanged":
                case "StatigelMelee":
                case "StatigelSummoner":
                case "Sulfur":
                case "TarragonSummoner":
                case "TarragonMagic":
                case "TarragonRanged":
                case "VictideMelee":
                case "VictideSummoner":
                case "VictideMagic":
                case "VictideRanged":
                case "WulfrumRanged":
                case "WulfrumMelee":
                case "WulfrumSummoner":
                case "WulfrumMagic":
                    return LangUtils.GetTextValue("Calamity", $"SetBonus.{set}");
            }

            return "";
        }

        public static string GetFargoSoulsArmorSetBonusByName(string set)
        {
            switch (set)
            {
                case "EridanusHat":
                case "GaiaHelmet":
                case "MutantMask":
                    return LangUtils.GetTextValue("FargoSouls", $"SetBonus.{set}");
            }

            return "";
        }

        public static string GetVanillaArmorSetBonusByName(string set)
        {
            switch (set)
            {
                case "Vanilla:MetalTier1":
                    return Language.GetTextValue("ArmorSetBonus.MetalTier1");
                case "Vanilla:MetalTier2":
                    return Language.GetTextValue("ArmorSetBonus.MetalTier2");
                case "Vanilla:CobaltRanged":
                    return Language.GetTextValue("ArmorSetBonus.CobaltRanged");
                case "Vanilla:MythrilCaster":
                    return Language.GetTextValue("ArmorSetBonus.MythrilCaster");
                case "Vanilla:MythrilMelee":
                    return Language.GetTextValue("ArmorSetBonus.MythrilMelee");
                case "Vanilla:MythrilRanged":
                    return Language.GetTextValue("ArmorSetBonus.MythrilRanged");
                case "Vanilla:AdamantiteCaster":
                    return Language.GetTextValue("ArmorSetBonus.AdamantiteCaster");
                case "Vanilla:AdamantiteMelee":
                    return Language.GetTextValue("ArmorSetBonus.AdamantiteMelee");
                case "Vanilla:AdamantiteRanged":
                    return Language.GetTextValue("ArmorSetBonus.AdamantiteRanged");
                case "Vanilla:HallowCaster":
                    return Language.GetTextValue("ArmorSetBonus.HallowCaster");
                case "Vanilla:HallowMelee":
                    return Language.GetTextValue("ArmorSetBonus.HallowMelee");
                case "Vanilla:HallowRanged":
                    return Language.GetTextValue("ArmorSetBonus.HallowRanged");
                case "Vanilla:ShadowScale":
                    return Language.GetTextValue("ArmorSetBonus.ShadowScale");
                case "Vanilla:Wood":
                    return Language.GetTextValue("ArmorSetBonus.Wood");
                case "Vanilla:Crimson":
                    return Language.GetTextValue("ArmorSetBonus.Crimson");
                case "Vanilla:Frost":
                    return Language.GetTextValue("ArmorSetBonus.Frost");
                case "Vanilla:Tiki":
                    return Language.GetTextValue("ArmorSetBonus.Tiki");
                case "Vanilla:Palladium":
                    return Language.GetTextValue("ArmorSetBonus.Palladium");
                case "Vanilla:Orichalcum":
                    return Language.GetTextValue("ArmorSetBonus.Orichalcum");
                case "Vanilla:Titanium":
                    return Language.GetTextValue("ArmorSetBonus.Titanium");
                case "Vanilla:Chlorophyte":
                    return Language.GetTextValue("ArmorSetBonus.Chlorophyte");
                case "Vanilla:Wizard":
                    return Language.GetTextValue("ArmorSetBonus.Wizard");
                case "Vanilla:Turtle":
                    return Language.GetTextValue("ArmorSetBonus.Turtle");
                case "Vanilla:Meteor":
                    return Language.GetTextValue("ArmorSetBonus.Meteor");
                case "Vanilla:SpectreHealing":
                    return Language.GetTextValue("ArmorSetBonus.SpectreHealing");
                case "Vanilla:Shroomite":
                    return Language.GetTextValue("ArmorSetBonus.Shroomite");
                case "Vanilla:Platinum":
                    return Language.GetTextValue("ArmorSetBonus.Platinum");
                case "Vanilla:Pumpkin":
                    return Language.GetTextValue("ArmorSetBonus.Pumpkin");
                case "Vanilla:Spooky":
                    return Language.GetTextValue("ArmorSetBonus.Spooky");
                case "Vanilla:SpectreDamage":
                    return Language.GetTextValue("ArmorSetBonus.SpectreDamage");
                case "Vanilla:MagicHat":
                    return Language.GetTextValue("ArmorSetBonus.MagicHat");
                case "Vanilla:BeetleDefense":
                    return Language.GetTextValue("ArmorSetBonus.BeetleDefense");
                case "Vanilla:BeetleDamage":
                    return Language.GetTextValue("ArmorSetBonus.BeetleDamage");
                case "Vanilla:Bee":
                    return Language.GetTextValue("ArmorSetBonus.Bee");
                case "Vanilla:Bone":
                    return Language.GetTextValue("ArmorSetBonus.Bone");
                case "Vanilla:Spider":
                    return Language.GetTextValue("ArmorSetBonus.Spider");
                case "Vanilla:Ninja":
                    return Language.GetTextValue("ArmorSetBonus.Ninja");
                case "Vanilla:Fossil":
                    return Language.GetTextValue("ArmorSetBonus.Fossil");
                case "Vanilla:Solar":
                    return Language.GetTextValue("ArmorSetBonus.Solar");
                case "Vanilla:Vortex":
                    return Language.GetTextValue("ArmorSetBonus.Vortex", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
                case "Vanilla:Nebula":
                    return Language.GetTextValue("ArmorSetBonus.Nebula");
                case "Vanilla:Stardust":
                    return Language.GetTextValue("ArmorSetBonus.Stardust", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
                case "Vanilla:Forbidden":
                    return Language.GetTextValue("ArmorSetBonus.Forbidden", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
                case "Vanilla:Jungle":
                    return Language.GetTextValue("ArmorSetBonus.Jungle");
                case "Vanilla:Molten":
                    return Language.GetTextValue("ArmorSetBonus.Molten");
                case "Vanilla:Mining":
                    return Language.GetTextValue("ArmorSetBonus.Mining");
                case "Vanilla:CobaltCaster":
                    return Language.GetTextValue("ArmorSetBonus.CobaltCaster");
                case "Vanilla:CobaltMelee":
                    return Language.GetTextValue("ArmorSetBonus.CobaltMelee");
                case "Vanilla:ApprenticeTier2":
                    return Language.GetTextValue("ArmorSetBonus.ApprenticeTier2");
                case "Vanilla:ApprenticeTier3":
                    return Language.GetTextValue("ArmorSetBonus.ApprenticeTier3");
                case "Vanilla:HuntressTier2":
                    return Language.GetTextValue("ArmorSetBonus.HuntressTier2");
                case "Vanilla:HuntressTier3":
                    return Language.GetTextValue("ArmorSetBonus.HuntressTier3");
                case "Vanilla:MonkTier2":
                    return Language.GetTextValue("ArmorSetBonus.MonkTier2");
                case "Vanilla:MonkTier3":
                    return Language.GetTextValue("ArmorSetBonus.MonkTier3");
                case "Vanilla:SquireTier2":
                    return Language.GetTextValue("ArmorSetBonus.SquireTier2");
                case "Vanilla:SquireTier3":
                    return Language.GetTextValue("ArmorSetBonus.SquireTier3");
            }

            return "";
        }

        public static string GetArmorSetName(int itemType, List<ArmorSetInfo> armorSetInfo)
        {
            foreach (ArmorSetInfo armorSet in armorSetInfo)
            {
                if (armorSet.CheckHeadOfArmorSet(itemType, out string name))
                    return name;
            }

            return default;
        }

        public static bool CheckArmorSetHead(int headType, List<ArmorSetInfo> armorSetInfo)
        {
            return armorSetInfo.Any(armorSet => armorSet.CheckHeadOfArmorSet(headType, out string _));
        }
    }
}