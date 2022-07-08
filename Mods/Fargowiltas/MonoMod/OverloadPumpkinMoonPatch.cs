using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.SwarmSummons;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class OverloadPumpkinMoonPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(OverloadPumpkinMoon).GetCachedMethod(nameof(OverloadPumpkinMoon.UseItem));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The Pumpkin Moon fades away!", "Тыквенная луна исчезает!");
        TranslationHelper.ModifyIL(il, "The Pumpkin Moon fades away!", "Тыквенная луна исчезает!", 2);
        TranslationHelper.ModifyIL(il, "The Pumpkin Moon is rising...", "Восходит тыквенная луна...");
        TranslationHelper.ModifyIL(il, "The Pumpkin Moon is rising...", "Восходит тыквенная луна...", 2);
        TranslationHelper.ModifyIL(il, "Wave: 15: Everything", "Волна 15: Все");
        TranslationHelper.ModifyIL(il, "Wave: 15: Everything", "Волна 15: Все", 2);
    };
}