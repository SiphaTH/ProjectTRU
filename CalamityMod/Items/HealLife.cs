using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Items
{
    public class HealLife : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            Mod calamity = ModLoader.GetMod("CalamityMod");
            if (calamity != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                foreach (TooltipLine tooltipLine in tooltips)
                {
                    if (tooltipLine.Name == "HealLife")
                    {
                        if (item.type == calamity.ItemType("SunkenStew"))
                        {
                            tooltipLine.text = "Восстанавливает 120 единиц здоровья";
                        }
                        if (item.type == calamity.ItemType("GrapeBeer"))
                        {
                            tooltipLine.text = "Восстанавливает 100 единиц здоровья";
                        }
                        if (item.type == calamity.ItemType("Margarita"))
                        {
                            tooltipLine.text = "Восстанавливает 200 единиц здоровья";
                        }
                        if (item.type == calamity.ItemType("Bloodfin"))
                        {
                            tooltipLine.text = "Восстанавливает 240 единиц здоровья";
                        }
                        if (item.type == calamity.ItemType("RedWine"))
                        {
                            tooltipLine.text = "Восстанавливает 200 единиц здоровья";
                        }
                    }
                }
            }
        }
    }
}