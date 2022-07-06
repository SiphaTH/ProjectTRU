using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class ModeIndicatorUIPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ModeIndicatorUI).GetCachedMethod(nameof(ModeIndicatorUI.Draw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Revengeance", "Месть");
        TranslationHelper.ModifyIL(il, "Death", "Смерть");
        TranslationHelper.ModifyIL(il, "Malice", "Злоба");
        TranslationHelper.ModifyIL(il, " Mode is ", " ");
        TranslationHelper.ModifyIL(il, "active", "активирована");
        TranslationHelper.ModifyIL(il, "not active", "деактивирована");
    };
}