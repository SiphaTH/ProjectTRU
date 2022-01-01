using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Items;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class MasochistRealPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(MasochistReal).GetCachedMethod(nameof(MasochistReal.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The difficulty got real!", "Сложность вышла погулять!");
            TranslationHelper.ILTranslation(il, "The difficulty got fake!", "Сложность загнали домой!");
        }
    }
}