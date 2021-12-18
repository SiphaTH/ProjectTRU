using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.Abom;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class WeatherBalloonPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(WeatherBalloon).GetCachedMethod(nameof(WeatherBalloon.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Rain clouds cover the sky.", "Тучи закрывают небо.");
        }
    }
}