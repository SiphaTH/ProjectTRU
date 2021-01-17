using System.Collections.Generic;

namespace CalamityRuTranslate.DictionariesAndLists
{
    public static class ThoriumTranslationLists
    {
        public static List<string> ThoriumChest;
        public static List<string> ThoriumDresser;

        public static void LoadLists()
        {
            ThoriumChest = new List<string>
            {
                "AquaticDepthsBiomeChest",
                "DepthChestTile",
                "DesertBiomeChest",
                "LodestoneChest",
                "MarineChest",
                "PermafrostChest",
                "PlateChest",
                "ScarletChest",
                "ThoriumChest",
                "UnderworldChest",
                "YewChest",
                "OrnateChest",
                "CursedChest",
                "NagaChest",
                "ShadyChest",
                "ValadiumChest",
                "BloodstainedChest"
            };

            ThoriumDresser = new List<string>
            {
                "FurnitureDresser"
            };
        }

        public static void UnloadLists()
        {
            ThoriumChest = null;
            ThoriumDresser = null;
        }
    }
}