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
    public class MythrilArmorSetChangePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(MythrilArmorSetChange).GetCachedMethod(nameof(MythrilArmorSetChange.UpdateSetBonusText));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "\nEnemy hits release mythril flares, which home in on enemies after a short delay\n", "\nУдары по врагам выпускают мифриловые вспышки, которые наводятся на врагов после небольшой задержки\n");
            TranslationHelper.ILTranslation(il, "Once a flare is created, there is a {0} frame delay before another one can appear", "После создания вспышки происходит задержка в {0} кадров до появления новой вспышки");
        }
    }
}