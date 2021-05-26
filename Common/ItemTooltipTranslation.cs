using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common
{
    public readonly struct ItemTooltipTranslation
    {
        private readonly string[] _itemTooltipNames;
        private readonly string[] _tooltipTranslations;
        public int ItemType { get; }

        public ItemTooltipTranslation(int itemType, string tooltipLine, string tooltipTranslation)
        {
            ItemType = itemType;
            _itemTooltipNames = new[] {tooltipLine};
            _tooltipTranslations = new[] {tooltipTranslation};
        }

        public ItemTooltipTranslation(int itemType, string[] tooltipLines, string[] tooltipTranslations)
        {
            ItemType = itemType;
            _itemTooltipNames = tooltipLines;
            _tooltipTranslations = tooltipTranslations;

            if (tooltipLines.Length != tooltipTranslations.Length)
                throw new ArgumentException();
        }

        public bool CheckTooltipName(TooltipLine tooltipLine)
        {
            return _itemTooltipNames.Any(x => x == tooltipLine.Name);
        }

        public void TranslateTooltip(IEnumerable<TooltipLine> tooltipLines)
        {
            var tooltips = tooltipLines as TooltipLine[] ?? tooltipLines.ToArray();
            if (tooltips.Length == 1)
            {
                tooltips[0].text = _tooltipTranslations[0];
                return;
            }

            for (var i = 0; i < _itemTooltipNames.Length; i++)
                if (tooltips[i].Name == _itemTooltipNames[i])
                    tooltips[i].text = _tooltipTranslations[i];
        }
    }
}