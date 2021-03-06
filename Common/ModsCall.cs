using CalamityMod;
using CalamityMod.World;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common
{
    public static class ModsCall
    {
        internal static Mod Calamity => ModLoader.GetMod("CalamityMod");
        internal static Mod Thorium => ModLoader.GetMod("ThoriumMod");
        internal static Mod Fargo => ModLoader.GetMod("Fargowiltas");
        internal static Mod FargoSouls => ModLoader.GetMod("FargowiltasSouls");

        internal static bool Revenge => CalamityWorld.revenge;
        internal static bool DeathMode => CalamityWorld.death;
        internal static bool DownedFlag => !CalamityWorld.downedSentinel1 || !CalamityWorld.downedSentinel2 || !CalamityWorld.downedSentinel3;
        internal static bool ProfanedCrystalBuffs => Main.player[Main.myPlayer].Calamity().profanedCrystalBuffs;
        internal static string AegisHotKey => global::CalamityMod.CalamityMod.AegisHotKey.TooltipHotkeyString();
        internal static string AstralArcanumUiHotkey => global::CalamityMod.CalamityMod.AstralArcanumUIHotkey.TooltipHotkeyString();
        internal static string MomentumCapacitatorHotkey => global::CalamityMod.CalamityMod.MomentumCapacitatorHotkey.TooltipHotkeyString();
        internal static string SandCloakHotkey => global::CalamityMod.CalamityMod.SandCloakHotkey.TooltipHotkeyString();
        internal static string SpectralVeilHotKey => global::CalamityMod.CalamityMod.SpectralVeilHotKey.TooltipHotkeyString();
        internal static string NormalityRelocatorHotKey => global::CalamityMod.CalamityMod.NormalityRelocatorHotKey.TooltipHotkeyString();
        internal static string PlaguePackHotKey => global::CalamityMod.CalamityMod.PlaguePackHotKey.TooltipHotkeyString();
        internal static string RageHotKey => global::CalamityMod.CalamityMod.RageHotKey.TooltipHotkeyString();
        internal static string AdrenalineHotKey => global::CalamityMod.CalamityMod.AdrenalineHotKey.TooltipHotkeyString();
        internal static string ArmorSetHotkey => global::CalamityMod.CalamityMod.TarraHotKey.TooltipHotkeyString();
        internal static string EternityDiscoHex => CalamityMod.Items.Weapons.Magic.Eternity.DisoHex;
        internal static int AncientStorm => (int)(60f * Main.player[Main.myPlayer].manaCost);
    }
}