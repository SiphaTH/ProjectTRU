using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.DevWishes;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class MatrixWishPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(MatrixWish).GetCachedMethod(nameof(MatrixWish.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The Scientific Method", "Научный подход");
        TranslationHelper.ModifyIL(il, "To experiment is to fail. To fail is to learn. To learn is to advance\n[c/777777:Defeat every single boss and Exo Mech combination]", "Экспериментировать — значит терпеть неудачи. Терпеть неудачи — значит учиться. Учиться — значит становиться лучше\n[c/777777:Одержать победу над каждым боссом и каждой комбинацией Экзо-механизмов]");
    };
}