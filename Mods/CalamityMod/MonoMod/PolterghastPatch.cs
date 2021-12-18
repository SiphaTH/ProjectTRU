using System.Reflection;
using CalamityMod.NPCs.Polterghast;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class PolterghastPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Polterghast).GetCachedMethod(nameof(Polterghast.AI));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Necroghast", "Некрогаст");
            TranslationHelper.ILTranslation(il, "Necroplasm", "Некроплазм");
        }
    }
}