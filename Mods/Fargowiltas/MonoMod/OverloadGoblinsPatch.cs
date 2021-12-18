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
    public class OverloadGoblinsPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(OverloadGoblins).GetCachedMethod(nameof(OverloadGoblins.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The goblins have calmed down!", "Гоблины успокоились!");
            TranslationHelper.ILTranslation(il, "The goblins have calmed down!", "Гоблины успокоились!", 2);
        }
    }
}