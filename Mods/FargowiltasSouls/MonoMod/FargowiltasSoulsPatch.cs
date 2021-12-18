using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class FargowiltasSoulsPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(global::FargowiltasSouls.Fargowiltas).GetCachedMethod(nameof(global::FargowiltasSouls.Fargowiltas.HandlePacket));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Duke Fishron EX has awoken!", "Герцог Рыброн ЕХ пробудился!");
        }
    }
}