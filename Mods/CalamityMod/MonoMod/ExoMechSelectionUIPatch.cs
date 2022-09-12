using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class ExoMechSelectionUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(ExoMechSelectionUI).GetCachedMethod(nameof(ExoMechSelectionUI.HandleInteractionWithButton));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.", "Танатос - змееподобное создание с непробиваемой броней и бесчисленным количеством лазерных турелей.");
        TranslationHelper.ModifyIL(il, "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.", "Арес - тяжеловесное чудовище с четырьмя экзо-супероружиями.");
        TranslationHelper.ModifyIL(il, "Artemis and Apollo, a pair of extremely agile destroyers with pulse cannons.", "Артемида и Аполлон - тандем чрезвычайно маневренных уничтожителей, обладающих импульсными пушками.");
    };
}