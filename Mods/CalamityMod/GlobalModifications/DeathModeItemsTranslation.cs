using System.Collections.Generic;
using CalamityMod.Items.Potions;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class DeathModeItemsTranslation : CalamityGlobalItemBase
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<PurifiedJam>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.PurifiedJam.Tooltip0",
                        ModsCall.DeathMode || ModsCall.MaliceMode ? 5 : 10);
                });
            }
        }
    }
}