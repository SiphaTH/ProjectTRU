using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class PatreonPlayerPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(PatreonPlayer).GetCachedMethod(nameof(PatreonPlayer.OnEnterWorld));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Your special patreon effects are active ", "Ваш особый эффект патреона - ");
        }
    }
}