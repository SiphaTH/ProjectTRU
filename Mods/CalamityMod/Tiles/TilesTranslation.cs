using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Tiles
{
	internal static class TilesTranslation
	{
		public static void SetupTranslation()
		{
			foreach (var translation in CalamityTranslationDictionaries.CalamityTiles)
			{
				try
				{
					ModTile modTile = TileLoader.GetTile(CoreCalamityTranslation.Calamity.TileType(translation.Key));
					ModTranslation modTranslation = modTile.CreateMapEntryName(translation.Value.MapEntryName);
					modTranslation.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Calamity.TileName.{translation.Key}"));
					modTile.AddMapEntry(translation.Value.ColorTile, modTranslation);
				}
				catch (NullReferenceException)
				{
					throw new TranslationException(translation.Key);
				}
			}
			
			foreach (var id in CalamityTranslationLists.CalamityChest)
			{
				try
				{
					TileLoader.GetTile(CoreCalamityTranslation.Calamity.TileType(id)).chest = LangUtilities.TranslationKey($"Calamity.ChestName.{id}");
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(id);
				}
			}
            
			foreach (var id in CalamityTranslationLists.CalamityDresser)
			{
				try
				{
					TileLoader.GetTile(CoreCalamityTranslation.Calamity.TileType(id)).dresser = LangUtilities.TranslationKey($"Calamity.DresserName.{id}");
				}
				catch(NullReferenceException)
				{
					throw new TranslationException(id);
				}
			}
		}
	}
}
