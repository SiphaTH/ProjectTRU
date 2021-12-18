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
    public class OverloadMartiansPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(OverloadMartians).GetCachedMethod(nameof(OverloadMartians.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The martians have calmed down!", "Марсиане успокоились!");
            TranslationHelper.ILTranslation(il, "The martians have calmed down!", "Марсиане успокоились!", 2);
        }
    }
}