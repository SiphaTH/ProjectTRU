using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Patreon.LaBonez;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class PiranhaPlantVoodooDollPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(PiranhaPlantVoodooDoll).GetCachedMethod(nameof(PiranhaPlantVoodooDoll.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The suffering continues.", "Страдания продолжаются.");
            TranslationHelper.ILTranslation(il, "The suffering wanes.", "Страдания ослабевают.");
        }
    }
}