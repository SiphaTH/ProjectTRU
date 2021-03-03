using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Umbra
{
    [AutoloadEquip(EquipType.Head)]
    public class UmbraVoidHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Пустотный капюшон Umbra");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
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
        
        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.overrideColor = new Color(Main.DiscoR, 51, 255 - (int)(Main.DiscoR * 0.4));
            }
        }
    }
}