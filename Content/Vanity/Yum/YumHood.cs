using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Yum
{
    [AutoloadEquip(EquipType.Head)]
    public class YumHood : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return false;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Капюшон Yum");
            Tooltip.SetDefault("Капюшон старого человека");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 30;
            item.rare = 1;
            item.vanity = true;
        }

        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.overrideColor = new Color(252, 255, 166);
            }
        }
        
        // public override bool IsArmorSet(Item head, Item body, Item legs)
        // {
        //     return body.type == ModContent.ItemType<YumChest>() && legs.type == ModContent.ItemType<YumBoots>();
        // }
        //
        // public override void UpdateArmorSet(Player player)
        // {
        //     player.GetModPlayer<ProjectTRuPlayer>().SetYum = true;
        // }
    }
}