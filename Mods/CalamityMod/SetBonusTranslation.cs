using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class SetBonusTranslation : CalamityCompatItem
    {
        private static readonly List<ArmorSetInfo> ArmorSets = new List<ArmorSetInfo>
        {
            new ArmorSetInfo(ItemID.ObsidianHelm, ItemID.ObsidianShirt, ItemID.ObsidianPants, "Obsidian"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("ForbiddenCirclet"), ItemID.AncientBattleArmorShirt, ItemID.AncientBattleArmorPants, "AncientForbiddenCirclet"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("ShroomiteVisage"), ItemID.ShroomiteBreastplate, ItemID.ShroomiteLeggings, "Shroomite"),
            
            new ArmorSetInfo(ItemID.GladiatorHelmet, ItemID.GladiatorBreastplate, ItemID.GladiatorLeggings, "Gladiator"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AerospecHat"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AerospecHeadgear"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AerospecHelm"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AerospecHelmet"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AerospecHood"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"), "AerospecRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AstralHelm"), ModsCall.Calamity.ItemType("AstralBreastplate"), ModsCall.Calamity.ItemType("AstralLeggings"), "Astral"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AtaxiaHeadgear"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AtaxiaHelm"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AtaxiaHelmet"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AtaxiaHood"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AtaxiaMask"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"), "AtaxiaMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AuricTeslaHelm"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AuricTeslaHoodedFacemask"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AuricTeslaPlumedHelm"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AuricTeslaSpaceHelmet"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("AuricTeslaWireHemmedVisage"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"), "AuricTeslaMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("BloodflareHelm"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("BloodflareHelmet"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("BloodflareHornedHelm"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("BloodflareHornedMask"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("BloodflareMask"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"), "BloodflareMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("BrimflameScowl"), ModsCall.Calamity.ItemType("BrimflameRobes"), ModsCall.Calamity.ItemType("BrimflameBoots"), "Brimflame"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("DaedalusHat"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("DaedalusHeadgear"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("DaedalusHelm"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("DaedalusHelmet"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("DaedalusVisor"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"), "DaedalusRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("DemonshadeHelm"), ModsCall.Calamity.ItemType("DemonshadeBreastplate"), ModsCall.Calamity.ItemType("DemonshadeGreaves"), "Demonshade"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("DesertProwlerHat"), ModsCall.Calamity.ItemType("DesertProwlerShirt"), ModsCall.Calamity.ItemType("DesertProwlerPants"), "DesertProwler"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("FearmongerGreathelm"), ModsCall.Calamity.ItemType("FearmongerPlateMail"), ModsCall.Calamity.ItemType("FearmongerGreaves"), "Fearmonger"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("FathomSwarmerVisage"), ModsCall.Calamity.ItemType("FathomSwarmerBreastplate"), ModsCall.Calamity.ItemType("FathomSwarmerBoots"), "FathomSwarmer"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("GodSlayerHelm"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("GodSlayerHelmet"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("GodSlayerHornedHelm"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("GodSlayerMask"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("GodSlayerVisage"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"), "GodSlayerMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("MolluskShellmet"), ModsCall.Calamity.ItemType("MolluskShellplate"), ModsCall.Calamity.ItemType("MolluskShelleggings"), "Mollusk"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("OmegaBlueHelmet"), ModsCall.Calamity.ItemType("OmegaBlueChestplate"), ModsCall.Calamity.ItemType("OmegaBlueLeggings"), "OmegaBlue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("PlagueReaperMask"), ModsCall.Calamity.ItemType("PlagueReaperVest"), ModsCall.Calamity.ItemType("PlagueReaperStriders"), "PlagueReaper"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("PrismaticHelmet"), ModsCall.Calamity.ItemType("PrismaticRegalia"), ModsCall.Calamity.ItemType("PrismaticGreaves"), "Prismatic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("PlaguebringerVisor"), ModsCall.Calamity.ItemType("PlaguebringerCarapace"), ModsCall.Calamity.ItemType("PlaguebringerPistons"), "Plaguebringer"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("ReaverCap"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("ReaverHelm"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("ReaverHelmet"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("ReaverMask"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("ReaverVisage"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"), "ReaverRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("SilvaHelm"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("SilvaHelmet"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("SilvaHornedHelm"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("SilvaMask"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("SilvaMaskedCap"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"), "SilvaMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("SnowRuffianMask"), ModsCall.Calamity.ItemType("SnowRuffianChestplate"), ModsCall.Calamity.ItemType("SnowRuffianGreaves"), "SnowRuffian"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("StatigelCap"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("StatigelHeadgear"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("StatigelHelm"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("StatigelHood"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("StatigelMask"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"), "StatigelRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("SulfurHelmet"), ModsCall.Calamity.ItemType("SulfurBreastplate"), ModsCall.Calamity.ItemType("SulfurLeggings"), "Sulfur"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("TarragonHelm"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("TarragonHelmet"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("TarragonHornedHelm"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("TarragonMask"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("TarragonVisage"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"), "TarragonRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("TitanHeartMask"), ModsCall.Calamity.ItemType("TitanHeartMantle"), ModsCall.Calamity.ItemType("TitanHeartBoots"), "TitanHeart"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("UmbraphileHood"), ModsCall.Calamity.ItemType("UmbraphileRegalia"), ModsCall.Calamity.ItemType("UmbraphileBoots"), "Umbraphile"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("VictideHeadgear"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("VictideHelm"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("VictideHelmet"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("VictideMask"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("VictideVisage"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"), "VictideRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("WulfrumHeadgear"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumRanged"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("WulfrumHelm"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumMelee"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("WulfrumHelmet"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumSummoner"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("WulfrumHood"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumMagic"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("WulfrumMask"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"), "WulfrumRogue"),
            
            new ArmorSetInfo(ModsCall.Calamity.ItemType("XerocMask"), ModsCall.Calamity.ItemType("XerocPlateMail"), ModsCall.Calamity.ItemType("XerocCuisses"), "Xeroc")
        };
        
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            foreach (ArmorSetInfo info in ArmorSets.Where(set => set.CheckArmorSet(head.type, body.type, legs.type)))
            {
                return info.GetArmorSetName();
            }
            
            if ((head.type == ItemID.EskimoHood || head.type == ItemID.PinkEskimoHood) &&
                (body.type == ItemID.EskimoCoat || body.type == ItemID.PinkEskimoCoat) &&
                (legs.type == ItemID.EskimoPants || legs.type == ItemID.PinkEskimoPants))
            {
                return "Eskimo";
            }
            return "";
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            switch (set)
            {
                case "Obsidian":
                    player.setBonus = LangUtils.GetTextValue("Calamity", "SetBonus.Obsidian") + (TRuConfig.Instance.CalamityStealthDescription ? LangUtils.GetTextValue("Calamity", "SetBonus.Stealth") : "") + (ModsCall.DeathMode ? LangUtils.GetTextValue("Calamity", "DeathMode.Heat") : "");
                    break;
                
                case "Fearmonger":
                case "Eskimo":
                    player.setBonus = LangUtils.GetTextValue("Calamity", $"SetBonus.{set}") + (ModsCall.DeathMode ? LangUtils.GetTextValue("Calamity", "DeathMode.Cold") : "");
                    break;
                
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
                    player.setBonus = LangUtils.GetTextValue("Calamity", $"SetBonus.{set}") + (TRuConfig.Instance.CalamityStealthDescription ? LangUtils.GetTextValue("Calamity", "SetBonus.Stealth") : "");
                    break;
                
                case "AncientForbiddenCirclet":
                    player.setBonus = string.Format(LangUtils.GetTextValue("Calamity", "SetBonus.AncientForbiddenCirclet"), ModsCall.ArmorSetHotkey, ModsCall.AncientStorm) + (TRuConfig.Instance.CalamityStealthDescription ? LangUtils.GetTextValue("Calamity", "SetBonus.Stealth") : "");
                    break;
                
                case "TarragonMelee":
                case "Brimflame":
                case "Demonshade":
                case "OmegaBlue":
                case "PlagueReaper":
                case "Prismatic":
                     player.setBonus = string.Format(LangUtils.GetTextValue("Calamity", $"SetBonus.{set}"), ModsCall.ArmorSetHotkey);
                    break;
                
                default:
                     player.setBonus = LangUtils.GetTextValue("Calamity", $"SetBonus.{set}");
                     break;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.AncientBattleArmorHat ||
                item.type == ItemID.AncientBattleArmorShirt ||
                item.type == ItemID.AncientBattleArmorPants)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "SetBonus");
                if (tooltip != null)
                {
                    string[] array = Regex.Split(tooltip.text, "\n");
                    tooltip.text = tooltip.text.Replace(array[1], LangUtils.GetTextValue("Calamity", "SetBonus.Forbidden"));
                }
            }
        }
    }
}