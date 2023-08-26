using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Content.UI.Elements;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

public class SoulTogglerButtonPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(SoulTogglerButton).GetCachedMethod(nameof(SoulTogglerButton.OnActivate));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Configure Accessory Effects", "Настройки эффектов аксессуаров");
        TranslationHelper.ModifyIL(il, "Eternity Mode is enabled", "Включён режим Вечности");
        TranslationHelper.ModifyIL(il, "Masochist Mode is enabled", "Включён режим Мазохиста");
    };
}