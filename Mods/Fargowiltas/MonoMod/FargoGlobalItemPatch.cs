using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class FargoGlobalItemPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FargoGlobalItem).GetCachedMethod(nameof(FargoGlobalItem.ModifyTooltips));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Forces surrounding biome state to Ocean upon activation", "Ваше окружение меняется на океан при активации");
            TranslationHelper.ILTranslation(il, "Forces surrounding biome state to Desert upon activation", "Ваше окружение меняется на пустыню при активации");
            TranslationHelper.ILTranslation(il, "Forces surrounding biome state to Jungle upon activation", "Ваше окружение меняется на джунгли при активации");
            TranslationHelper.ILTranslation(il, "Forces surrounding biome state to Snow upon activation", "Ваше окружение меняется на снега при активации");
            TranslationHelper.ILTranslation(il, "Forces surrounding biome state to Corruption upon activation", "Ваше окружение меняется на искажение при активации");
            TranslationHelper.ILTranslation(il, "Forces surrounding biome state to Crimson upon activation", "Ваше окружение меняется на багрянец при активации");
            TranslationHelper.ILTranslation(il, "In hardmode, forces surrounding biome state to Hallow upon activation", "В хардмоде, ваше окружение меняется на святые земли при активации");
            TranslationHelper.ILTranslation(il, "Can also catch townsfolk", "Также позволяет ловить НИПов");
            TranslationHelper.ILTranslation(il, "Also grants one extra lure", "Дарует дополнительный поплавок");
            TranslationHelper.ILTranslation(il, "This rod fires 2 lures", "Запускает 2 поплавка");
            TranslationHelper.ILTranslation(il, "This rod fires 3 lures", "Запускает 3 поплавка");
            TranslationHelper.ILTranslation(il, "This rod fires 5 lures", "Запускает 5 поплавков");
        }
    }
}