using System.Reflection;
using CalamityMod.Items.Weapons.Ranged;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class BloodBoilerPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(BloodBoiler).GetCachedMethod(nameof(BloodBoiler.Shoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " suffered from severe anemia.", " страдал тяжёлой анемией.");
            TranslationHelper.ILTranslation(il, " was unable to obtain a blood transfusion.", " не удалось добиться переливания крови.");
        }
    }
}