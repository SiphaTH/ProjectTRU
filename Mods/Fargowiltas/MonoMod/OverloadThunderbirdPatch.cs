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
    public class OverloadThunderbirdPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(OverloadThunderbird).GetCachedMethod(nameof(OverloadThunderbird.UseItem));

        public override string ModderMethod => nameof(Translation);

        private void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Electricity fills the air!", "Электричество наполняет воздух!");
            TranslationHelper.ILTranslation(il, "Electricity fills the air!", "Электричество наполняет воздух!", 2);
        }
    }
}