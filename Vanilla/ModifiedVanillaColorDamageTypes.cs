using System.Collections.Generic;
using CalamityRuTranslate.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla
{
    public class ModifiedVanillaColorDamageTypes : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Translation.IsRussianLanguage)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    if (tooltip.Name == "Damage")
                    {
                        if (item.melee)
                        {
                            tooltip.overrideColor = new Color(255, 85, 85);
                        }
                        if (item.magic)
                        {
                            tooltip.overrideColor = new Color(189, 147, 249);
                        }
                        if (item.ranged)
                        {
                            tooltip.overrideColor = new Color(80, 250, 123);
                        }
                        if (item.summon)
                        {
                            tooltip.overrideColor = new Color(241, 250, 140);
                        }
                    }
                }
            }
        }
    }
}