using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class ModeIndicatorUIGetDifficultyStatus : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ModeIndicatorUI).GetCachedMethod(nameof(ModeIndicatorUI.GetDifficultyStatus));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " Mode is ", " ");
        TranslationHelper.ModifyIL(il, "active", "активирована");
        TranslationHelper.ModifyIL(il, "not active", "деактивирована");
    };
}

[JITWhenModsEnabled("CalamityMod")]
public class ModeIndicatorUIGetLockStatus : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ModeIndicatorUI).GetCachedMethod(nameof(ModeIndicatorUI.GetLockStatus));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "[c/919191:Click to select a difficulty mode]", "[c/919191:Нажмите для выбора режима сложности]");
        TranslationHelper.ModifyIL(il, "[c/919191:Higher difficulty modes can only be toggled in Expert Mode or above]", "[c/919191:Режимы повышенной сложности можно переключать только в режиме Эксперта или выше]");
    };
}

[JITWhenModsEnabled("CalamityMod")]
public class ModeIndicatorUIGetDifficultyText : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ModeIndicatorUI).GetCachedMethod(nameof(ModeIndicatorUI.GetDifficultyText));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Currently Selected : ", "Текущая сложность : ");
        TranslationHelper.ModifyIL(il, "\n[c/737373:Hold the 'Shift' key for more information]", "\nУдерживайте 'Shift' для получения дополнительной информации");
    };
}