using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using IL.Terraria.GameContent.UI.States;
using MonoMod.Cil;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class UIManageControlsPatch : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;
    
    public void LoadContent() => UIManageControls.OnInitialize += UIManageControlsOnOnInitialize;

    public void UnloadContent() => UIManageControls.OnInitialize -= UIManageControlsOnOnInitialize;

    private void UIManageControlsOnOnInitialize(ILContext il)
    {
        TranslationHelper.ModifyIL(il, 0f, 700f);
        TranslationHelper.ModifyIL(il, 600f, 700f);
    }
}