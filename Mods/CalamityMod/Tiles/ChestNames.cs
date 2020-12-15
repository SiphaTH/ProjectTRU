using System;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Tiles
{
    internal static class ChestNames
    {
        public static void SetupTranslation()
        {
            foreach (var translation in RussianDictionaries.CalamityChestName)
            {
                try
                {
                    TileLoader.GetTile(CoreCalamityTranslation.CalamityMod.TileType(translation.Key)).chest = translation.Value;
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(translation.Key, GameCulture.Russian);
                }
            }
        }
    }
}