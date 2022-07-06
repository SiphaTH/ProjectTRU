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
            Item.width = 30;
            Item.height = 24;
            Item.rare = 1;
            Item.vanity = true;
        }
        
        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.OverrideColor = new Color(58, 187, 75);
            }
        }
    }
}