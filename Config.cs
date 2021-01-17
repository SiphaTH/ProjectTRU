using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityRuTranslate
{
    [Label("Config")]
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override void OnLoaded() => CalamityRuTranslate.Config = this;

        [Header("$Mods.CalamityRuTranslate.Config.Header.Font")]
        
        [Label("$Mods.CalamityRuTranslate.Config.Label.Font")]
        [Tooltip("$Mods.CalamityRuTranslate.Config.Tooltip.Font")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool NewTerrariaFont { get; set; }
        
        [Header("$Mods.CalamityRuTranslate.Config.Header.Mods")]
        
        [Label("Calamity")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool CalamityTranslation { get; set; }
        
        [Label("Thorium")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool ThoriumTranslation { get; set; }
        
        [Label("$Mods.CalamityRuTranslate.Config.Label.Vanilla")]
        [Tooltip("$Mods.CalamityRuTranslate.Config.Tooltip.Vanilla")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool NewVanillaTranslation { get; set; }
        
        [Header("$Mods.CalamityRuTranslate.Config.Header.Stealth")]
        
        [Label("$Mods.CalamityRuTranslate.Config.Label.Stealth")]
        [Tooltip("$Mods.CalamityRuTranslate.Config.Tooltip.Stealth")]
        [DefaultValue(true)]
        public bool CalamityStealth { get; set; }
        
        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message) => true;
    }
}