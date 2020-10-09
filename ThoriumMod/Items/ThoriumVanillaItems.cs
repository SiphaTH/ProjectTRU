using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Items
{
    public class ThoriumVanillaItems : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (ModLoader.GetMod("ThoriumMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (CalamityRuTranslate.TRuConfig.ThoriumTranslation)
                {
                    if (item.type == 1113 || item.type == 1110 || item.type == 1109 || item.type == 1114 ||
                        item.type == 1108 || item.type == 1112 || item.type == 1111 || item.type == 1107 ||
                        item.type == 1291 || item.type == 183 || item.type == 68 || item.type == 1330 ||
                        item.type == 967)
                    {
                        foreach (TooltipLine tooltipLine in tooltips)
                        {
                            string resultA = tooltipLine.text.Replace("The cook might be interested in this",
                                "Повару это должно быть интересно");
                            tooltipLine.text = resultA;
                        }
                    }

                    if (item.type == 3270 || item.type == 498 || item.type == 1989 || item.type == 2699)
                    {
                        foreach (TooltipLine tooltipLine2 in tooltips)
                        {
                            string resultA2 = tooltipLine2.text.Replace(
                                "-WARNING-\nThis item is highly unstable in tModLoader\nCommon issues include: Item deletion, unpredictable item swapping, tile breaking\nUse at your own risk",
                                "-ПРЕДУПРЕЖДЕНИЕ-\nЭтот предмет нестабилен в tModLoader\nОбщие проблемы включают в себя: Удаление предмета, непредсказуемая замена предмета, разрушение тайла\nИспользуйте на свой страх и риск");
                            tooltipLine2.text = resultA2;
                        }
                    }
                }
            }
        }
    }
}