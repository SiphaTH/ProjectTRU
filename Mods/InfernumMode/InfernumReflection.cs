using CalamityMod.Systems;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
internal static class InfernumReflection
{
    internal static void Load()
    {
        DifficultyModeSystem.Difficulties[4].Name = LangHelper.GetText("InfernumMode.DifficultyModeSystem.Difficulties.Infernum.Name");
        DifficultyModeSystem.Difficulties[4].ShortDescription = LangHelper.GetText("InfernumMode.DifficultyModeSystem.Difficulties.Infernum.ShortDescription");
    }
}