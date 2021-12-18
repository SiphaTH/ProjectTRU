using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Items.Misc;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class MutantsFuryPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(MutantsFury).GetCachedMethod(nameof(MutantsFury.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Mutant is angered!", "Мутант в ярости!");
            TranslationHelper.ILTranslation(il, "Mutant is calm.", "Мутант спокоен.");
        }
    }
}