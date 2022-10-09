using System.Reflection;
using CalamityMod.UI.DraedonLogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DraedonSchematicIceGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DraedonSchematicIceGUI).GetCachedMethod(nameof(DraedonSchematicIceGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "I have since made progress to even greater weapons than these, but they remain creations to be proud of.\nNo progress can be made without a desire that comes from dissatisfaction.\nAddendum: The time has come. You are ready.", "С тех пор я добился немалого прогресса в создании ещё более смертоносного оружия, но они остаются творениями, которыми можно гордиться. Не может быть достигнуто прогресса без желания, проистекающего из неудовлетворённости.\nДополнение: Время пришло. Ты готов.");
    };
}