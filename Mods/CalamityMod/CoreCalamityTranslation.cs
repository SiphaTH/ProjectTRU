using System;
using System.Linq;
using CalamityMod;
using CalamityMod.World;
using CalamityRuTranslate.Dictionaries;
using CalamityRuTranslate.Mods.CalamityMod.Buffs;
using CalamityRuTranslate.Mods.CalamityMod.Items;
using CalamityRuTranslate.Mods.CalamityMod.NPCs;
using CalamityRuTranslate.Mods.CalamityMod.Projectiles;
using CalamityRuTranslate.Mods.CalamityMod.Tiles;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    internal static class CoreCalamityTranslation
    {
        public static Mod CalamityMod;

        public static void Load()
        {
            CalamityMod = ModLoader.GetMod("CalamityMod");
            
            if (CalamityMod != null && CalamityMod.Version != new Version(1,4,5,7))
            {
                throw new ModVersionException("Calamity", "1.4.5.7");
            }

            if (CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation && Translation.IsRussianLanguage)
            {
                CalamityIL.Load();
                RussianDictionaries.LoadDictionaries();
                RussianDictionaries.CalamityTownNpcName = RussianDictionaries.CalamityTownNpcName.Union(RussianDictionaries.VanillaTownNpcName).ToDictionary(x => x.Key, x => x.Value);
            }
        }

        public static void LoadCrossContent()
        {
            if (CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation && Translation.IsRussianLanguage)
            {
                BuffNames.SetupTranslation();
                ItemNames.SetupTranslation();
                ItemTooltips.SetupTranslation();
                PrefixNames.SetupTranslation();
                NpcNames.SetupTranslation();
                ProjectileNames.SetupTranslation();
                ChestNames.SetupTranslation();
                TileNames.SetupTranslation();
                AddCalamityLocalization();
            }
        }

        public static void LoadNpcChat()
        {
            if (CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation && Translation.IsRussianLanguage)
            {
                NpcChatText.SetupTranslation();
            }
        }
        
        public static void Unload()
        {
            CalamityMod = null;
            CalamityIL.Unload();
            RussianDictionaries.UnloadDictionaries();
        }

        private static void AddCalamityLocalization()
        {
            foreach (var calamityKeys in RussianDictionaries.CalamityKeysLocalization)
            {
                ModTranslation translation = CalamityMod.CreateTranslation(calamityKeys.Key);
                translation.SetDefault(calamityKeys.Value);
                CalamityMod.AddTranslation(translation);
            }
        }
        
        public static bool Revenge => CalamityWorld.revenge;
        public static bool DeathMode => CalamityWorld.death;
        public static bool DownedFlag => !CalamityWorld.downedSentinel1 || !CalamityWorld.downedSentinel2 || !CalamityWorld.downedSentinel3;
        public static string AegisHotKey => global::CalamityMod.CalamityMod.AegisHotKey.TooltipHotkeyString();
        public static string AstralArcanumUiHotkey => global::CalamityMod.CalamityMod.AstralArcanumUIHotkey.TooltipHotkeyString();
        public static string MomentumCapacitatorHotkey => global::CalamityMod.CalamityMod.MomentumCapacitatorHotkey.TooltipHotkeyString();
        public static string SandCloakHotkey => global::CalamityMod.CalamityMod.SandCloakHotkey.TooltipHotkeyString();
        public static string SpectralVeilHotKey => global::CalamityMod.CalamityMod.SpectralVeilHotKey.TooltipHotkeyString();
        public static string NormalityRelocatorHotKey => global::CalamityMod.CalamityMod.NormalityRelocatorHotKey.TooltipHotkeyString();
        public static string PlaguePackHotKey => global::CalamityMod.CalamityMod.PlaguePackHotKey.TooltipHotkeyString();
        public static string RageHotKey => global::CalamityMod.CalamityMod.RageHotKey.TooltipHotkeyString();
        public static string AdrenalineHotKey => global::CalamityMod.CalamityMod.AdrenalineHotKey.TooltipHotkeyString();
        public static string ArmorSetHotkey => global::CalamityMod.CalamityMod.TarraHotKey.TooltipHotkeyString();
        public static int AncientStorm => (int)(60f * Main.LocalPlayer.manaCost);
    }
}