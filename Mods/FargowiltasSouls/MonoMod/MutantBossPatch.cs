using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.NPCs.MutantBoss;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class MutantBossPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(MutantBoss).GetCachedMethod(nameof(MutantBoss.AI));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Mutant tires of the charade...", "Мутант устал от шарады...");
        }
    }
}