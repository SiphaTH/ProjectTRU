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
    public class SEAHOEPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(SEAHOE).GetCachedMethod(nameof(SEAHOE.SetChatButtons));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Help", "Помощь");
        }
    }
}