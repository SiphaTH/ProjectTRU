using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.DevWishes;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class PurityWishPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(PurityWish).GetCachedMethod(nameof(PurityWish.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The Tanning Starseed", "Загарающее звёздное семя");
        TranslationHelper.ModifyIL(il, "It feels like solar winds, and solar chimes\n[c/777777:Defeat Infernum Night Providence in under 3.5 minutes]", "Словно прикосновение солнечного ветра и звучание солнечных колоколов\n[c/777777:Одержать победу над ночной Провиденс в Инфернуме менее чем за 3.5 минуты]");
    };
}