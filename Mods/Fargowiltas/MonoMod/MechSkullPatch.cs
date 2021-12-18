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
    public class MechSkullPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(MechSkull).GetCachedMethod(nameof(MechSkull.Shoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Skeletron Prime has awoken!", "Скелетрон Прайм пробудился!");
            TranslationHelper.ILTranslation(il, "Skeletron Prime has awoken!", "Скелетрон Прайм пробудился!", 2);
        }
    }
}