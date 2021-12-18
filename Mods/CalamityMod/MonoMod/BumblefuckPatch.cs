using System.Reflection;
using CalamityMod.NPCs.Bumblebirb;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class BumblefuckPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Bumblefuck).GetCachedMethod(nameof(Bumblefuck.BossLoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "A Dragonfolly", "Псевдодракон");
        }
    }
}