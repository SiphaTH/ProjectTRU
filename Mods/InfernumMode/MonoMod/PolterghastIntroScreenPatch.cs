using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BossIntroScreens;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class PolterghastIntroScreenPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(PolterghastIntroScreen).GetCachedMethod("get_TextToDisplay");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Wrathful Coalescence\nThe Polterghast", "ГНЕВНОЕ СЛИЯНИЕ\nПОЛТЕРГАСТ");
    };
}