using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Utilities
{
    public abstract class ItemColorLerper : ModItem
    {
        public static Color[] MyColors;
        public static Color CurrentColor;
        public static Color TargetColor;
        public static float Ratio = 0.01f;
        public static int Index = 1;

        public sealed override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (var tooltip in tooltips.Where(tooltip => tooltip.Name == "ItemName"))
            {
                tooltip.overrideColor = Color.Lerp(CurrentColor, TargetColor, Ratio);
                
                if (Ratio < 1f)
                {
                    Ratio += 0.015f;
                }
                else
                {
                    Ratio = 0.01f;
                    CurrentColor = TargetColor;
                    if (Index == 2)
                    {
                        Index = 0;
                    }
                    else
                    {
                        Index++;
                    }
                    TargetColor = MyColors[Index];
                }
            }
        }
    }
}