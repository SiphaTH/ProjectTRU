using System.Collections.Generic;
using CalamityRuTranslate.Dictionaries;
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
            if (CoreCalamityTranslation.CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                foreach (var armorSet in RussianDictionaries.CalamityArmorSets)
                {
                    if (head.type == armorSet.Key.Item1 && body.type == armorSet.Key.Item2 && legs.type == armorSet.Key.Item3)
                    {
                        return armorSet.Value;
                    }
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
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                try
                {
                    switch (set)
                    {
                        case "AncientForbiddenCirclet":
                            player.setBonus = (RussianDictionaries.CalamitySetBonusWithArmorKey[set].Item1 + CoreCalamityTranslation.ArmorSetHotkey + RussianDictionaries.CalamitySetBonusWithArmorKey[set].Item2).Replace("AncientStormManaCost", CoreCalamityTranslation.AncientStorm.ToString());
                            break;
                        case "BloodflareRanged":
                        case "Brimflame":
                        case "Demonshade":
                        case "OmegaBlue":
                        case "PlagueReaper":
                        case "Prismatic":
                        case "TarragonMelee":
                            player.setBonus = RussianDictionaries.CalamitySetBonusWithArmorKey[set].Item1 + CoreCalamityTranslation.ArmorSetHotkey + RussianDictionaries.CalamitySetBonusWithArmorKey[set].Item2;
                            break;
                        default:
                            player.setBonus = RussianDictionaries.CalamitySetBonus[set];
                            break;
                    }
                }
                catch
                {
                    Main.NewText($"Ошибка загрузки ключа бонуса комплекта {set}.");
                }
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                if (item.type == ItemID.AncientBattleArmorHat ||
                    item.type == ItemID.AncientBattleArmorShirt ||
                    item.type == ItemID.AncientBattleArmorPants)
                {
                    foreach (TooltipLine tooltipLine in tooltips)
                    {
                        if (tooltipLine.Name == "SetBonus")
                        {
                            tooltipLine.text = tooltipLine.text.Replace("The minion damage nerf is reduced while wielding magic weapons", Translation.KeyText("Calamity.SetBonus.AncientBattleArmor"));
                        }
                    }
                }
            }
        }
    }
}