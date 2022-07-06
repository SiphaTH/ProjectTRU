using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Umbra
{
    [AutoloadEquip(EquipType.Wings)]
    public class UmbraWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Полуночные крылья Umbra");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
        }

        public override void SetDefaults()
        {
            Item.width = 36;
            Item.height = 34;
            Item.rare = 1;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 180;
        }

        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.OverrideColor = ItemHelper.ColorSwap(new Color(209, 77, 253), new Color(83, 2, 218), 2f);
            }
        }
    }
}