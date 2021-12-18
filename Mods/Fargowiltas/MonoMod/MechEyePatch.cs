using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class MechEyePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(MechEye).GetCachedMethod(nameof(MechEye.Shoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The Twins have awoken!", "Близнецы пробудились!");
            TranslationHelper.ILTranslation(il, "The Twins have awoken!", "Близнецы пробудились!", 2);
        }
    }
}