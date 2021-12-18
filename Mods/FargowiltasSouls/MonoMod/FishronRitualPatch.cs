using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Projectiles.Masomode;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class FishronRitualPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FishronRitual).GetCachedMethod(nameof(FishronRitual.AI));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Duke Fishron EX", "Герцог Рыброн ЕХ");
        }
    }
}