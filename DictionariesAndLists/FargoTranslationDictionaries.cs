using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace CalamityRuTranslate.DictionariesAndLists
{
    public static class FargoTranslationDictionaries
    {
        public static Dictionary<string, (string MapEntryName, Color ColorTile)> FargoTiles;

        public static void LoadDictionaries()
        {
            FargoTiles = new Dictionary<string, (string MapEntryName, Color ColorTile)>
            {
                {"MultitaskCenterSheet", ("", new Color(200, 200, 200))},
                {"CrucibleCosmosSheet", ("", new Color(200, 200, 200))},
                {"ElementalAssemblerSheet", ("", new Color(200, 200, 200))},
                {"OmnistationPlusSheet", ("", new Color(221, 85, 125))},
                {"OmnistationSheet", ("", new Color(221, 85, 125))},
                {"RegalStatueSheet", ("", new Color(200, 200, 200))},
            };
        }

        public static void UnloadDictionaries()
        {
            FargoTiles = null;
        }
    }
}