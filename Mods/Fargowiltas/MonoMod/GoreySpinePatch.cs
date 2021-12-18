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
    public class GoreySpinePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(GoreySpine).GetCachedMethod("get_NPCName");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Brain of Cthulhu", "Мозг Ктулху");
        }
    }
}