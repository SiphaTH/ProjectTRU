using CalamityMod;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.World;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common;

public static class ModsCall
{
    public static Mod Calamity => ModLoader.GetMod("CalamityMod");
    public static bool TryGetCalamity => ModLoader.TryGetMod("CalamityMod", out Mod calamity);
    public static Mod Thorium => ModLoader.GetMod("ThoriumMod");
    public static bool TryGetThorium => ModLoader.TryGetMod("ThoriumMod", out Mod thorium);
    public static Mod Fargo => ModLoader.GetMod("Fargowiltas");
    public static bool TryGetFargo => ModLoader.TryGetMod("Fargowiltas", out Mod fargo);
    public static Mod FargoSouls => ModLoader.GetMod("FargowiltasSouls");
    public static bool TryGetFargoSouls => ModLoader.TryGetMod("FargowiltasSouls", out Mod fargoSouls);
    public static Mod Spirit => ModLoader.GetMod("SpiritMod");
    public static bool TryGetSpirit => ModLoader.TryGetMod("SpiritMod", out Mod spirit);
    public static Mod Census => ModLoader.GetMod("Census");
    public static bool TryGetCensus => ModLoader.TryGetMod("Census", out Mod census);
    public static Mod BossChecklist => ModLoader.GetMod("BossChecklist");
    public static bool TryGetBossChecklist => ModLoader.TryGetMod("BossChecklist", out Mod bossChecklist);
    public static Mod StarsAbove => ModLoader.GetMod("StarsAbove");
    public static bool TryGetStarsAbove => ModLoader.TryGetMod("StarsAbove", out Mod starsAbove);
    public static Mod Wikithis => ModLoader.GetMod("Wikithis");
    public static bool TryGetWikithis => ModLoader.TryGetMod("Wikithis", out Mod wikithis);
        
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