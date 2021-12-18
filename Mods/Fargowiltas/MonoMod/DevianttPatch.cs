using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class DevianttPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Deviantt).GetCachedMethod(nameof(Deviantt.SetChatButtons));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Help", "Помощь");
            TranslationHelper.ILTranslation(il, ":Receive Gift]", ":Получить подарок]");
        }
    }
}