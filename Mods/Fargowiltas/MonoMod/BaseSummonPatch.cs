using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class BaseSummonPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(BaseSummon).GetCachedMethod(nameof(BaseSummon.Shoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " has awoken!", " пробудился!");
            TranslationHelper.ILTranslation(il, " has awoken!", " пробудился!", 2);
        }
    }
}