using System.Reflection;
using CalamityMod.Items.VanillaArmorChanges;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CobaltArmorSetChangePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CobaltArmorSetChange).GetCachedMethod(nameof(CobaltArmorSetChange.UpdateSetBonusText));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "\n{0}% increased max speed and acceleration\n", "\nУвеличивает максимальную скорость передвижения и ускорение на {0}%\n");
            TranslationHelper.ILTranslation(il, "You gain a damage and critical strike chance boost relative to your current movement speed, up to {0}%", "Вы получаете бонус к урону и шансу критического удара относительно вашей текущей скорости передвижения, максимум {0}%");
        }
    }
}