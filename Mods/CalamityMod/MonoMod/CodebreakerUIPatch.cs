using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class CodebreakerUIDisplayCostText : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.DisplayCostText));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Cost: ", "Стоимость: ");
    };
}

[JITWhenModsEnabled("CalamityMod")]
public class CodebreakerUIDrawDecryptCancelConfirmationText : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.DrawDecryptCancelConfirmationText));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Are you sure?", "Вы уверены?");
    };
}

[JITWhenModsEnabled("CalamityMod")]
public class CodebreakerUIHandleDraedonSummonButton : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.HandleDraedonSummonButton));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Contact", "Контакт");
    };
}

[JITWhenModsEnabled("CalamityMod")]
public class CodebreakerUIDisplayNotStrongEnoughErrorText : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.DisplayNotStrongEnoughErrorText));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Encryption unsolveable: Upgrades required.", "Шифрование нерешаемо: требуются обновления.");
    };
}