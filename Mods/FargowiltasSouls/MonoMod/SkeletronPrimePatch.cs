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
    public class SkeletronPrimePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(SkeletronPrime).GetCachedMethod(nameof(SkeletronPrime.CheckDead));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Skeletron Prime has entered Dungeon Guardian form!", "Скелетрон Прайм принял форму стража темницы!");
        }
    }
}