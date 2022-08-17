using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityRuTranslate;

[Label("Конфигурация")]
public class TRuConfig : ModConfig
{
    public static TRuConfig Instance;
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [Header("Шрифт")]
    [Label("Шрифт JetBrains Mono")]
    [Tooltip("Если вам не нравится новый шрифт, который применяет русификатор\nи вы хотите играть со своим, вы можете его отключить.")]
    [DefaultValue(true)]
    [ReloadRequired]
    public bool NewRussianTerrariaFont;
        
    [Header("Прочее")]

    [Label("Сообщение об ошибке")]
    [Tooltip("Показывает сообщение об ошибке если версия переводимого мода не соответствует русификатору.\nИспользульте на свой страх и риск. Разработчики русификатора не гарантируют стабильную работу.")]
    [DefaultValue(true)]
    [ReloadRequired]
    public bool ModVersionException;

    [Label("Цветной тип урона")]
    [Tooltip("Если вам не нравится цветные типы урона на оружиях, вы можете их отключить.")]
    [DefaultValue(true)]
    public bool ColoredDamageTypes;
        
    [Label("Описание механики скрытности Каламити")]
    [Tooltip("Показывает текст бонуса скрытности на комплектах брони разбойника.")]
    [DefaultValue(true)]
    public bool CalamityArmorStealthDescription;
        
    [Label("Предварительный просмотр бонуса комплекта брони")]
    [Tooltip("Показывает бонус комплекта брони на шлемах при зажатой клавише.")]
    [DefaultValue(true)]
    public bool PreviewArmorSetBonus;
    
    [Label("Wikipedia предметов")]
    [Tooltip("Для работы требуется мод Wikithis\nПозволяет быстро перейти из игры на статью предмета в русской вики\nПлохо работает с ванильными предметами.")]
    [DefaultValue(true)]
    [ReloadRequired]
    public bool WikithisInfo;
}