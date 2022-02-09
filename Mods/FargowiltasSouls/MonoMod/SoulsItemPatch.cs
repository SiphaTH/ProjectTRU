using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.NPCs;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class SoulsItemPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FargoSoulsGlobalNPC).GetCachedMethod(nameof(FargoSoulsGlobalNPC.DropEnches));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Enchantment", "");
        }
    }
}