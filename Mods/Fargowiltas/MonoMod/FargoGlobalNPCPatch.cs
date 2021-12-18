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
    public class FargoGlobalNPCSwarm : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FargoGlobalNPC).GetCachedMethod("Swarm");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Killed: ", "Убито: ");
            TranslationHelper.ILTranslation(il, "Killed: ", "Убито: ", 2);
            TranslationHelper.ILTranslation(il, "Total: ", "Всего: ");
            TranslationHelper.ILTranslation(il, "Total: ", "Всего: ", 2);
            TranslationHelper.ILTranslation(il, "The swarm has been defeated!", "Орда была побеждена!");
            TranslationHelper.ILTranslation(il, "The swarm has been defeated!", "Орда была побеждена!", 2);
        }
    }
    
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class FargoGlobalNPCNPCLoot : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FargoGlobalNPC).GetCachedMethod("<NPCLoot>g__TryDowned|21_0");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "A new item has been unlocked in ", "Новый предмет был разблокирован в магазине ");
            TranslationHelper.ILTranslation(il, "'s shop!", "!");
        }
    }
    
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class FargoGlobalCheckDead : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FargoGlobalNPC).GetCachedMethod(nameof(FargoGlobalNPC.CheckDead));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Betsy has been defeated!", "Бетси была побеждена!");
        }
    }
}