using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityRuTranslate.Content.Vanity.Yum
{
    [AutoloadEquip(EquipType.Body)]
    public class YumChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Мантия Yum");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}\nМантия старого человека");
            //ModContent.GetInstance<TRuGlowmask>().AddGlowMask(Item.type, "CalamityRuTranslate/Content/Glowmasks/YumChest_Glow");
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
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