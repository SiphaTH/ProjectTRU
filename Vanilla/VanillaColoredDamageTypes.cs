using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla;

public class VanillaColoredDamageTypes : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (!TRuConfig.Instance.ColoredDamageTypes)
            return;

        ItemHelper.TranslateTooltip(item, tooltips, "Damage", tooltip =>
        {
            if (item.CountsAsClass(DamageClass.Melee))
                tooltip.OverrideColor = new Color(255, 85, 85);

            else if (item.CountsAsClass(DamageClass.Magic) && tooltip.Text.Contains(Language.GetTextValue("LegacyTooltip.4")))
                tooltip.OverrideColor = new Color(189, 147, 249);

            else if (item.CountsAsClass(DamageClass.Ranged))
                tooltip.OverrideColor = new Color(80, 250, 123);

            else if (item.CountsAsClass(DamageClass.Summon) || item.CountsAsClass(DamageClass.SummonMeleeSpeed))
                tooltip.OverrideColor = new Color(241, 250, 140);
        });
    }
}