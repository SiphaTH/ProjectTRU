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
    public class MutantRandomizerPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(MutantRandomizer).GetCachedMethod(nameof(MutantRandomizer.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Phantasmal energy wanes...", "Призрачная энергия ослабевает...");
            TranslationHelper.ILTranslation(il, "Phantasmal energy pulsates.", "Призрачная энергия пульсирует.");
        }
    }
}