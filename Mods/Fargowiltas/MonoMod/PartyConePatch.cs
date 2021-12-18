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
    public class PartyConePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(PartyCone).GetCachedMethod(nameof(PartyCone.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Looks like someone's throwing a Party!", "Похоже, кто-то закатывает вечеринку!");
        }
    }
}