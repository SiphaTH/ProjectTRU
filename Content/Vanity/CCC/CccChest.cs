using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.CCC
{
    [AutoloadEquip(EquipType.Body)]
    public class CccChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Самодельный ОЗК CCC");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.rare = 1;
            item.vanity = true;
        }
        
        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.overrideColor = new Color(58, 187, 75);
            }
        }
    }
}