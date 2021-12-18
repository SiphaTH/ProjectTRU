using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.SwarmSummons;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class OverloadPiratesPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(OverloadPirates).GetCachedMethod(nameof(OverloadPirates.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The pirates have calmed down!", "Пираты успокоились!");
            TranslationHelper.ILTranslation(il, "The pirates have calmed down!", "Пираты успокоились!", 2);
        }
    }
}