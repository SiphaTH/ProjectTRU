using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class FargoPlayerOnEnterWorld : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FargoPlayer).GetCachedMethod(nameof(FargoPlayer.OnEnterWorld));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Fargo's Music Mod not found!", "Fargo's Music Mod не найден");
            TranslationHelper.ILTranslation(il, "Please install Fargo's Music Mod for the full experience!!", "Пожалуйста, установите Fargo's Music Mod для полноценного опыта!");
        }
    }
    
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class FargoPlayerPreUpdate : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FargoPlayer).GetCachedMethod(nameof(FargoPlayer.PreUpdate));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " was pricked by a Cactus.", " был проколот кактусом.");
        }
    }
    
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class FargoPlayerPreKill : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FargoPlayer).GetCachedMethod(nameof(FargoPlayer.PreKill));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "You've been revived!", "Вы возродились!");
            TranslationHelper.ILTranslation(il, "You've been revived!", "Вы возродились!", 2);
            TranslationHelper.ILTranslation(il, " could not handle the infection.", " не справился с инфекцией.");
            TranslationHelper.ILTranslation(il, " rotted away.", " сгнил.");
            TranslationHelper.ILTranslation(il, " was annihilated by divine wrath.", " был истреблён божественным гневом.");
            TranslationHelper.ILTranslation(il, " was reaped by the cold hand of death.", " был сожжён холодной рукой смерти.");
        }
    }
    
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class FargoPlayerCatchFish : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(FargoPlayer).GetCachedMethod(nameof(FargoPlayer.CatchFish));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Duke Fishron EX has awoken!", "Герцог Рыброн ЕХ пробуждается!");
        }
    }
}