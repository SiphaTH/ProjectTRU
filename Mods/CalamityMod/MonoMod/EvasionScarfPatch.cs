using System.Reflection;
using CalamityMod.Cooldowns;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class EvasionScarfPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(EvasionScarf).GetCachedMethod("get_DisplayName");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Scarf Cooldown", "Перезарядка шарфа");
        }
    }
}