using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class SetBonusTranslation : CalamityCompatItem
    {
        private static readonly Dictionary<string, (int Head, int Body, int Legs)> CalamityArmorSet =
            new Dictionary<string, (int Head, int Body, int Legs)>
            {
                {"Obsidian", (ItemID.ObsidianHelm, ItemID.ObsidianShirt, ItemID.ObsidianPants)},
                {"AncientForbiddenCirclet", (ModsCall.Calamity.ItemType("ForbiddenCirclet"), ItemID.AncientBattleArmorShirt, ItemID.AncientBattleArmorPants)},
                {"Shroomite", (ModsCall.Calamity.ItemType("ShroomiteVisage"), ItemID.ShroomiteBreastplate, ItemID.ShroomiteLeggings)},
                {"Gladiator", (ItemID.GladiatorHelmet, ItemID.GladiatorBreastplate, ItemID.GladiatorLeggings)},
                {"AerospecMagic", (ModsCall.Calamity.ItemType("AerospecHat"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"))},
                {"AerospecRogue", (ModsCall.Calamity.ItemType("AerospecHeadgear"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"))},
                {"AerospecMelee", (ModsCall.Calamity.ItemType("AerospecHelm"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"))},
                {"AerospecSummoner", (ModsCall.Calamity.ItemType("AerospecHelmet"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"))},
                {"AerospecRanged", (ModsCall.Calamity.ItemType("AerospecHood"), ModsCall.Calamity.ItemType("AerospecBreastplate"), ModsCall.Calamity.ItemType("AerospecLeggings"))},
                {"Astral", (ModsCall.Calamity.ItemType("AstralHelm"), ModsCall.Calamity.ItemType("AstralBreastplate"), ModsCall.Calamity.ItemType("AstralLeggings"))},
                {"AtaxiaRanged", (ModsCall.Calamity.ItemType("AtaxiaHeadgear"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"))},
                {"AtaxiaMelee", (ModsCall.Calamity.ItemType("AtaxiaHelm"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"))},
                {"AtaxiaSummoner", (ModsCall.Calamity.ItemType("AtaxiaHelmet"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"))},
                {"AtaxiaRogue", (ModsCall.Calamity.ItemType("AtaxiaHood"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"))},
                {"AtaxiaMagic", (ModsCall.Calamity.ItemType("AtaxiaMask"), ModsCall.Calamity.ItemType("AtaxiaArmor"), ModsCall.Calamity.ItemType("AtaxiaSubligar"))},
                {"AuricTeslaMelee", (ModsCall.Calamity.ItemType("AuricTeslaHelm"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"))},
                {"AuricTeslaRanged", (ModsCall.Calamity.ItemType("AuricTeslaHoodedFacemask"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"))},
                {"AuricTeslaRogue", (ModsCall.Calamity.ItemType("AuricTeslaPlumedHelm"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"))},
                {"AuricTeslaSummoner", (ModsCall.Calamity.ItemType("AuricTeslaSpaceHelmet"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"))},
                {"AuricTeslaMagic", (ModsCall.Calamity.ItemType("AuricTeslaWireHemmedVisage"), ModsCall.Calamity.ItemType("AuricTeslaBodyArmor"), ModsCall.Calamity.ItemType("AuricTeslaCuisses"))},
                {"BloodflareRogue", (ModsCall.Calamity.ItemType("BloodflareHelm"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"))},
                {"BloodflareSummoner", (ModsCall.Calamity.ItemType("BloodflareHelmet"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"))},
                {"BloodflareRanged", (ModsCall.Calamity.ItemType("BloodflareHornedHelm"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"))},
                {"BloodflareMagic", (ModsCall.Calamity.ItemType("BloodflareHornedMask"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"))},
                {"BloodflareMelee", (ModsCall.Calamity.ItemType("BloodflareMask"), ModsCall.Calamity.ItemType("BloodflareBodyArmor"), ModsCall.Calamity.ItemType("BloodflareCuisses"))},
                {"Brimflame", (ModsCall.Calamity.ItemType("BrimflameScowl"), ModsCall.Calamity.ItemType("BrimflameRobes"), ModsCall.Calamity.ItemType("BrimflameBoots"))},
                {"DaedalusMagic", (ModsCall.Calamity.ItemType("DaedalusHat"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"))},
                {"DaedalusSummoner", (ModsCall.Calamity.ItemType("DaedalusHeadgear"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"))},
                {"DaedalusMelee", (ModsCall.Calamity.ItemType("DaedalusHelm"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"))},
                {"DaedalusRanged", (ModsCall.Calamity.ItemType("DaedalusHelmet"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"))},
                {"DaedalusRogue", (ModsCall.Calamity.ItemType("DaedalusVisor"), ModsCall.Calamity.ItemType("DaedalusBreastplate"), ModsCall.Calamity.ItemType("DaedalusLeggings"))},
                {"Demonshade", (ModsCall.Calamity.ItemType("DemonshadeHelm"), ModsCall.Calamity.ItemType("DemonshadeBreastplate"), ModsCall.Calamity.ItemType("DemonshadeGreaves"))},
                {"DesertProwler", (ModsCall.Calamity.ItemType("DesertProwlerHat"), ModsCall.Calamity.ItemType("DesertProwlerShirt"), ModsCall.Calamity.ItemType("DesertProwlerPants"))},
                {"Fearmonger", (ModsCall.Calamity.ItemType("FearmongerGreathelm"), ModsCall.Calamity.ItemType("FearmongerPlateMail"), ModsCall.Calamity.ItemType("FearmongerGreaves"))},
                {"FathomSwarmer", (ModsCall.Calamity.ItemType("FathomSwarmerVisage"), ModsCall.Calamity.ItemType("FathomSwarmerBreastplate"), ModsCall.Calamity.ItemType("FathomSwarmerBoots"))},
                {"GodSlayerMelee", (ModsCall.Calamity.ItemType("GodSlayerHelm"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"))},
                {"GodSlayerRanged", (ModsCall.Calamity.ItemType("GodSlayerHelmet"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"))},
                {"GodSlayerSummoner", (ModsCall.Calamity.ItemType("GodSlayerHornedHelm"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"))},
                {"GodSlayerRogue", (ModsCall.Calamity.ItemType("GodSlayerMask"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"))},
                {"GodSlayerMagic", (ModsCall.Calamity.ItemType("GodSlayerVisage"), ModsCall.Calamity.ItemType("GodSlayerChestplate"), ModsCall.Calamity.ItemType("GodSlayerLeggings"))},
                {"Mollusk", (ModsCall.Calamity.ItemType("MolluskShellmet"), ModsCall.Calamity.ItemType("MolluskShellplate"), ModsCall.Calamity.ItemType("MolluskShelleggings"))},
                {"OmegaBlue", (ModsCall.Calamity.ItemType("OmegaBlueHelmet"), ModsCall.Calamity.ItemType("OmegaBlueChestplate"), ModsCall.Calamity.ItemType("OmegaBlueLeggings"))},
                {"PlagueReaper", (ModsCall.Calamity.ItemType("PlagueReaperMask"), ModsCall.Calamity.ItemType("PlagueReaperVest"), ModsCall.Calamity.ItemType("PlagueReaperStriders"))},
                {"Prismatic", (ModsCall.Calamity.ItemType("PrismaticHelmet"), ModsCall.Calamity.ItemType("PrismaticRegalia"), ModsCall.Calamity.ItemType("PrismaticGreaves"))},
                {"Plaguebringer", (ModsCall.Calamity.ItemType("PlaguebringerVisor"), ModsCall.Calamity.ItemType("PlaguebringerCarapace"), ModsCall.Calamity.ItemType("PlaguebringerPistons"))},
                {"ReaverRogue", (ModsCall.Calamity.ItemType("ReaverCap"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"))},
                {"ReaverMelee", (ModsCall.Calamity.ItemType("ReaverHelm"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"))},
                {"ReaverSummoner", (ModsCall.Calamity.ItemType("ReaverHelmet"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"))},
                {"ReaverMagic", (ModsCall.Calamity.ItemType("ReaverMask"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"))},
                {"ReaverRanged", (ModsCall.Calamity.ItemType("ReaverVisage"), ModsCall.Calamity.ItemType("ReaverScaleMail"), ModsCall.Calamity.ItemType("ReaverCuisses"))},
                {"SilvaMelee", (ModsCall.Calamity.ItemType("SilvaHelm"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"))},
                {"SilvaSummoner", (ModsCall.Calamity.ItemType("SilvaHelmet"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"))},
                {"SilvaRanged", (ModsCall.Calamity.ItemType("SilvaHornedHelm"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"))},
                {"SilvaRogue", (ModsCall.Calamity.ItemType("SilvaMask"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"))},
                {"SilvaMagic", (ModsCall.Calamity.ItemType("SilvaMaskedCap"), ModsCall.Calamity.ItemType("SilvaArmor"), ModsCall.Calamity.ItemType("SilvaLeggings"))},
                {"SnowRuffian", (ModsCall.Calamity.ItemType("SnowRuffianMask"), ModsCall.Calamity.ItemType("SnowRuffianChestplate"), ModsCall.Calamity.ItemType("SnowRuffianGreaves"))},
                {"StatigelMagic", (ModsCall.Calamity.ItemType("StatigelCap"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"))},
                {"StatigelRanged", (ModsCall.Calamity.ItemType("StatigelHeadgear"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"))},
                {"StatigelMelee", (ModsCall.Calamity.ItemType("StatigelHelm"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"))},
                {"StatigelSummoner", (ModsCall.Calamity.ItemType("StatigelHood"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"))},
                {"StatigelRogue", (ModsCall.Calamity.ItemType("StatigelMask"), ModsCall.Calamity.ItemType("StatigelArmor"), ModsCall.Calamity.ItemType("StatigelGreaves"))},
                {"Sulfur", (ModsCall.Calamity.ItemType("SulfurHelmet"), ModsCall.Calamity.ItemType("SulfurBreastplate"), ModsCall.Calamity.ItemType("SulfurLeggings"))},
                {"TarragonMelee", (ModsCall.Calamity.ItemType("TarragonHelm"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"))},
                {"TarragonRogue", (ModsCall.Calamity.ItemType("TarragonHelmet"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"))},
                {"TarragonSummoner", (ModsCall.Calamity.ItemType("TarragonHornedHelm"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"))},
                {"TarragonMagic", (ModsCall.Calamity.ItemType("TarragonMask"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"))},
                {"TarragonRanged", (ModsCall.Calamity.ItemType("TarragonVisage"), ModsCall.Calamity.ItemType("TarragonBreastplate"), ModsCall.Calamity.ItemType("TarragonLeggings"))},
                {"TitanHeart", (ModsCall.Calamity.ItemType("TitanHeartMask"), ModsCall.Calamity.ItemType("TitanHeartMantle"), ModsCall.Calamity.ItemType("TitanHeartBoots"))},
                {"Umbraphile", (ModsCall.Calamity.ItemType("UmbraphileHood"), ModsCall.Calamity.ItemType("UmbraphileRegalia"), ModsCall.Calamity.ItemType("UmbraphileBoots"))},
                {"VictideRogue", (ModsCall.Calamity.ItemType("VictideHeadgear"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"))},
                {"VictideMelee", (ModsCall.Calamity.ItemType("VictideHelm"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"))},
                {"VictideSummoner", (ModsCall.Calamity.ItemType("VictideHelmet"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"))},
                {"VictideMagic", (ModsCall.Calamity.ItemType("VictideMask"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"))},
                {"VictideRanged", (ModsCall.Calamity.ItemType("VictideVisage"), ModsCall.Calamity.ItemType("VictideBreastplate"), ModsCall.Calamity.ItemType("VictideLeggings"))},
                {"WulfrumRanged", (ModsCall.Calamity.ItemType("WulfrumHeadgear"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"))},
                {"WulfrumMelee", (ModsCall.Calamity.ItemType("WulfrumHelm"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"))},
                {"WulfrumSummoner", (ModsCall.Calamity.ItemType("WulfrumHelmet"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"))},
                {"WulfrumMagic", (ModsCall.Calamity.ItemType("WulfrumHood"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"))},
                {"WulfrumRogue", (ModsCall.Calamity.ItemType("WulfrumMask"), ModsCall.Calamity.ItemType("WulfrumArmor"), ModsCall.Calamity.ItemType("WulfrumLeggings"))},
                {"Xeroc", (ModsCall.Calamity.ItemType("XerocMask"), ModsCall.Calamity.ItemType("XerocPlateMail"), ModsCall.Calamity.ItemType("XerocCuisses"))}
            };
        
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            foreach (var armorSet in CalamityArmorSet.Where(armorSet => head.type == armorSet.Value.Head && body.type == armorSet.Value.Body && legs.type == armorSet.Value.Legs))
            {
                return armorSet.Key;
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
                    player.setBonus = LangUtilities.GetTextValue("Calamity", "SetBonus.Obsidian") + (ProjectTRuConfig.Instance.CalamityStealthDescription ? LangUtilities.GetTextValue("Calamity", "SetBonus.Stealth") : "") + (ModsCall.DeathMode ? LangUtilities.GetTextValue("Calamity", "DeathMode.Heat") : "");
                    break;
                
                case "Fearmonger":
                case "Eskimo":
                    player.setBonus = LangUtilities.GetTextValue("Calamity", $"SetBonus.{set}") + (ModsCall.DeathMode ? LangUtilities.GetTextValue("Calamity", "DeathMode.Cold") : "");
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
                    player.setBonus = LangUtilities.GetTextValue("Calamity", $"SetBonus.{set}") + (ProjectTRuConfig.Instance.CalamityStealthDescription ? LangUtilities.GetTextValue("Calamity", "SetBonus.Stealth") : "");
                    break;
                
                case "AncientForbiddenCirclet":
                    player.setBonus = string.Format(LangUtilities.GetTextValue("Calamity", "SetBonus.AncientForbiddenCirclet"), ModsCall.ArmorSetHotkey, ModsCall.AncientStorm) + (ProjectTRuConfig.Instance.CalamityStealthDescription ? LangUtilities.GetTextValue("Calamity", "SetBonus.Stealth") : "");
                    break;
                
                case "TarragonMelee":
                case "Brimflame":
                case "Demonshade":
                case "OmegaBlue":
                case "PlagueReaper":
                case "Prismatic":
                     player.setBonus = string.Format(LangUtilities.GetTextValue("Calamity", $"SetBonus.{set}"), ModsCall.ArmorSetHotkey);
                    break;
                
                default:
                     player.setBonus = LangUtilities.GetTextValue("Calamity", $"SetBonus.{set}");
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
                    tooltip.text = tooltip.text.Replace(array[1], LangUtilities.GetTextValue("Calamity", "SetBonus.Forbidden"));
                }
            }
        }
    }
}