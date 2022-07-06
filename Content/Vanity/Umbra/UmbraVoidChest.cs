using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Umbra
{
    [AutoloadEquip(EquipType.Body)]
    public class UmbraVoidChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Пустотный нагрудник Umbra");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}\nСплав сие одеяния - единственный во всей Вселенной, что может сдержать 'ничего'");
        }

        public override void SetDefaults()
        {
            Item.width = 44;
            Item.height = 32;
            Item.rare = 1;
            Item.vanity = true;
        }

        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.OverrideColor = ItemHelper.ColorSwap(new Color(209, 77, 253), new Color(83, 2, 218), 2f);
            }
        }
    }
}