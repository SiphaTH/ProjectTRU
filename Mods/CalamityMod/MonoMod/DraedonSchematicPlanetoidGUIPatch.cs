using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DraedonSchematicPlanetoidGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DraedonSchematicPlanetoidGUI).GetCachedMethod(nameof(DraedonSchematicPlanetoidGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Within an army, as weapons do, the soldiers serve different purposes.\nThat distinction is crucial, as the wrong tool in the wrong hands—no matter how potent—may as well be a wooden club.\nAddendum: Seek out my base of operations closest to the Lihzahrd’s home.\nI wish you the best of luck with all sincerity, for it has been a long time since I have had a worthy test subject.", "В армии солдаты, как и оружие, служат разным целям.\nЭто различие имеет решающее значение, поскольку неправильный инструмент в неправильных руках, каким бы мощным он ни был, с таким же успехом может быть деревянной дубиной.\nДополнение: Найдите мою базу, она недалеко от Храма яхщеров.\nИскренне желаю вам удачи. Прошло много времени с тех пор, как у меня был достойный испытуемый.");
    };
}