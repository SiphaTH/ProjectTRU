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
                        player.setBonus = Translation.KeyText2("Calamity.SetBonus.Obsidian") +
                                          (CalamityRuTranslate.Config.CalamityStealth
                                              ? Translation.KeyText2("Calamity.SetBonus.Stealth")
                                              : "") + (CoreCalamityTranslation.DeathMode
                                              ? Translation.KeyText2("Calamity.DeathMode.Heat")
                                              : "");
                        break;
                    case "Fearmonger":
                    case "Eskimo":
                        player.setBonus = Translation.KeyText2($"Calamity.SetBonus.{set}") +
                                          (CoreCalamityTranslation.DeathMode
                                              ? Translation.KeyText2("Calamity.DeathMode.Cold")
                                              : "");
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
                        player.setBonus = Translation.KeyText2($"Calamity.SetBonus.{set}") +
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
                    case "TarragonMelee":
                    case "Brimflame":
                    case "Demonshade":
                    case "OmegaBlue":
                    case "PlagueReaper":
                    case "Prismatic":
                         player.setBonus = string.Format(Translation.KeyText2($"Calamity.SetBonus.{set}"), 
                             CoreCalamityTranslation.ArmorSetHotkey);
                        break;
                     default:
                         player.setBonus = Translation.KeyText2($"Calamity.SetBonus.{set}");
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
                            Translation.KeyText2("Calamity.SetBonus.Forbidden"));
                    }
                }
            }
        }
    }
}