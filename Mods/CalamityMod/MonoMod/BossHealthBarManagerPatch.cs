using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class BossHealthBarManagerPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BossHealthBarManager.BossHPUI).GetCachedMethod(nameof(BossHealthBarManager.BossHPUI.Draw));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " left: ", " осталось: ");
    };
}

[JITWhenModsEnabled("CalamityMod")]
public class AttemptToAddBar : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BossHealthBarManager).GetCachedMethod(nameof(BossHealthBarManager.AttemptToAddBar));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "XS-01 Artemis and XS-03 Apollo", "ВП-01 Артемида и ВП-03 Аполлон");
    };
}