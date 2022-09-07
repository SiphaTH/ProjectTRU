using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Systems;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class InfernumDifficultyExpandedDescription : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(InfernumDifficulty).GetCachedMethod("get_ExpandedDescription");

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "[c/B32E81:Many major foes will be vastly different, having more challenging AI.] \n[c/B32E81:Adrenaline takes considerably longer to charge.] \n[c/FF0055:Adaptability is imperative.]", "[c/B32E81:Большинство основных врагов будут сильно отличаться, обладая более сложным искусственным интеллектом.]\n[c/B32E81:Адреналин заряжается значительно дольше.]\n[c/FF0055:Крайне рекомендуется адаптивность.]");
    };
}

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class InfernumDifficultyFavoredDifficultyAtTier : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(InfernumDifficulty).GetCachedMethod(nameof(InfernumDifficulty.FavoredDifficultyAtTier));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Death", "Смерть");
    };
}