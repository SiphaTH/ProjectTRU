using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.BrotKrip
{
    [AutoloadEquip(EquipType.Body)]
    public class MarisaDress : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Прекрасное платье BrotKrip");
            Tooltip.SetDefault("Перчатки - канон?\n{$CommonItemTooltip.DevItem}");
        }
        
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 24;
            item.rare = 1;
            item.vanity = true;
        }
        
        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.overrideColor = new Color(219, 255, 0);
            }
        }
    }
}