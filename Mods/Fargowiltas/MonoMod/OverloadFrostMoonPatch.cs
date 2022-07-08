using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.SwarmSummons;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class OverloadFrostMoonPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(OverloadFrostMoon).GetCachedMethod(nameof(OverloadFrostMoon.UseItem));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The Frost Moon fades away!", "Морозная луна исчезает!");
        TranslationHelper.ModifyIL(il, "The Frost Moon fades away!", "Морозная луна исчезает!", 2);
        TranslationHelper.ModifyIL(il, "The Frost Moon is rising...", "Восходит морозная луна...");
        TranslationHelper.ModifyIL(il, "The Frost Moon is rising...", "Восходит морозная луна...", 2);
        TranslationHelper.ModifyIL(il, "Wave: 20: Everything", "Волна 20: Все");
        TranslationHelper.ModifyIL(il, "Wave: 20: Everything", "Волна 20: Все", 2);
    };
}