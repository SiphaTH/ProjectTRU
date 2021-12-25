using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.UI;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class StatSheetUIOnInitialize : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.OnInitialize));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, 660f, 860f);
            TranslationHelper.ILTranslation(il, 648f, 848f);
            TranslationHelper.ILTranslation(il, 652, 852);
        }
    }

    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class StatSheetUIRebuildStatList : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.RebuildStatList));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Melee Damage: {0}%", "Урон ближнего боя: {0}%");
            TranslationHelper.ILTranslation(il, "Melee Crit: {0}%", "Шанс критического удара ближнего боя: {0}%");
            TranslationHelper.ILTranslation(il, "Melee Speed: {0}%", "Скорость атаки ближнего боя: {0}%");
            TranslationHelper.ILTranslation(il, "Ranged Damage: {0}%", "Стрелковый урон: {0}%");
            TranslationHelper.ILTranslation(il, "Ranged Crit: {0}%", "Стрелковый шанс критического удара: {0}%");
            TranslationHelper.ILTranslation(il, "Magic Damage: {0}%", "Магический урон: {0}%");
            TranslationHelper.ILTranslation(il, "Magic Crit: {0}%", "Магический шанс критического удара: {0}%");
            TranslationHelper.ILTranslation(il, "Summon Damage: {0}%", "Урон миньонов: {0}%");
            TranslationHelper.ILTranslation(il, "Max Minions: {0}", "Максимальное число миньонов: {0}");
            TranslationHelper.ILTranslation(il, "Max Sentries: {0}", "Максимальное число турелей: {0}");
            TranslationHelper.ILTranslation(il, "HP: {0}", "Здоровье: {0}");
            TranslationHelper.ILTranslation(il, "Defense: {0}", "Защита: {0}");
            TranslationHelper.ILTranslation(il, "Damage Reduction: {0}%", "Сопротивление урону: {0}%");
            TranslationHelper.ILTranslation(il, "Life Regen: {0} HP/second","Регенерация здоровья: {0}/сек");
            TranslationHelper.ILTranslation(il, "Mana: {0}","Мана: {0}");
            TranslationHelper.ILTranslation(il, "Mana Regen: {0}/second","Восстановление маны: {0}/сек");
            TranslationHelper.ILTranslation(il, "Armor Penetration: {0}", "Пробивание брони: {0}");
            TranslationHelper.ILTranslation(il, "Aggro: {0}", "Агрессия: {0}");
            TranslationHelper.ILTranslation(il, "Max Speed: {0} mph", "Максимальная скорость: {0} км/ч");
            TranslationHelper.ILTranslation(il, "Wing Time: {0} seconds", "Время полёта: {0} сек");
        }
    }

    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class StatSheetUIAddStat : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.AddStat));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, 217, 475);
        }
    }
}