using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.EternityMode.Content.Boss.HM;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class DukeFishronSetDefaults : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(DukeFishron).GetCachedMethod(nameof(DukeFishron.SetDefaults));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Duke Fishron EX", "Герцог Рыброн ЕХ");
        }
    }
    
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class DukeFishronCheckDead : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(DukeFishron).GetCachedMethod(nameof(DukeFishron.CheckDead));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Duke Fishron EX has been defeated!", "Герцог Рыброн ЕХ был побеждён!");
        }
    }
}