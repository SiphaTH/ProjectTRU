using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class OverloadMoonPatch : ILEdit
{
    public override bool Autoload() => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override void Load()
    {
        IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadMoon.ctor += Translation;
    }

    public override void Unload()
    {
        IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadMoon.ctor -= Translation;
    }

    private void Translation(ILContext il)
    {
        TranslationHelper.ModifyIL(il, "The wind whispers of death's approach!", "Ветер шепчет о приближающейся смерти!");
    }
}