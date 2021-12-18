using System.Reflection;
using CalamityMod.Items.Weapons.Magic;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class ThornBlossomPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(ThornBlossom).GetCachedMethod(nameof(ThornBlossom.Shoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " was violently pricked by a flower.", " был яростно уколот цветком.");
        }
    }
}