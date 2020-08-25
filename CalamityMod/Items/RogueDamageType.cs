using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.CalamityMod.Items
{
    public class RogueDamageType : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (ModLoader.GetMod("CalamityMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    if (tooltip.Name == "Damage")
                    {
                        string[] splitText = tooltip.text.Split(' ');
                        string damageValue = splitText.First();
                        string str = tooltip.text;
                        string resultA = str.Replace(" rogue метании", " разбойный урон");
                        tooltip.text = resultA;
                        string dmg = damageValue + " разбойный урон";
                        
                        if (tooltip.text == dmg)
                        {
                            tooltip.overrideColor = new Color(255, 184, 108);
                        }
                    }
                }
                foreach (TooltipLine tooltip2 in tooltips)
                {
                    if (tooltip2.Name == "Damage")
                    {
                        string str = tooltip2.text;
                        string resultA = str.Replace(" true melee damage", " истинный урон ближнего боя");
                        tooltip2.text = resultA;
                    }
                }
            }
        }
    }
}