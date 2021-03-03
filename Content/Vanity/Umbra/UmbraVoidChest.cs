using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Umbra
{
    [AutoloadEquip(EquipType.Body)]
    public class UmbraVoidChest : ItemColorLerper
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Пустотный нагрудник Umbra");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
            MyColors = new[] {new Color(209, 77, 253), new Color(143, 77, 253), new Color(83, 2, 218)};
            CurrentColor = MyColors[0];
            TargetColor = MyColors[1];
            RatioChanger += f => f + 0.015f;
        }

        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 32;
            item.rare = 1;
            item.vanity = true;
        }
    }
}