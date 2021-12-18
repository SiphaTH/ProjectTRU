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
            ModContent.GetInstance<TRuGlowmask>().AddGlowMask(item.type, "CalamityRuTranslate/Content/Glowmasks/YumChest_Glow");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 20;
            item.rare = ItemRarityID.Blue;
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