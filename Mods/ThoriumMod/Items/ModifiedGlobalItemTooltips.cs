using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod.Items
{
    public class Tags : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage)
            {
                foreach (TooltipLine tooltipLine in tooltips)
                {
                    switch (tooltipLine.Name)
                    {
                        case "AccessoryWarning":
                            tooltipLine.text = tooltipLine.text
                                .Replace("Hibernation Charm", LangUtils.GetTextValue("Thorium","Tags.AccessoryWarning.HibernationCharm"))
                                .Replace("Sound Device", LangUtils.GetTextValue("Thorium", "Tags.AccessoryWarning.SoundDevice"))
                                .Replace("Omni Shield", LangUtils.GetTextValue("Thorium", "Tags.AccessoryWarning.OmniShield"))
                                .Replace("Spear Tip", LangUtils.GetTextValue("Thorium", "Tags.AccessoryWarning.SpearTip"))
                                .Replace("Soul Storage", LangUtils.GetTextValue("Thorium", "Tags.AccessoryWarning.SoulStorage"))
                                .Replace("Life Guard", LangUtils.GetTextValue("Thorium", "Tags.AccessoryWarning.LifeGuard"))
                                .Replace("Gem Ring", LangUtils.GetTextValue("Thorium", "Tags.AccessoryWarning.GemRing"));
                            break;
                        case "RealityTag":
                            tooltipLine.text = tooltipLine.text.Replace("Reality Breaker", LangUtils.GetTextValue("Thorium", "Tags.RealityTag"));
                            break;
                        case "TransformationTag":
                            tooltipLine.text = tooltipLine.text.Replace("Transformation", LangUtils.GetTextValue("Thorium", "Tags.TransformationTag"));
                            break;
                        case "ThrowerTag":
                            tooltipLine.text = tooltipLine.text.Replace("Thrower Class", LangUtils.GetTextValue("Thorium", "Tags.ThrowerTag"));
                            break;
                        case "HealerTag":
                            tooltipLine.text = tooltipLine.text.Replace("Healer Class", LangUtils.GetTextValue("Thorium", "Tags.HealerTag"));
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
            if (ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage)
            {
                foreach (TooltipLine tooltipLine in tooltips)
                {
                    switch (tooltipLine.Name)
                    {
                        case "ScytheSoulCharge":
                            tooltipLine.text = string.Format(LangUtils.GetTextValue("Thorium", "OtherTooltips.ScytheSoulCharge"),
                                tooltipLine.text.Split(' ')[1]);
                            break;
                    }
                }
            }
        }
    }
}