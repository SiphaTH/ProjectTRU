using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.CaughtNPCs;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class CaughtNPCItemPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CaughtNPCItem).GetCachedMethod(nameof(CaughtNPCItem.SetStaticDefaults));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The Caught ", "Пойманный ");
        }
    }
}