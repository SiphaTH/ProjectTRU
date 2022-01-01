using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class WeakReferenceSupportAddCalamityBosses : MonoModPatcher<string>
    {
        public override MethodInfo Method => ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetCachedMethod("AddCalamityBosses");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Desert Biome", "Используйте [i:{0}] в пустыне.");
            TranslationHelper.ILTranslation(il, "The scourge of the desert delved back into the sand.", "Пустынный бич погружается назад в песок.");
            TranslationHelper.ILTranslation(il, "Desert Scourge", "Пустынный бич");
            TranslationHelper.ILTranslation(il, "Can spawn naturally in the Sunken Sea", "Может естественно появится в затерянном море.");
            TranslationHelper.ILTranslation(il, "The Giant Clam returns into hiding in its grotto.", "Гигантский моллюск скрывается в своём гроте.");
            TranslationHelper.ILTranslation(il, "Giant Clam", "Гигантский моллюск");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Mushroom Biome", "Используйте [i:{0}] в грибном биоме.");
            TranslationHelper.ILTranslation(il, "The mycleium crab has lost interest.", "Мицелиевый краб потерял интерес.");
            TranslationHelper.ILTranslation(il, "Crabulon", "Крабулон", 2);
            TranslationHelper.ILTranslation(il, "Kill a Cyst in the Corruption or use a [i:{0}] in the Corruption", "Убейте кисту или используйте [i:{0}] в искажении.");
            TranslationHelper.ILTranslation(il, "The corrupted colony began searching for a new breeding ground.", "Искажённая стая начала поиски нового места для размножения.");
            TranslationHelper.ILTranslation(il, "Hive Mind", "Разум Улья");
            TranslationHelper.ILTranslation(il, "Kill a Cyst in the Crimson or use a [i:{0}] in the Crimson", "Убейте кисту или используйте [i:{0}] в багрянце.");
            TranslationHelper.ILTranslation(il, "The parasitic hive began searching for a new host.", "Паразитический улей начал искать нового носителя.");
            TranslationHelper.ILTranslation(il, "The Perforators", "Перфораторы");
            TranslationHelper.ILTranslation(il, "Use an [i:{0}]", "Используйте [i:{0}].");
            TranslationHelper.ILTranslation(il, "The gelatinous monstrosity achieved vengeance for its brethren.", "Желеподобное чудовище отомстило за своих собратьев.");
            TranslationHelper.ILTranslation(il, "Slime God", "Бог слизней");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Snow Biome", "Используйте [i:{0}] в снегах.");
            TranslationHelper.ILTranslation(il, "Cryogen drifts away, carried on a freezing wind.", "Криоген уносится прочь ледяным ветром.");
            TranslationHelper.ILTranslation(il, "Cryogen", "Криоген", 2);
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Brimstone Crag", "Используйте [i:{0}] в серной скале.");
            TranslationHelper.ILTranslation(il, "Brimstone Elemental withdraws to the ruins of her shrine.", "Серный элементаль отступает к руинам своей святыни.");
            TranslationHelper.ILTranslation(il, "Brimstone Elemental", "Серный элементаль");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Sulphuric Sea or wait for it to spawn in the Sulphuric Sea", "Используйте [i:{0}] или подождите его появление в сернистом море.");
            TranslationHelper.ILTranslation(il, "The Aquatic Scourge swam back into the open ocean.", "Акватический бич уплыл обратно в открытый океан.");
            TranslationHelper.ILTranslation(il, "Aquatic Scourge", "Акватический бич");
            TranslationHelper.ILTranslation(il, "Use an [i:{0}] at Night", "Используйте [i:{0}] ночью.");
            TranslationHelper.ILTranslation(il, "If you wanted a fight, you should've came more prepared.", "Если вы хотели драки, вы должны были прийти более подготовленными.");
            TranslationHelper.ILTranslation(il, "Calamitas", "Каламитас", 2);
            TranslationHelper.ILTranslation(il, "Kill 10 sand sharks after defeating Plantera or use a [i:{0}] in the Desert Biome", "Убейте 10 песчаных акул после победы над Плантерой или используйте [i:{0}] в пустыне.");
            TranslationHelper.ILTranslation(il, "The apex predator of the sands disappears into the dunes...", "Высший хищник песков исчезает в дюнах...");
            TranslationHelper.ILTranslation(il, "Great Sand Shark", "Великая песчаная акула");
            TranslationHelper.ILTranslation(il, "By killing an unknown entity in the Ocean Biome", "Убейте неизвестное существо в океане");
            TranslationHelper.ILTranslation(il, "The aquatic entities sink back beneath the ocean depths.", "Водные существа возвращаются в глубины океана.");
            TranslationHelper.ILTranslation(il, "Leviathan", "Левиафан", 2);
            TranslationHelper.ILTranslation(il, "Use an [i:{0}] at Night in the Astral Biome", "Используйте [i:{0}] ночью в астральном биоме.");
            TranslationHelper.ILTranslation(il, "Astrum Aureus’ program has been executed. Initiate recall.", "Программа Аструм Ареуса выполнена. Иницинирую возврат.");
            TranslationHelper.ILTranslation(il, "Astrum Aureus", "Аструм Ареус");
            TranslationHelper.ILTranslation(il, "Use an [i:{0}] in the Jungle Biome", "Используйте [i:{0}] в джунглях.");
            TranslationHelper.ILTranslation(il, "HOSTILE SPECIMENS TERMINATED. INITIATE RECALL TO HOME BASE.", "ВРАЖДЕБНЫЕ СУЩНОСТИ УНИЧТОЖЕНЫ. ИНИЦИНИРУЮ ВОЗВРАТ НА БАЗУ.");
            TranslationHelper.ILTranslation(il, "Plaguebringer Goliath", "Разносчица чумы, Голиаф");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}]", "Используйте [i:{0}].");
            TranslationHelper.ILTranslation(il, "The automaton of misshapen victims went looking for the true perpetrator.", "Машина бесформенных жертв отправилась на поиски истинного нарушителя.");
            TranslationHelper.ILTranslation(il, "Ravager", "Разрушитель", 2);
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] or [i:{1}] as offering at an [i:{2}]", "Используйте [i:{0}] или [i:{1}] в качестве подношения на [i:{2}].");
            TranslationHelper.ILTranslation(il, "The infected deity retreats to the heavens.", "Заражённое божество отступает к небесам.");
            TranslationHelper.ILTranslation(il, "Astrum Deus", "Аструм Деус");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Hallow or Underworld Biomes", "Используйте [i:{0}] в святых землях или в аду.");
            TranslationHelper.ILTranslation(il, "The guardians must protect their goddess at all costs.", "Стражи должны защищать свою богиню любой ценой.");
            TranslationHelper.ILTranslation(il, "Profaned Guardians", "Осквернённые стражи");
            TranslationHelper.ILTranslation(il, "Use [i:{0}] in the Jungle Biome", "Используйте [i:{0}] в джунглях.");
            TranslationHelper.ILTranslation(il, "The failed experiment returns to its reproductive routine.", "Неудачный эксперимент вернулся к своему репродуктивному распорядку.");
            TranslationHelper.ILTranslation(il, "Dragonfolly", "Псевдодракон", 2);
            TranslationHelper.ILTranslation(il, "Use [i:{0}] in the Hallow or Underworld Biomes", "Используйте [i:{0}] в святых землях или аду.");
            TranslationHelper.ILTranslation(il, "The Profaned Goddess vanishes in a burning blaze.", "Осквернённая богиня исчезает в горящем пламени.");
            TranslationHelper.ILTranslation(il, "Providence", "Провиденс", 2);
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Dungeon", "Используйте [i:{0}] в темнице.");
            TranslationHelper.ILTranslation(il, "The rift in time and space has moved away from your reach.", "Разлом во времени и пространстве удалился вдаль.");
            TranslationHelper.ILTranslation(il, "Ceaseless Void", "Нескончаемая пустота");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in Space", "Используйте [i:{0}] в космосе.");
            TranslationHelper.ILTranslation(il, "Storm Weaver hid itself once again within the stormfront.", "Штормовой ткач снова спрятался в грозовом фронте.");
            TranslationHelper.ILTranslation(il, "Storm Weaver", "Штормовой ткач");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Underworld", "Используйте [i:{0}] в аду.");
            TranslationHelper.ILTranslation(il, "The Devourer's assassin has finished its easy task.", "Убийца Пожирателя выполнил свою лёгкую задачу.");
            TranslationHelper.ILTranslation(il, "Signus", "Сигнус", 2);
            TranslationHelper.ILTranslation(il, "Kill 30 phantom spirits or use a [i:{0}] in the Dungeon", "Убейте 30 фантомных духов или используйте [i:{0}] в темнице.");
            TranslationHelper.ILTranslation(il, "The volatile spirits disperse throughout the depths of the dungeon.", "Нестабильные духи разбредаются по темнице.");
            TranslationHelper.ILTranslation(il, "Polterghast", "Полтергаст", 2);
            TranslationHelper.ILTranslation(il, "Defeat the Acid Rain event post-Polterghast or fish using a [i:{0}] in the Sulphurous Sea", "Одолейте событие «Кислотный дождь» после победы над Полтергастом или выловите с помощью [i:{0}] в сернистом море");
            TranslationHelper.ILTranslation(il, "The old duke disappears amidst the acidic downpour.", "Старый герцог исчезает посреди кислотного ливня.");
            TranslationHelper.ILTranslation(il, "Old Duke", "Старый герцог");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}]", "Используйте [i:{0}].", 2);
            TranslationHelper.ILTranslation(il, "The Devourer of Gods has slain everyone and feasted on their essence.", "Пожиратель богов убил всех и пировал их сущностью.");
            TranslationHelper.ILTranslation(il, "Devourer of Gods", "Пожиратель богов");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Jungle Biome", "Используйте [i:{0}] в джунглях.");
            TranslationHelper.ILTranslation(il, "Yharon found you too weak to stay near your gravestone.", "Ярон считает вас слишком слабым, чтобы оставаться с вашим надгробием.");
            TranslationHelper.ILTranslation(il, "Yharon", "Ярон", 2);
            TranslationHelper.ILTranslation(il, "Use an [i:{0}]", "Используйте [i:{0}].", 2);
            TranslationHelper.ILTranslation(il, "Please don't waste my time.", "Пожалуйста, не трать моё время.");
            TranslationHelper.ILTranslation(il, "Supreme Calamitas", "Высшая Каламитас");
            TranslationHelper.ILTranslation(il, "By using a high-tech computer", "С помощью высокотехнологичного компьютера.");
            TranslationHelper.ILTranslation(il, "An imperfection after all... what a shame.", "Несовершенство... какой позор.");
            TranslationHelper.ILTranslation(il, "Exo Mechs", "Экзо-механизмы");
            TranslationHelper.ILTranslation(il, "While in the Abyss, use an item that inflicts Chaos State", "Находясь в бездне, используйте предмет, который накладывает дебафф «Хаотичность»");
            TranslationHelper.ILTranslation(il, "Adult Eidolon Wyrm", "Фантомный змей");
        }
    }

    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class WeakReferenceSupportCensusSupport : MonoModPatcher<string>
    {
        public override MethodInfo Method => ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetCachedMethod("CensusSupport");
    
        public override string ModderMethod => nameof(Translation);
    
        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Defeat a Giant Clam after defeating the Desert Scourge", "Одолейте Гигантского моллюска после победы над Пустынным бичем");
            TranslationHelper.ILTranslation(il, "Have a [i:", "Имейте [i:");
            TranslationHelper.ILTranslation(il, "] in your inventory after defeating Skeletron", "] в вашем инвентаре после победы над Скелетроном");
            TranslationHelper.ILTranslation(il, "Defeat Cryogen", "Одолейте Криогена");
            TranslationHelper.ILTranslation(il, "Have [i:", "Имейте [i:");
            TranslationHelper.ILTranslation(il, "] in your inventory in Hardmode", "] в вашем инвентаре в Хардмоде");
            TranslationHelper.ILTranslation(il, "Defeat Supreme Calamitas", "Одолейте Высшую Каламитас");
        }
    }

    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class WeakReferenceSupportAddCalamityInvasions : MonoModPatcher<string>
    {
        public override MethodInfo Method => ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetCachedMethod("AddCalamityInvasions");
    
        public override string ModderMethod => nameof(Translation);
    
        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] or wait for the invasion to occur naturally after the Eye of Cthulhu is defeated.", "Используйте [i:{0}] или дождитесь, пока событие произойдёт естественным образом после победы над глазом Ктулху.");
            TranslationHelper.ILTranslation(il, "The mysterious creatures of the sulphuric sea descended back into the ocean.", "Таинственные существа сернистого моря спустились обратно в океан.");
            TranslationHelper.ILTranslation(il, "Acid Rain", "Кислотный дождь");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Aquatic Scourge is defeated", "Используйте [i:{0}] или, [i:{1}] или дождитесь, пока событие произойдёт естественным образом после победы над акватическим бичом.");
            TranslationHelper.ILTranslation(il, "The mysterious creatures of the sulphuric sea descended back into the deep ocean.", "Таинственные существа сернистого моря спустились обратно в глубины океана.");
            TranslationHelper.ILTranslation(il, "Acid Rain (Post-AS)", "Кислотный дождь (Пост-Аб)");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Polterghast is defeated", "Используйте [i:{0}] или, [i:{1}] или дождитесь, пока событие произойдёт естественным образом после победы над Полтергастом.");
            TranslationHelper.ILTranslation(il, "Acid Rain (Post-Polter)", "Кислотный дождь (Пост-Полтер)");
            TranslationHelper.ILTranslation(il, "The mysterious creatures of the sulphuric sea descended back into the deep ocean.", "Таинственные существа сернистого моря спустились обратно в глубины океана.", 2);
        }
    }
}