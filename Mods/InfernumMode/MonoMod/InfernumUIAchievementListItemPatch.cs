using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.UI;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class InfernumUIAchievementListItemPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(InfernumUIAchievementListItem).GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Spazmatism", "Спазматизм");
        TranslationHelper.ModifyIL(il, "The Twins", "Близнецы");
        TranslationHelper.ModifyIL(il, "Moon Lord Core", "Сердце Лунного лорда");
        TranslationHelper.ModifyIL(il, "Moon Lord", "Лунный лорд");
        TranslationHelper.ModifyIL(il, "Guardian Commander", "Нападающий страж");
        TranslationHelper.ModifyIL(il, "Profaned Guardians", "Осквернённые стражи");
        TranslationHelper.ModifyIL(il, "Next: ", "Следующий: ");
    };
}