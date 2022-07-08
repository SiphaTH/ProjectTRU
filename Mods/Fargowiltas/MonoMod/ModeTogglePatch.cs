using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Misc;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class ModeTogglePatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(ModeToggle).GetCachedMethod(nameof(ModeToggle.UseItem));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Expert mode is now enabled!", "Режим эксперта теперь включён!");
        TranslationHelper.ModifyIL(il, "Master mode is now enabled!", "Режим мастера теперь включён!");
        TranslationHelper.ModifyIL(il, "Journey mode is now enabled!", "Режим путешествия теперь включён!");
        TranslationHelper.ModifyIL(il, "Normal mode is now enabled!", "Нормальный режим теперь включён!");
    };
}