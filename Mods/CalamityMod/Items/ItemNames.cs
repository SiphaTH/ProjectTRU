using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.Items
{
    internal static class ItemNames
    {
        public static void SetupTranslation()
        {
            foreach (var id in CalamityTranslationLists.CalamityItemNames)
            {
                try
                {
                    CoreCalamityTranslation.CalamityMod.GetItem(id).DisplayName.AddTranslation(GameCulture.Russian,
                        Translation.KeyText($"Calamity.ItemName.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}