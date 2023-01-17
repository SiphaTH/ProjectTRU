using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.InfernumAchievements;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class BabysFirstAchievementPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BabysFirstAchievement).GetCachedMethod(nameof(BabysFirstAchievement.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "First Of Many", "Первый из многих");
        TranslationHelper.ModifyIL(il, "The higher the count, the more you've learnt\n[c/777777:Die to an Infernum boss]", "Чем больше ошибок, тем быстрее рост\n[c/777777:Умрите от инфернального босса]");
    };
}