using System.Collections.Generic;
using CalamityRuTranslate.Mods.FargowiltasSouls;
using Microsoft.Xna.Framework;

namespace CalamityRuTranslate.DictionariesAndLists
{
    public static class FargoSoulsTranslationDictionaries
    {
        public static Dictionary<string, (string MapEntryName, Color ColorTile)> FargoSoulsTiles;
        public static Dictionary<(int Head, int Body, int Legs), string> FargoSoulsArmorSets;

        public static void LoadDictionaries()
        {
            FargoSoulsTiles = new Dictionary<string, (string MapEntryName, Color ColorTile)>
            {
                {"AbomTrophy", ("", new Color(120, 85, 60))},
                {"DeviTrophy", ("", new Color(120, 85, 60))},
                {"MutantStatue", ("", new Color(144, 144, 144))},
                {"MutantStatueGift", ("", new Color(144, 144, 144))},
                {"MutantTrophy", ("", new Color(120, 85, 60))},
                {"SquidwardDoorClosed", ("", new Color(200, 200, 200))},
                {"SquidwardDoorOpen", ("", new Color(200, 200, 200))}
            };

            FargoSoulsArmorSets = new Dictionary<(int Head, int Body, int Legs), string>
            {
                {(CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("EridanusHat"), CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("EridanusBattleplate"), CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("EridanusLegwear")), "EridanusHat"},
                {(CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("GaiaHelmet"), CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("GaiaPlate"), CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("GaiaGreaves")), "GaiaHelmet"},
                {(CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("MutantMask"), CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("MutantBody"), CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("MutantPants")), "MutantMask"},
            };
        }

        public static void UnloadDictionaries()
        {
            FargoSoulsTiles = null;
            FargoSoulsArmorSets = null;
        }
    }
}