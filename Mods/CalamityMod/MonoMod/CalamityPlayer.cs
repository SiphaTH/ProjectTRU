using System.Reflection;
using CalamityMod.CalPlayer;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CalamityPlayerPreKill : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.PreKill));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " downed too many shots.", " выпивает слишком много напитков.");
            TranslationHelper.ILTranslation(il, "'s liver failed.", " отказывает печень.");
            TranslationHelper.ILTranslation(il, " was charred by the brimstone inferno.", " обугливается серным пламенем.");
            TranslationHelper.ILTranslation(il, "'s soul was released by the lava.", " душа освобождается лавой.");
            TranslationHelper.ILTranslation(il, "'s soul was extinguished.", " душа гаснет.");
            TranslationHelper.ILTranslation(il, " was melted by the toxic waste.", " расплавляется токсичными отходами.");
            TranslationHelper.ILTranslation(il, " disintegrated into ashes.", " рассыпается в прах.");
            TranslationHelper.ILTranslation(il, " was turned to ashes by the Profaned Goddess.", " обращается Осквернённой богиней в пепел.");
            TranslationHelper.ILTranslation(il, " fell prey to their sins.", " становится жертвой своих грехов.");
            TranslationHelper.ILTranslation(il, "'s spirit was turned to ash.", " дух вревращается в пепел.");
            TranslationHelper.ILTranslation(il, " became a blood geyser.", " становится кровавым гейзером.");
            TranslationHelper.ILTranslation(il, " was crushed by the pressure.", " расплющивается давлением.");
            TranslationHelper.ILTranslation(il, "'s lungs collapsed.", " отказывают лёгкие.");
            TranslationHelper.ILTranslation(il, " was consumed by the black flames.", " поглощается чёрным пламенем.");
            TranslationHelper.ILTranslation(il, "'s flesh was melted by the plague.", " плоть расплавляется чумой.");
            TranslationHelper.ILTranslation(il, " didn't vaccinate.", " не делает прививку.");
            TranslationHelper.ILTranslation(il, "'s infection spread too far.", " инфекция распространяется слишком сильно.");
            TranslationHelper.ILTranslation(il, "'s skin was replaced by the astral virus.", " кожа заменяется астральным вирусом.");
            TranslationHelper.ILTranslation(il, " was incinerated by lunar rays.", " испепеляется лунными лучами.");
            TranslationHelper.ILTranslation(il, " vaporized into thin air.", " испаряется в воздухе.");
            TranslationHelper.ILTranslation(il, "'s life was completely converted into mana.", " здоровье полностью преобразуется в ману.");
            TranslationHelper.ILTranslation(il, " succumbed to alcohol sickness.", " поддаётся алкогольной болезни.");
            TranslationHelper.ILTranslation(il, " withered away.", " иссушается.");
            TranslationHelper.ILTranslation(il, " was summoned too soon.", " призывается слишком рано.");
        }
    }
    
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CalamityPlayerKillPlayer : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.KillPlayer));
        
        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " is food for the Wyrms.", " становится пищей для змей.");
            TranslationHelper.ILTranslation(il, "Oxygen failed to reach ", "Не хватило кислорода для ");
            TranslationHelper.ILTranslation(il, " from the depths of the Abyss.", " из глубин бездны.");
            TranslationHelper.ILTranslation(il, " failed the challenge at hand.", " не справляется с испытанием.");
            TranslationHelper.ILTranslation(il, " was destroyed by a mysterious force.", " уничтожается таинственной силой.");
        }
    }
    
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class CalamityPlayerOnConsumeMana : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.OnConsumeMana));
        
        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " converted all of their life to mana.", " оборачивает всю свою жизнь в ману.");
        }
    }
}