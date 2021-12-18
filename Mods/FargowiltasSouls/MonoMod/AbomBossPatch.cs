using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.NPCs.AbomBoss;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class AbomBossPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(AbomBoss).GetCachedMethod(nameof(AbomBoss.AI));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "UH OH, STINKY", "Оо стинки");
        }
    }
}