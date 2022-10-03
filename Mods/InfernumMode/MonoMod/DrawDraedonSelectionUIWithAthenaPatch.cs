using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.ILEditingStuff;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class DrawDraedonSelectionUIWithAthenaDrawWrapper : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DrawDraedonSelectionUIWithAthena).GetCachedMethod(nameof(DrawDraedonSelectionUIWithAthena.DrawWrapper));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Pick two. The first mech will be fought alone. Once sufficiently damaged, the second mech will be summoned and the two will fight together.", "Выбери двоих. Первый экзо-мех будет сражаться один. Получив достаточно повреждений, вызывается второй экзо-мех, и они будут сражаться вместе.");
    };
}

public class DrawDraedonSelectionUIWithAthenaHandleInteractionWithButton : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DrawDraedonSelectionUIWithAthena).GetCachedMethod(nameof(DrawDraedonSelectionUIWithAthena.HandleInteractionWithButton));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.", "Танатос - змееподобное создание с непробиваемой броней и бесчисленным количеством лазерных турелей.");
        TranslationHelper.ModifyIL(il, "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.", "Арес - тяжеловесное чудовище с четырьмя экзо-супероружиями.");
        TranslationHelper.ModifyIL(il, "Artemis and Apollo, a pair of extremely agile destroyers with pulse cannons.", "Артемида и Аполлон - тандем чрезвычайно маневренных уничтожителей, обладающих импульсными пушками.");
    };
}