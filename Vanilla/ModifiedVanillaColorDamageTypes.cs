using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla
{
    public class ModifiedVanillaColorDamageTypes : GlobalItem
    {
        public override bool Autoload(ref string name) => TranslationUtils.IsRussianLanguage;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (!TRuConfig.Instance.ColoredDamageTypes)
                return;

            foreach (TooltipLine tooltip in tooltips.Where(tooltip => tooltip.Name == "Damage"))
            {
                if (item.melee)
                    tooltip.overrideColor = new Color(255, 85, 85);

                else if (item.magic && tooltip.text.Contains(Language.GetTextValue("LegacyTooltip.4")))
                    tooltip.overrideColor = new Color(189, 147, 249);

                else if (item.ranged)
                    tooltip.overrideColor = new Color(80, 250, 123);

                else if (item.summon)
                    tooltip.overrideColor = new Color(241, 250, 140);

                else if (tooltip.text.Contains(Language.GetTextValue("LegacyTooltip.55")))
                    tooltip.overrideColor = new Color(133, 133, 133);
            }
        }
    }
}