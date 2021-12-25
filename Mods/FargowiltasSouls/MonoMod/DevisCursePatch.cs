using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Items.Summons;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class DevisCursePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(DevisCurse).GetCachedMethod(nameof(DevisCurse.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Deviantt has awoken!", "Девиантт пробуждается!");
            TranslationHelper.ILTranslation(il, "Deviantt has awoken!", "Девиантт пробуждается!", 2);
        }
    }
}