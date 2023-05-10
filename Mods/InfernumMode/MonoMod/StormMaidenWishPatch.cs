using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.DevWishes;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class StormMaidenWishPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(StormMaidenWish).GetCachedMethod(nameof(StormMaidenWish.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Lamentation", "Плач");
        TranslationHelper.ModifyIL(il, "Their tears blend with the raindrops, mourning over all that couldn't be\n[c/777777:Defeat the Exo Mechs and Calamitas and find the spear near your spawn point during the rain]", "Их слёзы сливаются с каплями дождя, оплакивая всё, что не сбылось\n[c/777777:Одержать победу над Экзо-механизмами или Каламитас и найти копьё рядом с точкой]\n[c/777777:возрождения во время дождя]");
    };
}