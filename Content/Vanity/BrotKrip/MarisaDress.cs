using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.BrotKrip
{
    [AutoloadEquip(EquipType.Body)]
    public class MarisaDress : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Бронированное платье BrotKrip");
            Tooltip.SetDefault("Отлично подходит для подражания переводчикам!\n'Перчатки - канон?'");
        }
        
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 24;
            Item.rare = 1;
            Item.vanity = true;
        }
        
        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (TooltipLine tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.OverrideColor = new Color(219, 255, 0);
            }
        }
    }
}