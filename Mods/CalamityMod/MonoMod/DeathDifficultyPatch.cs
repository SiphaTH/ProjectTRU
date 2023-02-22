﻿using System.Reflection;
using CalamityMod.Systems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DeathDifficultyExpandedDescription : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DeathDifficulty).GetCachedMethod("get_ExpandedDescription");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "[c/B834E0:All foes will pose a much larger threat with highly aggressive AIs and increased damage] \n[c/B834E0:Bosses have substantially harder AI changes. Enemies are even more numerous and can easily overwhelm you] \n[c/B834E0:Debuffs are especially lethal and the Abyss is significantly more dangerous] \n[c/E945FF:Vigilance and tenacity are crucial to survival]", "[c/B834E0:Все враги будут создавать куда более серьезную угрозу благодаря очень агрессивному ИИ и увеличенному урону]\n[c/B834E0:У боссов более продвинутый ИИ. Численность врагов возросла, что позволяет им с лёгкостью одолеть вас]\n[c/B834E0:Дебаффы становятся намного смертоноснее, а Бездна - значительно опаснее]\n[c/E945FF:Для выживания важны собранность и упорство]");
    };
}

public class DeathDifficultyFavoredDifficultyAtTier : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DeathDifficulty).GetCachedMethod(nameof(DeathDifficulty.FavoredDifficultyAtTier));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Revengeance", "Месть");
    };
}