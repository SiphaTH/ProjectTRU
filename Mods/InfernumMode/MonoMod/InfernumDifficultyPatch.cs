using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.UI;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class InfernumDifficultyExpandedDescription : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(InfernumDifficulty).GetCachedMethod("get_ExpandedDescription");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "[c/B32E81:Many major foes will be different, having more challenging AI.] \n[c/B32E81:Adrenaline takes considerably longer to charge.] \n[c/FF0055:Adaptability is imperative.]", "[c/B32E81:Большинство основных врагов будут отличаться, обладая более сложным ИИ.]\n[c/B32E81:Адреналин заряжается значительно дольше.]\n[c/FF0055:Крайне рекомендуется адаптивность.]");
    };
}

public class InfernumDifficultyFavoredDifficultyAtTier : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(InfernumDifficulty).GetCachedMethod(nameof(InfernumDifficulty.FavoredDifficultyAtTier));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Death", "Смерть");
    };
}