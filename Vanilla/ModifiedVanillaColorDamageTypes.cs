using System.Collections.Generic;
using System.Linq;
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
                foreach (TooltipLine tooltip in tooltips.Where(tooltip => tooltip.Name == "Damage"))
                {
                    if (item.melee)
                    {
                        tooltip.text = tooltip.text.Replace("урон ближнего боя", "ед. урона ближнего боя");
                        tooltip.overrideColor = new Color(255, 85, 85);
                    }
                    if (item.magic)
                    {
                        tooltip.text = tooltip.text.Replace("магический урон", "ед. магического урона");
                        if (tooltip.text.Contains("ед. магического урона"))
                        {
                            tooltip.overrideColor = new Color(189, 147, 249);
                        }
                    }
                    if (item.ranged)
                    {
                        tooltip.text = tooltip.text.Replace("стрелковый урон", "ед. стрелкового урона");
                        tooltip.overrideColor = new Color(80, 250, 123);
                    }
                    if (item.summon)
                    {
                        tooltip.text = tooltip.text.Replace("Урон миньонов", "ед. урона миньонов");
                        tooltip.overrideColor = new Color(241, 250, 140);
                    }
                }
            }
        }
    }
}