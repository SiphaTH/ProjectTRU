using CalamityMod;
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
    internal static Mod Infernum => ModLoader.TryGetMod("InfernumMode", out Mod infernum) ? infernum : null;
    internal static Mod TModLoader => ModLoader.TryGetMod("ModLoader", out Mod tMod) ? tMod : null;
    internal static Mod StarlightRiver => ModLoader.TryGetMod("StarlightRiver", out Mod slr) ? slr : null;
    internal static Mod CalamityModMusic => ModLoader.TryGetMod("CalamityModMusic", out Mod calamityModMusic) ? calamityModMusic : null;

    internal static bool EarlyHardmodeProgressionRework => CalamityConfig.Instance.EarlyHardmodeProgressionRework;
}