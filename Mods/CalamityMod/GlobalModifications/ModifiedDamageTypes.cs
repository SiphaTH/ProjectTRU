using System.Collections.Generic;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications;

[JITWhenModsEnabled("CalamityMod")]
public class ModifiedDamageTypes : GlobalItem
{
    public DamageClass Rogue => ModContent.GetInstance<RogueDamageClass>();
    public DamageClass Average => ModContent.GetInstance<AverageDamageClass>();
    public DamageClass TrueMelee => ModContent.GetInstance<TrueMeleeDamageClass>();
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(item, tooltips, "Damage", tooltip =>
        {
            if (item.CountsAsClass(Rogue))
            {
                tooltip.Text = tooltip.Text.Replace("rogue damage", "ед. разбойного урона");
            
                if (TRuConfig.Instance.ColoredDamageTypes)
                    tooltip.OverrideColor = new Color(255, 184, 108);
            }
            else if (item.CountsAsClass(TrueMelee))
            {
                tooltip.Text = tooltip.Text.Replace("true melee damage", "ед. истинного урона ближнего боя");
            }
            else if (item.CountsAsClass(Average))
            {
                tooltip.Text = tooltip.Text.Replace("average damage", "ед. общего урона");
            }
        });
    }
}