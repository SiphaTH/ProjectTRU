using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class OverloadQueenSlimePatch : ILEdit
{
    public override bool Autoload() => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override void Load()
    {
        IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadQueenSlime.ctor += Translation;
    }

    public override void Unload()
    {
        IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadQueenSlime.ctor -= Translation;
    }

    private void Translation(ILContext il)
    {
        TranslationHelper.ModifyIL(il, "Welcome to the truer slime rain!", "");
    }
}