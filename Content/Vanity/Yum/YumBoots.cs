using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Yum
{
    [AutoloadEquip(EquipType.Legs)]
    public class YumBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Штаны Yum");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}\nШтаны старого человека");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 22;
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

        public override void UpdateVanity(Player player, EquipType type)
        {
            if (player.velocity.X != 0f)
            {
                int num = Dust.NewDust(new Vector2(player.position.X, player.position.Y + player.height - 4f), player.width, 0, 222);
                Main.dust[num].velocity *= 0f;
                Main.dust[num].scale *= 0.4f;
                Main.dust[num].noGravity = true;
            }
        }
    }
}