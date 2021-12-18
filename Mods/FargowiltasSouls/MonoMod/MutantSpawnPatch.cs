using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Projectiles.Pets;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class MutantSpawnPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(MutantSpawn).GetCachedMethod(nameof(MutantSpawn.BeCompanionCube));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Mutant has awoken!", "Мутант пробудился!");
            TranslationHelper.ILTranslation(il, "Mutant has awoken!", "Мутант пробудился!", 2);
            TranslationHelper.ILTranslation(il, "You think you're safe?", "Думаете, вы в безопасности?");
        }
    }
}