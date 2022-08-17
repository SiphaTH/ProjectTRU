using Fargowiltas.UI;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas;

[JITWhenModsEnabled("Fargowitlas")]
internal static class FargowiltasReflection
{
    internal static void Load()
    {
        StatButton statButton = global::Fargowiltas.Fargowiltas.UserInterfaceManager.StatButton;
        StatSheetUI statSheet = global::Fargowiltas.Fargowiltas.UserInterfaceManager.StatSheet;
        const float backWidth = 840f;

        statButton.IconHighlight.Text = "Таблица характеристик";
        statSheet.BackPanel.Width.Set(backWidth, 0f);
        statSheet.InnerPanel.Width.Set(backWidth - 12f, 0f);
    }
}