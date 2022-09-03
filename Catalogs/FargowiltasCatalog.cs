using System.Collections.Generic;
using CalamityRuTranslate.Common.DataStructures;
using Microsoft.Xna.Framework;

namespace CalamityRuTranslate.Catalogs;

internal static class FargowiltasCatalog
{
    internal static readonly List<TileData> Tiles = new()
    {
        new TileData("CrucibleCosmosSheet", "", new Color(200, 200, 200)),
        new TileData("DemonAltarSheet", "", new Color(200, 200, 200)),
        new TileData("CrimsonAltarSheet", "", new Color(200, 200, 200)),
        new TileData("ElementalAssemblerSheet", "", new Color(200, 200, 200)),
        new TileData("GoldenDippingVatSheet", "", new Color(255, 215, 0)),
        new TileData("MultitaskCenterSheet", "", new Color(200, 200, 200)),
        new TileData("OmnistationPlusSheet", "", new Color(221, 85, 125)),
        new TileData("OmnistationSheet", "", new Color(221, 85, 125)),
        new TileData("OmnistationSheet2", "", new Color(102, 116, 130)),
        new TileData("RegalStatueSheet", "", new Color(200, 200, 200)),
    };
}