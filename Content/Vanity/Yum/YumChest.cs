using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Yum
{
    [AutoloadEquip(EquipType.Body)]
    public class YumChest : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return false;
        }
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Доспех Yum");
            Tooltip.SetDefault("Доспехи старого человека");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 20;
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