using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.BrotKrip
{
    [AutoloadEquip(EquipType.Legs)]
    public class MarisaSocks : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Фетишистские чулки BrotKrip");
            Tooltip.SetDefault("В чулочках сила!\n{$CommonItemTooltip.DevItem}");
        }
        
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 12;
            item.rare = 1;
            item.vanity = true;
        }
        
        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.overrideColor = new Color(219, 255, 0);
            }
        }
    }
}