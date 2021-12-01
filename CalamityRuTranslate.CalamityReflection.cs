using System.Collections.Generic;
using System.Reflection;
using CalamityMod;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.UI;
using CalamityMod.UI.CalamitasEnchants;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityRuTranslate
{
    public partial class CalamityRuTranslate
    {
        private void CalamityReflections()
        {
            List<(string, string)> enchantmentTranslation = new List<(string, string)>
            {
                ("Наполнение", "Превращает этот предмет в нечто значительно более сильное"),
                ("Негодующий", "При использовании призывает демонов, которые причиняют вам вред, но роняют при смерти лечащие предметы"),
                ("Горящий", "Поджигает врагов при попадании, но также наносит вам периодический урон, пока вы держите в руках этот предмет"),
                ("Жертвенный", "Снижает расход маны и значительно увеличивает урон, но иногда этот предмет использует ваше здоровье"),
                ("Злопамятный", "Урон снарядов меняется в зависимости от расстояние до цели. Чем дальше цель, тем больше урон. Этот эффект обратно пропорционален"),
                ("Жаждущий", "Урон снарядов меняется в зависимости от расстояние до цели. Чем ближе цель, тем больше урон. Этот эффект обратно пропорционален"),
                ("Эфемерный", "Урон этого оружия уменьшается при продолжительном использовании.\nУрон возвращается в норму со временем, пока оружие не используется. Изначальный урон оружия выше, чем обычно"),
                ("Адский", "Призванные миньоны живут 40 секунд.\nПо истечении этого времени, они взрываются со страшной силой\nМиньоны наносят больше урона, чем дольше живут, а также взрываются от бездействия"),
                ("Порченный", "Лишает предмет возможности стрелять снарядами. Взамен выпускает две скелетные руки, шинкующие врагов"),
                ("Предательский", "Заставляет предмет иногда выпускать монстра, который причиняет вам и врагам вред, когда у вас меньше 50% маны"),
                ("Иссушающий", "При ранении, вы восстанавливаете процент от полученного урона исходя из того, сколько накопленного урона вы нанесли до этого, вплоть до 100%.\nПосле этого вы увеличиваете свой урон, пока удерживаете этот предмет в руках, но также получаете увеличивающийся периодический урон, чем дольше его удерживаете"),
                ("Гонимый", "При ранении, или со временем рядом с вами появляются демонические порталы.\nЕсли они достаточно повреждены, они становятся дружественными, в противном случае нападают на вас. Монстры из демонического портала впадают в ярость, если портал повреждён"),
                ("Блудливый", "Призывает живучего серного монстра, который постоянно находится между вами и ваши курсором, и препятствует оружию с самонаводящимися снарядами.\nПри смерти он сбрасывает множество сердец")
            };
            
            Dictionary<int, BossHealthBarManager.BossEntityExtension> dictionary = new Dictionary<int, BossHealthBarManager.BossEntityExtension>
            {
                {13, new BossHealthBarManager.BossEntityExtension("Сегментов", 13, 14, 15)},
                {266, new BossHealthBarManager.BossEntityExtension("Ползунов", 267)},
                {35, new BossHealthBarManager.BossEntityExtension("Рук", 36)},
                {127, new BossHealthBarManager.BossEntityExtension("Оружий", 128, 129, 130, 131)},
                {395, new BossHealthBarManager.BossEntityExtension("Ружий", 393, 394)},
                {ModContent.NPCType<CeaselessVoid>(), new BossHealthBarManager.BossEntityExtension("Тёмной энергии", ModContent.NPCType<DarkEnergy>())},
                {ModContent.NPCType<RavagerBody>(), new BossHealthBarManager.BossEntityExtension("Частей тела", ModContent.NPCType<RavagerClawLeft>(), ModContent.NPCType<RavagerClawRight>(), ModContent.NPCType<RavagerLegLeft>(), ModContent.NPCType<RavagerLegRight>())},
                {ModContent.NPCType<SlimeGodCore>(), new BossHealthBarManager.BossEntityExtension("Больших слизней", ModContent.NPCType<SlimeGod>(), ModContent.NPCType<SlimeGodSplit>(), ModContent.NPCType<SlimeGodRun>(), ModContent.NPCType<SlimeGodRunSplit>())},
            
            };
            BossHealthBarManager.EntityExtensionHandler = dictionary;
            
            if (typeof(AstralArcanumUI).GetField("CircleNames", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null) is string[] circleNames)
            {
                circleNames[0] = "Ад";
                circleNames[1] = "Темница";
                circleNames[2] = "Джунгли";
                circleNames[3] = "Случайное место";
            }
            
            if (typeof(EnchantmentManager).GetProperty("EnchantmentList", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) is List<Enchantment> enchantmentList)
            {
                for (int i = 0; i < enchantmentList.Count; i++)
                {
                    Enchantment currentEnchantment = enchantmentList[i];
                    currentEnchantment.Name = enchantmentTranslation[i].Item1;
                    currentEnchantment.Description = enchantmentTranslation[i].Item2;
                    enchantmentList[i] = currentEnchantment;
                }
            }

            PropertyInfo enchantment = typeof(EnchantmentManager).GetProperty("ClearEnchantment", BindingFlags.Public | BindingFlags.Static);
            enchantment?.SetValue(typeof(Enchantment),  new Enchantment("Снять зачарование", string.Empty, -18591774, null, delegate(Item item)
            {
                item.Calamity().AppliedEnchantment = null;
                item.Calamity().DischargeEnchantExhaustion = 0f;
            }, item => item.IsEnchantable() && item.shoot >= ProjectileID.None));

            FieldInfo alphanumericCharacters = typeof(CalamityUtils).GetField("AlphanumericCharacters", BindingFlags.NonPublic | BindingFlags.Static);
            alphanumericCharacters?.SetValue(typeof(string), "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789");
        }
    }
}