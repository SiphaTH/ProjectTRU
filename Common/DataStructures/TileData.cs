using Microsoft.Xna.Framework;

namespace CalamityRuTranslate.Common.DataStructures;

public readonly struct TileData
{
    public string Id { get; }
    public string MapEntryName { get; }
    public string TranslationKey { get; }
    public Color Color { get; }

    public TileData(string id, string mapEntryName, Color color, string translationKey)
    {
        Id = id;
        MapEntryName = mapEntryName;
        TranslationKey = translationKey;
        Color = color;
    }

    public TileData(string id, string mapEntryName, Color color)
    {
        Id = id;
        MapEntryName = mapEntryName;
        TranslationKey = id;
        Color = color;
    }
}