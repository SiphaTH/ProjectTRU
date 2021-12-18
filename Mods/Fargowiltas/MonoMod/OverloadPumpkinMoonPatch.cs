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
    public class OverloadPumpkinMoonPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(OverloadPumpkinMoon).GetCachedMethod(nameof(OverloadPumpkinMoon.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The Pumpkin Moon fades away!", "Тыквенная луна исчезает!");
            TranslationHelper.ILTranslation(il, "The Pumpkin Moon fades away!", "Тыквенная луна исчезает!", 2);
            TranslationHelper.ILTranslation(il, "The Pumpkin Moon is rising...", "Восходит тыквенная луна...");
            TranslationHelper.ILTranslation(il, "The Pumpkin Moon is rising...", "Восходит тыквенная луна...", 2);
            TranslationHelper.ILTranslation(il, "Wave: 15: Everything", "Волна 15: Все");
            TranslationHelper.ILTranslation(il, "Wave: 15: Everything", "Волна 15: Все", 2);
        }
    }
}