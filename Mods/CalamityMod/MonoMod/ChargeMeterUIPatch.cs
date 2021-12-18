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
    public class ChargeMeterUIPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(ChargeMeterUI).GetCachedMethod(nameof(ChargeMeterUI.Draw));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Current Charge: ", "Текущий заряд: ");
        }
    }
}