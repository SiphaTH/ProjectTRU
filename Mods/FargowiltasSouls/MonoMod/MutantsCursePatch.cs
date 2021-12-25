using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Items.Summons;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class MutantsCursePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(MutantsCurse).GetCachedMethod(nameof(MutantsCurse.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Mutant has awoken!", "Мутант пробуждается!");
            TranslationHelper.ILTranslation(il, "Mutant has awoken!", "Мутант пробуждается!", 2);
        }
    }
}