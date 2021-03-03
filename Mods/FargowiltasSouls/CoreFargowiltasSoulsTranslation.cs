using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Mods.FargowiltasSouls.Buffs;
using CalamityRuTranslate.Mods.FargowiltasSouls.Items;
using CalamityRuTranslate.Mods.FargowiltasSouls.NPCs;
using CalamityRuTranslate.Mods.FargowiltasSouls.Tiles;
using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    internal static class CoreFargowiltasSoulsTranslation
    {
        public static Mod FargoSouls => ModLoader.GetMod("FargowiltasSouls");
        
        public static void Load()
        {
            if (FargoSouls != null && FargoSouls.Version != new Version(1,3,95))
            {
                throw new ModVersionException("FargowiltasSouls", "1.3.95", FargoSouls.Version);
            }

            if (FargoSouls != null)
            {
                FargoSoulsTranslationLists.LoadLists();
                FargoSoulsTranslationDictionaries.LoadDictionaries();
            }
        }

        public static void LoadCrossContent()
        {
            if (FargoSouls != null)
            {
                BuffsTranslation.SetupTranslation();
                ItemsTranslation.SetupTranslation();
                NPCTranslation.SetupTranslation();
                TilesTranslation.SetupTranslation();
            }
        }

        public static void Unload()
        {
            FargoSoulsTranslationLists.UnloadLists();
            FargoSoulsTranslationDictionaries.UnloadDictionaries();
        }
    }
}