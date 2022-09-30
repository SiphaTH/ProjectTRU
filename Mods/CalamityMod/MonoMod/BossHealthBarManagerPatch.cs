using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class BossHealthBarManagerPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BossHealthBarManager.BossHPUI).GetCachedMethod(nameof(BossHealthBarManager.BossHPUI.Draw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " left: ", " осталось: ");
    };
}

public class AttemptToAddBar : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BossHealthBarManager).GetCachedMethod(nameof(BossHealthBarManager.AttemptToAddBar));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "XS-01 Artemis and XS-03 Apollo", "ВП-01 Артемида и ВП-03 Аполлон");
    };
}