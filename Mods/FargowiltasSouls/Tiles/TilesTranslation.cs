using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.Tiles
{
    public static class TilesTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var translation in FargoSoulsTranslationDictionaries.FargoSoulsTiles)
            {
                try
                {
                    ModTile modTile = TileLoader.GetTile(CoreFargowiltasSoulsTranslation.FargoSouls.TileType(translation.Key));
                    ModTranslation modTranslation = modTile.CreateMapEntryName(translation.Value.MapEntryName);
                    modTranslation.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"FargoSouls.TileName.{translation.Key}"));
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