using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content.Vanity.Umbra
{
    [AutoloadEquip(EquipType.Head)]
    public class UmbraVoidHood : ModItem
    {
        private static int _tooltipIndex;
        private static int _counter = 10;

        private readonly string[] _caesarCipher =
        {
            "РПИГПМЭ",
            "РФТУПУЁ",
            "РПДМПУЙУЭ",
            "УЁВА"
        };

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Пустотный капюшон Umbra");
            Tooltip.SetDefault("{$CommonItemTooltip.DevItem}\n[c/fcffb3:Один] лишь Цезарь укажет путь к свету");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 34;
            item.rare = 1;
            item.vanity = true;
        }

        public override void ModifyTooltips(List<TooltipLine> list)
        {
            list.Add(new TooltipLine(mod, $"{mod.Name}:Umbra", _caesarCipher[_tooltipIndex]));

            _counter--;

            if (_counter <= 0)
            {
                _tooltipIndex = Main.rand.Next(_caesarCipher.Length);

                _counter = 90;
            }

            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.overrideColor = ItemHelper.ColorSwap(new Color(209, 77, 253), new Color(83, 2, 218), 2f);
            }
        }
    }
}