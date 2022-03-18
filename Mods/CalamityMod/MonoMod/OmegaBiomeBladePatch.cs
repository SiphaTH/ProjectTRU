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
    public class OmegaBiomeBladePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(OmegaBiomeBlade).GetCachedMethod(nameof(OmegaBiomeBlade.ModifyTooltips));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Does nothing.. yet", "Ничего не делает... пока");
            TranslationHelper.ILTranslation(il, "It seems that upgrading the blade expanded the scope of the previous attunements", "Похоже, что улучшение клинка расширило возможности предыдущих настроек");
            TranslationHelper.ILTranslation(il, "Your secondary attunement can now provide passive bonuses", "Ваша вторичная настройка теперь может давать пассивные бонусы");
            TranslationHelper.ILTranslation(il, "Active attunement", "Активная настройка");
            TranslationHelper.ILTranslation(il, "Active Attumenent : [", "Активная настройка : [");
            TranslationHelper.ILTranslation(il, "Active Attumenent : [None]", "Активная настройка : [Нет]");
            TranslationHelper.ILTranslation(il, "Passive attunement", "Пассивная настройка");
            TranslationHelper.ILTranslation(il, "Passive Attumenent : [", "Пассивная настройка : [");
            TranslationHelper.ILTranslation(il, "Passive Attumenent : [None]", "Пассивная настройка : [Нет]");
        }
    }
}