using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using FargowiltasSouls.UI;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

[JITWhenModsEnabled("FargowitlasSouls")]
public class FargowiltasSoulsReflection : ContentTranslation
{
    public override bool IsTranslationEnabled => !Main.dedServ && ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;

    public override void LoadContent()
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
        soulToggler.SomeEffectsButton.Text = "Предустановленные настройки некоторых эффектов";
    }
}