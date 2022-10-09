using Microsoft.Xna.Framework;

namespace CalamityRuTranslate.Common.DataStructures;

public readonly struct TileData
{
    public string Id { get; }
    public string MapEntryName { get; }
    public string TranslationKey { get; }
    public Color Color { get; }
    public bool HasContainerName { get; }

    public TileData(string id, string mapEntryName, Color color, string translationKey, bool hasContainerName = false)
    {
        Id = id;
        MapEntryName = mapEntryName;
        TranslationKey = translationKey;
        Color = color;
        HasContainerName = hasContainerName;
    }

    public TileData(string id, string mapEntryName, Color color, bool hasContainerName = false)
    {
        Id = id;
        MapEntryName = mapEntryName;
        TranslationKey = id;
        Color = color;
        HasContainerName = hasContainerName;
    }
}