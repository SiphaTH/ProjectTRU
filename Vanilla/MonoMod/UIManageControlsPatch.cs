using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class UIManageControlsPatch : ILEdit
{
    public override bool Autoload() => TranslationHelper.IsRussianLanguage;

    public override void Load()
    {
        IL.Terraria.GameContent.UI.States.UIManageControls.OnInitialize += UIManageControlsOnOnInitialize;
    }
    
    public override void Unload()
    {
        IL.Terraria.GameContent.UI.States.UIManageControls.OnInitialize -= UIManageControlsOnOnInitialize;
    }

    private void UIManageControlsOnOnInitialize(ILContext il)
    {
        TranslationHelper.ModifyIL(il, 0f, 700f);
        TranslationHelper.ModifyIL(il, 600f, 700f);
    }
}