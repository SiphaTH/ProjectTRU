using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityRuTranslate.Content.Vanity.Yum
{
    [AutoloadEquip(EquipType.Head)]
    public class YumHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Капюшон Yum");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}\nКапюшон старого человека");
            //ModContent.GetInstance<TRuGlowmask>().AddGlowMask(Item.type, "CalamityRuTranslate/Content/Glowmasks/YumHood_Glow");
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 30;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }

        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.OverrideColor = new Color(252, 255, 166);
            }
        }
    }
}