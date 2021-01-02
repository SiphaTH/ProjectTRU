using System;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    internal static class ItemNames
    {
        public static void SetupTranslation()
        {
            foreach (var translation in RussianDictionaries.CalamityItemName)
            {
                try
                {
                    CoreCalamityTranslation.CalamityMod.GetItem(translation.Key).DisplayName.AddTranslation(GameCulture.Russian, translation.Value);
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(translation.Key);
                }
            }
        }
    }
}