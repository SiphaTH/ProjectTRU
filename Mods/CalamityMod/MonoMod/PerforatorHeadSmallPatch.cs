using System.Reflection;
using CalamityMod.NPCs.Perforator;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class PerforatorHeadSmallPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(PerforatorHeadSmall).GetCachedMethod(nameof(PerforatorHeadSmall.BossLoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The Small Perforator", "Перфоратор");
        }
    }
}