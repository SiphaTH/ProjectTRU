using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    public class ModifiedDamageTypes : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && 
                CalamityRuTranslate.Config.CalamityTranslation)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Damage");
                if (tooltip == null) 
                    return;
                if (tooltip.text.Contains("rogue метании"))
                {
                    tooltip.text = tooltip.text.Replace("rogue метании", "ед. разбойного урона");
                    tooltip.overrideColor = new Color(255, 184, 108);
                }
                else if (!item.summon && tooltip.text.Contains("Урон"))
                {
                    tooltip.text = tooltip.text.Replace("Урон", "ед. бесклассового урона");
                    tooltip.overrideColor = new Color(133, 133, 133);
                }
                else if (tooltip.text.Contains("true melee damage"))
                {
                    tooltip.text = tooltip.text.Replace("true melee damage", "ед. истинного урона ближнего боя");
                }
            }
        }
    }
}