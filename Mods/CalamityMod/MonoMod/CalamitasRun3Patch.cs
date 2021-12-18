using System.Reflection;
using CalamityMod.NPCs.Calamitas;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CalamitasRun3Patch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CalamitasRun3).GetCachedMethod(nameof(CalamitasRun3.BossLoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The Calamitas Clone", "Клон Каламитас");
        }
    }
}