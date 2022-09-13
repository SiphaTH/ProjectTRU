using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Fargowiltas.UI;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas;

[JITWhenModsEnabled("Fargowitlas")]
public class FargowiltasReflection : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => !Main.dedServ && ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;
    
    public void LoadContent()
    {
        StatButton statButton = global::Fargowiltas.Fargowiltas.UserInterfaceManager.StatButton;
        StatSheetUI statSheet = global::Fargowiltas.Fargowiltas.UserInterfaceManager.StatSheet;
        const float backWidth = 840f;

        statButton.IconHighlight.Text = "Таблица характеристик";
        statSheet.BackPanel.Width.Set(backWidth, 0f);
        statSheet.InnerPanel.Width.Set(backWidth - 12f, 0f);
    }

    public void UnloadContent() { }
}