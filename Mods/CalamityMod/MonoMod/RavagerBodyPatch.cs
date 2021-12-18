using System.Reflection;
using CalamityMod.NPCs.Ravager;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class RavagerBodyPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(RavagerBody).GetCachedMethod(nameof(RavagerBody.BossLoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Ravager", "Разрушитель");
        }
    }
}