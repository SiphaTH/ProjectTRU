using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod.Items
{
    public class VanillaItems : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreThoriumTranslation.ThoriumMod != null && TranslationUtils.IsRussianLanguage && TRuConfig.Instance.ThoriumTranslation)
            {
                foreach (TooltipLine tooltipLine in tooltips)
                {
                    switch (tooltipLine.Name)
                    {
                        case "CookText":
                            tooltipLine.text = tooltipLine.text.Replace("The cook might be interested in this", TranslationUtils.KeyText2("Thorium.VanillaItems.CookText"));
                            break;
                        case "BugWarning":
                            tooltipLine.text = tooltipLine.text.Replace("-WARNING-\nThis item is highly unstable in tModLoader\nCommon issues include: Item deletion, unpredictable item swapping, tile breaking\nUse at your own risk", TranslationUtils.KeyText2("Thorium.VanillaItems.BugWarning"));
                            break;
                    }
                }
            }
        }
    }

    public class Tags : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreThoriumTranslation.ThoriumMod != null && TranslationUtils.IsRussianLanguage && TRuConfig.Instance.ThoriumTranslation)
            {
                foreach (TooltipLine tooltipLine in tooltips)
                {
                    switch (tooltipLine.Name)
                    {
                        case "AccessoryWarning":
                            tooltipLine.text = tooltipLine.text
                                .Replace("Hibernation Charm", TranslationUtils.KeyText2("Thorium.Tags.AccessoryWarning.HibernationCharm"))
                                .Replace("Sound Device", TranslationUtils.KeyText2("Thorium.Tags.AccessoryWarning.SoundDevice"))
                                .Replace("Omni Shield", TranslationUtils.KeyText2("Thorium.Tags.AccessoryWarning.OmniShield"))
                                .Replace("Spear Tip", TranslationUtils.KeyText2("Thorium.Tags.AccessoryWarning.SpearTip"))
                                .Replace("Soul Storage", TranslationUtils.KeyText2("Thorium.Tags.AccessoryWarning.SoulStorage"))
                                .Replace("Life Guard", TranslationUtils.KeyText2("Thorium.Tags.AccessoryWarning.LifeGuard"))
                                .Replace("Gem Ring", TranslationUtils.KeyText2("Thorium.Tags.AccessoryWarning.GemRing"));
                            break;
                        case "RealityTag":
                            tooltipLine.text = tooltipLine.text.Replace("Reality Breaker", TranslationUtils.KeyText2("Thorium.Tags.RealityTag"));
                            break;
                        case "TransformationTag":
                            tooltipLine.text = tooltipLine.text.Replace("Transformation", TranslationUtils.KeyText2("Thorium.Tags.TransformationTag"));
                            break;
                        case "ThrowerTag":
                            tooltipLine.text = tooltipLine.text.Replace("Thrower Class", TranslationUtils.KeyText2("Thorium.Tags.ThrowerTag"));
                            break;
                        case "HealerTag":
                            tooltipLine.text = tooltipLine.text.Replace("Healer Class", TranslationUtils.KeyText2("Thorium.Tags.HealerTag"));
                            break;
                    }
                }
            }
        }
    }
    
    public class OtherTooltips : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreThoriumTranslation.ThoriumMod != null && TranslationUtils.IsRussianLanguage && TRuConfig.Instance.ThoriumTranslation)
            {
                foreach (TooltipLine tooltipLine in tooltips)
                {
                    switch (tooltipLine.Name)
                    {
                        case "ScytheSoulCharge":
                            tooltipLine.text = string.Format(TranslationUtils.KeyText2("Thorium.OtherTooltips.ScytheSoulCharge"),
                                tooltipLine.text.Split(' ')[1]);
                            break;
                    }
                }
            }
        }
    }
}