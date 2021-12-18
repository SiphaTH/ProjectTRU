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
    public class OverloadFrostMoonPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(OverloadFrostMoon).GetCachedMethod(nameof(OverloadFrostMoon.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The Frost Moon fades away!", "Морозная луна исчезает!");
            TranslationHelper.ILTranslation(il, "The Frost Moon fades away!", "Морозная луна исчезает!", 2);
            TranslationHelper.ILTranslation(il, "The Frost Moon is rising...", "Восходит морозная луна...");
            TranslationHelper.ILTranslation(il, "The Frost Moon is rising...", "Восходит морозная луна...", 2);
            TranslationHelper.ILTranslation(il, "Wave: 20: Everything", "Волна 20: Все");
            TranslationHelper.ILTranslation(il, "Wave: 20: Everything", "Волна 20: Все", 2);
        }
    }
}