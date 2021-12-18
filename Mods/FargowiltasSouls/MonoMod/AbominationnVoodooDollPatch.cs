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
    public class AbominationnVoodooDollPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(AbominationnVoodooDoll).GetCachedMethod(nameof(AbominationnVoodooDoll.Update));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Mutant has been enraged by the death of his brother!", "Мутант в ярости от гибели своего брата!");
        }
    }
}