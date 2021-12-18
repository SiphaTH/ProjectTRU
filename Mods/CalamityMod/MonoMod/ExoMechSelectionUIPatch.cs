using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class ExoMechSelectionUIPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(ExoMechSelectionUI).GetCachedMethod(nameof(ExoMechSelectionUI.HandleInteractionWithButton));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.", "Танатос - змееподобное создание с непробиваемой броней и бесчисленным количеством лазерных турелей.");
            TranslationHelper.ILTranslation(il, "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.", "Арес - тяжеловесное чудовище с четырьмя экзо-супероружиями.");
            TranslationHelper.ILTranslation(il, "Artemis and Apollo, a pair of extremely agile destroyers with pulse cannons.", "Артемида и Аполлон - тандем чрезвычайно маневренных уничтожителей, обладающих импульсными пушками.");
        }
    }
}