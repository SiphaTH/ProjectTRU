using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.InfernumAchievements;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class MechaMayhemAchievementPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(MechaMayhemAchievement).GetCachedMethod(nameof(MechaMayhemAchievement.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Malicious Machinery", "");
        TranslationHelper.ModifyIL(il, "Decommission the Maniacal Mechanical trio in one fell swoop!\n[c/777777:Beat Infernum Mecha-Mayhem]", "");
    };
}