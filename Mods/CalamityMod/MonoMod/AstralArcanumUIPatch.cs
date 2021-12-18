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
    public class AstralArcanumUIPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(AstralArcanumUI).GetCachedMethod(nameof(AstralArcanumUI.UpdateAndDraw));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Select", "Выбрать");
        }
    }
}