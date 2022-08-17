using System.Collections.Generic;
using System.Text.RegularExpressions;
using CalamityMod.Items.Accessories;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications;

[JITWhenModsEnabled("CalamityMod")]
public class MetersTranslation : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.type == ModContent.ItemType<StatMeter>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = tooltip.Text
                    .Replace("Displays almost all player stats\nOffensive stats displayed vary with held item",
                        "Отображает почти все характеристики игрока\nХарактеристики меняются в зависимости от удерживаемого предмета")
                    .Replace("Rage Damage Boost", "Бонус урона ярости")
                    .Replace("Adrenaline Damage Boost", "Бонус урона адреналина")
                    .Replace("Adrenaline DR Boost", "Бонус сопротивления урону адреналина")
                    
                    .Replace("True Melee Damage", "Истинный урон ближнего боя")
                    .Replace("Melee Damage", "Урон ближнего боя")
                    .Replace("Melee Crit Chance", "Шанс критического удара ближнего боя")
                    .Replace("Melee Attack Speed", "Скорость атаки ближнего боя")
                    .Replace("Melee Armor Penetration", "Пробивание брони ближнего боя")
                    
                    .Replace("Rogue Damage", "Разбойный урон")
                    .Replace("Rogue Crit Chance", "Разбойный шанс критического удара")
                    .Replace("Rogue Attack Speed", "Разбойная скорость атаки")
                    .Replace("Rogue Armor Penetration", "Разбойное пробивание брони")
                    .Replace("Rogue Velocity Boost", "Увеличение скорости снарядов разбойника")
                    .Replace("Rogue Weapon Consumption Chance", "Вероятность потребления разбойного оружия")
                    .Replace("Max Stealth", "Максимальная скрытность")
                    .Replace("Standing Regen", "Стоячая регенерация")
                    .Replace("Moving Regen", "Подвижная регенерация")
                    
                    .Replace("Ranged Damage", "Стрелковый урон")
                    .Replace("Ranged Crit Chance", "Стрелковый шанс критического удара")
                    .Replace("Ranged Attack Speed", "Стрелковая скорость атаки")
                    .Replace("Ranged Armor Penetration", "Стрелковое пробивание брони")
                    .Replace("Ammo Consumption Chance", "Шанс использовать боеприпасы")
                    
                    .Replace("Magic Damage", "Магический урон")
                    .Replace("Magic Crit Chance", "Магический шанс критического удара")
                    .Replace("Magic Attack Speed", "Магическая скорость атаки")
                    .Replace("Magic Armor Penetration", "Магическое пробивание брони")
                    .Replace("Mana Usage", "Потребление маны")
                    .Replace("Mana Regen", "Регенерация маны")

                    .Replace("Minion Damage", "Урон призывателя")
                    .Replace("Minion Crit Chance", "Шанс критического удара призывателя")
                    .Replace("Minion Armor Penetration", "Пробивание брони призывателя")
                    .Replace("Minion Slots", "Слотов призываемых миньонов")
                    
                    .Replace("Whip Damage", "Урон хлыстов")
                    .Replace("Whip Crit Chance", "Шанс критического удара хлыстов")
                    .Replace("Whip Attack Speed", "Скорость атаки хлыстов")
                    .Replace("Whip Armor Penetration", "Пробивание брони хлыстов")
                    .Replace("from melee", "от ближнего боя")
                    
                    .Replace("True (No Scaling) Damage", "Истинный (без скалирования) урон")
                    .Replace("True (No Scaling) Crit Chance", "Истинный (без скалирования) шанс критического удара")
                    .Replace("True (No Scaling) Attack Speed", "Истинная (без скалирования) скорость атаки")
                    .Replace("True (No Scaling) Armor Penetration", "Истинное (без скалирования) пробивание брони")
                    
                    .Replace("Classless Damage", "Бесклассовый урон")
                    .Replace("Classless Crit Chance", "Бесклассовый шанс критического удара")
                    .Replace("Classless Attack Speed", "Бесклассовая скорость атаки")
                    .Replace("Classless Armor Penetration", "Бесклассовое пробивание брони")
                    
                    .Replace("Averaged Damage", "Общий урон")
                    .Replace("Averaged Crit Chance", "Общий шанс критического удара")
                    .Replace("Averaged Attack Speed", "Общая скорость атаки")
                    .Replace("Averaged Armor Penetration", "Общее пробивание брони")
                    
                    .Replace("Magic+Summon Damage", "Магический+Призывателя урон")
                    .Replace("Magic+Summon Crit Chance", "Магический+Призывателя шанс критического удара")
                    .Replace("Magic+Summon Attack Speed", "Магическая+Призывателя скорость атаки")
                    .Replace("Magic+Summon Armor Penetration", "Магическое+Призывателя пробивание брони")
                    
                    .Replace("Throwing Damage", "Метательный урон")
                    .Replace("Throwing Crit Chance", "Метательный шанс критического удара")
                    .Replace("Throwing Attack Speed", "Метательная скорость атаки")
                    .Replace("Throwing Armor Penetration", "Метательное пробивание брони")

                    .Replace("Defense Lost From Pressure", "Потерянная защита от давления")
                    .Replace("Defense", "Защита")
                    .Replace("DR", "Сопротивление урону")
                    .Replace("Life Regen", "Регенерация здоровья")
                    .Replace("Move Speed", "Увеличение скорости передвижения")
                    .Replace("Jump Boost", "Увеличение скорости прыжка")
                    .Replace("Wing Flight Time", "Время полёта крыльев")
                    .Replace("seconds", "секунд")
                    .Replace("Abyss Light Strength", "Сила света в бездне")
                    .Replace("Other Abyss Stats", "Другие характеристики бездны")
                    .Replace("Breath Lost Per Tick", "Потеря дыхания за тик")
                    .Replace("Breath Loss Rate", " Скорость потери дыхания")
                    .Replace("Life Lost Per Tick at Zero Breath", "Потеря здоровья за тик при нулевом дыхании")
                    .Replace("Other Abyss stats are only displayed while in the Abyss", "Другие характеристики бездны отображаются только во время нахождения в бездне")
                    .Replace("sec", "сек");

            });
        }
        else if (item.type == ModContent.ItemType<MeleeLevelMeter>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                string[] array = Regex.Split(tooltip.Text, "\n");

                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.MeleeLevelMeter.Tooltip.0",
                    Regex.Split(array[3], ": ")[1],
                    Regex.Split(array[4], ": ")[1],
                    Regex.Split(array[5], ": ")[1],
                    Regex.Split(array[6], ": ")[1],
                    Regex.Split(array[7], ": ")[1]);
            });
        }

        else if (item.type == ModContent.ItemType<MagicLevelMeter>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                string[] array = Regex.Split(tooltip.Text, "\n");

                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.MagicLevelMeter.Tooltip.0",
                    Regex.Split(array[3], ": ")[1],
                    Regex.Split(array[4], ": ")[1],
                    Regex.Split(array[5], ": ")[1],
                    Regex.Split(array[6], ": ")[1],
                    Regex.Split(array[7], ": ")[1]);
            });
        }

        else if (item.type == ModContent.ItemType<RangedLevelMeter>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                string[] array = Regex.Split(tooltip.Text, "\n");

                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.RangedLevelMeter.Tooltip.0",
                    Regex.Split(array[3], ": ")[1],
                    Regex.Split(array[4], ": ")[1],
                    Regex.Split(array[5], ": ")[1],
                    Regex.Split(array[6], ": ")[1],
                    Regex.Split(array[7], ": ")[1]);
            });
        }

        else if (item.type == ModContent.ItemType<RogueLevelMeter>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                string[] array = Regex.Split(tooltip.Text, "\n");

                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.RogueLevelMeter.Tooltip.0",
                    Regex.Split(array[3], ": ")[1],
                    Regex.Split(array[4], ": ")[1],
                    Regex.Split(array[5], ": ")[1],
                    Regex.Split(array[6], ": ")[1],
                    Regex.Split(array[7], ": ")[1]);
            });
        }

        else if (item.type == ModContent.ItemType<SummonLevelMeter>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                string[] array = Regex.Split(tooltip.Text, "\n");

                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SummonLevelMeter.Tooltip.0",
                    Regex.Split(array[3], ": ")[1],
                    Regex.Split(array[4], ": ")[1],
                    Regex.Split(array[5], ": ")[1],
                    Regex.Split(array[6], ": ")[1]);
            });
        }
    }
}