using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.Abom;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class PillarSummonPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(PillarSummon).GetCachedMethod(nameof(PillarSummon.Shoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The Celestial Pillars have awoken!", "Небесные башни пробуждаются!");
            TranslationHelper.ILTranslation(il, "The Celestial Pillars have awoken!", "Небесные башни пробуждаются!", 2);
        }
    }
}