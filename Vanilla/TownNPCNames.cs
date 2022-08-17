using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla;

public class TownNpcNames : GlobalNPC
{
    public override bool InstancePerEntity => true;

    private readonly Dictionary<string, string> _townNpcNames = new()
    {
        {"Dazren", "Дазрен"},
        {"Drifter", "Дрифтер"},
        {"Finchi", "Финчи"},
        {"Heniek", "Хеник"},
        {"Fire", "Фаер"},
        {"Barney Calhoun", "Барни Калхун"},
        {"XiaoEn0426", "СяоЭн0426"},
        {"Joeseph Jostar", "Джозеф Джостар"},
        {"Sylux", "Силикс"},
        {"Tavish DeGroot", "Тэвиш ДеГрут"},
        {"Rythmi", "Ритми"},
        {"Izuna", "Изуна"},
        {"Jasmine", "Жасмин"},
        {"Cybil", "Кибил"},
        {"Verth", "Верт"},
        {"Gormer", "Кормер"},
        {"TingFlarg", "ТингФларг"},
        {"Driser", "Драйзер"},
        {"Eddie Spaghetti", "Эдди Спагетти"},
        {"G'tok", "Г'ток"},
        {"Katto", "Катто"},
        {"Lapp", "Лапп"},
        {"Ben Shapiro", "Бен Шапиро"},
        {"StreakistYT", "СтрикистYT"},
        {"Necroplasmic", "Некроплазмик"},
        {"Devin", "Девин"},
        {"Woffle", "Воффл"},
        {"Cameron", "Кэмерон"},
        {"Wilbur", "Уилбур"},
        {"Good Game Design", "иноп тибюл лосбаФ"},
        {"Danmaku", "Данмаку"},
        {"Lilly", "Лилли"},
        {"Daawn", "Даан"},
        {"Robin", "Робин"},
        {"Curly", "Кудряшка"},
        {"Farsni", "Фарсни"},
        {"Picasso", "Пикассо"},
        {"Arin", "Арин"},
        {"Tyler Van Hook", "Тайлер Ван Хук"},
        {"Cap'n Deek", "Кэп'н Дик"},
        {"Catalyst", "Каталист"},
        {"Sans Undertale", "Санс Андертейлов"},
        {"Papyrus Undertale", "Папирус Андертлейлов"},
        {"Vorbis", "Ворбис"},
        {"Angel", "Энжел"},
        {"Amber", "Янтарь"},
        {"Faith", "Вера"},
        {"Xsiana", "Ксиана"},
        {"Tim Lockwood", "Тим Локвуд"},
        {"Sir Samuel Winchester Jenkins Kester II", "Сэр Сэмюэль Винчестер Дженкинс Кестер II"},
        {"Brutus", "Брутус"},
        {"Emmett", "Эммет"},
        {"Stan Pines", "Стэн Пайнс"},
        {"Aldrimil", "Альдримил"},
        {"Sok'ar", "Сокар"},
        {"Toxin", "Токсин"},
        {"Mixcoatl", "Мишкоатль"},
        {"Khatunz", "Хатунц"},
        {"Amnesia Wapers", "Амнезия Вейперс"},
        {"Mage One-Trick", "Маг Трюкач"},
        {"Inorim, son of Ivukey", "Инорим, сын Ивукея"},
        {"Jensen", "Дженсен"},
        {"Merasmus", "Мерасмус"},
        {"Habolo", "Хаболо"},
        {"Ortho", "Орто"},
        {"Chris Tallballs", "Шаркрис Тальный"},
        {"Syethas", "Ситас"},
        {"Nextdoor Psycho", "Шизак Даркхолм"},
        {"Ozymandias", "Озимандиас"},
        {"Yoshi", "Йоши"},
        {"Smoogle", "Смоугл"},
        {"The Meowurer of Gods", "Мяукающий бог"},
    };

    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void AI(NPC npc)
    {
        if (_townNpcNames.ContainsKey(npc.GivenName))
        {
            npc.GivenName = _townNpcNames[npc.GivenName];
        }
    }
}