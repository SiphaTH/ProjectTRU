using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.DevWishes;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class EggWishPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(EggWish).GetCachedMethod(nameof(EggWish.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The Chosen One", "Избранный");
        TranslationHelper.ModifyIL(il, "Legends tell of a mighty warrior who will venture into the world and find the legendary blade hidden within\n[c/777777:Find an egg sword shrine after defeating Golem]", "Легенды гласят о могущественном воине, который отправится в странствие по миру в поисках легендарного клинка\n[c/777777:Найти святилище с яичным мечом после победы над Големом]");
    };
}