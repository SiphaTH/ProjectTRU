using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.EternityMode.Content.Boss.PHM;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class QueenBeePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(QueenBee).GetCachedMethod(nameof(QueenBee.PreAI));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Royal Subject has awoken!", "Королевская особа пробуждается!");
            TranslationHelper.ILTranslation(il, "Royal Subject has awoken!", "Королевская особа пробуждается!", 2);
        }
    }
}