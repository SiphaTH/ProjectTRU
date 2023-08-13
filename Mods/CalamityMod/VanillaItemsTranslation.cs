using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class VanillaItemsTranslation : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "Knockback", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.CobaltSword => tooltip.Text.Replace("Decreases enemy defense by 25% on hit", "Снижает защиту врага на 25% при ударе"),
                ItemID.CobaltNaginata => tooltip.Text.Replace("Decreases enemy defense by 25% on hit", "Снижает защиту врага на 25% при ударе"),
                ItemID.PalladiumSword => tooltip.Text.Replace("Increases life regen on hit", "Увеличивает регенерацию здоровья при ударе"),
                ItemID.PalladiumPike => tooltip.Text.Replace("Increases life regen on hit", "Увеличивает регенерацию здоровья при ударе"),
                ItemID.MythrilSword => tooltip.Text.Replace("Decreases enemy contact damage by 10% on hit", "Снижает контактный урон врага на 10% при ударе"),
                ItemID.MythrilHalberd => tooltip.Text.Replace("Decreases enemy contact damage by 10% on hit", "Снижает контактный урон врага на 10% при ударе"),
                ItemID.OrichalcumSword => tooltip.Text.Replace("Increases how frequently the Orichalcum set bonus triggers on hit", "При нанесении удара увеличивает частоту срабатывания бонуса орихалкового комплекта"),
                ItemID.OrichalcumHalberd => tooltip.Text.Replace("Increases how frequently the Orichalcum set bonus triggers on hit", "При нанесении удара увеличивает частоту срабатывания бонуса орихалкового комплекта"),
                ItemID.AdamantiteSword => tooltip.Text.Replace("Slows enemies on hit", "Замедляет врагов при ударе"),
                ItemID.AdamantiteGlaive => tooltip.Text.Replace("Slows enemies on hit", "Замедляет врагов при ударе"),
                ItemID.TitaniumSword => tooltip.Text.Replace("Deals increased damage to enemies with high knockback resistance", "Наносит увеличенный урон врагам с высоким сопротивлением к отбрасыванию"),
                ItemID.TitaniumTrident => tooltip.Text.Replace("Deals increased damage to enemies with high knockback resistance", "Наносит увеличенный урон врагам с высоким сопротивлением к отбрасыванию"),
                ItemID.Excalibur => tooltip.Text.Replace("Deals double damage to enemies above 75% life", "Наносит двойной урон врагам с уровнем здоровья выше 75%"),
                ItemID.Gungnir => tooltip.Text.Replace("Deals double damage to enemies above 75% life", "Наносит двойной урон врагам с уровнем здоровья выше 75%"),
                ItemID.TrueExcalibur => tooltip.Text.Replace("Deals double damage to enemies above 75% life", "Наносит двойной урон врагам с уровнем здоровья выше 75%"),
                ItemID.CandyCaneSword => tooltip.Text.Replace("Heals you on hit", "Исцеляет при ударе"),
                ItemID.FruitcakeChakram => tooltip.Text.Replace("Heals you on hit", "Исцеляет при ударе"),
                ItemID.StylistKilLaKillScissorsIWish => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.BluePhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.RedPhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.GreenPhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.PurplePhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.WhitePhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.YellowPhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.BluePhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.RedPhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.GreenPhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.PurplePhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.WhitePhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.YellowPhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.OrangePhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.OrangePhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.AntlionClaw => tooltip.Text.Replace("Ignores 50% of enemy defense", "Игнорирует 50% защиты врага"),
                ItemID.BoneSword => tooltip.Text.Replace("Ignores 50% of enemy defense", "Игнорирует 50% защиты врага"),
                ItemID.BreakerBlade => tooltip.Text.Replace("Ignores 50% of enemy defense", "Игнорирует 50% защиты врага"),
                ItemID.NightsEdge => tooltip.Text.Replace("Inflicts Shadowflame on hit", $"Накладывает дебафф «{Language.GetTextValue("BuffName.ShadowFlame")}» при ударе"),
                ItemID.TrueNightsEdge => tooltip.Text.Replace("Inflicts Shadowflame on hit", $"Накладывает дебафф «{Language.GetTextValue("BuffName.ShadowFlame")}» при ударе"),
                ItemID.FalconBlade => tooltip.Text.Replace("Holding this item grants +20% increased movement speed", $"Держа в руках этот предмет, увеличивает скорость передвижения на 20%"),
                ItemID.SolarFlarePickaxe => tooltip.Text.Replace("Can mine Uelibloom Ore", $"Способна добывать цветонит"),
                ItemID.VortexPickaxe => tooltip.Text.Replace("Can mine Uelibloom Ore", $"Способна добывать цветонит"),
                ItemID.NebulaPickaxe => tooltip.Text.Replace("Can mine Uelibloom Ore", $"Способна добывать цветонит"),
                ItemID.StardustPickaxe => tooltip.Text.Replace("Can mine Uelibloom Ore", $"Способна добывать цветонит"),
                ItemID.SolarFlareDrill => tooltip.Text.Replace("Can mine Uelibloom Ore", $"Способен добывать цветонит"),
                ItemID.VortexDrill => tooltip.Text.Replace("Can mine Uelibloom Ore", $"Способен добывать цветонит"),
                ItemID.NebulaDrill => tooltip.Text.Replace("Can mine Uelibloom Ore", $"Способен добывать цветонит"),
                ItemID.StardustDrill => tooltip.Text.Replace("Can mine Uelibloom Ore", $"Способен добывать цветонит"),
                _ => tooltip.Text
            };
        });

        if (item.accessory)
        {
            ItemHelper.TranslateTooltip(tooltips, "PrefixAccDefense", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("damage reduction", "к сопротивлению урону");
            });
            
            ItemHelper.TranslateTooltip(tooltips, "PrefixAccCritChance", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("+0.05 luck", "+0.05 к удаче");
            });
            
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "CalamityMod" && l.Name == "PrefixStealthGenBoost", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("stealth generation", "к скорости накопления скрытности");
            });
        
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "CalamityMod" && l.Name == "PrefixStealthDamageBoost", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("stealth strike damage", "к урону скрытного удара");
            });
        }
        
        if (item.master)
        {
            ItemHelper.TranslateTooltip(tooltips, "Master", _ =>
            {
                tooltips.ReplaceText("Мастер or Revengeance", "Мастер или Месть");
            });
        }
        
        ItemHelper.TranslateTooltip(tooltips, "Tooltip0", tooltip =>
        {
            if (ModsCall.EarlyHardmodeProgressionRework)
            {
                tooltip.Text = item.type switch
                {
                    ItemID.Pwnhammer => $"{Language.GetTextValue("ItemTooltip.Pwnhammer")}\nДемонические алтари при разрушении теперь дают эссенции ночи, вместо генерации руды\nХардмодная руда теперь генерируется после первой победы над механическими боссами",
                    ItemID.Hammush => $"{Language.GetTextValue("ItemTooltip.Hammush")}\nДемонические алтари при разрушении теперь дают эссенции ночи, вместо генерации руды\nХардмодная руда теперь генерируется после первой победы над механическими боссами",
                    _ => tooltip.Text
                };
            }

            tooltip.Text = item.type switch
            {
                ItemID.SlimeGun => $"{Language.GetTextValue("ItemTooltip.SlimeGun")}\nПокрытые слизью враги получают больше урона от огненных дебаффов",
                ItemID.GelBalloon => "Бросает смесь из слизи и сверкающих кристаллов\nПокрытые слизью враги получают больше урона от огненных дебаффов",
                ItemID.FleshKnuckles => $"{Language.GetTextValue("ItemTooltip.FleshKnuckles")}\nУвеличивает максимальный запас здоровья на 45",
                ItemID.HeroShield => "Даёт невосприимчивость к отбрасыванию\nУвеличивает максимальный запас здоровья на 45",
                ItemID.BerserkerGlove => "Увеличивает отбрасывание ближнего боя\nУвеличивает максимальный запас здоровья на 45",
                ItemID.RodofDiscord => $"Телепортирует вас в место, указанное курсором\nТелепортация невозможна, пока активен дебафф «{Language.GetTextValue("BuffName.ChaosState")}»",
                ItemID.SuperAbsorbantSponge => $"{Language.GetTextValue("ItemTooltip.SuperAbsorbantSponge")}\nНельзя использовать в бездне",
                ItemID.WarmthPotion => $"{Language.GetTextValue("ItemTooltip.WarmthPotion")}\nДаёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Chilled")}», «{Language.GetTextValue("BuffName.Frozen")}» и «{Language.GetTextValue("Mods.CalamityMod.Buffs.GlacialState.DisplayName")}»",
                ItemID.ArcheryPotion => "Увеличивает скорость стрел на 20% и урон стрел на 5%",
                ItemID.IronskinPotion => $"Увеличивает защиту на {tooltip.Text.Split(' ')[3]}",
                ItemID.SwiftnessPotion => Language.GetTextValue("ItemTooltip.SwiftnessPotion").Replace("25", "15"),
                ItemID.HandWarmer => $"{Language.GetTextValue("ItemTooltip.HandWarmer")}\nОбеспечивает увеличенной регенерацией, если надет снежный комплект",
                ItemID.DD2ElderCrystal => $"{Language.GetTextValue("ItemTooltip.DD2ElderCrystal")}\nПосле размещения, вы можете нажать ПКМ по кристаллу, чтобы пропустить волны и увеличить скорость появления вторженцев",
                ItemID.DD2BetsyBow => "Стреляет разделяющимися стрелами",
                ItemID.Abeemination => "Призывает королеву пчёл при использовании в джунглях\nВходит в ярость за пределами подземных джунглей\nНе расходуется",
                ItemID.BloodySpine => "Призывает Мозг Ктулху при использовании в багрянце\nВходит в ярость за пределами подземного багрянца\nНе расходуется",
                ItemID.ClothierVoodooDoll => $"{Language.GetTextValue("ItemTooltip.ClothierVoodooDoll")}\nПока экипирован, призывает Скелетрона в ночное время, когда портной убит\nВходит в ярость во время дня",
                ItemID.DeerThing => "Призывает Циклопа-оленя при использовании в снегах или льдах\nНе расходуется",
                ItemID.GuideVoodooDoll => $"{Language.GetTextValue("ItemTooltip.GuideVoodooDoll")}\nПризывает Стену плоти, если бросить в лаву преисподней, пока гид жив",
                ItemID.LihzahrdPowerCell => "Используется на алтаре яхщеров для призыва Голема\nВходит в ярость за пределами Храма джунглей",
                ItemID.MechanicalEye => "Призывает Близнецов при использовании в ночное время\nВходит в ярость во время дня\nНе расходуется",
                ItemID.MechanicalSkull => "Призывает Скелетрона Прайма при использовании в ночное время\nВходит в ярость во время дня\nНе расходуется",
                ItemID.MechanicalWorm => "Призывает Уничтожителя при использовании в ночное время\nВходит в ярость во время дня\nНе расходуется",
                ItemID.SuspiciousLookingEye => "Призывает Глаз Ктулху при использовании в ночное время\nВходит в ярость во время дня\nНе расходуется",
                ItemID.QueenSlimeCrystal => "Призывает Королеву слизней при использовании в освящении\nНе расходуется",
                ItemID.WormFood => "Призывает Пожирателя миров при использовании в искажении\nВходит в ярость за пределами подземного искажения\nНе расходуется",
                ItemID.BlackBelt => "Даёт способность уклоняться от атак\nУклонение имеет 90 секунд перезарядки и распространяется на все другие уклонения и отражения",
                ItemID.BrainOfConfusion => "Даёт способность уклоняться от атак\nУклонение имеет 90 секунд перезарядки и распространяется на все другие уклонения и отражения",
                ItemID.CrimsonHeart => $"{Language.GetTextValue("ItemTooltip.CrimsonHeart")}\nОбеспечивает небольшим количеством света в бездне",
                ItemID.ShadowOrb => $"{Language.GetTextValue("ItemTooltip.ShadowOrb")}\nОбеспечивает небольшим количеством света в бездне",
                ItemID.MagicLantern => $"{Language.GetTextValue("ItemTooltip.MagicLantern")}\nОбеспечивает небольшим количеством света в бездне",
                ItemID.JellyfishNecklace => $"{Language.GetTextValue("ItemTooltip.JellyfishNecklace")}\nОбеспечивает небольшим количеством света в бездне",
                ItemID.MiningHelmet => $"{Language.GetTextValue("ItemTooltip.MiningHelmet")}\nОбеспечивает небольшим количеством света в бездне",
                ItemID.UltrabrightHelmet => "Улучшает видение и освещает территорию вокруг персонажа\nОбеспечивает небольшим количеством света в бездне",
                ItemID.FairyBell => $"{Language.GetTextValue("ItemTooltip.FairyBell")}\nОбеспечивает умеренным количеством света в бездне",
                ItemID.DD2PetGhost => $"{Language.GetTextValue("ItemTooltip.DD2PetGhost")}\nОбеспечивает умеренным количеством света в бездне",
                ItemID.WispinaBottle => $"{Language.GetTextValue("ItemTooltip.WispinaBottle")}\nОбеспечивает большим количеством света в бездне",
                ItemID.PumpkingPetItem => "Призывает одержимый светильник Джека\nОбеспечивает большим количеством света в бездне",
                ItemID.GolemPetItem => "Призывает игрушечного голема, освещающего путь\nОбеспечивает большим количеством света в бездне",
                ItemID.FairyQueenPetItem => "Призывает освещающую принцессу-фею\nОбеспечивает большим количеством света в бездне",
                ItemID.DivingHelmet => $"{Language.GetTextValue("ItemTooltip.DivingHelmet")}\nУмеренно увеличивает запас воздуха в бездне",
                ItemID.NeptunesShell => $"{Language.GetTextValue("ItemTooltip.NeptunesShell")}\nЗначительно увеличивает запас воздуха в бездне",
                ItemID.MoonShell => $"{Language.GetTextValue("ItemTooltip.MoonShell")}\nЗначительно увеличивает запас воздуха в бездне",
                ItemID.FlaskofCursedFlames => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.CursedInferno")}»",
                ItemID.FlaskofFire => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.FlaskofGold => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.Midas")}»",
                ItemID.FlaskofIchor => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.Ichor")}»",
                ItemID.FlaskofNanites => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.Confused")}»",
                ItemID.FlaskofParty => "Все атаки разбрасывают конфетти",
                ItemID.FlaskofPoison => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.Poisoned")}»",
                ItemID.FlaskofVenom => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.Venom")}»",
                ItemID.AncientChisel => "Увеличивает скорость добычи на 15%",
                ItemID.FrozenTurtleShell => Language.GetTextValue("ItemTooltip.FrozenTurtleShell").Replace("25", "15"),
                ItemID.Ale => "Увеличивает урон ближнего боя на 10%, но снижает защиту на 5%",
                ItemID.Sake => "Увеличивает урон ближнего боя на 10%, но снижает защиту на 5%",
                ItemID.ArmorPolish => $"{Language.GetTextValue("ItemTooltip.ArmorPolish")} и дебаффу «{Language.GetTextValue("Mods.CalamityMod.Buffs.ArmorCrunch.DisplayName")}»",
                ItemID.ArmorBracing => $"{Language.GetTextValue("ItemTooltip.ArmorBracing")} и дебаффу «{Language.GetTextValue("Mods.CalamityMod.Buffs.ArmorCrunch.DisplayName")}»",
                ItemID.CelestialStone => "Незначительно увеличивает урон,",
                ItemID.ArcaneFlower => "Снижает расход маны на 12%",
                ItemID.MagnetFlower => "Снижает расход маны на 12%",
                ItemID.Magiluminescence => "Увеличивает ускорение и торможение на 25%\nУвеличивает скорость передвижения на 5%. Этот бонус распространяется на аксессуары ботинок",
                ItemID.EmpressFlightBooster => "Увеличивает время полёта крыльев на 25%",
                ItemID.MagicQuiver => "Увеличивает урон от стрел на 5% и значительно увеличивает скорость стрел",
                ItemID.MoltenQuiver => "Увеличивает урон от стрел на 7% и значительно увеличивает скорость стрел",
                ItemID.MagicPowerPotion => Language.GetTextValue("ItemTooltip.MagicPowerPotion").Replace("20", "10"),
                ItemID.MagicHat => Language.GetTextValue("ItemTooltip.MagicHat").Replace("6", "5"),
                ItemID.TitanGlove => "Увеличивает отбрасывание ближнего боя\nУвеличивает истинный урон ближнего боя на 10%",
                ItemID.PowerGlove => "Увеличивает отбрасывание ближнего боя\nУвеличивает истинный урон ближнего боя на 10%",
                ItemID.MechanicalGlove => "Увеличивает отбрасывание ближнего боя\nУвеличивает истинный урон ближнего боя на 10%",
                ItemID.ObsidianSkull => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.AnkhShield => $"Даёт невосприимчивость к отбрасыванию и дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.ObsidianSkullRose => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.MoltenCharm => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.YoyoBag => $"{Language.GetTextValue("ItemTooltip.YoyoBag")}\nВторое йо-йо наносит на 50% меньше урона",
                ItemID.YoYoGlove => $"{Language.GetTextValue("ItemTooltip.YoYoGlove")}\nВторое йо-йо наносит на 50% меньше урона",
                ItemID.CopperHelmet => "Увеличивает урон на 5%",
                ItemID.CopperChainmail => "Увеличивает шанс критического удара на 3%",
                ItemID.CopperGreaves => "Увеличивает скорость передвижения на 5%",
                ItemID.TinHelmet => "Увеличивает шанс критического удара на 3%",
                ItemID.TinChainmail => "Увеличивает регенерацию здоровья на 1",
                ItemID.TinGreaves => "Увеличивает скорость передвижения на 5%",
                ItemID.IronHelmet => "Увеличивает сопротивление урону на 3%",
                ItemID.AncientIronHelmet => "Увеличивает сопротивление урону на 3%",
                ItemID.IronChainmail => "Увеличивает сопротивление урону на 3%",
                ItemID.IronGreaves => "Увеличивает сопротивление урону на 3%",
                ItemID.LeadHelmet => "Увеличивает сопротивление урону на 3%",
                ItemID.LeadChainmail => "Увеличивает сопротивление урону на 3%",
                ItemID.LeadGreaves => "Увеличивает сопротивление урону на 3%",
                ItemID.SilverHelmet => "Увеличивает шанс критического удара на 5%",
                ItemID.SilverChainmail => "Увеличивает регенерацию здоровья на 2",
                ItemID.SilverGreaves => "Увеличивает скорость передвижения на 8%",
                ItemID.TungstenHelmet => "Увеличивает урон на 7%",
                ItemID.TungstenChainmail => "Увеличивает регенерацию здоровья на 1",
                ItemID.TungstenGreaves => "Увеличивает скорость передвижения на 8%",
                ItemID.GoldHelmet => "Увеличивает урон на 6%",
                ItemID.AncientGoldHelmet => "Увеличивает урон на 6%",
                ItemID.GoldChainmail => "Увеличивает сопротивление урону на 5%",
                ItemID.GoldGreaves => "Увеличивает скорость передвижения на 10%",
                ItemID.PlatinumHelmet => "Увеличивает урон на 6%",
                ItemID.PlatinumChainmail => "Увеличивает шанс критического удара на 5%",
                ItemID.PlatinumGreaves => "Увеличивает скорость передвижения на 10%",
                ItemID.ShadowHelmet => "Увеличивает урон на 5% и скорость прыжка на 7%",
                ItemID.AncientShadowHelmet => "Увеличивает урон на 5% и скорость прыжка на 7%",
                ItemID.ShadowScalemail => "Увеличивает урон на 5% и скорость прыжка на 7%",
                ItemID.AncientShadowScalemail => "Увеличивает урон на 5% и скорость прыжка на 7%",
                ItemID.ShadowGreaves => "Увеличивает урон на 5% и скорость прыжка на 7%",
                ItemID.AncientShadowGreaves => "Увеличивает урон на 5% и скорость прыжка на 7%",
                ItemID.CrimsonHelmet => "Увеличивает урон на 5%\nУвеличивает регенерацию здоровья на 1",
                ItemID.CrimsonScalemail => "Увеличивает урон на 5%\nУвеличивает регенерацию здоровья на 1",
                ItemID.CrimsonGreaves => "Увеличивает урон на 5%\nУвеличивает регенерацию здоровья на 1",
                ItemID.CobaltHat => "Увеличивает максимальный запас маны на 60",
                ItemID.PalladiumBreastplate => "Увеличивает урон на 5%",
                ItemID.PalladiumLeggings => "Увеличивает урон на 5%",
                ItemID.MythrilHood => "Увеличивает максимальный запас маны на 80",
                ItemID.OrichalcumBreastplate => Language.GetTextValue("ItemTooltip.OrichalcumBreastplate").Replace("6", "10"),
                ItemID.AdamantiteHeadgear => "Увеличивает максимальный запас маны на 100",
                ItemID.SquirePlating => Language.GetTextValue("ItemTooltip.SquirePlating").Replace("15", "10"),
                ItemID.SquireGreaves => "Увеличивает урон призывателя и шанс критического удара ближнего боя на 5%\nУвеличивает скорость передвижения на 15%",
                ItemID.MonkBrows => Language.GetTextValue("ItemTooltip.MonkBrows").Replace("20", "10"),
                ItemID.MonkShirt => Language.GetTextValue("ItemTooltip.MonkShirt").Replace("20", "10"),
                ItemID.MonkPants => "Увеличивает урон призывателя и шанс критического удара ближнего боя на 5%",
                ItemID.HuntressJerkin => "Увеличивает урон призывателя и стрелковый урон на 10%\nДаёт 10% шанс не использовать боеприпасы",
                ItemID.ApprenticeTrousers => "Увеличивает урон призывателя и магический шанс критического удара на 5%\nУвеличивает скорость передвижения на 20%",
                ItemID.SquireAltShirt => "Увеличивает урон призывателя на 30% и регенерацию здоровья",
                ItemID.SquireAltPants => "Увеличивает урон призывателя и шанс критического удара ближнего боя на 10%",
                ItemID.MonkAltHead => "Увеличивает призываемое число стражей на 2\nУвеличивает урон призывателя и ближнего боя на 10%",
                ItemID.MonkAltShirt => "Увеличивает урон призывателя и скорость атаки ближнего боя на 10%",
                ItemID.MonkAltPants => "Увеличивает урон призывателя и шанс критического удара ближнего боя на 10%",
                ItemID.HuntressAltShirt => Language.GetTextValue("ItemTooltip.HuntressAltShirt").Replace("25", "15"),
                ItemID.ApprenticeAltPants => "Увеличивает урон призывателя и магический шанс критического удара на 10%",
                ItemID.SlimeCrown => $"{Language.GetTextValue("ItemTooltip.SlimeCrown")}\nНе расходуется",
                ItemID.BloodMoonStarter => "Вызывает кровавую луну\nНе расходуется",
                ItemID.GoblinBattleStandard => $"{Language.GetTextValue("ItemTooltip.GoblinBattleStandard")}\nНе расходуется",
                ItemID.PirateMap => $"{Language.GetTextValue("ItemTooltip.PirateMap")}\nНе расходуется",
                ItemID.SnowGlobe => $"{Language.GetTextValue("ItemTooltip.SnowGlobe")}\nНе расходуется",
                ItemID.NaughtyPresent => $"{Language.GetTextValue("ItemTooltip.NaughtyPresent")}\nНе расходуется",
                ItemID.PumpkinMoonMedallion => $"{Language.GetTextValue("ItemTooltip.PumpkinMoonMedallion")}\nНе расходуется",
                ItemID.SolarTablet => $"{Language.GetTextValue("ItemTooltip.SolarTablet")}\nНе расходуется",
                ItemID.CelestialSigil => $"{Language.GetTextValue("ItemTooltip.CelestialSigil")}\nНе расходуется",
                ItemID.GoldPickaxe => "Способна добывать демонит, багротан, метеорит, морскую призму и кристалл морской призмы",
                ItemID.PlatinumPickaxe => "Способна добывать демонит, багротан, метеорит, морскую призму и кристалл морской призмы",
                ItemID.Picksaw => $"{Language.GetTextValue("ItemTooltip.Picksaw")}\nСпособна добывать магматит, расположенный в бездне",
                ItemID.DeathSickle => $"Накладывает дебафф «{Language.GetTextValue("Mods.CalamityMod.Buffs.WhisperingDeath.DisplayName")}» при ударе",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.EmptyBucket => "1 ед. защиты\nНельзя использовать в бездне",
                ItemID.GladiatorHelmet => "5 ед. защиты\nУвеличивает разбойный урон на 3%",
                ItemID.GladiatorBreastplate => "6 ед. защиты\nУвеличивает разбойный шанс критического удара на 3",
                ItemID.GladiatorLeggings => "5 ед. защиты\nУвеличивает скорость снарядов разбойника на 3%",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.AnkhShield => $"Даёт невосприимчивость к большинству дебаффов, включая «{Language.GetTextValue("BuffName.WindPushed")}»",
                ItemID.MasterNinjaGear => "Даёт способность уклоняться от атак\nУклонение имеет 90 секунд перезарядки и распространяется на все другие уклонения и отражения",
                ItemID.JellyfishDivingGear => "Создаёт очень тусклый свет, который становится ярче под водой\nОбеспечивает небольшим количеством света в бездне",
                ItemID.Magiluminescence => "Освещает при ношении\nОбеспечивает небольшим количеством света в бездне",
                ItemID.SuspiciousLookingTentacle => "Обеспечивает большим количеством света в бездне\n'Нет, эта тентакля не затем, зачем ты думаешь...'",
                ItemID.ArcticDivingGear => "Увеличивает подвижность на льду\nОбеспечивает небольшим количеством света в бездне\nУмеренно увеличивает запас воздуха в бездне",
                ItemID.FrozenShield => "Окружает панцирем, если ваше здоровье ниже 50%, который увеличивает сопротивление урону на 25%",
                ItemID.MoonStone => "шанс критического удара, регенерацию здоровья",
                ItemID.SunStone => "шанс критического удара, регенерацию здоровья",
                ItemID.EmpressFlightBooster => "Увеличивает скорость передвижения и прыжка на 10% и ускорение на 10%",
                ItemID.SniperScope => "Увеличивает стрелковый урон и шанс критического удара на 7%",
                ItemID.BerserkerGlove => "Увеличивает истинный урон ближнего боя на 10%",
                ItemID.FireGauntlet => "Увеличивает урон и скорость атаки ближнего боя на 14%\nУвеличивает истинный урон ближнего боя на 10%",
                ItemID.ObsidianHorseshoe => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.ObsidianShield => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.ObsidianWaterWalkingBoots => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.LavaWaders => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}» и 7 секунд невосприимчивости к лаве",
                ItemID.LavaSkull => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.MoltenSkullRose => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.HellfireTreads => $"Позволяет очень быстро бегать и даёт невосприимчивость к дебаффу «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.Gi => "Увеличивает скорость прыжка и передвижения на 10%",
                ItemID.MonkPants => "Увеличивает скорость передвижения на 20%",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "BuffTime", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.ShinePotion => "Длительность действия эффекта: 10 мин.\nОбеспечивает умеренным количеством света в бездне",
                ItemID.GillsPotion => "Длительность действия эффекта: 4 мин.\nЗначительно увеличивает запас воздуха в бездне",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "SetBonus", tooltip =>
        {
            Player player = Main.player[Main.myPlayer];
            
            if (player.armor[0].type == ItemID.AdamantiteHelmet &&
                player.armor[1].type == ItemID.AdamantiteBreastplate &&
                player.armor[2].type == ItemID.AdamantiteLeggings)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} Увеличивает скорость атаки ближнего боя на 15% и скорость передвижения на 20%\nПоловина текущего сопротивления урону добавляется к шансу критического удара\nНепрерывно нанося урон, вы постепенно получаете всё больше и больше защиты, вплоть до 15\nПри бездействии, этот бонус постепенно убывает\nЭта дополнительная защита может быть снижена уроном по защите";
            }
            
            if (player.armor[0].type == ItemID.AdamantiteHeadgear &&
                player.armor[1].type == ItemID.AdamantiteBreastplate &&
                player.armor[2].type == ItemID.AdamantiteLeggings)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.AdamantiteCaster")}\nПоловина текущего сопротивления урону добавляется к шансу критического удара\nНепрерывно нанося урон, вы постепенно получаете всё больше и больше защиты, вплоть до 15\nПри бездействии, этот бонус постепенно убывает\nЭта дополнительная защита может быть снижена уроном по защите";
            }
            
            if (player.armor[0].type == ItemID.AdamantiteMask &&
                player.armor[1].type == ItemID.AdamantiteBreastplate &&
                player.armor[2].type == ItemID.AdamantiteLeggings)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.AdamantiteRanged")}\nПоловина текущего сопротивления урону добавляется к шансу критического удара\nНепрерывно нанося урон, вы постепенно получаете всё больше и больше защиты, вплоть до 15\nПри бездействии, этот бонус постепенно убывает\nЭта дополнительная защита может быть снижена уроном по защите";
            }
            if (player.armor[0].type == ItemID.CobaltHelmet &&
                player.armor[1].type == ItemID.CobaltBreastplate &&
                player.armor[2].type == ItemID.CobaltLeggings)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} Увеличивает скорость атаки ближнего боя 10%\nУвеличивает максимальную скорость передвижения и ускорение на 10%\nВы получаете бонус к урону и шансу критического удара относительно текущей скорости передвижения, максимум 10%";
            }
            
            if (player.armor[0].type == ItemID.CobaltHat &
                player.armor[1].type == ItemID.CobaltBreastplate &&
                player.armor[2].type == ItemID.CobaltLeggings)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.CobaltCaster")}\nУвеличивает максимальную скорость передвижения и ускорение на 10%\nВы получаете бонус к урону и шансу критического удара относительно текущей скорости передвижения, максимум 10%";
            }
            
            if (player.armor[0].type == ItemID.CobaltMask &&
                player.armor[1].type == ItemID.CobaltBreastplate &&
                player.armor[2].type == ItemID.CobaltLeggings)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.CobaltRanged")}\nУвеличивает максимальную скорость передвижения и ускорение на 10%\nВы получаете бонус к урону и шансу критического удара относительно текущей скорости передвижения, максимум 10%";
            }
            
            if (player.armor[0].type == ItemID.MythrilHelmet &&
                player.armor[1].type == ItemID.MythrilChainmail &&
                player.armor[2].type == ItemID.MythrilGreaves)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MythrilMelee")}\nУдары по врагам вызывают мифриловые вспышки, которые нацеливаются на врагов после небольшой задержки\nПосле создания вспышки происходит задержка в 12 кадров до появления новой вспышки";
            }
            
            if (player.armor[0].type == ItemID.MythrilHood &&
                player.armor[1].type == ItemID.MythrilChainmail &&
                player.armor[2].type == ItemID.MythrilGreaves)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MythrilCaster")}\nУдары по врагам вызывают мифриловые вспышки, которые нацеливаются на врагов после небольшой задержки\nПосле создания вспышки происходит задержка в 12 кадров до появления новой вспышки";
            }
            
            if (player.armor[0].type == ItemID.MythrilHat &&
                player.armor[1].type == ItemID.MythrilChainmail &&
                player.armor[2].type == ItemID.MythrilGreaves)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MythrilRanged")}\nУдары по врагам вызывают мифриловые вспышки, которые нацеливаются на врагов после небольшой задержки\nПосле создания вспышки происходит задержка в 12 кадров до появления новой вспышки";
            }
            
            if (player.armor[0].type == ItemID.ShadowHelmet || player.armor[0].type == ItemID.AncientShadowHelmet &&
                player.armor[1].type == ItemID.ShadowScalemail || player.armor[1].type == ItemID.AncientShadowScalemail &&
                player.armor[2].type == ItemID.ShadowGreaves || player.armor[2].type == ItemID.AncientShadowGreaves)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} Увеличивает максимальную скорость передвижения и ускорение на 15%";
            }
            
            if (player.armor[0].type == ItemID.EskimoHood || player.armor[0].type == ItemID.PinkEskimoHood &&
                player.armor[1].type == ItemID.EskimoCoat || player.armor[1].type == ItemID.PinkEskimoCoat &&
                player.armor[2].type == ItemID.EskimoPants || player.armor[2].type == ItemID.PinkEskimoPants)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} Увеличивает урон всех дебаффов связанных с холодом на 25%\nВраги, связанные с холодом, наносят сниженный контактный урон\nОбеспечивает невосприимчивостью к дебаффам «{Language.GetTextValue("BuffName.Chilled")}», «{Language.GetTextValue("BuffName.Frozen}")}», «{Language.GetTextValue("BuffName.Frostburn")}» и «{Language.GetTextValue("Mods.CalamityMod.Buffs.GlacialState.DisplayName")}»";
            }
            
            if (player.armor[0].type == ItemID.ChlorophyteHeadgear ||
                player.armor[0].type == ItemID.ChlorophyteMask ||
                player.armor[0].type == ItemID.ChlorophyteHelmet &&
                player.armor[1].type == ItemID.ChlorophytePlateMail &&
                player.armor[2].type == ItemID.ChlorophyteGreaves)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} Призывает мощный кристальный лист, стреляющий импульсами жизни каждые 5 секунд\nИмпульсы наносят базовый урон в 300 единиц врагам в радиусе действия\nИмпульсы также увеличивают здоровье на 10 единиц вам и всем игрокам команды\nИгроки, исцелившиеся от предыдущих импульсов, не могут быть исцелены другим, пока не пройдёт 4.5 секунды\nКак увеличение здоровья, так и урон, зависят от вашего сильнейшего класса";
            }
            if (player.armor[0].type == ItemID.SpectreHood &&
                player.armor[1].type == ItemID.SpectreRobe &&
                player.armor[2].type == ItemID.SpectrePants)
            {
                tooltip.Text = $"{Language.GetText("LegacyTooltip.48").Value} {Language.GetText("ArmorSetBonus.SpectreHealing").Value.Replace("40%", "20%")}";
            }
            if (player.armor[0].type == ItemID.MiningHelmet || player.armor[0].type == ItemID.UltrabrightHelmet &&
                player.armor[1].type == ItemID.MiningShirt &&
                player.armor[2].type == ItemID.MiningPants)
            {
                tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} Увеличивает скорость добычи на 10%\nДобываемая вами руда иногда даёт дополнительный кусок руды";
            }
            
            switch (item.type)
            {
                case ItemID.MeteorHelmet:
                case ItemID.MeteorSuit:
                case ItemID.MeteorLeggings:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} Космическая пушка потребляет на 50% меньше маны";
                    break;
                
                case ItemID.CopperHelmet:
                case ItemID.CopperChainmail:
                case ItemID.CopperGreaves:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MetalTier1")}\nУвеличивает весь урон на 2";
                    break;
                
                case ItemID.TinHelmet:
                case ItemID.TinChainmail:
                case ItemID.TinGreaves:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MetalTier1")}\nУвеличивает пробивание брони на 5";
                    break;
                
                case ItemID.IronGreaves:
                case ItemID.IronChainmail:
                case ItemID.IronHelmet:
                case ItemID.AncientIronHelmet:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MetalTier1")}\nУвеличивает сопротивление урону на 6%\nУвеличивает регенерацию здоровья на 2";
                    break;
                
                case ItemID.LeadHelmet:
                case ItemID.LeadChainmail:
                case ItemID.LeadGreaves:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MetalTier2")}\nУвеличивает сопротивление урону на 3%\nУвеличивает регенерацию здоровья на 1\nДаёт невосприимчивость к отбрасыванию";
                    break;
                
                case ItemID.SilverGreaves:
                case ItemID.SilverChainmail:
                case ItemID.SilverHelmet:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MetalTier2")}\nУвеличивает регенерацию здоровья на 1\nЧерез две секунды после получения 20 или более урона восстанавливает 10 единиц здоровья\nПовторное попадание сбрасывает таймер, откладывая восстановление здоровья";
                    break;
            
                case ItemID.TungstenHelmet:
                case ItemID.TungstenChainmail:
                case ItemID.TungstenGreaves:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MetalTier2")}\nУвеличивает шанс критического удара на 100% от отбрасывания удерживаемого оружия\nЭтот эффект ограничивается безумным отбрасыванием, увеличивая шанс критического удара на 10%\nУвеличивает всё отбрасывание на 33%, это учитывается для вышеуказанного усиления\nТекущий бонус: {tooltip.Text.Split(' ')[42]} шанса критического удара от {tooltip.Text.Split(' ')[47]} отбрасывания";
                    break;
            
                case ItemID.GoldGreaves:
                case ItemID.GoldChainmail:
                case ItemID.GoldHelmet:
                case ItemID.AncientGoldHelmet:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MetalTier2")}\nВсе враги с 4% шансом могут выронить 1 золотую монету. Со всех убитых боссов выпадает 3 золотые монеты\nВы получаете 1% шанса критического удара за каждые 5 золотых монет в инвентаре, максимум 10%";
                    break;
                
                case ItemID.PlatinumHelmet:
                case ItemID.PlatinumChainmail:
                case ItemID.PlatinumGreaves:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.Platinum")}\nКаждые 15 единиц защиты дают 1 единицу регенерации здоровья и 1% шанс критического удара\nЭти эффекты ограничены максимумом в 45 единиц защиты";
                    break;
                
                case ItemID.MoltenHelmet:
                case ItemID.MoltenBreastplate:
                case ItemID.MoltenGreaves:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.Molten")}\nУвеличивает истинный урон ближнего боя на 20%\nДаёт невосприимчивость к огненным блокам и временную невосприимчивость к лаве";
                    break;
                
                case ItemID.MonkBrows:
                case ItemID.MonkShirt:
                case ItemID.MonkPants:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MonkTier2")}\nУвеличивает урон, шанс критического удара и скорость атаки ближнего боя на 10%\nУвеличивает урон призывателя на 15%";
                    break;
                
                case ItemID.SquireGreatHelm:
                case ItemID.SquirePlating:
                case ItemID.SquireGreaves:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.SquireTier2")}\nУвеличивает регенерацию здоровья\nУвеличивает урон призывателя на 15% и шанс критического удара ближнего боя на 10%";
                    break;
                
                case ItemID.HuntressWig:
                case ItemID.HuntressJerkin:
                case ItemID.HuntressPants:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.HuntressTier2")}\nУвеличивает урон призывателя и стрелковый урон на 10%";
                    break;
                
                case ItemID.ApprenticeHat:
                case ItemID.ApprenticeRobe:
                case ItemID.ApprenticeTrousers:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.ApprenticeTier2")}\nУвеличивает урон призывателя на 5% и магический шанс критического удара на 15%";
                    break;
                
                case ItemID.MonkAltHead:
                case ItemID.MonkAltShirt:
                case ItemID.MonkAltPants:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.MonkTier3")}\nУвеличивает урон, шанс критического удара и скорость атаки ближнего боя на 10%\nУвеличивает урон призывателя на 30%";
                    break;
                
                case ItemID.SquireAltHead:
                case ItemID.SquireAltShirt:
                case ItemID.SquireAltPants:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.SquireTier3")}\nЗначительно увеличивает регенерацию здоровья\nУвеличивает урон призывателя и шанс критического удара ближнего боя на 10%";
                    break;
                
                case ItemID.HuntressAltHead:
                case ItemID.HuntressAltShirt:
                case ItemID.HuntressAltPants:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.HuntressTier3")}\nУвеличивает урон призывателя и стрелковый урон на 10%";
                    break;
                
                case ItemID.ApprenticeAltHead:
                case ItemID.ApprenticeAltShirt:
                case ItemID.ApprenticeAltPants:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.ApprenticeTier3")}\nУвеличивает урон призывателя на 10% и магический шанс критического удара на 15%";
                    break;
                    
                case ItemID.GladiatorHelmet:
                case ItemID.GladiatorBreastplate:
                case ItemID.GladiatorLeggings:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.Gladiator")}\nУвеличивает защиту на 3\nУвеличивает максимальную скрытность на 60\nУвеличивает разбойный урон на 5% и скорость снарядов на 10%";
                    break;
                
                case ItemID.ObsidianHelm:
                case ItemID.ObsidianShirt:
                case ItemID.ObsidianPants:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.ObsidianOutlaw")}\nДаёт невосприимчивость к огненным блокам и временную невосприимчивость к лаве";
                    break;
                
                case ItemID.CrystalNinjaHelmet:
                case ItemID.CrystalNinjaChestplate:
                case ItemID.CrystalNinjaLeggings:
                    tooltip.Text = $"{Language.GetTextValue("LegacyTooltip.48")} {Language.GetTextValue("ArmorSetBonus.CrystalNinja")}";
                    break;
            }
        });
        
        ItemHelper.TranslateTooltip(tooltips, "NeedsBait", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.GoldenFishingRod => $"{Language.GetTextValue("GameUI.BaitRequired")}\nЛеска никогда не порвётся",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "HealLife", tooltip =>
        {
            tooltips.ReplaceText("Restores", "Восстанавливает");
            tooltips.ReplaceText("life", "ед. здоровья");
            
            tooltip.Text = item.type switch
            {
                ItemID.BottledHoney => $"Восстанавливает 80 ед. здоровья\nНакладывает бафф «{Language.GetTextValue("BuffName.Honey")}» на 2 минуты",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Consumable", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.TruffleWorm => $"{Language.GetTextValue("LegacyTooltip.35")}\nПризывает Герцога Рыброна при использовании в качестве наживки в океане\nВходит в ярость за пределами океана",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Tooltip4", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.CelestialShell => $"защиту, скорость добычи и отбрасывание призывателя\nУмеренно увеличивает запас воздуха в бездне\nДаёт невосприимчивость к дебаффам «{Language.GetTextValue("Mods.CalamityMod.Buffs.Nightwither.DisplayName")}» и «{Language.GetTextValue("Mods.CalamityMod.Buffs.HolyFlames.DisplayName")}»",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Tooltip2", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.FairyBoots => "На траве, по которой прошлись, начинают расти цветы\nФеи появляются на поверхности в любое время и гораздо чаще\nНаходящиеся поблизости феи увеличивают регенерацию здоровья, защиту и скорость передвижения\nФеи невосприимчивы к урону и больше не улетают",
                ItemID.MoonStone => $"защиту, скорость добычи и отбрасывание призывателя\nДаёт невосприимчивость к дебаффу «{Language.GetTextValue("Mods.CalamityMod.Buffs.Nightwither.DisplayName")}»",
                ItemID.SunStone => $"защиту, скорость добычи и отбрасывание призывателя\nДаёт невосприимчивость к дебаффу «{Language.GetTextValue("Mods.CalamityMod.Buffs.HolyFlames.DisplayName")}»",
                ItemID.CelestialStone => $"защиту, скорость добычи и отбрасывание призывателя\nДаёт невосприимчивость к дебаффам «{Language.GetTextValue("Mods.CalamityMod.Buffs.Nightwither.DisplayName")}» и «{Language.GetTextValue("Mods.CalamityMod.Buffs.HolyFlames.DisplayName")}»",
                ItemID.CelestialShell => "Незначительно увеличивает урон,",
                ItemID.MoltenQuiver => $"Поджигает деревянные стрелы и все стрелы накладывают дебафф «{Language.GetTextValue("BuffName.OnFire3")}»",
                ItemID.HellfireTreads => $"Оставляет за вами огненный след\nУмножает весь урон накладываемых игроком огненных дебаффов на 50%\nВсе атаки, включая миньонов, накладывают дебафф «{Language.GetTextValue("BuffName.OnFire3")}»",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Tooltip3", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.TerrasparkBoots => $"Даёт невосприимчивость к огненным блокам и 7 секунд невосприимчивости к лаве\nДаёт невосприимчивость к дебаффу «{Language.GetTextValue("BuffName.OnFire")}»",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "UseMana", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.SpaceGun => $"Использует {tooltip.Text.Split(' ')[1]} ед. маны",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Material", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.Tombstone => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.GraveMarker => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.CrossGraveMarker => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.Headstone => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.Gravestone => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.Obelisk => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.RichGravestone1 => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.RichGravestone2 => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.RichGravestone3 => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.RichGravestone4 => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.RichGravestone5 => $"{Language.GetTextValue("LegacyTooltip.36")}\n20 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                _ => tooltip.Text
            };
        });
    }
}