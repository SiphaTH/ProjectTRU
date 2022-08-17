using CalamityMod;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.World;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common;

internal static class ModsCall
{
    internal static Mod Calamity => ModLoader.TryGetMod("CalamityMod", out Mod calamity) ? calamity : null;
    internal static Mod Thorium => ModLoader.TryGetMod("ThoriumMod", out Mod thorium) ? thorium : null;
    internal static Mod Fargo => ModLoader.TryGetMod("Fargowiltas", out Mod fargowiltas) ? fargowiltas : null;
    internal static Mod FargoSouls => ModLoader.TryGetMod("FargowiltasSouls", out Mod fargowiltasSouls) ? fargowiltasSouls : null;
    internal static Mod Spirit => ModLoader.TryGetMod("SpiritMod", out Mod spirit) ? spirit : null;
    internal static Mod Census => ModLoader.TryGetMod("Census", out Mod census) ? census : null;
    internal static Mod BossChecklist => ModLoader.TryGetMod("BossChecklist", out Mod bossChecklist) ? bossChecklist : null;
    internal static Mod StarsAbove => ModLoader.TryGetMod("StarsAbove", out Mod starsAbove) ? starsAbove : null;
    internal static Mod Wikithis => ModLoader.TryGetMod("Wikithis", out Mod wikithis) ? wikithis : null;

    internal static bool Revenge => CalamityWorld.revenge;
    internal static bool DownedSCal => DownedBossSystem.downedSCal;
    internal static bool DownedExoMechs => DownedBossSystem.downedExoMechs;
    internal static string AegisHotKey => CalamityKeybinds.AegisHotKey.TooltipHotkeyString();
    internal static string AstralArcanumUiHotkey => CalamityKeybinds.AstralArcanumUIHotkey.TooltipHotkeyString();
    internal static string AstralTeleportHotKey => CalamityKeybinds.AstralTeleportHotKey.TooltipHotkeyString();
    internal static string MomentumCapacitatorHotkey => CalamityKeybinds.MomentumCapacitatorHotkey.TooltipHotkeyString();
    internal static string SandCloakHotkey => CalamityKeybinds.SandCloakHotkey.TooltipHotkeyString();
    internal static string SpectralVeilHotKey => CalamityKeybinds.SpectralVeilHotKey.TooltipHotkeyString();
    internal static string NormalityRelocatorHotKey => CalamityKeybinds.NormalityRelocatorHotKey.TooltipHotkeyString();
    internal static string PlaguePackHotKey => CalamityKeybinds.PlaguePackHotKey.TooltipHotkeyString();
    internal static string RageHotKey => CalamityKeybinds.RageHotKey.TooltipHotkeyString();
    internal static string AdrenalineHotKey => CalamityKeybinds.AdrenalineHotKey.TooltipHotkeyString();
    internal static string SetBonusHotKey => CalamityKeybinds.SetBonusHotKey.TooltipHotkeyString();
    internal static string EternityDiscoHex => Eternity.DisoHex;
    internal static string AngelicAllianceHotKey => CalamityKeybinds.AngelicAllianceHotKey.TooltipHotkeyString();
    internal static string GodSlayerDashHotKey => CalamityKeybinds.GodSlayerDashHotKey.TooltipHotkeyString();
    internal static string ExoChairSpeedupHotkey => CalamityKeybinds.ExoChairSpeedupHotkey.TooltipHotkeyString();
    internal static string ExoChairSlowdownHotkey => CalamityKeybinds.ExoChairSlowdownHotkey.TooltipHotkeyString();
    internal static bool EarlyHardmodeProgressionRework => CalamityConfig.Instance.EarlyHardmodeProgressionRework;
}