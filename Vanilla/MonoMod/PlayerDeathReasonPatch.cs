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
        if (reasoninenglish == $"{name}'s blood vessels burst from drug overdose.")
            reasoninenglish = $"{name} разрывает кровеносные сосуды от передозировки наркотиками.";
        if (reasoninenglish == $"{name} suffered from severe anemia.")
            reasoninenglish = $"{name} страдает от тяжёлой анемии.";
        if (reasoninenglish == $"{name} was unable to obtain a blood transfusion.")
            reasoninenglish = $"{name} не добивается переливания крови.";
        if (reasoninenglish == $"{name}'s liver failed.")
            reasoninenglish = $"{name} сажает печень.";
        if (reasoninenglish == $"{name} downed too many shots.")
            reasoninenglish = $"{name} выпивает слишком много напитков.";
        if (reasoninenglish == $"{name} was charred by the brimstone inferno.")
            reasoninenglish = $"{name} обугливается серным пекло.";
        if (reasoninenglish == $"{name}'s soul was released by the lava.")
            reasoninenglish = $"{name} освобождает душу лавой.";
        if (reasoninenglish == $"{name}'s soul was extinguished.")
            reasoninenglish = $"{name} гасит свою душу.";
        if (reasoninenglish == $"{name} was melted by the toxic waste.")
            reasoninenglish = $"{name} расплавляется токсичными отходами.";
        if (reasoninenglish == $"{name}'s ashes scatter in the wind.")
            reasoninenglish = $"{name} развеивает по ветру свой прах.";
        if (reasoninenglish == $"{name} was turned to ashes by the Profaned Goddess.")
            reasoninenglish = $"{name} обращается Осквернённой богиней в пепел.";
        if (reasoninenglish == $"{name} fell prey to their sins.")
            reasoninenglish = $"{name} становится жертвой собственных грехов.";
        if (reasoninenglish == $"{name} lost too much blood.")
            reasoninenglish = $"{name} теряет слишком много крови.";
        if (reasoninenglish == $"{name}'s spirit was turned to ash.")
            reasoninenglish = $"{name} превращает свой дух в пепел.";
        if (reasoninenglish == $"{name} became a blood geyser.")
            reasoninenglish = $"{name} становится кровавым гейзером.";
        if (reasoninenglish == $"{name}'s lungs collapsed.")
            reasoninenglish = $"{name} выплёвывает лёгкие.";
        if (reasoninenglish == $"{name} was crushed by the pressure.")
            reasoninenglish = $"{name} расплющивается давлением.";
        if (reasoninenglish == $"{name} was consumed by the black flames.")
            reasoninenglish = $"{name} поглощается чёрным пламенем.";
        if (reasoninenglish == $"{name} didn't vaccinate.")
            reasoninenglish = $"{name} не делает прививку.";
        if (reasoninenglish == $"{name}'s flesh was melted by the plague.")
            reasoninenglish = $"{name} расплавляет свою плоть чумой.";
        if (reasoninenglish == $"{name}'s skin was replaced by the astral virus.")
            reasoninenglish = $"{name} сменяет кожу астральным вирусом.";
        if (reasoninenglish == $"{name}'s infection spread too far.")
            reasoninenglish = $"{name} слишком сильно запустила инфекцию.";
        if (reasoninenglish == $"{name} was incinerated by lunar rays.")
            reasoninenglish = $"{name} испепеляется лунными лучами.";
        if (reasoninenglish == $"{name} vaporized into thin air.")
            reasoninenglish = $"{name} испаряется в воздухе.";
        if (reasoninenglish == $"{name}'s life was completely converted into mana.")
            reasoninenglish = $"{name} обращает свою жизнь в ману.";
        if (reasoninenglish == $"{name} succumbed to alcohol sickness.")
            reasoninenglish = $"{name} поддаётся алкогольной болезни.";
        if (reasoninenglish == $"{name} withered away.")
            reasoninenglish = $"{name} увядает.";
        if (reasoninenglish == $"{name} was summoned too soon.")
            reasoninenglish = $"{name} призывается слишком рано.";
        if (reasoninenglish == $"Oxygen failed to reach {name} from the depths of the Abyss.")
            reasoninenglish = $"Кислород в глубинах бездны не достигает игрока {name}.";
        if (reasoninenglish == $"{name} is food for the Wyrms.")
            reasoninenglish = $"{name} становится пищей для змей.";
        if (reasoninenglish == $"{name} failed the challenge at hand.")
            reasoninenglish = $"{name} не справляется с испытанием.";
        if (reasoninenglish == $"{name} was destroyed by a mysterious force.")
            reasoninenglish = $"{name} уничтожается таинственной силой.";
        if (reasoninenglish == $"{name} converted all of their life to mana.")
            reasoninenglish = $"{name} преобразовывает всё своё здоровье в ману.";
        if (reasoninenglish == $"{name} couldn't stand the sharp objects.")
            reasoninenglish = $"{name} не выдерживает острых предметов.";
        if (reasoninenglish == $"{name} was slapped too hard.")
            reasoninenglish = $"{name} получает слишком сильную пощёчину.";
        if (reasoninenglish == $"{name} was once again impaled by Goldfish.")
            reasoninenglish = $"{name} вновь обезглавливается золотой рыбкой.";
        if (reasoninenglish == $"{name} burst into sinless ash.")
            reasoninenglish = $"{name} превращается в безгрешный пепел.";
        if (reasoninenglish == $"{name} was sucked dry.")
            reasoninenglish = $"{name} высушается досуха.";
        if (reasoninenglish == $"{name} was impaled by a Giant Tortoise.")
            reasoninenglish = $"{name} обезглавливается гигантской черепахой.";
        if (reasoninenglish == $"{name} was swallowed whole.")
			reasoninenglish = $"{name} полностью проглатывается.";
        if (reasoninenglish == $"{name} became a man eaten by Man Eater.")
		    reasoninenglish = $"{name} становится человеком, съеденым людоедом.";
        if (reasoninenglish == $"{name} had his nuts cracked.")
            reasoninenglish = $"{name} раскалывает свои орешки.";
        if (reasoninenglish == $"{name} could not withstand the red lightning.")
            reasoninenglish = $"{name} не выдерживает красной молнии.";
        if (reasoninenglish == $"{name} was incinerated by ungodly fire.")
            reasoninenglish = $"{name} сгорает осквернённым огнём.";
        if (reasoninenglish == $"{name} went mad.")
            reasoninenglish = $"{name} сходит с ума.";
        if (reasoninenglish == $"{name} was violently pricked by roses.")
            reasoninenglish = $"{name} яростно закалывается розами.";
        if (reasoninenglish == $"{name} was somehow impaled by a pillar of crystals.")
            reasoninenglish = $"{name} каким-то образом пронзается столбом кристаллов.";

        return orig.Invoke(reasoninenglish);
    }
}