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
    public class SetBonusTranslation: CalamityCompatItem
    {
        public override string IsArmorSet(Item head, Item body, Item legs)
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
            return "";
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            switch (set)
            {
                case "Obsidian":
                    player.setBonus = LangUtilities.GetTextValue("Calamity", "SetBonus.Obsidian") + (ProjectTRuConfig.Instance.CalamityStealthDescription ? LangUtilities.GetTextValue("Calamity", "SetBonus.Stealth") : "") + (CoreCalamityTranslation.DeathMode ? LangUtilities.GetTextValue("Calamity", "DeathMode.Heat") : "");
                    break;
                
                case "Fearmonger":
                case "Eskimo":
                    player.setBonus = LangUtilities.GetTextValue("Calamity", $"SetBonus.{set}") + (CoreCalamityTranslation.DeathMode ? LangUtilities.GetTextValue("Calamity", "DeathMode.Cold") : "");
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
                    player.setBonus = string.Format(LangUtilities.GetTextValue("Calamity", "SetBonus.AncientForbiddenCirclet"), CoreCalamityTranslation.ArmorSetHotkey, CoreCalamityTranslation.AncientStorm) + (ProjectTRuConfig.Instance.CalamityStealthDescription ? LangUtilities.GetTextValue("Calamity", "SetBonus.Stealth") : "");
                    break;
                
                case "TarragonMelee":
                case "Brimflame":
                case "Demonshade":
                case "OmegaBlue":
                case "PlagueReaper":
                case "Prismatic":
                     player.setBonus = string.Format(LangUtilities.GetTextValue("Calamity", $"SetBonus.{set}"), CoreCalamityTranslation.ArmorSetHotkey);
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