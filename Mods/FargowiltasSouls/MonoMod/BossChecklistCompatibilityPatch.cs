using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.ModCompatibilities;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class BossChecklistCompatibilityInitializeBosses : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(BossChecklistCompatibility).GetCachedMethod("InitializeBosses");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Deviantt", "Девиантт");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}].", "Используйте [i:{0}].");
            TranslationHelper.ILTranslation(il, "Deviantt is satisfied with its show of love.", "Девиантт доволен своим проявлением любви.");
            TranslationHelper.ILTranslation(il, "Abominationn", "Мерзостть");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}].", "Используйте [i:{0}].", 2);
            TranslationHelper.ILTranslation(il, "Abominationn has destroyed everyone.", "Мерзостть уничтожил всех.");
            TranslationHelper.ILTranslation(il, "Mutant", "Мутант");
            TranslationHelper.ILTranslation(il, "Throw [i:{0}] into a pool of lava while Abominationn is alive in Mutant's presence.", "Бросьте [i:{0}] в лаву, пока Мерзостть жив и в присутствие Мутанта.");
            TranslationHelper.ILTranslation(il, "Mutant has eviscerated everyone under its hands.", "Мутант выпотрошил всех своими руками.");
        }
    }
    
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class BossChecklistCompatibilityInitializeMinibosses : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(BossChecklistCompatibility).GetCachedMethod("InitializeMinibosses");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Champion of Timber", "Чемпион леса");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}] on the surface during the day.", "Используйте [i:{0}] днём на поверхности.");
            TranslationHelper.ILTranslation(il, "Champion of Timber returns to its squirrel clan...", "Чемпион леса возвращается в свой белчий клан...");
            TranslationHelper.ILTranslation(il, "Champion of Terra", "Чемпион земли");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}] underground.", "Используйте [i:{0}] под землёй.");
            TranslationHelper.ILTranslation(il, "Champion of Terra vanishes into the caverns...", "Чемпион земли исчезает в пещерах...");
            TranslationHelper.ILTranslation(il, "Champion of Earth", "Чемпион планеты");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}] in the underworld.", "Используйте [i:{0}] в аду.");
            TranslationHelper.ILTranslation(il, "Champion of Earth disappears beneath the magma...", "Чемпион планеты исчезает под магмой...");
            TranslationHelper.ILTranslation(il, "Champion of Nature", "Чемпион природы");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}] in underground snow.", "Используйте [i:{0}] в подземных снегах.");
            TranslationHelper.ILTranslation(il, "Champion of Nature returns to its slumber...", "Чемпион природы возвращается в свой сон...");
            TranslationHelper.ILTranslation(il, "Champion of Life", "Чемпион жизни");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}] in the Hallow at day.", "Используйте [i:{0}] днём в святых землях.");
            TranslationHelper.ILTranslation(il, "Champion of Life fades away...", "Чемпион жизни исчезает...");
            TranslationHelper.ILTranslation(il, "Champion of Shadow", "Чемпион тени");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}] in the Corruption or Crimson at night.", "Используйте [i:{0}] ночью в искажении или багрянце.");
            TranslationHelper.ILTranslation(il, "Champion of Shadow fades away...", "Чемпион тени исчезает...");
            TranslationHelper.ILTranslation(il, "Champion of Spirit", "Чемпион духа");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}] in the underground desert.", "Используйте [i:{0}] в подземной пустыне.");
            TranslationHelper.ILTranslation(il, "Champion of Spirit vanishes into the desert...", "Чемпион духа исчезает в пустыне...");
            TranslationHelper.ILTranslation(il, "Champion of Will", "Чемпион воли");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}] at the ocean.", "Используйте [i:{0}] в океане.");
            TranslationHelper.ILTranslation(il, "Champion of Will returns to the depths...", "Чемпион воли возвращается в глубины...");
            TranslationHelper.ILTranslation(il, "Eridanus, Champion of Cosmos", "Эридан, чемпион космоса");
            TranslationHelper.ILTranslation(il, "Spawn by using [i:{0}] in space.", "Используйте [i:{0}] в космосе.");
            TranslationHelper.ILTranslation(il, "Eridanus, Champion of Cosmos returns to the stars...", "Эридан, чемпион космоса возвращается к звёздам...");
        }
    }
}