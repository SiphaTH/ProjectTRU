using System.Reflection;
using CalamityMod.Items.Weapons.Melee;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class FourSeasonsGalaxiaPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FourSeasonsGalaxia).GetCachedMethod(nameof(FourSeasonsGalaxia.ModifyTooltips));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Active Attunement", "Активная настройка");
            TranslationHelper.ILTranslation(il, "Active Attumenent : [", "Активная настройка : [");
            TranslationHelper.ILTranslation(il, "Active Attumenent : [", "Активная настройка : [", 2);
            TranslationHelper.ILTranslation(il, "Passive Blessing", "Пассивное благословение");
            TranslationHelper.ILTranslation(il, "Passive Blessing : [", "Пассивное благословение : [");
            TranslationHelper.ILTranslation(il, "Passive Blessing : [", "Пассивное благословение : [", 2);
        }
    }
}