using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BossIntroScreens;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class GolemIntroScreenPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(GolemIntroScreen).GetCachedMethod("get_TextToDisplay");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "NUMBER ! SALSMAN\n[Circa 1997]", "ПРОДАВЕЦ НОМЕР !\n[С 1997 года]");
        TranslationHelper.ModifyIL(il, "The Ancient Idol\nGolem", "ДРЕВНИЙ ИДОЛ\nГОЛЕМ");
    };
}