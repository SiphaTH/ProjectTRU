using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class DraedonSchematicJungleGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DraedonSchematicJungleGUI).GetCachedMethod(nameof(DraedonSchematicJungleGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "As rank progresses, so often does the lethality of equipment. In the hands of competent soldiers, the weapons have the ability to make change.\nHowever, competent soldiers take no action but orders from above.\nAddendum: If you read this, you have come far. Do not disappoint.\nGo now to Hell, for the next component stored in what were once my forges.", "С ростом в звании неизбежен и рост мощности снаряжения. В компетентных руках оружие способно вносить огромные изменения на всём поле боя\nНо эти же руки не самостоятельны, лишь выполняют приказы.\nДополнение: Вы далеко продвинулись. Не разочаровывайте. Теперь идите в ад. Следующий компонент хранится в месте, что некогда было моими кузницами.");
    };
}