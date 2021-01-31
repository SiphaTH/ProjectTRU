using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod.Items
{
    public class VanillaItems : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (CoreThoriumTranslation.ThoriumMod != null && Translation.IsRussianLanguage && ProjectTRuConfig.Instance.ThoriumTranslation)
            {
                foreach (TooltipLine tooltipLine in tooltips)
                {
                    switch (tooltipLine.Name)
                    {
                        case "CookText":
                            tooltipLine.text = tooltipLine.text.Replace("The cook might be interested in this", Translation.KeyText2("Thorium.VanillaItems.CookText"));
                            break;
                        case "BugWarning":
                            tooltipLine.text = tooltipLine.text.Replace("-WARNING-\nThis item is highly unstable in tModLoader\nCommon issues include: Item deletion, unpredictable item swapping, tile breaking\nUse at your own risk", Translation.KeyText2("Thorium.VanillaItems.BugWarning"));
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
            if (CoreThoriumTranslation.ThoriumMod != null && Translation.IsRussianLanguage && ProjectTRuConfig.Instance.ThoriumTranslation)
            {
                foreach (TooltipLine tooltipLine in tooltips)
                {
                    switch (tooltipLine.Name)
                    {
                        case "AccessoryWarning":
                            tooltipLine.text = tooltipLine.text
                                .Replace("Hibernation Charm", Translation.KeyText2("Thorium.Tags.AccessoryWarning.HibernationCharm"))
                                .Replace("Sound Device", Translation.KeyText2("Thorium.Tags.AccessoryWarning.SoundDevice"))
                                .Replace("Omni Shield", Translation.KeyText2("Thorium.Tags.AccessoryWarning.OmniShield"))
                                .Replace("Spear Tip", Translation.KeyText2("Thorium.Tags.AccessoryWarning.SpearTip"))
                                .Replace("Soul Storage", Translation.KeyText2("Thorium.Tags.AccessoryWarning.SoulStorage"))
                                .Replace("Life Guard", Translation.KeyText2("Thorium.Tags.AccessoryWarning.LifeGuard"))
                                .Replace("Gem Ring", Translation.KeyText2("Thorium.Tags.AccessoryWarning.GemRing"));
                            break;
                        case "RealityTag":
                            tooltipLine.text = tooltipLine.text.Replace("Reality Breaker", Translation.KeyText2("Thorium.Tags.RealityTag"));
                            break;
                        case "TransformationTag":
                            tooltipLine.text = tooltipLine.text.Replace("Transformation", Translation.KeyText2("Thorium.Tags.TransformationTag"));
                            break;
                        case "ThrowerTag":
                            tooltipLine.text = tooltipLine.text.Replace("Thrower Class", Translation.KeyText2("Thorium.Tags.ThrowerTag"));
                            break;
                        case "HealerTag":
                            tooltipLine.text = tooltipLine.text.Replace("Healer Class", Translation.KeyText2("Thorium.Tags.HealerTag"));
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
            if (CoreThoriumTranslation.ThoriumMod != null && Translation.IsRussianLanguage && ProjectTRuConfig.Instance.ThoriumTranslation)
            {
                foreach (TooltipLine tooltipLine in tooltips)
                {
                    switch (tooltipLine.Name)
                    {
                        case "ScytheSoulCharge":
                            tooltipLine.text = string.Format(Translation.KeyText2("Thorium.OtherTooltips.ScytheSoulCharge"),
                                tooltipLine.text.Split(' ')[1]);
                            break;
                    }
                }
            }
        }
    }
}