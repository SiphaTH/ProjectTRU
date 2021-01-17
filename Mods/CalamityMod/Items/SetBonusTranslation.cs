using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CalamityRuTranslate.DictionariesAndLists;
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
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                var armorSet = CalamityTranslationDictionaries.CalamityArmorSets.FirstOrDefault(x =>
                    head.type == x.Key.Head && body.type == x.Key.Body && legs.type == x.Key.Legs);
                if (!armorSet.Equals(new KeyValuePair<(int Head, int Body, int Legs), string>()))
                {
                    return armorSet.Value;
                }
            
                if ((head.type == ItemID.EskimoHood || head.type == ItemID.PinkEskimoHood) &&
                    (body.type == ItemID.EskimoCoat || body.type == ItemID.PinkEskimoCoat) &&
                    (legs.type == ItemID.EskimoPants || legs.type == ItemID.PinkEskimoPants))
                {
                    return "Eskimo";
                }
            }

            return "";
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                switch (set)
                {
                    case "Obsidian":
                        player.setBonus = Translation.KeyText2("Calamity.VanillaSetBonus.Obsidian") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "") + (CoreCalamityTranslation.DeathMode
                                              ? Translation.KeyText2("Calamity.DeathMode.Heat")
                                              : "");
                        break;
                    case "Eskimo":
                        player.setBonus = Translation.KeyText2("Calamity.VanillaSetBonus.Eskimo") +
                                          (CoreCalamityTranslation.DeathMode
                                              ? Translation.KeyText2("Calamity.DeathMode.Cold")
                                              : "");
                            
                        break;
                    case "Shroomite":
                        player.setBonus = Translation.KeyText2("Calamity.VanillaSetBonus.Shroomite");
                        break;
                    case "Gladiator":
                        player.setBonus = Translation.KeyText2("Calamity.VanillaSetBonus.Gladiator") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "AerospecMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AerospecMagic");
                        break;
                    case "AerospecRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AerospecRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "AerospecMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AerospecMelee");
                        break;
                    case "AerospecSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AerospecSummoner");
                        break;
                    case "AerospecRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AerospecRanged");
                        break;
                    case "Astral":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.Astral");
                        break;
                    case "AtaxiaRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AtaxiaRanged");
                        break;
                    case "AtaxiaMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AtaxiaMelee");
                        break;
                    case "AtaxiaSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AtaxiaSummoner");
                        break;
                    case "AtaxiaRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AtaxiaRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "AtaxiaMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AtaxiaMagic");
                        break;
                    case "AuricTeslaMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AuricTeslaMelee");
                        break;
                    case "AuricTeslaRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AuricTeslaRanged");
                        break;
                    case "AuricTeslaRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AuricTeslaRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "AuricTeslaSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AuricTeslaSummoner");
                        break;
                    case "AuricTeslaMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.AuricTeslaMagic");
                        break;
                    case "BloodflareRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.BloodflareRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "BloodflareSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.BloodflareSummoner");
                        break;
                    case "BloodflareMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.BloodflareMagic");
                        break;
                    case "BloodflareMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.BloodflareMelee");
                        break;
                    case "BloodflareRanged":
                        player.setBonus = string.Format(Translation.KeyText2("Calamity.SetBonus.BloodflareRanged"), 
                            CoreCalamityTranslation.ArmorSetHotkey);
                        break;
                    case "DaedalusMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.DaedalusMagic");
                        break;
                    case "DaedalusSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.DaedalusSummoner");
                        break;
                    case "DaedalusMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.DaedalusMelee");
                        break;
                    case "DaedalusRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.DaedalusRanged");
                        break;
                    case "DaedalusRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.DaedalusRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "DesertProwler":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.DesertProwler");
                        break;
                    case "Fearmonger":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.Fearmonger") +
                                          (CoreCalamityTranslation.DeathMode
                                              ? Translation.KeyText2("Calamity.DeathMode.Cold")
                                              : "");
                        break;
                    case "FathomSwarmer":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.FathomSwarmer");
                        break;
                    case "GodSlayerMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.GodSlayerMelee");
                        break;
                    case "GodSlayerRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.GodSlayerRanged");
                        break;
                    case "GodSlayerSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.GodSlayerSummoner");
                        break;
                    case "GodSlayerRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.GodSlayerRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "GodSlayerMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.GodSlayerMagic");
                        break;
                    case "Mollusk":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.Mollusk");
                        break;
                    case "Plaguebringer":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.Plaguebringer");
                        break;
                    case "ReaverRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.ReaverRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "ReaverMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.ReaverMelee");
                        break;
                    case "ReaverSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.ReaverSummoner");
                        break;
                    case "ReaverMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.ReaverMagic");
                        break;
                    case "ReaverRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.ReaverRanged");
                        break;
                    case "SilvaMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.SilvaMelee");
                        break;
                    case "SilvaSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.SilvaSummoner");
                        break;
                    case "SilvaRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.SilvaRanged");
                        break;
                    case "SilvaRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.SilvaRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "SilvaMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.SilvaMagic");
                        break;
                    case "SnowRuffian":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.SnowRuffian") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "StatigelMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.StatigelMagic");
                        break;
                    case "StatigelRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.StatigelRanged");
                        break;
                    case "StatigelMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.StatigelMelee");
                        break;
                    case "StatigelSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.StatigelSummoner");
                        break;
                    case "StatigelRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.StatigelRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "Sulfur":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.Sulfur") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "TarragonRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.TarragonRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "TarragonSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.TarragonSummoner");
                        break;
                    case "TarragonMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.TarragonMagic");
                        break;
                    case "TarragonRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.TarragonRanged");
                        break;
                    case "TarragonMelee":
                        player.setBonus = string.Format(Translation.KeyText2("Calamity.SetBonus.TarragonMelee"), 
                            CoreCalamityTranslation.ArmorSetHotkey);
                        break;
                    case "TitanHeart":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.TitanHeart") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "Umbraphile":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.Umbraphile") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "VictideRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.VictideRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "VictideMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.VictideMelee");
                        break;
                    case "VictideSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.VictideSummoner");
                        break;
                    case "VictideMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.VictideMagic");
                        break;
                    case "VictideRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.VictideRanged");
                        break;
                    case "WulfrumRanged":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.WulfrumRanged");
                        break;
                    case "WulfrumMelee":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.WulfrumMelee");
                        break;
                    case "WulfrumSummoner":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.WulfrumSummoner");
                        break;
                    case "WulfrumMagic":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.WulfrumMagic");
                        break;
                    case "WulfrumRogue":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.WulfrumRogue") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "Xeroc":
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.Xeroc") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "AncientForbiddenCirclet":
                        player.setBonus = string.Format(Translation.KeyText2("Calamity.SetBonus.AncientForbiddenCirclet"), 
                            CoreCalamityTranslation.ArmorSetHotkey, CoreCalamityTranslation.AncientStorm) +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "");
                        break;
                    case "Brimflame":
                        player.setBonus = string.Format(Translation.KeyText2("Calamity.SetBonus.Brimflame"), 
                            CoreCalamityTranslation.ArmorSetHotkey);
                        break;
                     case "Demonshade":
                         player.setBonus = string.Format(Translation.KeyText2("Calamity.SetBonus.Demonshade"), 
                             CoreCalamityTranslation.ArmorSetHotkey);
                         break;
                     case "OmegaBlue":
                         player.setBonus = string.Format(Translation.KeyText2("Calamity.SetBonus.OmegaBlue"), 
                             CoreCalamityTranslation.ArmorSetHotkey);
                         break;
                     case "PlagueReaper":
                         player.setBonus = string.Format(Translation.KeyText2("Calamity.SetBonus.PlagueReaper"), 
                             CoreCalamityTranslation.ArmorSetHotkey);
                         break;
                     case "Prismatic":
                         player.setBonus = string.Format(Translation.KeyText2("Calamity.SetBonus.Prismatic"), 
                             CoreCalamityTranslation.ArmorSetHotkey);
                        break;
                }
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                if (item.type == ItemID.AncientBattleArmorHat ||
                    item.type == ItemID.AncientBattleArmorShirt ||
                    item.type == ItemID.AncientBattleArmorPants)
                {
                    TooltipLine tooltipLine = tooltips.FirstOrDefault(x => x.Name == "SetBonus");
                    if (tooltipLine != null)
                    {
                        string[] array = Regex.Split(tooltipLine.text, "\n");
                        tooltipLine.text = tooltipLine.text.Replace(array[1], 
                            Translation.KeyText2("Calamity.VanillaSetBonus.Forbidden"));
                    }
                }
            }
        }
    }
}