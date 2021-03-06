using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas
{
    public class ModifiedGlobalItemTooltips : GlobalItem
    {
        public override bool Autoload(ref string name) => ModsCall.Fargo != null && Translation.IsRussianLanguage;
        
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            switch (item.type)
            {
                case ItemID.CrystalBall:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Altar");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("Functions as a Demon altar as well", LangUtilities.GetTextValue("Fargo", "ItemName.CrystalBall.Altar"));
                    break;
                }
                
                case ItemID.PureWaterFountain:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("Forces surrounding biome state to Ocean upon activation", LangUtilities.GetTextValue("Fargo", "ItemName.PureWaterFountain.Tooltip0"));
                    break;
                }
                
                case ItemID.DesertWaterFountain:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("Forces surrounding biome state to Desert upon activation", LangUtilities.GetTextValue("Fargo", "ItemName.DesertWaterFountain.Tooltip0"));
                    break;
                }
                
                case ItemID.JungleWaterFountain:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("Forces surrounding biome state to Jungle upon activation", LangUtilities.GetTextValue("Fargo", "ItemName.JungleWaterFountain.Tooltip0"));
                    break;
                }
                
                case ItemID.IcyWaterFountain:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("Forces surrounding biome state to Snow upon activation", LangUtilities.GetTextValue("Fargo", "ItemName.IcyWaterFountain.Tooltip0"));
                    break;
                }
                
                case ItemID.CorruptWaterFountain:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("Forces surrounding biome state to Corruption upon activation", LangUtilities.GetTextValue("Fargo", "ItemName.CorruptWaterFountain.Tooltip0"));
                    break;
                }
                
                case ItemID.CrimsonWaterFountain:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("Forces surrounding biome state to Crimson upon activation", LangUtilities.GetTextValue("Fargo", "ItemName.CrimsonWaterFountain.Tooltip1"));
                    break;
                }
                
                case ItemID.HallowedWaterFountain:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("In hardmode, forces surrounding biome state to Hallow upon activation", LangUtilities.GetTextValue("Fargo", "ItemName.HallowedWaterFountain.Tooltip1"));
                    break;
                }
                
                case ItemID.FishingPotion:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("Also grants one extra lure", LangUtilities.GetTextValue("Fargo", "ItemName.FishingPotion.Tooltip1"));
                    break;
                }
                
                case ItemID.FiberglassFishingPole:
                case ItemID.FisherofSouls:
                case ItemID.Fleshcatcher:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("This rod fires 2 lures", LangUtilities.GetTextValue("Fargo", "ItemName.FiberglassFishingPole.FisherofSouls.Fleshcatcher.Tooltip1"));
                    break;
                }
                
                case ItemID.MechanicsRod:
                case ItemID.SittingDucksFishingRod:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("This rod fires 3 lures", LangUtilities.GetTextValue("Fargo", "ItemName.MechanicsRod.SittingDucksFishingRod.Tooltip1"));
                    break;
                }
                
                case ItemID.GoldenFishingRod:
                case ItemID.HotlineFishingHook:
                {
                    TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
                    if (tooltip != null)
                        tooltip.text = tooltip.text.Replace("This rod fires 5 lures", LangUtilities.GetTextValue("Fargo", "ItemName.GoldenFishingRod.HotlineFishingHook.Tooltip1"));
                    break;
                }
            }
        }
    }
}