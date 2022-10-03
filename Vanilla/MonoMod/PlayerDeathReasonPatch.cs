using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;
using Terraria.DataStructures;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class PlayerDeathReasonPatch : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;

    public void LoadContent()
    {
        On.Terraria.DataStructures.PlayerDeathReason.ByCustomReason += PlayerDeathReasonOnByCustomReason;
    }

    public void UnloadContent()
    {
        On.Terraria.DataStructures.PlayerDeathReason.ByCustomReason -= PlayerDeathReasonOnByCustomReason;
    }
    
    private PlayerDeathReason PlayerDeathReasonOnByCustomReason(On.Terraria.DataStructures.PlayerDeathReason.orig_ByCustomReason orig, string reasoninenglish)
    {
        string name = Main.player[Main.myPlayer].name;
        
        if (reasoninenglish == $"{name} was violently pricked by a flower.") 
            reasoninenglish = $"{name} яростно закалывается цветком.";
        else if (reasoninenglish == $"{name}'s blood vessels burst from drug overdose.")
            reasoninenglish = $"{name} разрывает кровеносные сосуды от передозировки наркотиками.";
        else if (reasoninenglish == $"{name} suffered from severe anemia.")
            reasoninenglish = $"{name} страдает от тяжёлой анемии.";
        else if (reasoninenglish == $"{name} was unable to obtain a blood transfusion.")
            reasoninenglish = $"{name} не добивается переливания крови.";
        else if (reasoninenglish == $"{name}'s liver failed.")
            reasoninenglish = $"{name} сажает печень.";
        else if (reasoninenglish == $"{name} downed too many shots.")
            reasoninenglish = $"{name} выпивает слишком много напитков.";
        else if (reasoninenglish == $"{name} was charred by the brimstone inferno.")
            reasoninenglish = $"{name} обугливается серным пекло.";
        else if (reasoninenglish == $"{name}'s soul was released by the lava.")
            reasoninenglish = $"{name} освобождает душу лавой.";
        else if (reasoninenglish == $"{name}'s soul was extinguished.")
            reasoninenglish = $"{name} гасит свою душу.";
        else if (reasoninenglish == $"{name} was melted by the toxic waste.")
            reasoninenglish = $"{name} расплавляется токсичными отходами.";
        else if (reasoninenglish == $"{name}'s ashes scatter in the wind.")
            reasoninenglish = $"{name} развеивает по ветру свой прах.";
        else if (reasoninenglish == $"{name} was turned to ashes by the Profaned Goddess.")
            reasoninenglish = $"{name} обращается Осквернённой богиней в пепел.";
        else if (reasoninenglish == $"{name} fell prey to their sins.")
            reasoninenglish = $"{name} становится жертвой собственных грехов.";
        else if (reasoninenglish == $"{name} lost too much blood.")
            reasoninenglish = $"{name} теряет слишком много крови.";
        else if (reasoninenglish == $"{name}'s spirit was turned to ash.")
            reasoninenglish = $"{name} превращает свой дух в пепел.";
        else if (reasoninenglish == $"{name} became a blood geyser.")
            reasoninenglish = $"{name} становится кровавым гейзером.";
        else if (reasoninenglish == $"{name}'s lungs collapsed.")
            reasoninenglish = $"{name} выплёвывает лёгкие.";
        else if (reasoninenglish == $"{name} was crushed by the pressure.")
            reasoninenglish = $"{name} расплющивается давлением.";
        else if (reasoninenglish == $"{name} was consumed by the black flames.")
            reasoninenglish = $"{name} поглощается чёрным пламенем.";
        else if (reasoninenglish == $"{name} didn't vaccinate.")
            reasoninenglish = $"{name} не делает прививку.";
        else if (reasoninenglish == $"{name}'s flesh was melted by the plague.")
            reasoninenglish = $"{name} расплавляет свою плоть чумой.";
        else if (reasoninenglish == $"{name}'s skin was replaced by the astral virus.")
            reasoninenglish = $"{name} сменяет кожу астральным вирусом.";
        else if (reasoninenglish == $"{name}'s infection spread too far.")
            reasoninenglish = $"{name} слишком сильно запустила инфекцию.";
        else if (reasoninenglish == $"{name} was incinerated by lunar rays.")
            reasoninenglish = $"{name} испепеляется лунными лучами.";
        else if (reasoninenglish == $"{name} vaporized into thin air.")
            reasoninenglish = $"{name} испаряется в воздухе.";
        else if (reasoninenglish == $"{name}'s life was completely converted into mana.")
            reasoninenglish = $"{name} обращает свою жизнь в ману.";
        else if (reasoninenglish == $"{name} succumbed to alcohol sickness.")
            reasoninenglish = $"{name} поддаётся алкогольной болезни.";
        else if (reasoninenglish == $"{name} withered away.")
            reasoninenglish = $"{name} увядает.";
        else if (reasoninenglish == $"{name} was summoned too soon.")
            reasoninenglish = $"{name} призывается слишком рано.";
        else if (reasoninenglish == $"Oxygen failed to reach {name} from the depths of the Abyss.")
            reasoninenglish = $"Кислород в глубинах бездны не достигает игрока {name}.";
        else if (reasoninenglish == $"{name} is food for the Wyrms.")
            reasoninenglish = $"{name} становится пищей для змей.";
        else if (reasoninenglish == $"{name} failed the challenge at hand.")
            reasoninenglish = $"{name} не справляется с испытанием.";
        else if (reasoninenglish == $"{name} was destroyed by a mysterious force.")
            reasoninenglish = $"{name} уничтожается таинственной силой.";
        else if (reasoninenglish == $"{name} converted all of their life to mana.")
            reasoninenglish = $"{name} преобразовывает всё своё здоровье в ману.";
        else if (reasoninenglish == $"{name} couldn't stand the sharp objects.")
            reasoninenglish = $"{name} не выдерживает острых предметов.";
        else if (reasoninenglish == $"{name} was slapped too hard.")
            reasoninenglish = $"{name} получает слишком сильную пощёчину.";
        else if (reasoninenglish == $"{name} was once again impaled by Goldfish.")
            reasoninenglish = $"{name} вновь обезглавливается золотой рыбкой.";
        else if (reasoninenglish == $"{name} burst into sinless ash.")
            reasoninenglish = $"{name} превращается в безгрешный пепел.";
        else if (reasoninenglish == $"{name} was sucked dry.")
            reasoninenglish = $"{name} высушается досуха.";
        else if (reasoninenglish == $"{name} was impaled by a Giant Tortoise.")
            reasoninenglish = $"{name} обезглавливается гигантской черепахой.";
        else if (reasoninenglish == $"{name} was swallowed whole.")
			reasoninenglish = $"{name} полностью проглатывается.";
        else if (reasoninenglish == $"{name} became a man eaten by Man Eater.")
		    reasoninenglish = $"{name} становится человеком, съеденым людоедом.";
        else if (reasoninenglish == $"{name} had his nuts cracked.")
            reasoninenglish = $"{name} раскалывает свои орешки.";
        else if (reasoninenglish == $"{name} could not withstand the red lightning.")
            reasoninenglish = $"{name} не выдерживает красной молнии.";
        else if (reasoninenglish == $"{name} was incinerated by ungodly fire.")
            reasoninenglish = $"{name} сгорает осквернённым огнём.";
        else if (reasoninenglish == $"{name} went mad.")
            reasoninenglish = $"{name} сходит с ума.";
        else if (reasoninenglish == $"{name} was violently pricked by roses.")
            reasoninenglish = $"{name} яростно закалывается розами.";
        else if (reasoninenglish == $"{name} was somehow impaled by a pillar of crystals.")
            reasoninenglish = $"{name} каким-то образом пронзается столбом кристаллов.";

        return orig.Invoke(reasoninenglish);
    }
}