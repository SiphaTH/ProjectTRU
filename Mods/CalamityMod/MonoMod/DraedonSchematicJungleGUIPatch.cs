using System.Reflection;
using CalamityMod.UI.DraedonLogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DraedonSchematicJungleGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DraedonSchematicJungleGUI).GetCachedMethod(nameof(DraedonSchematicJungleGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "As rank progresses, so often does the lethality of equipment. In the hands of competent soldiers, the weapons have the ability to make change.\nHowever, competent soldiers take no action but orders from above.\nAddendum: If you read this, you have come far. Do not disappoint.\nGo now to Hell, for the next component stored in what were once my forges.", "С ростом в звании неизбежно возрастает и мощность снаряжения. В компетентных руках оружие способно вносить огромные изменения на всём поле боя\nНо эти же руки не самостоятельны, они лишь выполняют приказы.\nДополнение: Ты далеко продвинулся. Не подведи. Теперь отправляйся в ад. Следующий компонент хранится в месте, что некогда было моими кузницами.");
    };
}