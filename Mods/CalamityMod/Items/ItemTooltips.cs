using System;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    internal static class ItemTooltips
    {
        public static void SetupTranslation()
        {
            foreach (var id in CalamityTranslationLists.CalamityItemTooltips)
            {
                try
                {
                    CoreCalamityTranslation.CalamityMod.GetItem(id).Tooltip.AddTranslation(GameCulture.Russian,
                        Translation.KeyText($"Calamity.ItemTooltip.{id}"));
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}