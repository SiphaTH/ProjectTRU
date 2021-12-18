using System.Reflection;
using CalamityMod.NPCs.TownNPCs;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class THIEFPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(THIEF).GetCachedMethod(nameof(THIEF.SetChatButtons));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Refund", "Возврат");
        }
    }
}