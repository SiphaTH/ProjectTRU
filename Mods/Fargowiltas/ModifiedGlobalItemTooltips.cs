using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas
{
    public class ModifiedGlobalItemTooltips : GlobalItem
    {
        public override bool Autoload(ref string name) => ModsCall.Fargo != null && TranslationUtils.IsRussianLanguage;
        
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            TooltipLine line1 = tooltips.FirstOrDefault(x => x.Name == "Altar");
            if (line1 != null)
            {
                switch (item.type)
                {
                    case ItemID.CrystalBall:
                        line1.text = LangUtils.GetTextValue("Fargo", "ItemName.CrystalBall.Altar");
                        break;
                }
            }
            
            TooltipLine line2 = tooltips.FirstOrDefault(x => x.Name == "Tooltip0");
            if (line2 != null)
            {
                switch (item.type)
                {
                    case ItemID.PureWaterFountain:
                        line2.text = LangUtils.GetTextValue("Fargo", "ItemName.PureWaterFountain.Tooltip0");
                        break;
                    
                    case ItemID.DesertWaterFountain:
                        line2.text = LangUtils.GetTextValue("Fargo", "ItemName.DesertWaterFountain.Tooltip0");
                        break;
                    
                    case ItemID.JungleWaterFountain:
                        line2.text = LangUtils.GetTextValue("Fargo", "ItemName.JungleWaterFountain.Tooltip0");
                        break;
                    
                    case ItemID.IcyWaterFountain:
                        line2.text = LangUtils.GetTextValue("Fargo", "ItemName.IcyWaterFountain.Tooltip0");
                        break;
                    
                    case ItemID.CorruptWaterFountain:
                        line2.text = LangUtils.GetTextValue("Fargo", "ItemName.CorruptWaterFountain.Tooltip0");
                        break;
                }
            }
            
            TooltipLine line3 = tooltips.FirstOrDefault(x => x.Name == "Tooltip1");
            if (line3 != null)
            {
                switch (item.type)
                {
                    case ItemID.CrimsonWaterFountain:
                        line3.text = LangUtils.GetTextValue("Fargo", "ItemName.CrimsonWaterFountain.Tooltip1");
                        break;
                    
                    case ItemID.HallowedWaterFountain:
                        line3.text = LangUtils.GetTextValue("Fargo", "ItemName.HallowedWaterFountain.Tooltip1");
                        break;
                    
                    case ItemID.FishingPotion:
                        line3.text = LangUtils.GetTextValue("Fargo", "ItemName.FishingPotion.Tooltip1");
                        break;
                    
                    case ItemID.FiberglassFishingPole:
                    case ItemID.FisherofSouls:
                    case ItemID.Fleshcatcher:
                        line3.text = LangUtils.GetTextValue("Fargo", "ItemName.FiberglassFishingPole.FisherofSouls.Fleshcatcher.Tooltip1");
                        break;
                    
                    case ItemID.MechanicsRod:
                    case ItemID.SittingDucksFishingRod:
                        line3.text = LangUtils.GetTextValue("Fargo", "ItemName.MechanicsRod.SittingDucksFishingRod.Tooltip1");
                        break;
                    
                    case ItemID.GoldenFishingRod:
                    case ItemID.HotlineFishingHook:
                        line3.text = LangUtils.GetTextValue("Fargo", "ItemName.GoldenFishingRod.HotlineFishingHook.Tooltip1");
                        break;
                }
            }
        }
    }
}