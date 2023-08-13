using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityRuTranslate;

public class TRuConfig : ModConfig
{
    public static TRuConfig Instance;
    
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [Header("Font")]

    [DefaultValue(true)]
    [ReloadRequired]
    public bool NewRussianTerrariaFont;
        
    [Header("Other")]

    [DefaultValue(true)]
    public bool ColoredDamageTypes;

    [DefaultValue(true)]
    public bool PreviewArmorSetBonus;

    [DefaultValue(true)]
    [ReloadRequired]
    public bool WikithisInfo;

    [DefaultValue(false)]
    [ReloadRequired]
    public bool RandomDeathText;
}