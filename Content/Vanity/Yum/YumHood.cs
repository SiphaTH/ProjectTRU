using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Yum
{
    [AutoloadEquip(EquipType.Head)]
    public class YumHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Капюшон Yum");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}\nКапюшон старого человека");
            TRuGlowmask.AddGlowMask(item.type, "CalamityRuTranslate/Content/Glowmasks/YumHood_Glow");
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
    }
}