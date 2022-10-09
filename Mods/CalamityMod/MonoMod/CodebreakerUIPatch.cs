using System.Reflection;
using CalamityMod.UI.DraedonSummoning;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class CodebreakerUIDisplayCostText : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.DisplayCostText));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Cost: ", "Стоимость: ");
    };
}

public class CodebreakerUIDrawDecryptCancelConfirmationText : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.DrawDecryptCancelConfirmationText));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Are you sure?", "Вы уверены?");
    };
}

public class CodebreakerUIHandleDraedonSummonButton : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.HandleDraedonSummonButton));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Contact", "Контакт");
    };
}

public class CodebreakerUIDisplayNotStrongEnoughErrorText : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.DisplayNotStrongEnoughErrorText));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Encryption unsolveable: Upgrades required.", "Шифрование нерешаемое: требуются обновления.");
    };
}