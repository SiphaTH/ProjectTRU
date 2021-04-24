using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod
{
    public class ModifiedDamageTypes : GlobalItem
    {
        public override bool Autoload(ref string name) => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltip in tooltips.Where(tooltip => tooltip.Name == "Damage"))
            {
                if (tooltip.text.Contains("radiant damage"))
                {
                    tooltip.text = tooltip.text.Split(' ')[0] + " ед. лучезарного урона";

                    if (TRuConfig.Instance.ColoredDamageTypes)
                        tooltip.overrideColor = new Color(190, 245, 116);
                }
                else if (tooltip.text.Contains("symphonic damage"))
                {
                    tooltip.text = tooltip.text.Split(' ')[0] + " ед. симфонического урона";

                    if (TRuConfig.Instance.ColoredDamageTypes)
                        tooltip.overrideColor = new Color(255, 87, 210);
                }
                else if (tooltip.text.Contains("true damage"))
                {
                    tooltip.text = tooltip.text.Split(' ')[0] + " ед. чистого урона";
                }

                if (item.type == ModsCall.Thorium.ItemType("StonePurple"))
                    tooltip.text = "1% здоровья цели как чистый урон";
            }
        }
    }
}