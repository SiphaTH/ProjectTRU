using CalamityRuTranslate.Utilities;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Umbra
{
    [AutoloadEquip(EquipType.Legs)]
    public class UmbraVoidGreaves : ItemColorLerper
    {
        // public static Color[] Colors = {new Color(209, 77, 253), new Color(143, 77, 253), new Color(83, 2, 218)};

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Пустотные сапоги Umbra");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}");
            MyColors = new[] {new Color(209, 77, 253), new Color(143, 77, 253), new Color(83, 2, 218)};
            CurrentColor = MyColors[0];
            TargetColor = MyColors[1];
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}