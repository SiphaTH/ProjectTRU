using System;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Tiles
{
	internal static class TileNames
	{
		public static void SetupTranslation()
		{
			foreach (var translation in RussianDictionaries.CalamityTiles)
			{
				try
				{
					ModTile modTile = TileLoader.GetTile(CoreCalamityTranslation.CalamityMod.TileType(translation.Key));
					ModTranslation modTranslation = modTile.CreateMapEntryName(translation.Value.Item1);
					modTranslation.AddTranslation(GameCulture.Russian, translation.Value.Item2);
					modTile.AddMapEntry(translation.Value.Item3, modTranslation);
				}
				catch (NullReferenceException)
				{
					throw new TranslationException(translation.Key, GameCulture.Russian);
				}
			}
		}
	}
}
