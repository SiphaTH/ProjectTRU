using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using FargowiltasSouls.Content.UI;
using FargowiltasSouls.Content.UI.Elements;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsReflection : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return !Main.dedServ && ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        const float backWidth = 540f;
        SoulToggler soulToggler = FargoUIManager.SoulToggler;
        soulToggler.BackPanel.Width.Set(backWidth, 0f);
        soulToggler.InnerPanel.Width.Set(backWidth - 12f, 0f);
        soulToggler.Scrollbar.Left.Set(soulToggler.InnerPanel.Width.Pixels - soulToggler.Scrollbar.Width.Pixels - 18f, 0f);
        soulToggler.PresetPanel.Width.Set(backWidth - 10f, 0f);
        soulToggler.ToggleList.Width.Set(soulToggler.InnerPanel.Width.Pixels - soulToggler.InnerPanel.PaddingLeft * 2f - soulToggler.Scrollbar.Width.Pixels, 0f);
        soulToggler.OffButton.Text = "Выключить все эффекты";
        soulToggler.OnButton.Text = "Включить все эффекты";
        soulToggler.MinimalButton.Text = "Предустановленные настройки минимума эффектов";
        soulToggler.SomeEffectsButton.Text = "Предустановленные настройки некоторых эффектов";
        soulToggler.SearchBar.HintText = "Поиск...";
        soulToggler.CustomButton[0].Text = "Пользовательский набор 1 (ПКМ, чтобы сохранить)";
        soulToggler.CustomButton[1].Text = "Пользовательский набор 2 (ПКМ, чтобы сохранить)";
        soulToggler.CustomButton[2].Text = "Пользовательский набор 3 (ПКМ, чтобы сохранить)";
    }

    public void Unload()
    {
    }
}