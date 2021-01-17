using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Tiles
{
	internal static class TileNames
	{
		public static void SetupTranslation()
		{
			foreach (var translation in CalamityTranslationDictionaries.CalamityTiles)
			{
				try
				{
					ModTile modTile = TileLoader.GetTile(CoreCalamityTranslation.CalamityMod.TileType(translation.Key));
					ModTranslation modTranslation = modTile.CreateMapEntryName(translation.Value.MapEntryName);
					modTranslation.AddTranslation(GameCulture.Russian, Translation.KeyText($"Calamity.TileName.{translation.Key}"));
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
