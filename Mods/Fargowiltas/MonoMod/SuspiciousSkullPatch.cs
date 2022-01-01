using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.Mutant;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class SuspiciousSkullPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(SuspiciousSkull).GetCachedMethod(nameof(SuspiciousSkull.Shoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Skeletron has awoken!", "Скелетрон пробуждается!");
            TranslationHelper.ILTranslation(il, "Skeletron has awoken!", "Скелетрон пробуждается!", 2);
            TranslationHelper.ILTranslation(il, "Dungeon Guardian has awoken!", "Страж темницы пробуждается!");
            TranslationHelper.ILTranslation(il, "Dungeon Guardian has awoken!", "Страж темницы пробуждается!", 2);
        }
    }
}