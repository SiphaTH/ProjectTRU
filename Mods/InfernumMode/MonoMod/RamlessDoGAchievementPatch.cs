using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.InfernumAchievements;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class RamlessDoGAchievementPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(RamlessDoGAchievement).GetCachedMethod(nameof(RamlessDoGAchievement.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Ramification", "");
        TranslationHelper.ModifyIL(il, "Best the Devourer at his own game: without a ram!\n[c/777777:Beat the Infernum Devourer of Gods without using a ram dash]", "");
    };
}