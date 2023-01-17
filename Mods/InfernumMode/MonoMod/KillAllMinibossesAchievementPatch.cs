using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.InfernumAchievements;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class KillAllMinibossesAchievementPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(KillAllMinibossesAchievement).GetCachedMethod(nameof(KillAllMinibossesAchievement.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Mini-Meany!", "Малыши-плахиши");
        TranslationHelper.ModifyIL(il, "Defeat the various minor threats across the world!\n[c/777777:Beat every Infernum Miniboss]", "Одолейте различные мелкие угрозы, встречающиеся по всему миру!\n[c/777777:Одолейте каждого инфернального минибосса]");
    };
}