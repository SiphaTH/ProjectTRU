using System.Collections.Generic;
using CalamityMod.Items;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class ModifiedDamageTypes : CalamityGlobalItemBase
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Damage", tooltip =>
            {
                if (item.GetGlobalItem<CalamityGlobalItem>().rogue)
                {
                    tooltip.text = tooltip.text.Replace("stealth strike damage", "ед. урона от скрытного удара");
                    tooltip.text = tooltip.text.Replace(Language.GetTextValue("LegacyTooltip.58"), " ед. разбойного урона");

                    if (TRuConfig.Instance.ColoredDamageTypes)
                        tooltip.overrideColor = new Color(255, 184, 108);
                }
                else if (item.melee)
                {
                    tooltip.text = tooltip.text.Replace("true melee damage", "ед. истинного урона ближнего боя");
                }
            });
        }
    }
}