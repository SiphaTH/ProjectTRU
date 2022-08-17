using FargowiltasSouls.UI;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

[JITWhenModsEnabled("FargowitlasSouls")]
internal static class FargowiltasSoulsReflection
{
    internal static void Load()
    {
        const float backWidth = 540f;
        SoulToggler soulToggler = global::FargowiltasSouls.FargowiltasSouls.UserInterfaceManager.SoulToggler;
        SoulTogglerButton soulTogglerButton = global::FargowiltasSouls.FargowiltasSouls.UserInterfaceManager.SoulTogglerButton;
        
        soulTogglerButton.OncomingMutant.TextEMode = "Включён режим Вечности";
        soulTogglerButton.OncomingMutant.TextMaso = "Включён режим Мазохиста";
        
        soulToggler.BackPanel.Width.Set(backWidth, 0f);
        soulToggler.InnerPanel.Width.Set(backWidth - 12f, 0f);
        soulToggler.Scrollbar.Left.Set(soulToggler.InnerPanel.Width.Pixels - soulToggler.Scrollbar.Width.Pixels - 18f, 0f);
        soulToggler.PresetPanel.Width.Set(backWidth - 10f, 0f);
        soulToggler.ToggleList.Width.Set(soulToggler.InnerPanel.Width.Pixels - soulToggler.InnerPanel.PaddingLeft * 2f - soulToggler.Scrollbar.Width.Pixels, 0f);
        soulToggler.OffButton.Text = "Выключить все эффекты";
        soulToggler.OnButton.Text = "Включить все эффекты";
        soulToggler.MinimalButton.Text = "Предустановленные настройки минимума эффектов";
    }
}