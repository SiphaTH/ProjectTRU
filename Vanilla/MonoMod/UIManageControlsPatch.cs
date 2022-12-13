using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;
using Terraria.UI;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class UIManageControlsPatch : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;
    
    public void LoadContent()
    {
        Main.ManageControlsMenu.RemoveAllChildren();
        Main.ManageControlsMenu.Initialize();
        UIElement outerContainer = Main.ManageControlsMenu.GetType().GetField("_outerContainer", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(Main.ManageControlsMenu) as UIElement;
        outerContainer?.Width.Set(700f, 0.8f);
        outerContainer?.MaxWidth.Set(700f, 0f);
    }

    public void UnloadContent()
    {
        UIElement outerContainer = Main.ManageControlsMenu.GetType().GetField("_outerContainer", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(Main.ManageControlsMenu) as UIElement;
        outerContainer?.Width.Set(600f, 0.8f);
        outerContainer?.MaxWidth.Set(600f, 0f);
    }
}