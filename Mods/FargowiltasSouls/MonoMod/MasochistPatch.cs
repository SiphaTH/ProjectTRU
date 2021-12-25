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
    public class MasochistPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Masochist).GetCachedMethod(nameof(Masochist.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Eternity Mode initiated!", "Режим Вечности активирован!");
            TranslationHelper.ILTranslation(il, "Eternity Mode deactivated!", "Режим Вечности деактивирован!");
            TranslationHelper.ILTranslation(il, "Deviantt has awoken!", "Девиантт пробуждается!");
            TranslationHelper.ILTranslation(il, "Deviantt has awoken!", "Девиантт пробуждается!", 2);
        }
    }
}