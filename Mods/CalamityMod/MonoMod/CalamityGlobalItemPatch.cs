using System.Reflection;
using CalamityMod.Items;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CalamityGlobalItemPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CalamityGlobalItem).GetCachedMethod("<ModifyVanillaTooltips>g__HookStatsTooltip|91_113");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Reach: {0:N3} tiles\n", "Дальность: {0} блоков\n");
            TranslationHelper.ILTranslation(il, "Launch Velocity: {0:N2}\n", "Скорость вылета: {0}\n");
            TranslationHelper.ILTranslation(il, "Reelback Velocity: {0:N2}\n", "Скорость возврата: {0}\n");
            TranslationHelper.ILTranslation(il, "Pull Velocity: {0:N2}", "Скорость притягивания: {0}");
        }
    }
}