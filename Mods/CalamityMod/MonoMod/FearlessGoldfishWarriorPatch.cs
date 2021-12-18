using System.Reflection;
using CalamityMod.NPCs.NormalNPCs;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class FearlessGoldfishWarriorPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FearlessGoldfishWarrior).GetCachedMethod(nameof(FearlessGoldfishWarrior.ModifyHitPlayer));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " was once again impaled by Goldfish.", " был снова проткнут Золотой рыбкой.");
        }
    }
}