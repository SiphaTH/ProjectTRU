using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Umbra
{
    [AutoloadEquip(EquipType.Legs)]
    public class UmbraVoidGreaves : ModItem
    {
        // public static Color[] Colors = {new Color(209, 77, 253), new Color(143, 77, 253), new Color(83, 2, 218)};
        // public static Color _currentColor = Colors[0];
        // public static Color _targetColor = Colors[1];
        // public static float _ratio = 0.1f;
        // public static int _index = 1;

        public override void SetStaticDefaults() => DisplayName.SetDefault("Пустотные сапоги Umbra");

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
                // d14dfd = 209, 77, 253
                // 8f4dfd = 143, 77, 253
                // 5302da = 83, 2, 218
                tooltip.overrideColor = Color.Lerp(Color.Cyan, Color.Aqua, 0.01f);
            }

            // if (_ratio < 1f)
            // {
            //     _ratio += 0.01f;
            // }
            // else
            // {
            //     _ratio = 0.01f;
            //     _currentColor = _targetColor;
            //     if (_index == 2)
            //     {
            //         _index = 0;
            //     }
            //     else
            //     {
            //         _index++;
            //     }
            //     _targetColor = Colors[_index];
            // }
        }
    }
}