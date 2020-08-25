using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityRuTranslate
{
    [Label("Config")]
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        public override void OnLoaded()
        {
            CalamityRuTranslate.tRuConfig = this;
        }

        [Header("Шрифт")]
        [DefaultValue(true)]
        [Label("Шрифт Comic Sans MS")]
        [Tooltip("Если вам не нравится новый шрифт который предлагает русификатор\nи вы хотите играть со своим, вы можете его отключить\nТребуется перезагрузка мода")]
        [ReloadRequired]
        public bool NewRussianTerrariaFont { get; set; }

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
        {
            return true;
        }
    }
}