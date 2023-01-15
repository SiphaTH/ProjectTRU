using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.InfernumAchievements;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class InfernalChaliceAchievementPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(InfernalChaliceAchievement).GetCachedMethod(nameof(InfernalChaliceAchievement.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Baptized By Hellfire", "");
        TranslationHelper.ModifyIL(il, "Complete the final challenge, and earn your reward\n[c/777777:Obtain the Infernal Chalice]", "");
    };
}