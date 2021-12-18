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
    public class AncientSealShoot : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(AncientSeal).GetCachedMethod(nameof(AncientSeal.Shoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Every boss has awoken!", "Все боссы пробудились!");
            TranslationHelper.ILTranslation(il, "Every boss has awoken!", "Все боссы пробудились!", 2);
        }
    }

    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class AncientSealSpawnBoss : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(AncientSeal).GetCachedMethod(nameof(AncientSeal.SpawnBoss));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " has awoken!", " пробудился!");
        }
    }
}