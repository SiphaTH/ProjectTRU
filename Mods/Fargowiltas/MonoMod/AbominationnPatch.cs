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
    public class AbominationnSetChatButtons : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Abominationn).GetCachedMethod(nameof(Abominationn.SetChatButtons));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Cancel Event", "Остановить событие");
        }
    }
    
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class AbominationnOnChatButtonClicked : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(Abominationn).GetCachedMethod(nameof(Abominationn.OnChatButtonClicked));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The event has been cancelled!", "Событие было остановлено!");
            TranslationHelper.ILTranslation(il, "Hocus pocus, the event is over.", "Фокус-покус, событие кончилось.");
        }
    }
}