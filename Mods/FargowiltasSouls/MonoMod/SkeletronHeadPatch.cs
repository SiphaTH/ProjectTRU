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
    public class SkeletronHeadPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(SkeletronHead).GetCachedMethod(nameof(SkeletronHead.CheckDead));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Skeletron has entered Dungeon Guardian form!", "Скелетрон принял форму стража темницы!");
        }
    }
}