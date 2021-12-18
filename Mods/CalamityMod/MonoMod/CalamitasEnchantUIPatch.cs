using System.Reflection;
using CalamityMod.UI.CalamitasEnchants;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CalamitasEnchantUIDrawEnchantmentCost : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CalamitasEnchantUI).GetCachedMethod(nameof(CalamitasEnchantUI.DrawEnchantmentCost));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Cost: ", "Стоимость: ");
            TranslationHelper.ILTranslation(il, "Exhume", "Наполнение");
        }
    }

    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CalamitasEnchantUIInteractWithEnchantIcon : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CalamitasEnchantUI).GetCachedMethod(nameof(CalamitasEnchantUI.InteractWithEnchantIcon));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Exhume", "Наполнение");
            TranslationHelper.ILTranslation(il, "Exhume", "Наполнение", 2);
            TranslationHelper.ILTranslation(il, "Exhume", "Наполнение", 3);
        }
    }
}