using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.Fargowiltas.Items
{
    public static class ItemsTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var id in FargoTranslationLists.FargoItemName)
            {
                try
                {
                    CoreFargowiltasTranslation.Fargo.GetItem(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Fargo.ItemName.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }

            foreach (var id in FargoTranslationLists.FargoItemTooltip)
            {
                try
                {
                    CoreFargowiltasTranslation.Fargo.GetItem(id).Tooltip.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Fargo.ItemTooltip.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}