using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    public class ModifiedDamageTypes : CalamityCompatItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Translation.IsRussianLanguage)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "Damage");
                if (tooltip != null)
                {
                    if (tooltip.text.Contains("rogue урона"))
                    {
                        tooltip.text = tooltip.text.Replace("rogue урона", "ед. разбойного урона");
                        tooltip.overrideColor = new Color(255, 184, 108);
                    }
                    else if (tooltip.text.Contains("true melee damage"))
                    {
                        tooltip.text = tooltip.text.Replace("true melee damage", "ед. истинного урона ближнего боя");
                    }
                }
            }
        }
    }
}