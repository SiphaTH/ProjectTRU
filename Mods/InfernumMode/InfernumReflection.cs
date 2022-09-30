using CalamityMod.Systems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumReflection : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => ModsCall.Calamity != null && ModsCall.Infernum != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;
    
    public void LoadContent()
    {
        DifficultyModeSystem.Difficulties[4].Name = LangHelper.GetText("InfernumMode.DifficultyModeSystem.Difficulties.Infernum.Name");
        DifficultyModeSystem.Difficulties[4].ShortDescription = LangHelper.GetText("InfernumMode.DifficultyModeSystem.Difficulties.Infernum.ShortDescription");
        CalamityRuTranslate.Instance.BossIntroScreensFont = ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Fonts/BossIntroScreensFont", AssetRequestMode.ImmediateLoad).Value;
    }

    public void UnloadContent() { }
}