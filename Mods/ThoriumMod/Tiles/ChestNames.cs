using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod.Tiles
{
    internal static class ChestNames
    {
        public static void SetupTranslation()
        {
            foreach (var translation in ThoriumRussianDictionaries.ThoriumChestName)
            {
                try
                {
                    TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType(translation.Key)).chest = translation.Value;
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(translation.Key);
                }
            }
            
            foreach (var translation in ThoriumRussianDictionaries.ThoriumDresserName)
            {
                try
                {
                    TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType(translation.Key)).dresser = translation.Value;
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(translation.Key);
                }
            }
        }
    }
}