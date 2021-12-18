using System.Reflection;
using CalamityMod.Projectiles.Boss;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class HolyBurnOrbPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(HolyBurnOrb).GetCachedMethod(nameof(HolyBurnOrb.AI));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " burst into sinless ash.", " превратился в безгрешный пепел.");
        }
    }
}