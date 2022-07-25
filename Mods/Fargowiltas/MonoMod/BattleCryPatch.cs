using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Misc;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class BattleCryPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(BattleCry).GetCachedMethod("ToggleCry");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Battle", "Боевой");
        TranslationHelper.ModifyIL(il, "Calming", "Успокаивающий");
        TranslationHelper.ModifyIL(il, "activated", "активирован");
        TranslationHelper.ModifyIL(il, "deactivated", "деактивирован");
        TranslationHelper.ModifyIL(il, " Cry ", " клич ");
        TranslationHelper.ModifyIL(il, " for ", " для ");
    };
}