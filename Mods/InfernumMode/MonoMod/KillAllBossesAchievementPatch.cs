﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.InfernumAchievements;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class KillAllBossesAchievementPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(KillAllBossesAchievement).GetCachedMethod(nameof(KillAllBossesAchievement.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Infer-it-all!", "Инферните ля комедиа");
        TranslationHelper.ModifyIL(il, "Rip and tear, until it is done\n[c/777777:Beat every Infernum Boss]", "Круши и кромсай, пока они не иссякнут\n[c/777777:Одержать победу над каждым боссом в Инфернуме]");
    };
}