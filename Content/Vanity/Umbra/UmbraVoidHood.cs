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

        private static string[] _caesarCipher =
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
            Item.width = 26;
            Item.height = 34;
            Item.rare = 1;
            Item.vanity = true;
        }

        public override void ModifyTooltips(List<TooltipLine> list)
        {
            list.Add(new TooltipLine(Mod, $"{Mod.Name}:Umbra", _caesarCipher[_tooltipIndex]));

            _counter--;

            if (_counter <= 0)
            {
                _tooltipIndex = Main.rand.Next(_caesarCipher.Length);

                _counter = 90;
            }

            foreach (var tooltip in list.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.OverrideColor = ItemHelper.ColorSwap(new Color(209, 77, 253), new Color(83, 2, 218), 2f);
            }
        }
    }
}