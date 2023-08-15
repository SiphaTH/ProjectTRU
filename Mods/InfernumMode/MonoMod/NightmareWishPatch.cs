using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.DevWishes;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class NightmareWishPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(NightmareWish).GetCachedMethod(nameof(NightmareWish.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "It Awakens", "Вознесение из сна");
        TranslationHelper.ModifyIL(il, "It demands a sacrifice. You seem like a good choice\n", "Оно просит жертву. И ты подходишь\n");
        TranslationHelper.ModifyIL(il, "[c/777777:Sleep in the brimstone crags for ", "[c/777777:Поспать в серной скале в течение ");
        TranslationHelper.ModifyIL(il, " seconds]", " секунд]");
    };
}