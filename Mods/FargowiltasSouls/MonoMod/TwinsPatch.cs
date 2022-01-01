using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.EternityMode.Content.Boss.HM;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class TwinsRetinazer : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Retinazer).GetCachedMethod(nameof(Retinazer.CheckDead));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Retinazer endured the fatal blow to fight alongside its twin!", "Ретинайзер пережил смертельный удар, чтобы сражаться вместе со своим близнецом!");
        }
    }
    
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class TwinsSpazmatism : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Spazmatism).GetCachedMethod(nameof(Spazmatism.CheckDead));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Spazmatism endured the fatal blow to fight alongside its twin!", "Спазматизм пережил смертельный удар, чтобы сражаться вместе со своим близнецом!");
        }
    }
}