using System.Collections.Generic;
using System.Linq;
using CalamityMod.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class ModifiedDamageTypes : CalamityAutoLoad
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltip in tooltips.Where(tooltip => tooltip.Name == "Damage"))
            {
                if (item.GetGlobalItem<CalamityGlobalItem>().rogue)
                {
                    tooltip.text = tooltip.text.Replace("rogue урона", "ед. разбойного урона");

                    if (TRuConfig.Instance.ColoredDamageTypes)
                        tooltip.overrideColor = new Color(255, 184, 108);
                }
                else if (item.melee)
                {
                    tooltip.text = tooltip.text.Replace("true melee damage", "ед. истинного урона ближнего боя");
                }
            }
        }
    }
}