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
    public class BossHealthBarManagerPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(BossHealthBarManager.BossHPUI).GetCachedMethod(nameof(BossHealthBarManager.BossHPUI.Draw));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "({0} left: {1})", "({0} осталось: {1})");
        }
    }
}