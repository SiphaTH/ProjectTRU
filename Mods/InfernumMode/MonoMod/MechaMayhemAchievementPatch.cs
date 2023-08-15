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
        TranslationHelper.ModifyIL(il, "Malicious Machinery", "Заводные злыдни");
        TranslationHelper.ModifyIL(il, "Decommission the Maniacal Mechanical trio in one fell swoop!\n[c/777777:Beat Infernum Mecha-Mayhem]", "Деконструировать сразу всю троицу безумных механических убийц за раз!\n[c/777777:Одержать победу во время Мехорубки в Инфернуме]");
    };
}