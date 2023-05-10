using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.DevWishes;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class SakuraWishPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(SakuraWish).GetCachedMethod(nameof(SakuraWish.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Innocent Breeze", "Нежный бриз");
        TranslationHelper.ModifyIL(il, "One hundred whimsical spirits, dancing playfully\n[c/777777:Find a Sakura Bud]", "Сотня причудливых духов игриво танцуют\n[c/777777:Найти Початок сакуры]");
    };
}