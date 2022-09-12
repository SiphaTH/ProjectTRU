using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Misc;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class ModeTogglePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(ModeToggle).GetCachedMethod(nameof(ModeToggle.UseItem));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Expert mode is now enabled!", "Мир переключён в режим Эксперта!");
        TranslationHelper.ModifyIL(il, "Master mode is now enabled!", "Мир переключён в режим Мастера!");
        TranslationHelper.ModifyIL(il, "Journey mode is now enabled!", "Мир переключён в режим Путешествия!");
        TranslationHelper.ModifyIL(il, "Normal mode is now enabled!", "Мир переключён в обычный режим!");
    };
}