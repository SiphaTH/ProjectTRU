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
    public class WITCHPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(WITCH).GetCachedMethod(nameof(WITCH.SetChatButtons));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Enchant", "Зачарование");
        }
    }
}