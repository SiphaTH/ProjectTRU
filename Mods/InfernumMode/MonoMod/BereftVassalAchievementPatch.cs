using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.InfernumAchievements;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class BereftVassalAchievementPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BereftVassalAchievement).GetCachedMethod(nameof(BereftVassalAchievement.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Forgotten Sands", "Забытые пески");
        TranslationHelper.ModifyIL(il, "Best the Bereft Vassal in combat, in the far reaches of the desert's dunes\n[c/777777:Defeat the Bereft Vassal]", "Одолеть в битве Обездоленного вассала, что таится в дальних уголках пустынных дюн\n[c/777777:Одержать победу над Обездоленным вассалом]");
    };
}