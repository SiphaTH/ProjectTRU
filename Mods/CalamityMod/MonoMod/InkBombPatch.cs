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
    public class InkBombPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(InkBomb).GetCachedMethod("get_DisplayName");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Ink Bomb Cooldown", "Перезарядка чернильной бомбы");
        }
    }
}