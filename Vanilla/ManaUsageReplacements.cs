using System.Collections.Generic;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla
{
    public class ManaUsageReplacements : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Translation.IsRussianLanguage && CalamityRuTranslate.Config.NewVanillaTranslation && ModLoader.GetMod("TerrariaOverhaul") == null)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    if (tooltip.Name == "UseMana")
                    {
                        string manaUsage = tooltip.text.Split(' ')[1];
                        if (int.Parse(manaUsage) == 1 || manaUsage.Length > 1 &&
                            manaUsage[manaUsage.Length - 1] == '1' && manaUsage[manaUsage.Length - 2] != '1')
                        {
                            tooltip.text = string.Format(Language.GetTextValue("CommonItemTooltip.NewUsesMana"), manaUsage);
                        }
                    }
                }
            }
        }
    }
}