using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Mods.Fargowiltas.Buffs;
using CalamityRuTranslate.Mods.Fargowiltas.Items;
using CalamityRuTranslate.Mods.Fargowiltas.NPCs;
using CalamityRuTranslate.Mods.Fargowiltas.Tiles;
using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas
{
    internal static class CoreFargowiltasTranslation
    {
        public static Mod Fargo => ModLoader.GetMod("Fargowiltas");

        public static void Load()
        {
            if (Fargo != null && Fargo.Version != new Version(2, 2, 7))
            {
                throw new ModVersionException("Fargowiltas", "2.2.7", Fargo.Version);
            }

            if (Fargo != null)
            {
                FargoTranslationLists.LoadLists();
                FargoTranslationDictionaries.LoadDictionaries();
            }
        }

        public static void LoadCrossContent()
        {
            if (Fargo != null)
            {
                BuffsTranslation.SetupTranslation();
                ItemsTranslation.SetupTranslation();
                NPCTranslation.SetupTranslation();
                TilesTranslation.SetupTranslation();
            }
        }

        public static void LoadNpcChat()
        {
            if (Fargo != null)
            {
                NPCTextTranslation.SetupTranslation();
            }
        }

        public static void Unload()
        {
            FargoTranslationLists.UnloadLists();
            FargoTranslationDictionaries.UnloadDictionaries();
        }
    }
}