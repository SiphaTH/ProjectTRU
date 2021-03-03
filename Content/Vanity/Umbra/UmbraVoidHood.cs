using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Umbra
{
    [AutoloadEquip(EquipType.Head)]
    public class UmbraVoidHood : ItemColorLerper
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Пустотный капюшон Umbra");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
            MyColors = new[] {new Color(209, 77, 253), new Color(143, 77, 253), new Color(83, 2, 218)};
            CurrentColor = MyColors[0];
            TargetColor = MyColors[1];
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 34;
            item.rare = 1;
            item.vanity = true;
        }
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<UmbraVoidChest>() && legs.type == ModContent.ItemType<UmbraVoidGreaves>();
        }
        
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawShadow = true;
        }
    }
}