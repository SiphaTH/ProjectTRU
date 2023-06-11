using System.Reflection;
using CalamityMod.UI.DraedonLogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DraedonSchematicSunkenSeaGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DraedonSchematicSunkenSeaGUI).GetCachedMethod(nameof(DraedonSchematicSunkenSeaGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The weaponry I supply to the workers of the laboratories is weak. Hardly suited for battle.\nHowever, they suffice for self defense against any lab mechanisms or creations which may have gone rogue.\nAddendum: For those who think themselves powerful, search the upper bounds of this planet's atmosphere for a structure similar to that of the Sunken Seas.\nI will know by the end if you are worthy of battling my creations.\n", "Вооружение, которое я поставляю сотрудникам лабораторий, довольно слабое и вряд ли пригодное для сражений.\nТем не менее, его предостаточно для самообороны от любых обезумевших механизмов лаборатории.\nДополнение для тех, кто считает себя достаточно могущественным: отправляйся в верхние слоя атмосферы этой планеты и найди похожую структуру.\nВ конце концов, я сам решу, достоен ли ты сражаться с моими лучшими творениями.");
    };
}