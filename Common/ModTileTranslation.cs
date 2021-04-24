using Microsoft.Xna.Framework;

namespace CalamityRuTranslate.Common
{
    public readonly struct ModTileTranslation
    {
        public string TileId { get; }
        public string MapEntryName { get; }
        public string TranslationKey { get; }
        public Color TileColor { get; }

        public ModTileTranslation(string tileId, string mapEntryName, Color tileColor, string translationKey)
        {
            TileId = tileId;
            MapEntryName = mapEntryName;
            TranslationKey = translationKey;
            TileColor = tileColor;
        }
        
        public ModTileTranslation(string tileId, string mapEntryName, Color tileColor)
        {
            TileId = tileId;
            MapEntryName = mapEntryName;
            TranslationKey = tileId;
            TileColor = tileColor;
        }
    }
}