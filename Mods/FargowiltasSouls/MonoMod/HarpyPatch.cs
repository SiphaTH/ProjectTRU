using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.EternityMode.Content.Enemy;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class HarpyPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Harpy).GetCachedMethod(nameof(Harpy.OnHitPlayer));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "An item was stolen from you!", "У вас украли предмет!");
            TranslationHelper.ILTranslation(il, "An item was stolen from you!", "У вас украли предмет!", 2);
        }
    }
}