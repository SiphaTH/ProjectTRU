using System;
using Microsoft.Xna.Framework;
using Terraria;

namespace CalamityRuTranslate.Common.Utilities
{
    public static class ItemNameColorSwap
    {
        public static Color ColorSwap(Color firstColor, Color secondColor, float seconds)
        {
            float num = (float) ((Math.Sin(6.28318548202515 / seconds * Main.GlobalTime) + 1.0) * 0.5);
            return Color.Lerp(firstColor, secondColor, num);
        }
    }
}