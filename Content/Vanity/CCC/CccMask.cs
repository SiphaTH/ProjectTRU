﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.CCC
{
    [AutoloadEquip(EquipType.Head)]
    public class CccMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ржавая газовая маска CCC");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 26;
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