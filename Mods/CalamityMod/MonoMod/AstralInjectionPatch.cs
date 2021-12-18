using System.Reflection;
using CalamityMod.Items.Potions;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class AstralInjectionPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(AstralInjection).GetCachedMethod(nameof(AstralInjection.OnConsumeItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "'s blood vessels burst from drug overdose.", " кровеносные сосуды лопаются от передозировки наркотиков.");
        }
    }
}