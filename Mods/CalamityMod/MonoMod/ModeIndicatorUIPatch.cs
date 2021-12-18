using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class ModeIndicatorUIPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(ModeIndicatorUI).GetCachedMethod(nameof(ModeIndicatorUI.Draw));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Death", "Смерть");
            TranslationHelper.ILTranslation(il, "Revengeance", "Месть");
            TranslationHelper.ILTranslation(il, " Mode is ", " ");
            TranslationHelper.ILTranslation(il, "active", "активирована");
            TranslationHelper.ILTranslation(il, "not active", "деактивирована");
            TranslationHelper.ILTranslation(il, "Armageddon is ", "Армагеддон ");
            TranslationHelper.ILTranslation(il, "active", "активирован", 2);
            TranslationHelper.ILTranslation(il, "not active", "деактивирован", 2);
            TranslationHelper.ILTranslation(il, "Malice Mode is ", "Злоба ");
            TranslationHelper.ILTranslation(il, "active", "активирована", 3);
            TranslationHelper.ILTranslation(il, "not active", "деактивирована", 3);
        }
    }
}