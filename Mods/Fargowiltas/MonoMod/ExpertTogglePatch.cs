using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Misc;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class ExpertTogglePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(ExpertToggle).GetCachedMethod(nameof(ExpertToggle.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Expert mode is now enabled!", "Режим эксперта теперь включён!");
            TranslationHelper.ILTranslation(il, "Expert mode is now disabled!", "Режим эксперта теперь отключён!");
        }
    }
}