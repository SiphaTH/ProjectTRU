using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.BrotKrip
{
    [AutoloadEquip(EquipType.Head)]
    public class MarisaHat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Многомерная шляпа BrotKrip");
            Tooltip.SetDefault("Отлично подходит для подражания переводчикам!\n'Аналитическая и алгебраическая топология евклидовой метризации бесконечно дифференцируемого риманова многообразия'\n'БОЖЕ МОЙ!'");
        }
        
        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 20;
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