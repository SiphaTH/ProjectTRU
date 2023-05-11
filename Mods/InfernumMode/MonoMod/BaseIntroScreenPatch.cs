using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BossIntroScreens;
using InfernumMode.Core;
using ReLogic.Graphics;
using Terraria;
using Terraria.ID;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class BaseIntroScreenFontToUse : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(BaseIntroScreen).GetCachedMethod("get_FontToUse");
    
    private delegate DynamicSpriteFont FontToUseDelegate();

    public override Delegate Delegate => Translation;
    
    private DynamicSpriteFont Translation(FontToUseDelegate orig)
    {
        return CalamityRuTranslate.Instance.BossIntroScreensFont;
    }
}

public class BaseIntroScreenUpdate : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(BaseIntroScreen).GetCachedMethod(nameof(BaseIntroScreen.Update));
    
    private delegate void UpdateDelegate(BaseIntroScreen self);

    public override Delegate Delegate => Translation;
    
    private void Translation(UpdateDelegate orig, BaseIntroScreen self)
    {
        if (Main.netMode == NetmodeID.Server)
            return;

        if (!self.ShouldBeActive() || !global::InfernumMode.InfernumMode.CanUseCustomAIs || !InfernumConfig.Instance.BossIntroductionAnimationsAreAllowed)
        {
            self.AnimationTimer = 0;
            self.HasPlayedMainSound = false;
            self.CachedText = string.Empty;
            return;
        }

        if (string.IsNullOrEmpty(self.CachedText))
        {
            self.CachedText = self.TextToDisplay switch
            {
                "Monarch of the Gelatinous\nKing Slime" => "МОНАРХ ЖЕЛАТИНА\nКОРОЛЬ СЛИЗНЕЙ",
                "Terror of the Seas\nDuke Fishron" => "УЖАС МОРЕЙ\nГЕРЦОГ РЫБРОН",
                "Primeval Warden\nThe Eidolon Wyrm" => "ДРЕВНИЙ ХРАНИТЕЛЬ\nЭЙДОЛОНСКИЙ ЗМЕЙ",
                "Forgotten Deity\nAnahita" => "ЗАБЫТОЕ БОЖЕСТВО\nАНАХИТА",
                "Sulphuric Serpent\nThe Aquatic Scourge" => "СЕРНИСТЫЙ ЗМЕЙ\nАКВАТИЧЕСКИЙ БИЧ",
                "The Supreme Hunters\nArtemis and Apollo" => "ВЕРХОВНЫЕ ОХОТНИКИ\nАРТЕМИДА И АПОЛЛОН",
                "The Infected Stomper\nAstrum Aureus" => "ЗАРАЖЁННЫЙ ДАВИТЕЛЬ\nАСТРУМ АРЕУС",
                "The Star Weaver\nAstrum Deus" => "ЗВЁЗДНЫЙ ТКАЧ\nАСТРУМ ДЕУС",
                "Argus\nThe Bereft Vassal" => "АРГУС\nОБЕЗДОЛЕННЫЙ ВАССАЛ",
                "Mother of Wyverns\nBetsy" => "МАТЬ ВИВЕРН\nБЭТСИ",
                "Eldritch Mind\nThe Brain of Cthulhu" => "ЖУТКИЙ РАЗУМ\nМОЗГ КТУЛХУ",
                "Scarred Numen\nThe Brimstone Elemental" => "ИЗРАНЕННОЕ БОЖЕСТВО\nСЕРНЫЙ ЭЛЕМЕНТАЛЬ",
                "False Witch\nCalamitas' Clone" => "ЛОЖНАЯ ВЕДЬМА\nКЛОН КАЛАМИТАС",
                "False Witch\nCalamitas' Shadow" => "ЛОЖНАЯ ВЕДЬМА\nТЕНЬ КАЛАМИТАС",
                "The Never-Ending\nCeaseless Void" => "БЕСКОНЕЧНАЯ\nНЕСКОНЧАЕМАЯ ПУСТОТА",
                "The Reanimated Carcass\nCrabulon" => "ОЖИВШАЯ ОБОЛОЧКА\nКРАБУЛОН",
                "The Unstable Prison\nCryogen" => "НЕСТАБИЛЬНАЯ ТЮРЬМА\nКРИОГЕН",
                "Ancient Doomsayer\nThe Lunatic Cultist" => "ДРЕВНИЙ ВЕСТНИК РОКА\nКУЛЬТИСТ-ЛУНАТИК",
                "Winter Beast\nThe Deerclops" => "ЗИМНЕЕ ЧУДИЩЕ\nЦИКЛОП-ОЛЕНЬ",
                "Dried Glutton\nThe Desert Scourge" => "ИССУШЁННЫЙ ОБЖОРА\nПУСТЫННЫЙ БИЧ",
                "World Excavator\nThe Destroyer" => "РАСКОПЩИК МИРА\nУНИЧТОЖИТЕЛЬ",
                "The Conceited\nDevourer of Gods" => "ВЫСОКОМЕРНЫЙ\nПОЖИРАТЕЛЬ БОГОВ",
                "The Cosmic Engineer\nDraedon" => "КОСМИЧЕСКИЙ ИНЖЕНЕР\nДРЭЙДОН",
                "False Offspring\nThe Dragonfolly" => "ЛОЖНЫЙ ПОТОМОК\nПСЕВДОДРАКОН",
                "Nightmare of the Blood Moon\nDreadnautilus" => "КОШМАР КРОВАВОЙ ЛУНЫ\nДРЕДНАУТИЛУС",
                "Terror of the Corruption\nThe Eater of Worlds" => "ГРОЗА ИСКАЖЕНИЯ\nПОЖИРАТЕЛЬ МИРОВ",
                "Prismatic Fae\nThe Empress of Light" => "ПРИЗМАТИЧЕСКАЯ ФЕЯ\nИМПЕРАТРИЦА СВЕТА",
                "Demonic Seer\nThe Eye of Cthulhu" => "ДЕМОНИЧЕСКИЙ ВЗОР\nГЛАЗ КТУЛХУ",
                "Taurus\nThe Great Sand Shark" => "ТАУРУС\nВЕЛИКАЯ ПЕСЧАНАЯ АКУЛА",
                "Collective Growth\nThe Hive Mind" => "КОЛЛЕКТИВНЫЙ РОСТ\nРАЗУМ УЛЬЯ",
                "Timeworn Beast\nThe Leviathan" => "СТАРЫЙ ЗВЕРЬ\nЛЕВИАФАН",
                "Eldritch Remains\nThe Moon Lord" => "ЖУТКИЕ ОСТАНКИ\nЛУННЫЙ ЛОРД",
                "Biomechanical Colossus\nThe Plaguebringer Goliath" => "БИОМЕХАНИЧЕСКИЙ КОЛОСС\nРАЗНОСЧИЦА ЧУМЫ, ГОЛИАФ",
                "Bloodied Parasites\nThe Perforators" => "КРОВАВЫЕ ПАРАЗИТЫ\nПЕРФОРАТОРЫ",
                "The Overgrowth\nPlantera" => "РАСТЕНИЕ-ПЕРЕРОСТОК\nПЛАНТЕРА",
                "Wrathful Coalescence\nThe Polterghast" => "ГНЕВНОЕ СЛИЯНИЕ\nПОЛТЕРГАСТ",
                "Disciples of Purity\nThe Profaned Guardians" => "АПОСТОЛЫ ЧИСТОТЫ\nОСКВЕРНЁННЫЕ СТРАЖИ",
                "Cleansed Site\nThe Profaned Garden" => "ОЧИЩЕННЫЙ УЧАСТОК\nОСКВЕРНЁННЫЙ САД",
                "Hive Matriarch\nQueen Bee" => "МАТРИАРХ ПЧЕЛИНОГО УЛЬЯ\nКОРОЛЕВА ПЧЁЛ",
                "Hallowed Mass\nThe Queen Slime" => "ОСВЯЩЁННАЯ МАССА\nКОРОЛЕВА СЛИЗНЕЙ",
                "The Fortress of Flesh\nRavager" => "ТВЕРДЫНЯ ПЛОТИ\nРАЗРУШИТЕЛЬ",
                "The Brimstone Witch\nCalamitas" => "СЕРНАЯ ВЕДЬМА\nКАЛАМИТАС",
                "The Fathomless Assassin\nSignus" => "НЕПОСТИЖИМЫЙ УБИЙЦА\nСИГНУС",
                "The Old Man's Curse\nSkeletron" => "ПРОКЛЯТИЕ СТАРИКА\nСКЕЛЕТРОН",
                "Contraption of Dread\nSkeletron Prime" => "УСТРОЙСТВО УЖАСА\nСКЕЛЕТРОН ПРАЙМ",
                "Primordial Formation\nThe Slime God" => "ИЗВЕЧНОЕ ОБРАЗОВАНИЕ\nБОГ СЛИЗНЕЙ",
                "Atmospheric Predator\nThe Storm Weaver" => "АТМОСФЕРНЫЙ ХИЩНИК\nШТОРМОВОЙ ТКАЧ",
                "You found the Terminus!" => "ВЫ НАШЛИ ТЕРМИНУС!",
                "The Perfect Annihilator\nThanatos" => "СОВЕРШЕННЫЙ АННИГИЛЯТОР\nТАНАТОС",
                "Mechanical Observers\nThe Twins" => "МЕХАНИЧЕСКИЕ НАБЛЮДАТЕЛИ\nБЛИЗНЕЦЫ",
                "Hungering Conglomeration\nThe Wall of Flesh" => "ВЕЧНОГОЛОДНАЯ ВЛАДЫКА\nСТЕНА ПЛОТИ",
                "Prediction Game Master\nAres" => "МАСТЕР ПРОГНОЗОВ\nАРЕС",
                "The Ultimate War Machine\nAres" => "АБСОЛЮТНАЯ МАШИНА ВОЙНЫ\nАРЕС",
                "NUMBER ! SALSMAN\n[Circa 1997]" => "ПРОДАВЕЦ НОМЕР !\n[С 1997 года]",
                "The Ancient Idol\nGolem" => "ДРЕВНИЙ ИДОЛ\nГОЛЕМ",
                "Speed Demon\nThe Old Duke" => "ДЕМОН СКОРОСТИ\nСТАРЫЙ ГЕРЦОГ",
                "Sulphuric Terror\nThe Old Duke" => "СЕРНИСТЫЙ УЖАС\nСТАРЫЙ ГЕРЦОГ",
                "The Blaze of Purity\nProvidence" => "ПЛАМЯ ЧИСТОТЫ\nПРОВИДЕНС",
                "The Blaze of Absolution\nProvidence" => "ПЛАМЯ ИСКУПЛЕНИЯ\nПРОВИДЕНС",
                "Grand\nYharon" => "ВЕЛИКИЙ\nЯРОН",
                "Unwavering Guardian\nYharon" => "НЕПОКОРНЫЙ СТРАЖ\nЯРОН",
                _ => self.CachedText
            };
        }

        if (self.AnimationTimer < self.AnimationTime)
            self.AnimationTimer++;
    }
}