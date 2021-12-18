using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Umbra
{
    [AutoloadEquip(EquipType.Legs)]
    public class UmbraVoidGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Пустотные сапоги Umbra");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}\nОт следов этих ботинок исходит затягивающий дым");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }

        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.overrideColor = ItemHelper.ColorSwap(new Color(209, 77, 253), new Color(83, 2, 218), 2f);
            }
        }
    }
}