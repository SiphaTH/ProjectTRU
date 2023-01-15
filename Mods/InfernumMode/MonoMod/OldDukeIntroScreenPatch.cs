using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BossIntroScreens;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class OldDukeIntroScreenPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(OldDukeIntroScreen).GetCachedMethod("get_TextToDisplay");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Speed Demon\nThe Old Duke", "ДЕМОН СКОРОСТИ\nСТАРЫЙ ГЕРЦОГ");
        TranslationHelper.ModifyIL(il, "Sulphuric Terror\nThe Old Duke", "СЕРНИСТЫЙ УЖАС\nСТАРЫЙ ГЕРЦОГ");
    };
}