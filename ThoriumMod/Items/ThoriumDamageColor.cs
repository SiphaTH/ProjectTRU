using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Items
{
    public class ThoriumDamageColor : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (ModLoader.GetMod("ThoriumMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    if (tooltip.Name == "Damage")
                    {
                        string[] splitText = tooltip.text.Split(' ');
                        string damageValue = splitText.First();
                        string str = tooltip.text;
                        string resultA = str.Replace(" radiant damage", " лучезарный урон");
                        tooltip.text = resultA;
                        string dmg = damageValue + " лучезарный урон";
                        
                        if (tooltip.text == dmg)
                        {
                            tooltip.overrideColor = new Color(190, 245, 116);
                        }
                    }
                }
                foreach (TooltipLine tooltip2 in tooltips)
                {
                    if (tooltip2.Name == "Damage")
                    {
                        string[] splitText = tooltip2.text.Split(' ');
                        string damageValue = splitText.First();
                        string str2 = tooltip2.text;
                        string resultA = str2.Replace(" symphonic damage", " симфонический урон");
                        string dmg2 = damageValue + " симфонический урон";
                        tooltip2.text = resultA;
                        
                        if (tooltip2.text == dmg2)
                        {
                            tooltip2.overrideColor = new Color(255, 87, 210);
                        }
                    }
                }
                foreach (TooltipLine tooltip3 in tooltips)
                {
                    if (tooltip3.Name == "Damage")
                    {
                        string str3 = tooltip3.text;
                        string resultA = str3.Replace(" true damage", " чистый урон");
                        string resultB = resultA.Replace(" of targets health as ", " здоровья цели как ");
                        tooltip3.text = resultB;
                    }
                }
            }
        }
    }
}