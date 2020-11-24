using CalamityMod;
using CalamityMod.World;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate
{
    public static class ModCompatibility
    {
        public static Mod CalamityMod;
        public static Mod ThoriumMod;
        public static Mod RedemptionMod;
        public static Mod ElementsAwokenMod;
        public static Mod SpiritMod;

        public static void Load()
        {
            CalamityMod = ModLoader.GetMod("CalamityMod");
            ThoriumMod = ModLoader.GetMod("ThoriumMod");
            RedemptionMod = ModLoader.GetMod("Redemption");
            ElementsAwokenMod = ModLoader.GetMod("ElementsAwoken");
            SpiritMod = ModLoader.GetMod("SpiritMod");
        }
        
        public static void Unload()
        {
            CalamityMod = null;
            ThoriumMod = null;
            RedemptionMod = null;
            ElementsAwokenMod = null;
            SpiritMod = null;
        }

        public static bool Revenge => CalamityWorld.revenge;
        public static bool DeathMode => CalamityWorld.death;
        public static bool DownedFlag => !CalamityWorld.downedSentinel1 || !CalamityWorld.downedSentinel2 || !CalamityWorld.downedSentinel3;
        public static string AegisHotKey => global::CalamityMod.CalamityMod.AegisHotKey.TooltipHotkeyString();
        public static string AstralArcanumUIHotkey => global::CalamityMod.CalamityMod.AstralArcanumUIHotkey.TooltipHotkeyString();
        public static string MomentumCapacitatorHotkey => global::CalamityMod.CalamityMod.MomentumCapacitatorHotkey.TooltipHotkeyString();
        public static string SandCloakHotkey => global::CalamityMod.CalamityMod.SandCloakHotkey.TooltipHotkeyString();
        public static string SpectralVeilHotKey => global::CalamityMod.CalamityMod.SpectralVeilHotKey.TooltipHotkeyString();
        public static string NormalityRelocatorHotKey => global::CalamityMod.CalamityMod.NormalityRelocatorHotKey.TooltipHotkeyString();
        public static string PlaguePackHotKey => global::CalamityMod.CalamityMod.PlaguePackHotKey.TooltipHotkeyString();
        public static string RageHotKey => global::CalamityMod.CalamityMod.RageHotKey.TooltipHotkeyString();
        public static string AdrenalineHotKey => global::CalamityMod.CalamityMod.AdrenalineHotKey.TooltipHotkeyString();
        public static string ArmorSetHotkey => global::CalamityMod.CalamityMod.TarraHotKey.TooltipHotkeyString();
        public static int CalamityAncientStorm => (int)(60f * Main.LocalPlayer.manaCost);
    }
}