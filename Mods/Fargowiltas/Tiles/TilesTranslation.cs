using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.Tiles
{
    public static class TilesTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var translation in FargoTranslationDictionaries.FargoTiles)
            {
                try
                {
                    ModTile modTile = TileLoader.GetTile(CoreFargowiltasTranslation.Fargo.TileType(translation.Key));
                    ModTranslation modTranslation = modTile.CreateMapEntryName(translation.Value.MapEntryName);
                    modTranslation.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Fargo.TileName.{translation.Key}"));
                    modTile.AddMapEntry(translation.Value.ColorTile, modTranslation);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(translation.Key);
                }
            }
        }
    }
}