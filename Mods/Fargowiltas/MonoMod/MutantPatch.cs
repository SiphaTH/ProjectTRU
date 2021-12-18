using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class MutantPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Mutant).GetCachedMethod(nameof(Mutant.SetChatButtons));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Pre Hardmode", "Прехардмод");
            TranslationHelper.ILTranslation(il, "Hardmode", "Хардмод");
            TranslationHelper.ILTranslation(il, "Post Moon Lord", "Пост-Лунный лорд");
            TranslationHelper.ILTranslation(il, "Cycle Shop", "Переключить магазин");
        }
    }
}