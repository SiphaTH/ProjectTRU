using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    internal static class ItemsTranslation
    {
        public static void SetupTranslation()
        {
            foreach (var id in CalamityTranslationLists.CalamityItemNames)
            {
                try
                {
                    CoreCalamityTranslation.Calamity.GetItem(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Calamity.ItemName.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }

            foreach (var id in CalamityTranslationLists.CalamityItemTooltips)
            {
                try
                {
                    CoreCalamityTranslation.Calamity.GetItem(id).Tooltip.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Calamity.ItemTooltip.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}