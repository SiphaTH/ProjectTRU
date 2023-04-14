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

    [Label("Цветной тип урона")]
    [Tooltip("Если вам не нравится цветные типы урона на оружиях, вы можете их отключить.")]
    [DefaultValue(true)]
    public bool ColoredDamageTypes;

    [Label("Предварительный просмотр бонуса комплекта брони")]
    [Tooltip("Показывает бонус комплекта брони на шлемах при удержании клавиши.")]
    [DefaultValue(true)]
    public bool PreviewArmorSetBonus;
    
    [Label("Wikipedia предметов")]
    [Tooltip("Для работы требуется мод Wikithis\nПозволяет быстро перейти из игры на статью предмета в русской вики.")]
    [DefaultValue(true)]
    [ReloadRequired]
    public bool WikithisInfo;
    
    [Label("Забавные фразы смерти")]
    [Tooltip("Добавляет несколько новых забавных фраз смерти, когда игрок умирает.")]
    [DefaultValue(false)]
    [ReloadRequired]
    public bool RandomDeathText;
}