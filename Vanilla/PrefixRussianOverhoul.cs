using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla
{
    public class PrefixRussianOverhoul : GlobalItem
    {
        //Мужской, Женский, Средний, Множественный
        private static string[] _prefixAdept = {"Искусный ", "Искусная ", "Искусное ", "Искусные "};
        private static string[] _prefixAgile = {"Проворный ", "Проворная ", "Проворное ", "Проворные "};
        private static string[] _prefixAngry = {"Яростный ", "Яростная ", "Яростное ", "Яростные "};
        private static string[] _prefixAnnoying = {"Надоедливый ", "Надоедливая ", "Надоедливое ", "Надоедливые "};
        private static string[] _prefixArcane = {"Таинственный ", "Таинственная ", "Таинственное ", "Таинственные "};
        private static string[] _prefixArmored = {"Укреплённый ", "Укреплённая ", "Укреплённое ", "Укреплённые "};
        private static string[] _prefixAwful = {"Отвратительный ", "Отвратительная ", "Отвратительное ", "Отвратительные "};
        private static string[] _prefixAwkward = {"Неудобный ", "Неудобная ", "Неудобное ", "Неудобные "};
        private static string[] _prefixBrisk = {"Юркий ", "Юркая ", "Юркое ", "Юркие "};
        private static string[] _prefixBroken = {"Сломанный ", "Сломанная ", "Сломанное ", "Сломанные "};
        private static string[] _prefixBulky = {"Громоздкий ", "Громоздкая ", "Громоздкое ", "Громоздкие "};
        private static string[] _prefixCelestial = {"Небесный ", "Небесная ", "Небесное ", "Небесные "};
        private static string[] _prefixDamaged = {"Повреждённый ", "Повреждённая ", "Повреждённое ", "Повреждённые "};
        private static string[] _prefixDangerous = {"Опасный ", "Опасная ", "Опасное ", "Опасные "};
        private static string[] _prefixDeadly = {"Смертоносный ", "Смертоносная ", "Смертоносное ", "Смертоносные "};
        private static string[] _prefixDeadly2 = {"Смертоносный ", "Смертоносная ", "Смертоносное ", "Смертоносные "};
        private static string[] _prefixDemonic = {"Демонический ", "Демоническая ", "Демоническое ", "Демонические "};
        private static string[] _prefixDeranged = {"Безумный ", "Безумная ", "Безумное ", "Безумные "};
        private static string[] _prefixDull = {"Притуплённый ", "Притуплённая ", "Притуплённое ", "Притуплённые "};
        private static string[] _prefixFleeting = {"Стремительный ", "Стремительная ", "Стремительное ", "Стремительные "};
        private static string[] _prefixForceful = {"Неистовый ", "Неистовая ", "Неистовое ", "Неистовые "};
        private static string[] _prefixFrenzying = {"Буйный ", "Буйная ", "Буйное ", "Буйные "};
        private static string[] _prefixFurious = {"Яростный ", "Яростная ", "Яростное ", "Яростные "};
        private static string[] _prefixGodly = {"Праведный ", "Праведная ", "Праведное ", "Праведные "};
        private static string[] _prefixGuarding = {"Охранный ", "Охранная ", "Охранное ", "Охранные "};
        private static string[] _prefixHard = {"Твёрдый ", "Твёрдая ", "Твёрдое ", "Твёрдые "};
        private static string[] _prefixHasty = {"Стремительный ", "Стремительная ", "Стремительное ", "Стремительные "};
        private static string[] _prefixHasty2 = {"Поспешный ", "Поспешная ", "Поспешное ", "Поспешные "};
        private static string[] _prefixHeavy = {"Тяжёлый ", "Тяжёлая ", "Тяжёлое ", "Тяжёлые "};
        private static string[] _prefixHurtful = {"Пагубный ", "Пагубная ", "Пагубное ", "Пагубные "};
        private static string[] _prefixIgnorant = {"Никчёмный ", "Никчёмная ", "Никчёмное ", "Никчёмные "};
        private static string[] _prefixInept = {"Непригодный ", "Непригодная ", "Непригодное ", "Непригодные "};
        private static string[] _prefixIntense = {"Мощный ", "Мощная ", "Мощное ", "Мощные "};
        private static string[] _prefixIntimidating = {"Устрашающий ", "Устрашающая ", "Устрашающее ", "Устрашающие "};
        private static string[] _prefixIntrepid = {"Отважный ", "Отважная ", "Отважное ", "Отважные "};
        private static string[] _prefixJagged = {"Зазубренный ", "Зазубренная ", "Зазубренное ", "Зазубренные "};
        private static string[] _prefixKeen = {"Заточенный ", "Заточенная ", "Заточенное ", "Заточенные "};
        private static string[] _prefixLarge = {"Большой ", "Большая ", "Большое ", "Большие "};
        private static string[] _prefixLazy = {"Лентяйский ", "Лентяйская ", "Лентяйское ", "Лентяйские "};
        private static string[] _prefixLegendary = {"Легендарный ", "Легендарная ", "Легендарное ", "Легендарные "};
        private static string[] _prefixLethargic = {"Апатичный ", "Апатичная ", "Апатичное ", "Апатичные "};
        private static string[] _prefixLight = {"Лёгкий ", "Лёгкая ", "Лёгкое ", "Лёгкие "};
        private static string[] _prefixLucky = {"Везучий ", "Везучая ", "Везучее ", "Везучие "};
        private static string[] _prefixManic = {"Маниакальный ", "Маниакальная ", "Маниакальное ", "Маниакальные "};
        private static string[] _prefixMassive = {"Массивный ", "Массивная ", "Массивное ", "Массивные "};
        private static string[] _prefixMasterful = {"Умелый ", "Умелая ", "Умелое ", "Умелые "};
        private static string[] _prefixMenacing = {"Грозный ", "Грозная ", "Грозное ", "Грозные "};
        private static string[] _prefixMurderous = {"Убийственный ", "Убийственная ", "Убийственное ", "Убийственные "};
        private static string[] _prefixMystic = {"Мистический ", "Мистическая ", "Мистическое ", "Мистические "};
        private static string[] _prefixMythical = {"Загадочный ", "Загадочная ", "Загадочное ", "Загадочные "};
        private static string[] _prefixNasty = {"Пакостный ", "Пакостная ", "Пакостное ", "Пакостные "};
        private static string[] _prefixNimble = {"Шустрый ", "Шустрая ", "Шустрое ", "Шустрые "};
        private static string[] _prefixPointy = {"Заострённый ", "Заострённая ", "Заострённое ", "Заострённые "};
        private static string[] _prefixPowerful = {"Мощный ", "Мощная ", "Мощное ", "Мощные "};
        private static string[] _prefixPrecise = {"Точный ", "Точная ", "Точное ", "Точные "};
        private static string[] _prefixQuick = {"Быстрый ", "Быстрая ", "Быстрое ", "Быстрые "};
        private static string[] _prefixQuick2 = {"Быстрый ", "Быстрая ", "Быстрое ", "Быстрые "};
        private static string[] _prefixRapid = {"Скоростной ", "Скоростная ", "Скоростное ", "Скоростные "};
        private static string[] _prefixRash = {"Безудержный ", "Безудержная ", "Безудержное ", "Безудержные "};
        private static string[] _prefixRuthless = {"Безжалостный ", "Безжалостная ", "Безжалостное ", "Безжалостные "};
        private static string[] _prefixSavage = {"Кровожадный ", "Кровожадная ", "Кровожадное ", "Кровожадные "};
        private static string[] _prefixShameful = {"Позорный ", "Позорная ", "Позорное ", "Позорные "};
        private static string[] _prefixSharp = {"Острый ", "Острая ", "Острое ", "Острые "};
        private static string[] _prefixShoddy = {"Некачественный ", "Некачественная ", "Некачественное ", "Некачественные "};
        private static string[] _prefixSighted = {"Меткий ", "Меткая ", "Меткое ", "Меткие "};
        private static string[] _prefixSlow = {"Медлительный ", "Медлительная ", "Медлительное ", "Медлительные "};
        private static string[] _prefixSluggish = {"Вялый ", "Вялая ", "Вялое ", "Вялые "};
        private static string[] _prefixSmall = {"Маленький ", "Маленькая ", "Маленькое ", "Маленькие "};
        private static string[] _prefixSpiked = {"Шипастый ", "Шипастая ", "Шипастое ", "Шипастые "};
        private static string[] _prefixStaunch = {"Надёжный ", "Надёжная ", "Надёжное ", "Надёжные "};
        private static string[] _prefixStrong = {"Усиленный ", "Усиленная ", "Усиленное ", "Усиленные "};
        private static string[] _prefixSuperior = {"Превосходный ", "Превосходная ", "Превосходное ", "Превосходные "};
        private static string[] _prefixTaboo = {"Запретный ", "Запретная ", "Запретное ", "Запретные "};
        private static string[] _prefixTerrible = {"Ужасный ", "Ужасная ", "Ужасное ", "Ужасные "};
        private static string[] _prefixTiny = {"Крошечный ", "Крошечная ", "Крошечное ", "Крошечные "};
        private static string[] _prefixUnhappy = {"Неудачный ", "Неудачная ", "Неудачное ", "Неудачные "};
        private static string[] _prefixUnpleasant = {"Неприятный ", "Неприятная ", "Неприятное ", "Неприятные "};
        private static string[] _prefixUnreal = {"Нереальный ", "Нереальная ", "Нереальное", "Нереальные "};
        private static string[] _prefixViolent = {"Жестокий ", "Жестокая ", "Жестокое ", "Жестокие "};
        private static string[] _prefixWarding = {"Оберегающий ", "Оберегающая ", "Оберегающее ", "Оберегающие "};
        private static string[] _prefixWeak = {"Слабый ", "Слабая ", "Слабое ", "Слабые "};
        private static string[] _prefixWild = {"Дикий ", "Дикая ", "Дикое ", "Дикие "};
        private static string[] _prefixZealous = {"Пылкий ", "Пылкая ", "Пылкое ", "Пылкие "};

        private static List<int> _womanList = new List<int>
        {
            ItemID.BoneGlove,
            ItemID.LuckyHorseshoe,
            ItemID.Ruler,
            ItemID.BlizzardinaBottle,
            ItemID.HighTestFishingLine,
            ItemID.AnglerEarring,
            ItemID.FrogLeg,
            ItemID.LaserRuler,
            ItemID.BalloonPufferfish,
            ItemID.RedString,
            ItemID.OrangeString,
            ItemID.YellowString,
            ItemID.LimeString,
            ItemID.GreenString,
            ItemID.TealString,
            ItemID.CyanString,
            ItemID.SkyBlueString,
            ItemID.BlueString,
            ItemID.PurpleString,
            ItemID.VioletString,
            ItemID.PinkString,
            ItemID.BrownString,
            ItemID.WhiteString,
            ItemID.RainbowString,
            ItemID.BlackString,
            ItemID.SandstorminaBottle,
            ItemID.FartinaJar,
            ItemID.HandWarmer,
            ItemID.Toolbox,
            ItemID.ObsidianRose,
            ItemID.PortableCementMixer,
            ItemID.GoblinTech,
            ItemID.MechanicalLens,
            ItemID.ObsidianHorseshoe,
            ItemID.MoonCharm,
            ItemID.SorcererEmblem,
            ItemID.WarriorEmblem,
            ItemID.RangerEmblem,
            ItemID.TitanGlove,
            ItemID.Blindfold,
            ItemID.TrifoldMap,
            ItemID.SandstorminaBalloon,
            ItemID.BlizzardinaBalloon,
            ItemID.FartInABalloon,
            ItemID.SummonerEmblem,
            ItemID.YoYoGlove,
            ItemID.NeptunesShell,
            ItemID.DiscountCard,
            ItemID.LuckyCoin,
            ItemID.PowerGlove,
            ItemID.CountercurseMantra,
            ItemID.AvengerEmblem,
            ItemID.Hoverboard,
            ItemID.CelestialEmblem,
            ItemID.MoonShell,
            ItemID.StarVeil,
            ItemID.MechanicalGlove,
            ItemID.DestroyerEmblem,
            ItemID.FireGauntlet,
            ItemID.BundleofBalloons,
            ItemID.CelestialShell,
            ItemID.BejeweledValkyrieWing,
            ItemID.LeinforsWings,
            ItemID.WingsNebula,
            ItemID.CobaltChainsaw,
            ItemID.MythrilChainsaw,
            ItemID.AdamantiteChainsaw,
            ItemID.FleshGrinder,
            ItemID.BloodLustCluster,
            ItemID.PalladiumChainsaw,
            ItemID.OrichalcumChainsaw,
            ItemID.TitaniumChainsaw,
            ItemID.ChlorophyteChainsaw,
            ItemID.SawtoothShark,
            ItemID.ButchersChainsaw,
            ItemID.CactusPickaxe,
            ItemID.TinPickaxe,
            ItemID.CopperPickaxe,
            ItemID.IronPickaxe,
            ItemID.LeadPickaxe,
            ItemID.SilverPickaxe,
            ItemID.BonePickaxe,
            ItemID.TungstenPickaxe,
            ItemID.CnadyCanePickaxe,
            ItemID.GoldPickaxe,
            ItemID.PlatinumPickaxe,
            ItemID.NightmarePickaxe,
            ItemID.DeathbringerPickaxe,
            ItemID.MoltenPickaxe,
            ItemID.ReaverShark,
            ItemID.CobaltPickaxe,
            ItemID.PalladiumPickaxe,
            ItemID.MythrilPickaxe,
            ItemID.OrichalcumPickaxe,
            ItemID.AdamantitePickaxe,
            ItemID.TitaniumPickaxe,
            ItemID.ChlorophytePickaxe,
            ItemID.SpectrePickaxe,
            ItemID.ShroomiteDiggingClaw,
            ItemID.VortexPickaxe,
            ItemID.NebulaPickaxe,
            ItemID.SolarFlarePickaxe,
            ItemID.StardustPickaxe,
            ItemID.Minishark,
            ItemID.Blowpipe,
            ItemID.Sickle,
            ItemID.Vilethorn,
            ItemID.SnowballCannon,
            ItemID.DD2LightningAuraT2Popper,
            ItemID.ZombieArm,
            ItemID.BladedGlove,
            ItemID.TheRottedFork,
            ItemID.TheMeatball,
            ItemID.Katana,
            ItemID.TaxCollectorsStickOfDoom,
            ItemID.CrimsonYoyo,
            ItemID.SpaceGun,
            ItemID.Muramasa,
            ItemID.ClockworkAssaultRifle,
            ItemID.Swordfish,
            ItemID.JungleYoyo,
            ItemID.DyeTradersScimitar,
            ItemID.WaspGun,
            ItemID.Starfury,
            ItemID.Valor,
            ItemID.BlueMoon,
            ItemID.PurpleClubberfish,
            ItemID.BookStaff,
            ItemID.Megashark,
            ItemID.MagicMissile,
            ItemID.LaserRifle,
            ItemID.CobaltNaginata,
            ItemID.BookofSkulls,
            ItemID.Sandgun,
            ItemID.MoltenFury,
            ItemID.MagicalHarp,
            ItemID.PalladiumPike,
            ItemID.Sunfury,
            ItemID.DemonScythe,
            ItemID.MythrilHalberd,
            ItemID.SlapHand,
            ItemID.OrichalcumHalberd,
            ItemID.AdamantiteGlaive,
            ItemID.PiranhaGun,
            ItemID.Flamelash,
            ItemID.Marrow,
            ItemID.KOCannon,
            ItemID.ElectrosphereLauncher,
            ItemID.ShadowFlameHexDoll,
            ItemID.NightsEdge,
            ItemID.IceSickle,
            ItemID.DD2FlameburstTowerT2Popper,
            ItemID.CandyCornRifle,
            ItemID.RainbowGun,
            ItemID.Xenopopper,
            ItemID.MedusaHead,
            ItemID.MonkStaffT2,
            ItemID.ToxicFlask,
            ItemID.ChlorophyteSaber,
            ItemID.MagnetSphere,
            ItemID.Cutlass,
            ItemID.Frostbrand,
            ItemID.ChargedBlasterCannon,
            ItemID.VortexBeater,
            ItemID.DartRifle,
            ItemID.StarCannon,
            ItemID.DeathSickle,
            ItemID.DD2ExplosiveTrapT2Popper,
            ItemID.DaoofPow,
            ItemID.ScourgeoftheCorruptor,
            ItemID.ApprenticeStaffT3,
            ItemID.SnowmanCannon,
            ItemID.DD2BallistraTowerT2Popper,
            ItemID.ObsidianSwordfish,
            ItemID.BubbleGun,
            ItemID.MonkStaffT3,
            ItemID.TrueNightsEdge,
            ItemID.LastPrism,
            ItemID.LunarFlareBook,
            ItemID.StarWrath,
            ItemID.DayBreak,
            
        };
        
        private static List<int> _среднийList = new List<int>
        {
            ItemID.CloudinaBottle,
            ItemID.PanicNecklace,
            ItemID.WeatherRadio,
            ItemID.CordageGuide,
            ItemID.FishermansGuide,
            ItemID.TsunamiInABottle,
            ItemID.SharkToothNecklace,
            ItemID.JellyfishNecklace,
            ItemID.SweetheartNecklace,
            ItemID.PocketMirror,
            ItemID.DivingGear,
            ItemID.CloudinaBalloon,
            ItemID.ArmorBracing,
            ItemID.GoldRing,
            ItemID.CoinRing,
            ItemID.CharmofMyths,
            ItemID.GreedyRing,
            ItemID.PygmyNecklace,
            ItemID.Yoraiz0rWings,
            ItemID.Spear,
            ItemID.WoodYoyo,
            ItemID.Rally,
            ItemID.AntlionClaw,
            ItemID.RedRyder,
            ItemID.Blowgun,
            ItemID.DarkLance,
            ItemID.Uzi,
            ItemID.FalconBlade,
            ItemID.HelFire,
            ItemID.DD2SquireDemonSword,
            ItemID.DD2BetsyBow,
            ItemID.MushroomSpear,
            ItemID.Tsunami,
            ItemID.FireworksLauncher,
            ItemID.ValkyrieYoyo,
            ItemID.SpiritFlame,
            ItemID.SolarEruption,
            ItemID.NebulaBlaze,
            ItemID.SniperRifle,
            
        };
        
        private static List<int> _множественныйList = new List<int>
        {
            ItemID.BrainOfConfusion,
            ItemID.CopperWatch,
            ItemID.SilverWatch,
            ItemID.TinWatch,
            ItemID.TungstenWatch,
            ItemID.GoldWatch,
            ItemID.HermesBoots,
            ItemID.Flipper,
            ItemID.Shackle,
            ItemID.PlatinumWatch,
            ItemID.IceSkates,
            ItemID.ClimbingClaws,
            ItemID.ShoeSpikes,
            ItemID.FlurryBoots,
            ItemID.SailfishBoots,
            ItemID.BrainOfConfusion,
            ItemID.MagicCuffs,
            ItemID.RocketBoots,
            ItemID.FeralClaws,
            ItemID.SpectreBoots,
            ItemID.WaterWalkingBoots,
            ItemID.FastClock,
            ItemID.Vitamins,
            ItemID.ObsidianWaterWalkingBoots,
            ItemID.FinWings,
            ItemID.DemonWings,
            ItemID.AngelWings,
            ItemID.ButterflyWings,
            ItemID.FairyWings,
            ItemID.HarpyWings,
            ItemID.BoneWings,
            ItemID.FlameWings,
            ItemID.FrozenWings,
            ItemID.LightningBoots,
            ItemID.LeafWings,
            ItemID.BatWings,
            ItemID.BeeWings,
            ItemID.FestiveWings,
            ItemID.CelestialCuffs,
            ItemID.PutridScent,
            ItemID.LavaWaders,
            ItemID.Tabi,
            ItemID.TatteredFairyWings,
            ItemID.SpookyWings,
            ItemID.FrostsparkBoots,
            ItemID.BeetleWings,
            ItemID.FlowerBoots,
            ItemID.GhostWings,
            ItemID.SteampunkWings,
            ItemID.MasterNinjaGear,
            ItemID.FishronWings,
            ItemID.MothronWings,
            ItemID.BetsyWings,
            ItemID.RedsWings,
            ItemID.DTownsWings,
            ItemID.WillsWings,
            ItemID.CrownosWings,
            ItemID.CenxsWings,
            ItemID.JimsWings,
            ItemID.SkiphsWings,
            ItemID.LokisWings,
            ItemID.ArkhalisWings,
            ItemID.WingsSolar,
            ItemID.WingsStardust,
            ItemID.StylistKilLaKillScissorsIWish,
            ItemID.VampireKnives,
            ItemID.ChainGuillotines,
            ItemID.FetidBaghnakhs,
            
        };

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Translation.IsRussianLanguage && CalamityRuTranslate.Config.NewVanillaTranslation)
            {
                foreach (var tooltip in tooltips.Where(tooltip => tooltip.Name == "ItemName" && item.prefix > 0))
                {
                    if (_prefixAdept[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixAdept, item.type, item);
                    }
                    if (_prefixAgile[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixAgile, item.type, item);
                    }
                    if (_prefixAngry[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixAngry, item.type, item);
                    }
                    if (_prefixAnnoying[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixAnnoying, item.type, item);
                    }
                    if (_prefixArcane[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixArcane, item.type, item);
                    }
                    if (_prefixArmored[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixArmored, item.type, item);
                    }
                    if (_prefixAwful[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixAwful, item.type, item);
                    }
                    if (_prefixAwkward[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixAwkward, item.type, item);
                    }
                    if (_prefixBrisk[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixBrisk, item.type, item);
                    }
                    if (_prefixBroken[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixBroken, item.type, item);
                    }
                    if (_prefixBulky[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixBulky, item.type, item);
                    }
                    if (_prefixCelestial[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixCelestial, item.type, item);
                    }
                    if (_prefixDamaged[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixDamaged, item.type, item);
                    }
                    if (_prefixDangerous[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixDangerous, item.type, item);
                    }
                    if (_prefixDeadly[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixDeadly, item.type, item);
                    }
                    if (_prefixDeadly2[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixDeadly2, item.type, item);
                    }
                    if (_prefixDemonic[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixDemonic, item.type, item);
                    }
                    if (_prefixDeranged[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixDeranged, item.type, item);
                    }
                    if (_prefixDull[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixDull, item.type, item);
                    }
                    if (_prefixFleeting[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixFleeting, item.type, item);
                    }
                    if (_prefixForceful[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixForceful, item.type, item);
                    }
                    if (_prefixFrenzying[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixFrenzying, item.type, item);
                    }
                    if (_prefixFurious[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixFurious, item.type, item);
                    }
                    if (_prefixGodly[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixGodly, item.type, item);
                    }
                    if (_prefixGuarding[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixGuarding, item.type, item);
                    }
                    if (_prefixHard[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixHard, item.type, item);
                    }
                    if (_prefixHasty[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixHasty, item.type, item);
                    }
                    if (_prefixHasty2[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixHasty2, item.type, item);
                    }
                    if (_prefixHeavy[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixHeavy, item.type, item);
                    }
                    if (_prefixHurtful[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixHurtful, item.type, item);
                    }
                    if (_prefixIgnorant[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixIgnorant, item.type, item);
                    }
                    if (_prefixInept[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixInept, item.type, item);
                    }
                    if (_prefixIntense[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixIntense, item.type, item);
                    }
                    if (_prefixIntimidating[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixIntimidating, item.type, item);
                    }
                    if (_prefixIntrepid[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixIntrepid, item.type, item);
                    }
                    if (_prefixJagged[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixJagged, item.type, item);
                    }
                    if (_prefixKeen[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixKeen, item.type, item);
                    }
                    if (_prefixLarge[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixLarge, item.type, item);
                    }
                    if (_prefixLazy[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixLazy, item.type, item);
                    }
                    if (_prefixLegendary[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixLegendary, item.type, item);
                    }
                    if (_prefixLethargic[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixLethargic, item.type, item);
                    }
                    if (_prefixLight[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixLight, item.type, item);
                    }
                    if (_prefixLucky[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixLucky, item.type, item);
                    }
                    if (_prefixManic[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixManic, item.type, item);
                    }
                    if (_prefixMassive[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixMassive, item.type, item);
                    }
                    if (_prefixMasterful[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixMasterful, item.type, item);
                    }
                    if (_prefixMenacing[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixMenacing, item.type, item);
                    }
                    if (_prefixMurderous[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixMurderous, item.type, item);
                    }
                    if (_prefixMystic[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixMystic, item.type, item);
                    }
                    if (_prefixMythical[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixMythical, item.type, item);
                    }
                    if (_prefixNasty[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixNasty, item.type, item);
                    }
                    if (_prefixNimble[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixNimble, item.type, item);
                    }
                    if (_prefixPointy[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixPointy, item.type, item);
                    }
                    if (_prefixPowerful[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixPowerful, item.type, item);
                    }
                    if (_prefixPrecise[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixPrecise, item.type, item);
                    }
                    if (_prefixQuick[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixQuick, item.type, item);
                    }
                    if (_prefixQuick2[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixQuick2, item.type, item);
                    }
                    if (_prefixRapid[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixRapid, item.type, item);
                    }
                    if (_prefixRash[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixRash, item.type, item);
                    }
                    if (_prefixRuthless[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixRuthless, item.type, item);
                    }
                    if (_prefixSavage[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixSavage, item.type, item);
                    }
                    if (_prefixShameful[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixShameful, item.type, item);
                    }
                    if (_prefixSharp[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixSharp, item.type, item);
                    }
                    if (_prefixShoddy[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixShoddy, item.type, item);
                    }
                    if (_prefixSighted[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixSighted, item.type, item);
                    }
                    if (_prefixSlow[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixSlow, item.type, item);
                    }
                    if (_prefixSluggish[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixSluggish, item.type, item);
                    }
                    if (_prefixSmall[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixSmall, item.type, item);
                    }
                    if (_prefixSpiked[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixSpiked, item.type, item);
                    }
                    if (_prefixStaunch[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixStaunch, item.type, item);
                    }
                    if (_prefixStrong[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixStrong, item.type, item);
                    }
                    if (_prefixSuperior[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixSuperior, item.type, item);
                    }
                    if (_prefixTaboo[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixTaboo, item.type, item);
                    }
                    if (_prefixTerrible[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixTerrible, item.type, item);
                    }
                    if (_prefixTiny[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixTiny, item.type, item);
                    }
                    if (_prefixUnhappy[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixUnhappy, item.type, item);
                    }
                    if (_prefixUnpleasant[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixUnpleasant, item.type, item);
                    }
                    if (_prefixUnreal[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixUnreal, item.type, item);
                    }
                    if (_prefixViolent[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixViolent, item.type, item);
                    }
                    if (_prefixWarding[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixWarding, item.type, item);
                    }
                    if (_prefixWeak[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixWeak, item.type, item);
                    }
                    if (_prefixWild[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixWild, item.type, item);
                    }
                    if (_prefixZealous[0] == Regex.Split(tooltip.text, item.Name)[0])
                    {
                        tooltip.text = GetGenderedPrefix(_prefixZealous, item.type, item);
                    }
                }
            }
        }

        private static string GetGenderedPrefix(string[] prefix, int id, Item item)
        {
            if (_womanList.Contains(id))
            {
                return prefix[1] + item.Name.ToLower();
            }

            if (_среднийList.Contains(id))
            {
                return prefix[2] + item.Name.ToLower();
            }
            
            if (_множественныйList.Contains(id))
            {
                return prefix[3] + item.Name.ToLower();
            }

            return prefix[0] + item.Name.ToLower();
        }
    }
}