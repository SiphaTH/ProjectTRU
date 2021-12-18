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
    public class RipperUIPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(RipperUI).GetCachedMethod("HandleMouseInteraction");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Adrenaline: ", "Адреналин: ");
            TranslationHelper.ILTranslation(il, "Rage: ", "Ярость: ");
        }
    }
}