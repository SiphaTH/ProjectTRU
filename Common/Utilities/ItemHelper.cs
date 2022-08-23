using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common.Utilities;

internal static class ItemHelper
{
    internal static void TranslateTooltip(Item item, List<TooltipLine> tooltips, string lineName, Action<TooltipLine> action)
    {
        ApplyTooltipEdits(item, tooltips, TooltipLineName(lineName), action);
    }

    internal static void ApplyTooltipEdits(Item item, List<TooltipLine> lines, Func<Item, TooltipLine, bool> predicate, Action<TooltipLine> action)
    {
        foreach (var line in lines.Where(line => predicate(item, line)))
            if (line != null)
                action(line);
    }

    private static Func<Item, TooltipLine, bool> TooltipLineName(string name)
    {
        return (item, tooltip) => tooltip.Name == name;
    }

    internal static Color ColorSwap(Color firstColor, Color secondColor, float seconds)
    {
        float num = (float) ((Math.Sin(6.28318548202515 / seconds * Main.GlobalTimeWrappedHourly) + 1.0) * 0.5);

        return Color.Lerp(firstColor, secondColor, num);
    }

    internal static void SetBonusColorTooltip(Item item, List<TooltipLine> tooltips, params string[] tooltipLine)
    {
        for (int i = 0; i < tooltipLine.Length; i++)
        {
            TranslateTooltip(item, tooltips, i == 0 ? "SetBonus" : $"CalamityMod:SetBonus{i}", tooltip =>
            {
                if (tooltipLine[i] != "") {
                    tooltip.Text = LangHelper.GetTextValue(tooltipLine[i]);
                }
            });
        }
    }
}