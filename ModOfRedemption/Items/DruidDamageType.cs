using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ModOfRedemption.Items
{
    public class DruidDamageType : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (ModLoader.GetMod("Redemption") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    if (tooltip.Name == "Damage")
                    {
                        string[] splitText = tooltip.text.Split(' ');
                        string damageValue = splitText.First();
                        string str = tooltip.text;
                        string resultA = str.Replace(" druidic Урон", " урон друида");
                        tooltip.text = resultA;
                        string dmg = damageValue + " урон друида";
                        
                        if (tooltip.text == dmg)
                        {
                            tooltip.overrideColor = new Color(145, 220, 22);
                        }
                    }
                }
            }
        }
    }
}