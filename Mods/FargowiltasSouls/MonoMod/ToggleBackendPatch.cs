using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Core.Toggler;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

public class ToggleBackendSaveCustomPresetPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(ToggleBackend).GetCachedMethod(nameof(ToggleBackend.SaveCustomPreset));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Toggles saved to custom set ", "Настройки эффектов сохранены в пользовательский набор ");
    };
}

public class ToggleBackendLoadCustomPresetPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(ToggleBackend).GetCachedMethod(nameof(ToggleBackend.LoadCustomPreset));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "No toggles found in custom set ", "Не найдены сохранённые настройки эффектов в пользовательском наборе ");
    };
}