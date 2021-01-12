using System;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Mods.ThoriumMod.Buffs;
using CalamityRuTranslate.Mods.ThoriumMod.Items;
using CalamityRuTranslate.Mods.ThoriumMod.Projectiles;
using CalamityRuTranslate.Mods.ThoriumMod.Tiles;
using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod
{
    internal static class CoreThoriumTranslation
    {
        public static Mod ThoriumMod;

        public static void Load()
        {
            ThoriumMod = ModLoader.GetMod("ThoriumMod");

            if (ThoriumMod != null && ThoriumMod.Version != new Version(1, 6, 3, 13))
            {
                throw new ModVersionException("Thorium", "1.6.3.13");
            }

            if (ThoriumMod != null && CalamityRuTranslate.Config.ThoriumTranslation && Translation.IsRussianLanguage)
            {
                ThoriumIL.Load();
                ThoriumRussianDictionaries.LoadDictionaries();
            }
        }

        public static void LoadCrossContent()
        {
            if (ThoriumMod != null && CalamityRuTranslate.Config.ThoriumTranslation && Translation.IsRussianLanguage)
            {
                BuffNames.SetupTranslation();
                ProjectileNames.SetupTranslation();
                PrefixNames.SetupTranslation();
                ChestNames.SetupTranslation();
            }
        }

        public static void Unload()
        {
            ThoriumMod = null;
            ThoriumIL.Unload();
            ThoriumRussianDictionaries.UnloadDictionaries();
        }
    }
}