using System;
using System.Collections.Generic;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.Items
{
    public static class ItemsTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var id in FargoSoulsTranslationLists.FargoSoulsItemName)
            {
                try
                {
                    CoreFargowiltasSoulsTranslation.FargoSouls.GetItem(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"FargoSouls.ItemName.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
            
            foreach (var id in FargoSoulsTranslationLists.FargoSoulsItemTooltip)
            {
                try
                {
                    CoreFargowiltasSoulsTranslation.FargoSouls.GetItem(id).Tooltip.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"FargoSouls.ItemTooltip.{id}"));
                }
                catch(KeyNotFoundException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}