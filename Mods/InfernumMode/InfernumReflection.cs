using CalamityMod.Systems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class InfernumReflection : ContentTranslation
{
    public override bool IsTranslationEnabled => ModsCall.Calamity != null && ModsCall.Infernum != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;
    
    public override void LoadContent()
    {
        DifficultyModeSystem.Difficulties[4].Name = LangHelper.GetText("InfernumMode.DifficultyModeSystem.Difficulties.Infernum.Name");
        DifficultyModeSystem.Difficulties[4].ShortDescription = LangHelper.GetText("InfernumMode.DifficultyModeSystem.Difficulties.Infernum.ShortDescription");
        CalamityRuTranslate.Instance.BossIntroScreensFont = ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Fonts/BossIntroScreensFont", AssetRequestMode.ImmediateLoad).Value;
    }
}