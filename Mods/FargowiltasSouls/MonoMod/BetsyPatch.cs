using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.EternityMode.Content.Boss.HM;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class BetsyPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Betsy).GetCachedMethod(nameof(Betsy.PreAI));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "<User {0}{1}{2}{3}{4} was banned>", "<Пользователь {0}{1}{2}{3}{4} был забанен>");
            TranslationHelper.ILTranslation(il, "<User {0}{1}{2}{3}{4} was muted>", "<Пользователь {0}{1}{2}{3}{4} был замьючен>");
        }
    }
}