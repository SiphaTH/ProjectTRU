using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common.Exceptions;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Mods.ThoriumMod.Buffs;
using CalamityRuTranslate.Mods.ThoriumMod.Items;
using CalamityRuTranslate.Mods.ThoriumMod.Projectiles;
using CalamityRuTranslate.Mods.ThoriumMod.Tiles;
using CalamityRuTranslate.ThoriumMod.Items;
using CalamityRuTranslate.ThoriumMod.ModSupport;
using CalamityRuTranslate.ThoriumMod.NPCs;
using CalamityRuTranslate.ThoriumMod.Tiles;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod
{
    internal static class CoreThoriumTranslation
    {
        public static Mod ThoriumMod;

        public static void Load()
        {
            ThoriumMod = ModLoader.GetMod("ThoriumMod");

            if (ThoriumMod != null && ThoriumMod.Version != new Version(1, 6, 4, 1))
            {
                throw new ModVersionException("Thorium", "1.6.4.1", ThoriumMod.Version);
            }

            if (ThoriumMod != null && TRuConfig.Instance.ThoriumTranslation && TranslationUtils.IsRussianLanguage)
            {
                ThoriumIL.Load();
                ThoriumTranslationLists.LoadLists();
                ThoriumRussianDictionaries.LoadDictionaries();
            }
        }

        public static void LoadCrossContent()
        {
            if (ThoriumMod != null && TRuConfig.Instance.ThoriumTranslation && TranslationUtils.IsRussianLanguage)
            {
                ThoriumItemName.Setup();
                ThoriumItemTooltip.Setup();
                ThoriumNpc.Setup();
                BuffTranslation.SetupTranslation();
                ProjectileNames.SetupTranslation();
                PrefixNames.SetupTranslation();
                ThoriumTiles.Setup();
                ChestNames.SetupTranslation();
                ThoriumSupport.ThoriumAddLocalizations();
            }
        }

        public static void Unload()
        {
            ThoriumMod = null;
            ThoriumIL.Unload();
            ThoriumRussianDictionaries.UnloadDictionaries();
            ThoriumTranslationLists.UnloadLists();
        }
    }
}