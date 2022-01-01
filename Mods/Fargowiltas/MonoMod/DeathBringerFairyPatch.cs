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
    public class DeathBringerFairyPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(DeathBringerFairy).GetCachedMethod(nameof(DeathBringerFairy.Shoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Several bosses have awoken!", "Несколько боссов пробуждаются!");
            TranslationHelper.ILTranslation(il, "Several bosses have awoken!", "Несколько боссов пробуждаются!", 2);
        }
    }
}