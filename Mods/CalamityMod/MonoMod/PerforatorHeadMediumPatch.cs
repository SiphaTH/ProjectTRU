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
    public class PerforatorHeadMediumPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(PerforatorHeadMedium).GetCachedMethod(nameof(PerforatorHeadMedium.BossLoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The Medium Perforator", "Перфоратор");
        }
    }
}