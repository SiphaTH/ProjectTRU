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
    public class CodebreakerUIDisplayCostText : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.DisplayCostText));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Cost: ", "Стоимость: ");
        }
    }

    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CodebreakerUIDrawDecryptCancelConfirmationText : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.DrawDecryptCancelConfirmationText));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Are you sure?", "Вы уверены?");
        }
    }

    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CodebreakerUIHandleDraedonSummonButton : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.HandleDraedonSummonButton));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Contact", "Контакт");
        }
    }

    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CodebreakerUIDisplayNotStrongEnoughErrorText : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.DisplayNotStrongEnoughErrorText));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Encryption unsolveable: Upgrades required.", "Шифрование нерешаемо: требуются обновления.");
        }
    }
}