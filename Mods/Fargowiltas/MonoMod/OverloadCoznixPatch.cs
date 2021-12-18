using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.SwarmSummons.Thorium;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [ModDependency("ThoriumMod")]
    [CultureDependency("ru-RU")]
    public class OverloadCoznixPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(OverloadCoznix).GetCachedMethod(nameof(OverloadCoznix.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The gates of hell have opened wide!", "Врата ада распахнулись!");
            TranslationHelper.ILTranslation(il, "The gates of hell have opened wide!", "Врата ада распахнулись!", 2);
        }
    }
}