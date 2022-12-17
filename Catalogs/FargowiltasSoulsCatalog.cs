using System.Collections.Generic;
using CalamityRuTranslate.Common.DataStructures;
using Microsoft.Xna.Framework;

namespace CalamityRuTranslate.Catalogs;

internal static class FargowiltasSoulsCatalog
{
    internal static readonly List<TileData> Tiles = new()
    {
        new TileData("FMMBanner", "", new Color(13, 88, 130)),
        new TileData("MutantStatue", "", new Color(144, 144, 144)),
        new TileData("MutantStatueGift", "", new Color(144, 144, 144)),
        new TileData("SquidwardDoorClosed", "", new Color(200, 200, 200)),
        new TileData("SquidwardDoorOpen", "", new Color(200, 200, 200)),
        new TileData("LifeRevitalizerPlaced", "", Color.Pink),
        new TileData("AbomMusicBoxSheet", "", new Color(200, 200, 200)),
        new TileData("ChampionMusicBoxSheet", "", new Color(200, 200, 200)),
        new TileData("DeviMusicBoxSheet", "", new Color(200, 200, 200)),
        new TileData("MutantMusicBoxSheet", "", new Color(200, 200, 200)),
        new TileData("RePrologueMusicBoxSheet", "", new Color(200, 200, 200)),
        new TileData("StoriaMusicBoxSheet", "", new Color(200, 200, 200)),
    };
}