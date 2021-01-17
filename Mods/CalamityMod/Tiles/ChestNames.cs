using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Tiles
{
    internal static class ChestNames
    {
        public static void SetupTranslation()
        {
            foreach (var id in CalamityTranslationLists.CalamityChest)
            {
                try
                {
                    TileLoader.GetTile(CoreCalamityTranslation.CalamityMod.TileType(id)).chest = Translation.KeyText($"Calamity.ChestName.{id}");
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
                    TileLoader.GetTile(CoreCalamityTranslation.CalamityMod.TileType(id)).dresser = Translation.KeyText($"Calamity.DresserName.{id}");
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}