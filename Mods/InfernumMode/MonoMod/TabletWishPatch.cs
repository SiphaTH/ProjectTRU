using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements.DevWishes;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class TabletWishPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(TabletWish).GetCachedMethod(nameof(TabletWish.Initialize));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Unsullied", "Незапятнанный");
        TranslationHelper.ModifyIL(il, "Not all beasts are monsters\n[c/777777:Defeat the Aquatic Scourge without ever letting the acid meter exceed 50% during the battle]", "Не все чудовища - монстры\n[c/777777:Одержать победу над Акватическим бичом, не превышая заполнения индикатора]\n[c/777777:сернистого отравления более чем на 50% во время битвы]");
    };
}