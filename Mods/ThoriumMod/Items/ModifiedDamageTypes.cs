using System.Collections.Generic;
using CalamityRuTranslate.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod.Items
{
    public class ModifiedDamageTypes :GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreThoriumTranslation.ThoriumMod != null && Translation.IsRussianLanguage && CalamityRuTranslate.Config.ThoriumTranslation)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    if (tooltip.Name == "Damage")
                    {
                        tooltip.text = tooltip.text.Replace("radiant damage", "лучезарный урон");
                        
                        if (tooltip.text.Contains("лучезарный урон"))
                        {
                            tooltip.overrideColor = new Color(190, 245, 116);
                        }
                    }
                }
                
                foreach (TooltipLine tooltip2 in tooltips)
                {
                    if (tooltip2.Name == "Damage")
                    {
                        tooltip2.text = tooltip2.text.Replace("symphonic damage", "симфонический урон");
                        
                        if (tooltip2.text.Contains("симфонический урон"))
                        {
                            tooltip2.overrideColor = new Color(255, 87, 210);
                        }
                    }
                }
                
                foreach (TooltipLine tooltip3 in tooltips)
                {
                    if (tooltip3.Name == "Damage")
                    {
                        tooltip3.text = tooltip3.text.Replace("true damage", "чистый урон").Replace("of targets health as", "здоровья цели как");   
                    }
                }
            }
        }
    }
}