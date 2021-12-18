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
    public class FargoGlobalTilePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FargoGlobalTile).GetCachedMethod(nameof(FargoGlobalTile.NearbyEffects));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The altar's light shines on you!", "Свет алтаря падает на вас!");
        }
    }
}