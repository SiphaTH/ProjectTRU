using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Projectiles;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class HatGirlPatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(HatGirl).GetCachedMethod(nameof(HatGirl.SayThingWhileOwnerIsAlive));

    
    private delegate void SayThingWhileOwnerIsAliveDelegate(Player owner, string text);

    public override Delegate Delegate => Translation;

    private void Translation(SayThingWhileOwnerIsAliveDelegate orig, Player owner, string text)
    {
        text = text switch
        {
            "The Scourge will stop at nothing to snack on you! Stay on the move!" => "Бича ничего не остановит, лишь бы полакомиться тобой! Будь начеку!",
            "That thing seems to have shed its outer shell. Brace yourself, it's going to be a lot faster now!" => "Это существо, похоже, сбросило свою внешнюю оболочку. Готовься, теперь всё будет намного быстрее!",
            "Don't forget about that rubble! It will rain down from above!" => "Не забывай про булыжники! Они будут осыпаться сверху!",
            "Don't panic while trying to evade the bolts!" => "Не паникуй, пытаясь уклониться от снарядов!",
            "Stay near the center of your arena if you can. Those thorns are really good at cornering you!" => "Старайся держаться ближе к центру арены. Эти шипы хорошо загоняют в угол!",
            "The beam predicts your position, try baiting it into shooting away from you!" => "Луч предугадывает твою позицию, попробуй заставить его выстрелить на опережение!",
            "It seems like she's going to give it all she has! Brace yourself!" => "Кажется, она собирается выложиться по полной! Соберись с духом!",
            "Try and move as precisely as possible here; you don't want to waste arena space!" => "Постарайся двигаться как можно точнее, ты же не хочешь впустую потратить часть арены!",
            "This is the Void's last stand! Try not to get sucked in, and weave through the energy bolts!" => "Пустота решила дать последний бой! Старайся, чтобы тебя не засосало, и прорывайся через энергетические заряды!",
            "Lightning is going to aim ahead of you! Try to bait it!" => "Молния старается бить перед тобой! Попробуй обмануть её!",
            "Try to get between those lines, before the ice barrages explode!" => "Попытайся пройти между этими линиями, пока ледяные заграждения не взорвались!",
            "Prepare for it's final stand! Watch for red laser telegraphs and prepare to dash to safety!" => "Готовься к финальной атаке! Следи за красными полосами света и готовься к рывкам в безопасные зоны!",
            "Don't feel intimidated, face fear in the eyes and dash directly into the Devourer's maw!" => "Не поддавайся страху, посмотри ему в глаза и ринься прямо в пасть Пожирателя!",
            "Oh man, theres so many lasers! Slow and precise movements seem like your best bet here..." => "Божечки, сколько лазеров! Лучше всего здесь двигаться медленно и точно...",
            "Seems like they are combining efforts, beware!" => "По всей видимости, они объединяются, берегись!",
            "Don't fret, face fear in the eyes and dash directly into Thanatos' face-plates!" => "Не бойся, взгляни страху в глаза и ринься прямо в лицевые пластины Танатоса!",
            "If a certain starting combo isnt working too well, maybe experiment with another one?" => "Если стартовая комбинация плохо работает, может стоит поэкспериментировать с другой?",
            "Better choose well!" => "Хорошенько подумай над выбором!",
            "Static bolts seem to be flying towards you! Be wary of them, and don't get trapped by the lightning telegraphs!" => "В твою сторону летят статические заряды! Избегай их и не попадись в ловушку из полос молний!",
            "Keep track of where the long charge stops! You might get swept up by a tidal wave!" => "Следи за местом окончания длинного заряда, иначе тебя может захлестнуть приливная волна!",
            "Try your best to weave through the razorblades and brace youself!" => "Старайся ловко пробираться сквозь острые лезвия и держись!",
            "You're gonna have a bad time..." => "Тебе придётся несладко...",
            "It's still going?!" => "Это ещё не кончилось?!",
            "The ninja shoots more shurikens the farther you are, so don't go too far!" => "Чем дальше ты находишься, тем больше сюрикенов запускает ниндзя, так что не убегай слишком далеко!",
            "Home stretch! Do the same as you did before!" => "Ну, уже почти! Давай, делай то же самое, что делал до этого!",
            "Home stretch! try focusing on yourself more than the boss!" => "Финишная прямая! Постарайся больше концентрироваться на себе, чем на боссе!",
            "The Moon Lord seems angry! Try to dodge the side projectiles, and don't touch that black hole!" => "Лунный лорд, кажется, разгневан! Старайся уворачиваться от боковых снарядов и не задевай чёрную дыру!",
            "Brace yourself! A barrage of slow bolts are going to be released!" => "Приготовься! Сейчас будет выпущен шквал медленных зарядов!",
            "Staying calm and still will help dodge the slow projectiles!" => "Спокойствие и неспешность помогут увернуться от медленных снарядов!",
            "Those drones are building a jail around you, destroying one will give you an opening!" => "Дроны строят вокруг тебя тюрьму, уничтожь одного для открытия прохода!",
            "Destroy those builder drones before the whole jungle goes kablooey!" => "Уничтожь этих строительных дронов, пока всем джунглям не настал кабздец!",
            "Plantera isn't keeping anything back, watch out!" => "Плантера больше не сдерживается, берегись!",
            "Manage those clouds carefully. You'll need to weave through them to find the gap in her tentacles!" => "Внимательно следи за облаками. Тебе нужно будет пробираться сквозь них, чтобы найти брешь в её щупальцах!",
            "Polterghast's spirits have been released! But they don't seem very happy with us..." => "Духи Полтергаста были освобождены! Но, кажется, они нам не очень-то рады...",
            "Those blue tesla mines are going to explode into gas; take cover!" => "Эти синие электро-мины сейчас взорвутся газом, прячься!",
            "Pay attention to where you move. Try to stay in one spot so that those bombs aren't all over the arena!" => "Обращай внимание на то, куда двигаешься. Старайся оставаться на одном месте, чтобы бомбы не разлетелись по всей арене!",
            "Don't move around too quickly! Small but quick horizontal movements are important for evading those crystals!" => "Не двигайся слишком быстро! Небольшие, но быстрые горизонтальные движения помогут уклониться от кристаллов!",
            "Pay attention to where you move. You don't want Providence to fire her lasers when near a wall!" => "Обращай внимание на то, куда двигаешься. Уж поверь, ты не хочешь, чтобы Провиденс стреляла из своих лазеров, когда ты рядом со стеной!",
            "Watch out, he might try to trick you at the end!" => "Смотри, будь аккуратнее, в конце он может попробовать тебя одурачить!",
            "Those bombs will explode into kunai that fly towards you. Be careful!" => "Эти бомбы взорвутся и превратятся в кунаи, которые полетят в твою сторону. Будь осторожен!",
            "The Weaver has shed its exterior. It will now move far faster!" => "Ткач сбросил свой внешний слой. Теперь он будет двигаться гораздо быстрее!",
            "The Weaver seems to be creating a bunch of clouds above you! Try to weave through the resulting bolts as they fall!" => "Ткач формирует кучу облаков над тобой! Постарайся проскочить сквозь образовавшиеся заряды, пока они падают!",
            "So many skulls, but it appears they aren't focused directly at you! Try going inbetween!" => "Как много черепов, но, похоже, они не направлены прямо на тебя! Попробуй проскочить между ними!",
            "Calamitas' is laying exploding brimstone magic with every charge, try to direct them away from a safe location!" => "Каламитас использует взрывную серную магию. С каждым зарядом старайся увести их подальше от безопасной зоны!",
            "Dont feel overwhelmed by all the projectiles, keep your cool during this flaming match!" => "Не бойся снарядов, сохраняй хладнокровие во время этого жаркого боя!",
            "Even when all hell breaks loose, stay focused on your dodging!" => "Даже когда наступит полный п... кхм, концентрируйся на уклонении!",
            "Watch out, that last twin is gonna hit you with everything it's got! Don't let up!" => "Берегись, последний близнец атакует тебя со всей силы! Не расслабляйся!",
            "Better stay near the edges of the arena during those carpet bomb flames, That should keep them out of the way!" => "Во время ковровой бомбардировки огнями лучше держись ближе к краям арены, так они будут меньше мешать!",
            "This speed is crazy! Make sure you know when it starts; you might get jumpscared!" => "Вот это скорость! Надеюсь, ты знаешь, когда всё начнётся. Если нет, то готовься к скримеру!",
            "Don't let the flashbang faze you! Keep your eyes peeled for where the embers are!" => "Не отвлекайся на вспышки! Следи за тем, где сейчас находятся снаряды!",
            "Yharon's burning some serious energy now! Stay focused!" => "Ярон сейчас пылает просто невероятной энергией! Не отвлекайся!",
            "It seems as if it is manipulating telelocational magic, your Rod of Discord is of no use here!" => "Видимо, он манипулирует телелокационной магией, твой жезл раздора бесполезен!",
            _ => text
        };
        
        orig.Invoke(owner, text);
    }
}