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
    public class OverloadSaucerPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(OverloadSaucer).GetCachedMethod(nameof(OverloadSaucer.UseItem));

        public override string ModderMethod => nameof(Translation);

        private void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Invaders have arrived!", "Произошло вторжение!");
            TranslationHelper.ILTranslation(il, "Invaders have arrived!", "Произошло вторжение!", 2);
        }
    }
}