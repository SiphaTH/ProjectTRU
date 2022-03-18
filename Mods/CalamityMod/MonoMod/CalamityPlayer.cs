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
            TranslationHelper.ILTranslation(il, " downed too many shots.", " выпил слишком много напитков.");
            TranslationHelper.ILTranslation(il, "'s liver failed.", " отказала печень.");
            TranslationHelper.ILTranslation(il, " was charred by the brimstone inferno.", " был обуглен серным пламенем.");
            TranslationHelper.ILTranslation(il, "'s soul was released by the lava.", " душа была освобождена лавой.");
            TranslationHelper.ILTranslation(il, "'s soul was extinguished.", " душа была погашена.");
            TranslationHelper.ILTranslation(il, " was melted by the toxic waste.", " был расплавлен токсичными отходами.");
            TranslationHelper.ILTranslation(il, " disintegrated into ashes.", " рассыпался в прах.");
            TranslationHelper.ILTranslation(il, " was turned to ashes by the Profaned Goddess.", " был обращён Осквернённой богиней в пепел.");
            TranslationHelper.ILTranslation(il, " fell prey to their sins.", " пал жертвой своих грехов.");
            TranslationHelper.ILTranslation(il, "'s spirit was turned to ash.", " дух превратился в пепел.");
            TranslationHelper.ILTranslation(il, " became a blood geyser.", " стал кровавым гейзером.");
            TranslationHelper.ILTranslation(il, " was crushed by the pressure.", " был раздавлен давлением.");
            TranslationHelper.ILTranslation(il, "'s lungs collapsed.", " лёгкие отказали.");
            TranslationHelper.ILTranslation(il, " was consumed by the black flames.", " был поглощён чёрным пламенем.");
            TranslationHelper.ILTranslation(il, "'s flesh was melted by the plague.", " плоть была расплавлена чумой.");
            TranslationHelper.ILTranslation(il, " didn't vaccinate.", " не сделал прививок.");
            TranslationHelper.ILTranslation(il, "'s infection spread too far.", " инфекция распространилась слишком сильно.");
            TranslationHelper.ILTranslation(il, "'s skin was replaced by the astral virus.", " кожа была заменена астральным вирусом.");
            TranslationHelper.ILTranslation(il, " was incinerated by lunar rays.", " был испепелён лунными лучами.");
            TranslationHelper.ILTranslation(il, " vaporized into thin air.", " растворился в воздухе.");
            TranslationHelper.ILTranslation(il, "'s life was completely converted into mana.", " здоровье было полностью преобразовано в ману.");
            TranslationHelper.ILTranslation(il, " succumbed to alcohol sickness.", " поддался алкогольной болезни.");
            TranslationHelper.ILTranslation(il, " withered away.", " зачах.");
            TranslationHelper.ILTranslation(il, " was summoned too soon.", " был призван слишком рано.");
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
            TranslationHelper.ILTranslation(il, " is food for the Wyrms.", " стал пищей для змей.");
            TranslationHelper.ILTranslation(il, "Oxygen failed to reach ", "Не хватило кислорода для ");
            TranslationHelper.ILTranslation(il, " from the depths of the Abyss.", " из глубин бездны.");
            TranslationHelper.ILTranslation(il, " failed the challenge at hand.", " не справился с испытанием.");
            TranslationHelper.ILTranslation(il, " was destroyed by a mysterious force.", " был уничтожен таинственной силой.");
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
            TranslationHelper.ILTranslation(il, " converted all of their life to mana.", " обернул всю свою жизнь в ману.");
        }
    }
}