﻿using CalamityMod;
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
        internal static Mod Spirit => ModLoader.GetMod("SpiritMod");

        internal static bool CalamityGetInZone => (bool) Calamity.Call("GetInZone", Main.player[Main.myPlayer], "abyss");
        internal static bool Revenge => CalamityWorld.revenge;
        internal static bool DeathMode => CalamityWorld.death;
        internal static bool DownedFlag => !CalamityWorld.downedSentinel1 || !CalamityWorld.downedSentinel2 || !CalamityWorld.downedSentinel3;
        internal static bool ProfanedCrystalBuffs => Main.player[Main.myPlayer].Calamity().profanedCrystalBuffs;
        internal static string AegisHotKey => CalamityMod.CalamityMod.AegisHotKey.TooltipHotkeyString();
        internal static string AstralArcanumUiHotkey => CalamityMod.CalamityMod.AstralArcanumUIHotkey.TooltipHotkeyString();
        internal static string MomentumCapacitatorHotkey => CalamityMod.CalamityMod.MomentumCapacitatorHotkey.TooltipHotkeyString();
        internal static string SandCloakHotkey => CalamityMod.CalamityMod.SandCloakHotkey.TooltipHotkeyString();
        internal static string SpectralVeilHotKey => CalamityMod.CalamityMod.SpectralVeilHotKey.TooltipHotkeyString();
        internal static string NormalityRelocatorHotKey => CalamityMod.CalamityMod.NormalityRelocatorHotKey.TooltipHotkeyString();
        internal static string PlaguePackHotKey => CalamityMod.CalamityMod.PlaguePackHotKey.TooltipHotkeyString();
        internal static string RageHotKey => CalamityMod.CalamityMod.RageHotKey.TooltipHotkeyString();
        internal static string AdrenalineHotKey => CalamityMod.CalamityMod.AdrenalineHotKey.TooltipHotkeyString();
        internal static string ArmorSetHotkey => CalamityMod.CalamityMod.TarraHotKey.TooltipHotkeyString();
        internal static string EternityDiscoHex => CalamityMod.Items.Weapons.Magic.Eternity.DisoHex;
        internal static int AncientStorm => (int)(60f * Main.player[Main.myPlayer].manaCost);
    }
}