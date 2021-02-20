﻿using System.Collections.Generic;

namespace CalamityRuTranslate.DictionariesAndLists
{
    public static class ThoriumRussianDictionaries
    {
        public static Dictionary<string, (string, string)> ThoriumBuffs;
        public static Dictionary<string, string> ThoriumPrefixes;
        public static Dictionary<string, string> ThoriumProjectiles;
        public static Dictionary<string, string> ThoriumChestName;
        public static Dictionary<string, string> ThoriumDresserName;

        public static void LoadDictionaries()
        {
            ThoriumBuffs = new Dictionary<string, (string, string)>
            {
                {"AbyssalShell", ("Глубоководный панцирь", "Теперь ничто вам не навредит!")},
                {"AbyssalShellWeak", ("Давление глубин", "Урон, защита, и скорость передвижения значительно снижены")},
                {"AquaAffinity", ("Родство с водой", "Пока вы мокрые, скорость передвижения увеличена")},
                {"Aquamancer", ("Аквамант", "Ваш магический урон и скорость чтения заклинаний значительно увеличены")},
                {"AquaticAptitude", ("Подводник", "Окружающая вода усиливает вас!")},
                {"ArtilleryBuff", ("Артиллерия", "Увеличивает ваше максимальное количество стражей")},
                {"AssassinBuff", ("Ассасин", "Вне боя метательные атаки наносят в 4 раза больше критического урона")},
                {"AudioOverload", ("Звуковая перегрузка", "Симфонический урон увеличен на 15%")}, 
                {"ConductorBuff", ("Проводник", "Длительность и радиус эффектов вашего вдохновения увеличены")},
                {"GhostConductor", ("Падший хор", "Ваш призрачный хор перезаряжается")}, 
                {"MetronomeBuff", ("Тик!", "Симфонический урон и скорость игры на инструменте увеличены")},
                {"MetronomeDebuff", ("Так!", "Симфонический урон и скорость игры на инструменте снижены")},
                {"BatRepellentBuff", ("Репеллент: Летучие мыши", "Большинство летучих мышей становятся дружелюбными к вам")},
                {"BeetleCarapace", ("Жучий панцирь", "Сопротивление урону увеличено. Также вы отражаете часть урона")},
                {"BerserkSoul", ("Душа берсерка", "Если этот противник умрёт, наружу вырвется агрессивный дух")},
                {"BlightFever", ("Лихорадка", "Омницид осквернил душу этого существа...")},
                {"BloodRush", ("Приток крови", "Скорость передвижения и добычи увеличены на 15%")},
                {"BouncingFlameBuff", ("Цепное пламя", "Ваши огненные дебаффы распространяются на ближайших врагов")},
                {"Bubbled", ("Запузырен", "Вы улетаете!")},
                {"CactusJuice", ("Колючий и вкусный", "Вы невосприимчивы к большинству дебаффов влияющих на характеристики")},
                {"CalmWaters", ("Незапятнанные воды", "Без скверного присутствия Абиссия тут стало будто легче дышать")},
                {"CannotChain", ("Наэлектризован", "Не попадёт под влияние цепных молний")},
                {"ChaosState", ("Состояние хаоса: Телепортация", "Ваше тело все ещё восстанавливается от телепортации")},
                {"Charmed", ("Очарован", "Этот враг не может устоять перед вашей привлекательностью!")},
                {"Chill", ("Озноб", "Становится прохладно")},
                {"ChokingDepths", ("Удушающая аура", "Присутствие скверны загрязняет и отравляет свежий воздух поблизости")},
                {"ChosenMight", ("Опора реальности", "Этот мир находится под вашей защитой. Не позволяйте никому забыть это...")},
                {"Christmas", ("Рождество", "Сегодня наступило Рождество")},
                {"CleanBubble", ("Освежающий пузырь", "Вдыхание пузыря наполнило ваши лёгкие дополнительным запасом воздуха!")},
                {"CobblerBuff", ("Отполированная обувь", "Скорость передвижения, ускорение бега и высота прыжка увеличены")},
                {"Conflagrate", ("Служа другим, сгораю сам", "Ваши внутренности горят, но вы наносите больше урона")},
                {"Corporeal", ("Материальный", "Ваш дух перезаряжается")},
                {"Corrosion", ("Коррозия", "Урон по вам увеличен. Вы периодически теряете здоровье")},
                {"CounterAttack", ("Контрудар", "Сейчас самое время нанести удар!")},
                {"CreativityDrop", ("Креативность", "Базовый шанс выпадения вдохновения удвоен")},
                {"CursedHurtle", ("Проклятый взмах", "Вращение выходит из под контроля!")},
                {"DarknessWithin", ("Тьма внутри нас", "Только сильнейшие враги смогут утолить ваш голод...")},
                {"DashBuff", ("Кинетический аккумулятор", "Позволяет двойным нажатием совершить рывок")},
                {"DecayingFlesh", ("Гниющая плоть", "Плоть жертвы стремительно разлагается")},
                {"DemonBloodExhaust", ("Кровавая жатва", "В настоящее время нельзя хранить заряды крови")},
                {"DemonicDance", ("Демонический танец", "Магический урон увеличен на 20%")},
                {"DepthBreath", ("Глубина: Дыхание", "Вы можете дышать под водой")},
                {"DepthDamage", ("Глубина: Урон", "Урон увеличен на 10%")},
                {"DepthSpeed", ("Глубина: Скорость", "Скорость передвижения увеличена на 10%")},
                {"Destabilized", ("Дестабилизирован", "Ваше существование подобно коту Шрёдингера")},
                {"DevilSoul", ("Хватка дьявола", "Получение смертельного урона воскресит вас с 100 единицами здоровья")},
                {"DevilTired", ("Дьявольское истощение", "Получение смертельного урона убьёт вас...")},
                {"DRLimit", ("Лимит сопротивления урону", "Эффект Thorium Mod'а ограничен 35% сопротивления урону\nНайдите другие оригинальные/модовые предметы, чтобы увеличить сопротивление урону")},
                {"EarwormBuff", ("Навязчивая мелодия", "Длительность эффектов вашего вдохновения увеличена на 25%")},
                {"EmergencyAir", ("Аварийный запас воздуха", "При критическом значении кислорода запас вашего воздуха мгновенно пополнится")},
                //{"Enchanted", ("Зачарован", "Ваши магические способности улучшены")},
                //{"EnchantedArmorBuff", ("Зачарованная броня", "Вы носите комплект магической брони")},
                {"EnemyFrozen", ("Замёрзший", "Скорость передвижения этого противника заметно снижена")},
                {"EscapeRocketBuff", ("Система аварийного спасения", "Движки на полную мощность!")},
                {"ExplodePrevent", ("Взрыв готовится", "Вы ещё не можете устроить взрыв...")},
                {"ExplosionCoating", ("Насыщение метательного оружия: Взрыв", "Метательное оружие имеет шанс вызвать взрыв который поджигает ближайших врагов")},
                {"FishRepellentBuff", ("Репеллент: Рыба", "Большинство рыб становятся дружелюбными")},
                {"FleshFrenzy", ("Сумасшествие плоти", "Симбиот повысил ваш урон на 10%")},
                {"Frenzy", ("Безумие", "Скорость ваших атак увеличена на 8%")},
                {"FrostCoating", ("Насыщение метательного оружия: Глубокая заморозка", "Метательное оружие имеет шанс значительно затруднить движение поражённых врагов")},
                {"FrostHeart", ("Оледеневшее сердце", "В ледяной тюрьме ваше здоровье восстанавливаются")},
                {"Full", ("Сытый желудок", "Вы не можете больше съесть ни кусочка!")},
                {"Gateway", ("Портал", "Ваши врата где-то тут...")},
                {"GhastlySoul", ("Призрачная душа", "Получение смертельного урона вернёт вас домой")},
                {"GhastlyTired", ("Призрачное истощение", "Получение смертельного урона убьёт вас...")},
                {"GorganCoating", ("Насыщение метательного оружия: Горгоновый сок", "Метательное оружие имеет шанс заключить противника в камень")},
                {"Gouge", ("Глубокий порез", "Жизнь проносится перед глазами...")},
                {"Grace", ("Грация", "Вы стали гораздо более ловким")},
                {"GraniteSurge", ("Гранитный скачок", "Получаете на 5% больше урона из всех источников и урона с течением времени")},
                {"GravityDamage", ("Гравитационное мастерство", "Урон в дальнем бою увеличен на 15%")},
                {"Grimshadow", ("Фантомное присутствие", "Что-то таится в тьме...")},
                {"Grimshadow2", ("Фантомное присутствие", "Что-то таится в тьме...")},
                {"Grimshadow3", ("Фантомное присутствие", "По воде идёт рябь...")},
                {"Halloween", ("Хэллоуин!", "Сегодня наступил Хэллоуин")},
                {"Hallucination", ("Галлюцинации", "Что-то не так...")},
                {"Hexed", ("Заколдован", "Вы превратились в лягушку!")},
                {"Honey", ("Мёд", "Пчелы просто ОБОЖАЮТ мёд...")},
                {"HydrationBuff", ("Гидратация", "Ваше истощение быстрее проходит. Очки техники восстанавливаются быстрее")},
                {"IlluminatedNPC", ("Подсвеченный", "Этот обнаруженный враг получает на 10% больше урона")},
                {"IncandescentBurn", ("Раскалённое пламя", "Потеря здоровья")},
                {"Insanity", ("Безумие", "Вы наносите урон ближайшим противникам")},
                {"InsectRepellentBuff", ("Репеллент: Насекомые", "Большинство насекомых становятся дружелюбными")},
                {"InspirationReach", ("Пламенная речь", "Радиус подбора нот вдохновения увеличен")},
                {"Karma", ("Карма", "Тебя слили!")},
                {"LegacyBurn", ("Огонь наследия", "Если этот враг умрёт, будет высвобождена вредящая энергия")},
                {"LichActive", ("Полный крестраж", "Получение смертельного урона воскресит вас с 20 единицами здоровья")},
                {"LichNotActive", ("Крестраж без души", "Получение смертельного урона убьёт вас...")},
                {"LifeTransfusion", ("Жизненная трансфузия", "Регенерация здоровья отключена")},
                {"LifeWaterRegen", ("Дар живительной воды", "Максимальный запас здоровья и регенерация увеличены")},
                {"LightCurse", ("Лёгкое проклятие", "Этого врага медленно уничтожает чистая тьма")},
                {"LimbSnatch", ("Крепкая хватка", "Оно на твоём лице! Аагх!")},
                {"Liquefied", ("Сжиженный", "Защита и скорость передвижения уменьшены")},
                {"MagickStaffDebuff", ("Стихийный распад", "Расколот низшими элементами Террарии")},
                {"Magma", ("Магма", "Вы получаете дополнительный урон от огненных эффектов")},
                {"MajorEnchanted", ("Перечарован", "Ваши магические способности значительно улучшены")},
                {"Melting", ("Распад", "Вы быстро теряете здоровье")},
                {"MetamorphosisBad", ("Метаморфоза", "Ваша сила достигает абсолютного пика!")},
                {"MetamorphosisGood", ("Освобождённый", "Скорость атаки и урон увеличены на 30%")},
                {"MetamorphosisRealBad", ("Восстановление", "Ваше тело не привыкло к этой форме...")},
                {"MidnightOil", ("Сумеречное масло", "Враги не заинтересованы в вас")},
                {"Mycelium", ("Грибной рост", "Эта цель заражена мицелием")},
                {"MyceliumVeins", ("Грибные жилы", "Скорость метания увеличена на 10%")},
                {"Napalm", ("Напалм", "Жар нетерпим...")},
                {"Nightshade", ("Паслён", "Вы получаете дополнительный урон от отравляющих эффектов")},
                {"NinjaBuff", ("Ловкость рук", "Скорость метания, скорость передвижения и шанс критического удара увеличены")},
                {"OceansBuffer", ("Океанический буфер", "Превращает весь урон в исцеление")},
                {"OceansBufferExhaust", ("Истощение: Океанический буфер", "Ваш океанический буфер в настоящее время перезаряжается")},
                {"OmniVision", ("Абсолютное зрение", "Этот враг находится под взглядом ассасина")},
                {"Oozed", ("Просочившись", "Движение значительно уменьшено")},
                {"Overcharge", ("Нестабильность", "Магический урон и шанс критического удара сильно увеличены. Ваше тело медленно испаряется")},
                {"Overgrowth", ("Беспорядочный рост", "Восстановление здоровья и скорость регенерации здоровья значительно увеличены")},
                {"Paralyzed", ("Парализован", "Враг не может двигаться!")},
                {"ParryStance", ("Стойка для парирования", "Получаемый урон снижен на 10%")},
                {"Petrify", ("Окаменение", "Этот враг окаменел!")},
                {"PoisonHeart", ("Порченные сердца", "Выпадающие сердца лечат лишь на половину и отравляют вас")},
                {"Sanguine", ("Жизнерадостный", "Сопротивление урону увеличено на 10%. Восстановление здоровья значительно увеличено")},
                {"SchmelzeDebuff", ("Расплавленная ярость", "Вы теряете здоровье")},
                {"SeasonsGreeting", ("Приятная атмосфера", "Регенерация здоровья, маны и вдохновения увеличены")},
                {"Shackled", ("Скованный", "Вы привязаны к ближайшей 'королевской дочке'")},
                {"SilverTongue", ("Серебряный язык", "'Используйте этот серебряный язык, чтобы обмануть владельцев магазинов!'")},
                {"Singed", ("Опалённый", "Неприятный ожог...")},
                {"SkeletonRepellentBuff", ("Репеллент: Скелеты", "Большинство скелетов становятся дружелюбными")},
                {"SlagfuryStandBuffTired", ("Литая ярость", "Сила шлакового яростня восстанавливается...")},
                {"SnakeBite", ("Змеиный укус", "Вы теряете здоровье")},
                {"SoulHarvest", ("Жатва душ", "Ваше скорость передвижения и скорость метания значительно улучшены")},
                {"SporeCoating", ("Насыщение метательного оружия: Споры", "Метательное оружие имеет шанс заразить врагов мицелием")},
                {"Spored", ("Опылён", "Если этот противник умрёт, из него высвободится больше спор")},
                {"Staggered", ("Ошеломление", "У тебя слишком кружится голова, чтобы прыгать правильно")},
                {"Stunned", ("Оглушён", "Этот враг оглушён и не может двигаться")},
                {"Sunder", ("Расколотый", "Получаете на 10% больше урона из всех источников")},
                {"TastyJelly", ("Вкусное желе", "Восстановление здоровья значительно увеличено")},
                {"TerrariumMix", ("Ответный удар Террарии", "Расколот элементами Террарии")},
                {"TerrariumRegen", ("Поцелуй Террарии", "Силы Террарии оберегают вас")},
                {"ToxicCoating", ("Насыщение метательного оружия: Токсины", "Метательное оружие имеет шанс отравить врагов")},
                {"TrueStrike", ("Истинный удар", "Ваше оружие имеет 100% шанс нанести критический удар")},
                {"TrueStrikeTired", ("Критически истощён", "Ваш метательный урон уменьшен на 10%")},
                {"Tuned", ("Гармонизирован", "Вы получаете на 10% больше урона")},
                {"ViscountDebuff", ("Проклятие вампира", "Вас насильно превратили в слабую летучую мышь!")},
                {"WidowsKiss", ("Поцелуй вдовы", "В ваше тело выпущен смертельный токсин!")},
                {"WindBurst", ("Взрыв ветра", "Скорость ваших инструментов увеличена на 15%")},
                {"Wither", ("Иссушение", "ИССУШИСЬ!!!")},
                {"ZombieRepellentBuff", ("Репеллент: Зомби", "Большинство зомби становятся дружелюбными")},
                {"ShockAbsorbtion", ("Амортизация", "Весь урон увеличен на 15%")},
                {"Soloist", ("Бесконечная креативность", "Ваш музыкальный талант не имеет себе равных")},
                {"SoloistDebuff", ("Творческий кризис", "Вы не можете дать волю своему творчеству")},
                {"ZunpetBuff", ("Энергия зунпета", "Симфонический урон увеличен")},
                {"AegisAura", ("Защитная энергия", "Сопротивление урону увеличено на 5%")},
                //{"AloeJuice", ("Энергия алоэ", "Вы медленно восстанавливаете здоровье")},
                {"AngelBuff", ("Маленький Херувим", "От вашего плеча до линии фланга!")},
                {"Awake", ("Пробуждённый", "Не могу войти в сон...")},
                {"BloodBoost", ("Кровавое усиление", "Союзники усиливают ваши эффекты при попадании")},
                {"BloomBoost", ("Форсированное цветение", "Вы восстанавливаете здоровье и имеете увеличенную защиту")},
                {"BoneArmor", ("Костяная броня", "Сопротивление урону увеличено на 15%")},
                {"BulwarkBuff", ("Пузырный бастион", "Следующая атака по вам нанесёт 0 урона")},
                {"CelestialDamage", ("Лучезарное кольцо", "Лучезарный урон увеличен на 25%")},
                {"CelestialHeal", ("Исцеляющая звезда", "Целительные заклинания исцеляют дополнительные 2 очка здоровья")},
                {"ConsumingShadow", ("Поглощая тени", "Получение дополнительного урона от теневых дебаффов")},
                {"Cured", ("Исцелённый", "Большинство негативных эффектов были развеяны")},
                {"DarkContagion", ("Тёмная инфекция", "Вы поражены заразным темным проклятием")},
                {"DevilBuff", ("Маленький Дьявол", "От вашего плеча до линии фронта!")},
                {"DistortedTime", ("Искажённая реальность", "Поток времени находится под сильным давлением")},
                {"DistortedTimeBoost", ("Искажённое время", "Поток времени находится под сильным давлением")},
                {"DistortedTimeEnemy", ("Искажённое время", "Время замедляет этого врага")},
                {"DragonHeart", ("Сердце дракона", "Урон увеличен на 15%")},
                {"DreamBuff", ("Сновидец", "Невосприимчив к почти всем повреждениям")},
                {"DreamCatcherBuff", ("Ловец снов", "Получение смертельного урона восстановит ваш максимальный запас здоровья")},
                {"DreamCatcherDebuff", ("Пойманный сон", "Во сне вы не можете возродиться")},
                {"EffigyRegen", ("Чучело", "Враги, поражённые тёмной энергией, исцеляют вас")},
                //{"EquilibriumHeal", ("Уравновешенность", "Восстановление здоровья")},
                {"Gaurdian", ("Ангел-хранитель", "Спиритуалист защищает вас от смертельного урона")},
                {"GaurdianBad", ("Истощение Хранителя", "Вы не можете принять дар спиритуалиста")},
                {"GuardianDamage", ("Хранитель: Месть", "Урон увеличен на 15%")},
                {"GuardianDefense", ("Хранитель: Защита", "Сопротивление урону увеличено на 30%")},
                {"GuardianRegen", ("Хранитель: Восстановление", "Восстановление здоровья значительно увеличено")},
                {"HealerDefenseAura", ("Аура: Сопротивление урону", "Ваш союзник увеличивает ваше сопротивление урону на 12%")},
                {"HealerPotionBuff", ("Крепкое зелье", "Получение 1 дополнительного исцеления")},
                //{"HealerRegenAura", ("Аура: Восстановление здоровья", "Ваш союзник способствует восстановлению вашего здоровья")},
                {"HealingLoss", ("Вне связи", "Ваш бонус исцеления эффективен только на 33%")},
                {"HealingMastery", ("Мастерство исцеления", "Восстановление маны, бонус исцеления и скорость исцеления увеличены")},
                {"HolyAuraTired", ("Святая аура", "Защитная аура окружает ваш курсор")},
                {"HolyBonus", ("Святая сила", "Целительные заклинания исцеляют дополнительное здоровье")},
                {"HolyDefense", ("Святая защита", "Ваша защита увеличена на 20")},
                {"HolyGlare", ("Святой свет", "Да очистит святой свет нечистого!")},
                {"HolyShine", ("Аура: Святое сияние", "Ваши атакующие и защитные характеристики значительно увеличены")},
                {"KarmicConvergance", ("Кармическая конвергенция", "Лучезарный урон увеличен")},
                {"LifeRecovery", ("Восстановление здоровья", "Восстанавливает здоровье со временем")},
                {"LifeSpiritBuff", ("Дух жизни", "Слишком ярок, чтобы смотреть прямо")},
                {"MistBulwark", ("Напитанный туманом бастион", "Максимальный запас здоровья увеличен на 50")},
                {"Mortality", ("Смертность", "Сопротивление урону, урон и скорость передвижения уменьшены")},
                {"NullZoneBuff", ("Нуль-зона", "Получаемый снарядами урон снижен на 20%")},
                //{"Ointment", ("Перевязанный", "Восстановление здоровья")},
                {"PheonixBuff", ("Феникс", "Величественное существо наблюдает за вами и вашими союзниками")},
                //{"PurifiedRegen", ("Чистая регенерация", "Восстановление здоровья")},
                {"QuickRecovery", ("Быстрое восстановление", "Скорость восстановления здоровья увеличено на 20%")},
                {"RadiantBoost", ("Люминесцентная энергия", "Лучезарный урон увеличен на 10%")},
                {"Rebound", ("Отдача", "Время пытается вернуть свой ход")},
                {"RoseWind", ("Розовый пузырь", "Таинственная сила защищает и лечит вас")},
                {"RoseWindBad", ("Лопнувший пузырь", "Ваш пузырь перезаряжается...")},
                {"Savior", ("Освобождённый", "Невосприимчивость к урону")},
                {"SerpentsBubble", ("Змеиный пузырь", "Вы получаете 2 дополнительных очка здоровья от исцелений. Сопротивление урону увеличено на 10%")},
                {"ShieldDroneBuff", ("Защитный дрон", "От вашего плеча до краёв линий фронта!")},
                {"SmiteFire", ("Карающее пламя", "Вам наносится урон!")},
                {"SoulEssence", ("Сущность души", "")},
                {"SpeedBurst", ("Взрывное ускорение", "Исцеление союзника повышает вашу скорость передвижения и скорость лечения")},
                {"SpiritualConnection", ("Духовная связь", "Ваши лечебные заклинания исцеляют дополнительное здоровье")},
                {"Stabilized", ("Стабилизированный", "Не попадёт под действие цепного целительного эффекта")},
                {"TangyHeal", ("Резкое исцеление", "Скорость восстановления здоровья увеличена")},
                {"TheDream", ("Мечта", "Мир - это осознанная реальность...")},
                {"TwilightBoost", ("Сумеречное ускорение", "Союзник усиливает ваши эффекты при попадании")},
                {"VoidForm", ("Поглощая шёпот", "Власть приходит за плату")},
                {"BallBuff", ("Кибернетическая сфера", "Сферическая!")},
                {"BatBuffGood", ("Подарок вампира", "Вы превратились в летучую мышь!")},
                {"BathtubCartBuff", ("Ванна-мобиль", "Мойтесь даже на ходу!")},
                {"BeetleTFBuff", ("Жук", "Вы превратились в жука, способного к полёту")},
                {"BroomMountBuff", ("Волшебная метла", "Знак любви 'Мастер-спарк'")},
                {"CarMount", ("Пустотная колесница", "Кто знал, что это можно приручить?")},
                {"DragonMountBuff", ("Злой дракон", "Попробуйте игнорировать запах дыма...")},
                {"EnemyCrabBuff", ("Крабик", "Трепещите, морские обитатели!")},
                {"FrogBuff", ("Лягушка", "Вы превратились в прыгучую лягушку")},
                {"GoldfishTFBuff", ("Золотая рыбка", "Вы приобрели жабры и отличный вкус")},
                {"InfernalHoundBuff", ("Инфернальная гончая", "Беги, подгоняемый яростью ада!")},
                {"MaggotTFBuff", ("Литая личинка", "Вы превратились в маленького огненного червя")},
                {"MimicFormBuff", ("Подражатель", "Вы превратились в сундук-подражатель")},
                {"OldDebt", ("Знакомое лицо", "Старый долг выплачивается... а теперь спасите мир!")},
                {"RagMountBuff", ("Апокалипсис", "Вы знаменуете конец света...")},
                {"RocketCartBuff", ("Ракетная тележка", "Это не безопасно...")},
                {"SpectralFangBuff", ("Спектральный тигр", "Даже в смерти он все такой же хороший компаньон")},
                {"SquirrelBuff", ("Белка", "Вы превратились в белку")},
                {"StarvedMountBuff", ("Голодный зверь", "Этот зверь пускает слюни в своём вечном голоде")},
                {"SuperAnvilBuff", ("Супер наковальня", "Тяжелее, чем вес ваших ответственности")},
                {"WargMountBuff", ("Боевой варг", "Вступи в бой на своём чёрном варге!")},
                {"WhaleMountBuff", ("Кит", "Это действительно стоило того?")},
                {"WyvernMountBuff", ("Виверна", "Почувствуй ветер в своих волосах!")},
                {"Enrage", ("Ярость!", "Этот противник наносит на 15% больше урона при контакте")},
                {"Protection", ("Защита", "Этот противник получает на 25% меньше урона")},
                {"QuickFire", ("Скорострел", "Этот противник стреляет быстрее, чем обычно")},
                {"Regeneration", ("Регенерация", "Этот противник восстанавливает здоровье")},
                {"AbyssalWhistleBuff", ("Глубинный кролик", "Этот бедный малыш может быть последним из своего вида...")},
                {"AncientRatBuff", ("Древняя крыса", "Крыса тоже древняя? Ага!")},
                {"BabyBaliBuff", ("Экзотическая майна", "Этот особенный птенец любит тебя!")},
                {"BioFeederBuff", ("Био-кормушка", "Что за странное маленькое создание...")},
                {"BlisterBuff", ("Летающий волдырь", "Он не оставит тебя в покое!")},
                {"ClownfishPetBuff", ("Рыба-клоун", "Не смейся над ним...")},
                {"DrachmaBuff", ("Любопытный коинлинг", "Драхмы в наши дни не очень полезны...")},
                {"Experiment3Buff", ("Эксперимент #3", "Будь рад, что он ещё не взрослый...")},
                {"FerretBuff", ("Хорёк", "Этот маленький парень просто обожает двигаться!")},
                {"HolyGoatBuff", ("Святая коза", "Он светится золотом, так что и так неплохо!")},
                {"JellyPet", ("Медуза в пузыре", "Посмотрите как она летает вокруг!")},
                {"LilMogBuff", ("Маленький мугл", "Он милый, не правда ли?")},
                {"LittlePhylacteryBuff", ("Маленький некромант", "Этот маленький парень намного сильнее чем кажется...")},
                {"LockBoxBuff", ("Сундучок Дэйви Джонса!", "Полный бесконечным количеством монет!")},
                {"MaidBuff", ("Маленькая горничная", "Ну, здесь не то чтобы надо убираться...")},
                {"OmegaBuff", ("Омега Драйв", "ИСПАРИТЕЛЬНАЯ МАТРИЦА: ОНЛАЙН")},
                {"PickleBuff", ("Совершенно Обычная Собака", "Или же...?")},
                {"PinkSlimeBuff", ("Розовый слизень", "Это так мило!")},
                {"ShineDust", ("Сияющий друг", "Это довольно мило...")},
                {"SkunkBuff", ("Скунс", "Не пугай его, не то пожалеешь...")},
                {"SnowyOwlBuff", ("Потерянная снежная сова", "Видимо кто-то не получил свою почту...")},
                {"SubterraneanAnglerBuff", ("Глубоководный рыбак", "Может, это выглядит противно, но ты ему нравишься!")},
                {"SupportLanternBuff", ("Восстановительный фонарь", "Он постоянно излучает успокаивающую ауру")},
                {"TortleScuteBuff", ("Черепаший мудрец", "Мудр не по годам")},
                {"WyvernPetBuff", ("Виверна-волчонок", "Он может быть и молод, но старается как может!")},
                {"BannerConfusion", ("Коллективный разум", "Призванные существа могут запутать врагов")},
                {"BannerDamage", ("Боевое знамя", "Призванные существа наносят 5 дополнительного урона")},
                {"BannerDefense", ("Воинственное знамя", "Сопротивление урону повышается на 3% за каждое призванное существо")},
                {"BannerFalcon", ("Сокол", "Ближайшие призванные существа могут нанести дополнительный урон")},
                {"BannerGhost", ("Жертвенное чучело", "Ближайшие убийства призывают помогающих призраков")},
                {"BannerLifeRegen", ("Знамя боевого духа", "Атаки прислужников могут исцелить вас")},
                {"BannerPower", ("Знамя мощи", "Один из ваших стражей усилен")},
                {"Beholding", ("Созерцание", "Созерцающий покажет и уничтожит ваших противников")},
                {"BlackCaneBuff", ("Оружие Ли", "Любимое оружие Ли сражается за вас, даже когда его истинный хозяин в могиле...")},
                {"BlobfishBuff", ("Рыба-капля", "Это мило? Или же уродливо? Решать вам...")},
                {"BloodDrinker", ("Кровопийца", "Его жажда крови ненасытна")},
                {"BloodMinionBuff", ("Кровавый зомби", "Пока его кормят, он вас не побеспокоит...")},
                {"BloodPact", ("Кровавый пакт", "Просто заключил договор с демоном...")},
                {"BloodyPaganStaffBuff", ("Коварное лицо", "Будут разодраны. Твои враги. НА КУСКИ!")},
                {"ButterflyMinionBuff", ("Рой бабочек", "Собравшись вместе, бабочки представляют для врагов нешуточную угрозу")},
                {"Command", ("Аура сплочения", "Существа, призванные под этим эффектом, наносят на 10% больше урона")},
                {"CorrodeSlimeBuff", ("Искажака", "У защитников нет шансов против орды этих малышей!")},
                {"CorruptMinionBuff", ("Душевик", "Не все обитатели искажения хотят есть души...")},
                {"CrimsonMinionBuff", ("Кровавая гончая", "Несмотря на отсутствие рта, гончая всегда найдёт способ наесться...")},
                {"DarkRisenBuff", ("Тёмное воскрешение", "Да он хоть сейчас готов начать свою скелетную рейв-вечеринку!")},
                {"DinoBuff", ("Буйство", "Эти динозавры сходят с ума!")},
                {"DragonMinionBuff", ("Литой дракон", "У ваших врагов нет ни шанса")},
                {"EnchantedShieldBuff", ("Зачарованный барьер", "Вы защищены магическим барьером")},
                {"EnchantedTomeBuff", ("Гримуар", "Стреляющая заклинаниями книга помогает вам")},
                {"EnigmaMinion", ("Энигма", "Свет огибает сложную энигму...")},
                {"HailBomberBuff", ("Градо-подрывник", "Не бойся, они не пострадали... наверное")},
                {"HatchlingBuff", ("Птенец", "Этот птенец считает вас своей матерью!")},
                {"IceFairyBuff", ("Ледяная фея", "Лучше бы вашим врагам принести на бой шубу!")},
                {"LadyLightBuff", ("Звёздная искра", "Сверкает в неистовстве!")},
                {"MantisMinionBuff", ("Бритвенный богомол", "Мужчины, берегитесь!")},
                {"MeteorHeadStaff", ("Метеоритная голова", "Метеоритная голова решила работать с вами")},
                {"MeteorShieldBuff", ("Астральный барьер", "Вы защищены астральным барьером")},
                {"MoltenBannerBuff", ("Литое знамя", "Призванные существа были усилены мощным жаром")},
                {"MushroomArmy", ("Грибная армия", "Командуйте военными силами грибов!")},
                {"NebulaMinionBuff", ("Зеркальное отражение", "Зеркальное изображение помогает вам")},
                {"OdinEyeBuff", ("Око Одина", "Могучий глаз готов обрушить на ваших врагов электрическую бурю!")},
                {"RosySlimeBuff", ("Розовый слизень", "Почти столь же демоническая, как сама Пинки")},
                {"SaplingBuff", ("Верный росток", "Ради спасения мира, этот малыш выкладывается на полную")},
                {"SeahorseBuff", ("Морской конёк", "И на пути у нас пузыри!")},
                {"SlagMinionBuff", ("Литой уголёк", "Тепло, испускаемое им, неизмеримо...")},
                {"SteamgunnerBuff", ("Стимпанковский дрон", "У дрона всего одна задача: СТРЕЛЯТЬ")},
                {"TigerMinionBuff", ("Малыш-котёнок", "Укусы и царапины станут их погибелью")},
                {"BloodLotus", ("Кровавый лотос", "Выпускает крадущий здоровье поток")},
                {"LastStandBuff", ("Последний бой", "Скорость метания и урон увеличены на 30%, но ведь все имеет свою цену...")},
                {"ThrowingSpeed", ("Взрыв скорости", "Ваша скорость метания увеличена на 15%")},
                {"ValkyrieBladeBuff", ("Клинок валькирии", "У этого клинка есть своя воля...")}
            };

            ThoriumPrefixes = new Dictionary<string, string>
            {
                {"Loud", "Громкий"},
                {"Supersonic", "Сверхзвуковой"},
                {"Vibrant", "Вибрирующий"},
                {"Euphonic", "Благозвучный"},
                {"Melodic", "Мелодичный"},
                {"Inspiring", "Вдохновляющий"},
                {"Muted", "Приглушённый"},
                {"OffKey", "Нескладный"},
                {"Rambling", "Бессвязный"},
                {"Refined", "Настроенный"},
                {"Buzzing", "Гудящий"},
                {"Fabled", "Сказочный"}
            };
            
            ThoriumProjectiles = new Dictionary<string, string>
            {
                {"AbyssionSpit", "Плевок Абиссия"},
                {"AbyssionSpit2", "Плевок Абиссия"},
                {"AquaBomb", "Водяная бомба"},
                {"AquaBomb2", "Водяная бомба"},
                {"AquaRipple", "Тёмная пульсация"},
                {"AquaSplash", "Водяной всплеск"},
                {"AquaTyphoon", "Водяной тайфун"},
                {"AquaTyphoon2", "Водяной тайфун"},
                {"BeholderBeam", "Луч Созерцателя"},
                {"BeholderEyeEffect2", "Импульс Созерцателя"},
                {"BeholderLavaCascade", "Лавовый водопад"},
                {"BeholderLavaCascade1", "Лавовый водопад"},
                {"BioCoreBeam", "Био-ядерный луч"},
                {"BioVaporize", "Био-испарение"},
                {"BlizzardBoom", "Снежная вьюга"},
                {"BlizzardCascade", "Снежный водопад"},
                {"BlizzardFang", "Снежный клык"},
                {"BlizzardStart", "Снежный зажигатель"},
                {"BubbleBomb", "Пузырьковая бомба"},
                {"BubblePulse", "Пузырьковый импульс"},
                {"BuriedArrow", "Стрела"},
                {"BuriedArrow2", "Стрела"},
                {"BuriedArrowC", "Стрела"},
                {"BuriedArrowF", "Стрела"},
                {"BuriedArrowFBoom", "Огненный взрыв"},
                {"BuriedArrowP", "Стрела"},
                {"BuriedDagger", "Скрытый кинжал"},
                {"BuriedDaggerSpawner", "Скрытый кинжал"},
                {"BuriedMagic", "Магический взрыв"},
                {"BuriedMagicPop", "Магический хлопок"},
                {"ChampionBuff", "Чемпион"},
                {"CountScream", "Скрип"},
                {"CryoCoreBeam", "Крио-ядерный луч"},
                {"CryoVaporize", "Крио-испарение"},
                {"DeathCircle", "Хохочущая смерть"},
                {"DeathCircle2", "Хохочущая смерть"},
                {"DeathRay", "Луч смерти"},
                {"DeathRaySpawn", "Луч смерти"},
                {"DeathRaySpawn2", "Луч смерти"},
                {"DeathRaySpawn3", "Луч смерти"},
                {"DoomBeholderBeam", "Искореняющий луч Созерцателя"},
                {"EncroachBlast", "Сжимающий взрыв"},
                {"FlameFury", "Литая ярость"},
                {"FlameLash", "Огненная плеть"},
                {"FlameNova", "Кольцо огня"},
                {"FlameNovaBoom", "Кольцо пламени"},
                {"FlamePulsePro", "Огненный импульс"},
                {"GraniteBurst", "Гранитный взрыв"},
                {"GraniteCharge", "Гранитный заряд"},
                {"GravitonBoom", "Гравитонный взрыв"},
                {"GravitonCharge", "Гравитонный заряд"},
                {"GravitonSurge", "Гравитонный всплеск"},
                {"GravitySpark", "Гравитационная искра"},
                {"Laser", "Пустотный лазер"},
                {"LaserCloud", "Пустотные врата"},
                {"LaserCollide", "Лазер"},
                {"LichFlare", "Вспышка Лича"},
                {"LichFlareDeath", "Вспышка Лича"},
                {"LichFlareDeathSpawn", "Вспышка Лича"},
                {"LichFlareDeathSpawn2", "Вспышка Лича"},
                {"LichFlareDeathSpawn3", "Вспышка Лича"},
                {"LichFlareSpawn", "Вспышка Лича"},
                {"LichFlareSpawn2", "Вспышка Лича"},
                {"LichFlareSpawn3", "Вспышка Лича"},
                {"LichGaze", "Взор Лича"},
                {"LichPumpkinPro", "Тыква Лича"},
                {"LichPumpkinPro2", "Тыква Лича"},
                {"LightShock", "Электростатический шквал"},
                {"LucidBomb", "Светлая энергия"},
                {"LucidBomb2", "Светлая энергия"},
                {"LucidFury", "Светлая энергия"},
                {"LucidIndicator", "Светлая энергия"},
                {"LucidIndicator2", "Светлая энергия"},
                {"LucidNovaBoom", "Светлая энергия"},
                {"LucidPulse", "Светлая энергия"},
                {"LucidRay", "Светлая энергия"},
                {"LucidRaySpawn", "Светлая энергия"},
                {"LucidTyphoon", "Светлая энергия"},
                {"MainBeam", "Испаритель"},
                {"MainBeamCheese", "Испаритель"},
                {"MainBeamOuter", "Испаритель"},
                {"MoltenCoreBeam", "Литой-ядерный луч"},
                {"MoltenVaporize", "Литое испарение"},
                {"OldGodSpit", "Плевок Старого Бога"},
                {"OldGodSpit2", "Плевок Старого Бога"},
                {"QueenTorrent", "Водоворот"},
                {"RagFinish", "Рваная отделка"},
                {"RagFinish2", "Рваная отделка"},
                {"RagFinish3", "Финал"},
		        {"RagFinish4", "Финал"},
                {"SoulRenderLich", "Опустошитель души"},
                {"SoulSteal", "Импульс души"},
                {"ThunderBirdScreech", "Скрип"},
                {"ThunderChargeImage", "Скрип"},
                {"ThunderGust", "Грозовой порыв"},
                {"ThunderSpark", "Грозовая искра"},
                {"Vaporize", "Испарение"},
                {"VaporizeBlast", "Испаряющий заряд"},
                {"VaporizeBoom", "Испаряющий взрыв"},
                {"VaporizePulse", "Испаритель"},
                {"ViscountRipple", "Пульсация Виконта"},
                {"ViscountRipple2", "Пульсация Виконта"},
                {"ViscountRockFall", "Падающий камень"},
                {"ViscountStomp", "Топот Виконта"},
                {"ViscountStomp2", "Топот Виконта"},
                {"VoidLaserPro", "Пустотный лазер"},
                {"VoidPortal1", "Пустотный портал"},
                {"VoidPortal2", "Пустотный портал"},
                {"Whirlpool", "Водоворот"},
            };

            ThoriumChestName = new Dictionary<string, string>
            {
                {"AquaticDepthsBiomeChest", "Водный глубинный сундук"},
                {"DepthChestTile", "Глубинный сундук"},
                {"DesertBiomeChest", "Пустынный сундук"},
                {"LodestoneChest", "Магнетитовый сундук"},
                {"MarineChest", "Морской сундук"},
                {"PermafrostChest", "Сундук вечной мерзлоты"},
                {"PlateChest", "Пластинчатый сундук"},
                {"ScarletChest", "Алый сундук"},
                {"ThoriumChest", "Ториевый сундук"},
                {"UnderworldChest", "Адский сундук"},
                {"YewChest", "Тисовый сундук"},
                {"OrnateChest", "Изысканный сундук"},
                {"CursedChest", "Проклятый сундук"},
                {"NagaChest", "Нага-сундук"},
                {"ShadyChest", "Теневой сундук"},
                {"ValadiumChest", "Валадиумовый сундук"},
                {"BloodstainedChest", "Окровавленный сундук"}
            };

            ThoriumDresserName = new Dictionary<string, string>
            {
                {"FurnitureDresser", "Комод"}
            };
        }

        public static void UnloadDictionaries()
        {
            ThoriumBuffs = null;
            ThoriumPrefixes = null;
            ThoriumProjectiles = null;
            ThoriumChestName = null;
            ThoriumDresserName = null;
        }
    }
}