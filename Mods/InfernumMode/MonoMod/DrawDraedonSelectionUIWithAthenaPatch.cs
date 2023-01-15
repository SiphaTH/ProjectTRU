using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Core.GlobalInstances.Systems;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class CustomExoMechSelectionSystemDrawWrapperPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CustomExoMechSelectionSystem).GetCachedMethod(nameof(CustomExoMechSelectionSystem.DrawWrapper));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Pick two. The first mech will be fought alone. Once sufficiently damaged, the second mech will be summoned and the two will fight together.", "Выбери двоих. Первый экзо-мех будет сражаться в одиночку. Когда он получит достаточно урона, то появится второй экзо-мех, и они будут сражаться вместе.");
        TranslationHelper.ModifyIL(il, 50f, 25f);
    };
}

public class CustomExoMechSelectionSystemHandleInteractionWithButtonPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CustomExoMechSelectionSystem).GetCachedMethod(nameof(CustomExoMechSelectionSystem.HandleInteractionWithButton));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.", "Танатос - змееподобный ужас с непробиваемой броней и бесчисленным количеством лазерных турелей.");
        TranslationHelper.ModifyIL(il, "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.", "Арес - тяжеловес, дьявольское чудовище с четырьмя экзо-супероружиями.");
        TranslationHelper.ModifyIL(il, "Artemis and Apollo, a pair of extremely agile destroyers with unstable energy reserves.", "Артемида и Аполлон - тандем чрезвычайно манёвренных уничтожителей, бладающих нестабильным запасом энергии.");
    };
}