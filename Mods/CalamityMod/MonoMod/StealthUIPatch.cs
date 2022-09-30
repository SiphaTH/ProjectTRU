using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class StealthUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(StealthUI).GetCachedMethod(nameof(StealthUI.Draw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Stealth: ", "Скрытность: ");
        TranslationHelper.ModifyIL(il, "Rogue stealth builds while not attacking and slower while moving\nOnce you have built max stealth, you will be able to perform a Stealth Strike\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage, crit, and movement speed", "Скрытность разбойника накапливается быстрее, пока вы не атакуете, и медленнее, пока вы движетесь\nПосле заполнения шкалы скрытности вы сможете выполнить скрытный удар\nСкрытность расходуется только при атаке и не расходуется во время движения\nЧем выше ваша скрытность, тем выше разбойный урон, шанс критического удара и скорость передвижения");
        TranslationHelper.ModifyIL(il, "Hold SHIFT for more information on Rogue stealth", "Удерживайте 'Shift' для получения дополнительной информации о скрытности разбойника");
    };
}