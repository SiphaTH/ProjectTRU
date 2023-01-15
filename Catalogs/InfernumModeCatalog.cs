using System.Collections.Generic;
using CalamityRuTranslate.Common.DataStructures;
using Microsoft.Xna.Framework;

namespace CalamityRuTranslate.Catalogs;

internal static class InfernumModeCatalog
{
    internal static readonly List<TileData> Tiles = new()
    {
        new TileData("GolemArena", "", new Color(40, 70, 70)),
        new TileData("MoonlordArena", "", new Color(40, 70, 70)),
        new TileData("SeaShell", "", new Color(158, 120, 103)),
    };
}