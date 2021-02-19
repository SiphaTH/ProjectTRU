using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.Items
{
    public static class ItemsTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var id in FargoSoulsTranslationLists.FargoSoulsItems)
            {
                try
                {
                    CoreFargowiltasSoulsTranslation.FargoSouls.GetItem(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"FargoSouls.ItemName.{id}"));
                    CoreFargowiltasSoulsTranslation.FargoSouls.GetItem(id).Tooltip.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"FargoSouls.ItemTooltip.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}