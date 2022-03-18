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
    public class BiomeBladePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(BiomeBlade).GetCachedMethod(nameof(BiomeBlade.ModifyTooltips));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Does nothing.. yet", "Ничего не делает... пока");
            TranslationHelper.ILTranslation(il, "Main attunement", "Основная настройка");
            TranslationHelper.ILTranslation(il, "Main Attumenent : [", "Основная настройка : [");
            TranslationHelper.ILTranslation(il, "Main Attumenent : [None]", "Основная настройка : [Нет]");
            TranslationHelper.ILTranslation(il, "Secondary attunement", "Вторичная настройка");
            TranslationHelper.ILTranslation(il, "Secondary Attumenent : [", "Вторичная настройка : [");
            TranslationHelper.ILTranslation(il, "Secondary Attumenent : [None]", "Вторичная настройка : [Нет]");
        }
    }
}