using System.Collections.Generic;
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
            if (CoreCalamityTranslation.CalamityMod != null && Translation.IsRussianLanguage && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    if (tooltip.Name == "Damage")
                    {
                        tooltip.text = tooltip.text.Replace("rogue метании", "разбойный урон").Replace("true melee damage", "истинный урон ближнего боя");
                        if (tooltip.text.Contains("разбойный урон"))
                        {
                            tooltip.overrideColor = new Color(255, 184, 108);
                        }
                    }
                }
            }
        }
    }
}