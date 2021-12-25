using System.Reflection;
using CalamityMod.Projectiles.Pets;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class ChibiiDoggoAI : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(ChibiiDoggo).GetCachedMethod(nameof(ChibiiDoggo.AI));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " couldn't stand the sharp objects.", " не выдерживал острых предметов.");
        }
    }

    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class ChibiiDoggoSpawnDoggo : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(ChibiiDoggo).GetCachedMethod(nameof(ChibiiDoggo.SpawnDoggo));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "It's not over yet, kid!", "Это ещё не конец, малыш!");
            TranslationHelper.ILTranslation(il, "Don't get cocky, kid!", "Не зазнавайся, мелкий!");
        }
    }
}