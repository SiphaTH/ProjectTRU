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
        public override bool Autoload(ref string name)
        {
            return false;
        }
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ботинки Yum");
            Tooltip.SetDefault("Ботинки старого человека");
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
    }
}