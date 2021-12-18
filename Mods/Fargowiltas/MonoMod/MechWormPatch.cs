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
    public class MechWormPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(MechWorm).GetCachedMethod(nameof(MechWorm.Shoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The Destroyer has awoken!", "Разрушитель пробудился!");
            TranslationHelper.ILTranslation(il, "The Destroyer has awoken!", "Разрушитель пробудился!", 2);
        }
    }
}