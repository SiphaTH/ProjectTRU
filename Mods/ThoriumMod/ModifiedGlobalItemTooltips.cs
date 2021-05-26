using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod
{
    public class ModifiedGlobalItemTooltips : GlobalItem
    {
        public override bool Autoload(ref string name) => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltipLine in tooltips)
            {
                switch (tooltipLine.Name)
                {
                    case "CookText":
                        tooltipLine.text = tooltipLine.text.Replace("The cook might be interested in this", LangUtils.GetTextValue("Thorium", "TooltipName.CookText"));
                    break;
                    
                    case "BugWarning":
                        tooltipLine.text = LangUtils.GetTextValue("Thorium", "TooltipName.BugWarning");
                    break;
                    
                    case "PrefixAccEmpowermentDuration":
                        tooltipLine.text = LangUtils.GetTextValue("Thorium", "TooltipName.PrefixAccEmpowermentDuration");
                        break;
                }
            }
        }
    }
}