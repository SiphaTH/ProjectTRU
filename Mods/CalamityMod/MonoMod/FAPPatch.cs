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
    public class FAPSetChatButtons : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FAP).GetCachedMethod(nameof(FAP.SetChatButtons));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Death Count", "Количество смертей");
        }
    }

    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class FAPGetChat : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FAP).GetCachedMethod(nameof(FAP.GetChat));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " was slapped too hard.", " получил слишком сильную пощечину.");
        }
    }
}