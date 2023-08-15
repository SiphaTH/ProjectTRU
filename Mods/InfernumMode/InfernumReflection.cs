using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using InfernumMode.Content.Credits;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumReflection : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && ModsCall.Infernum != null && TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        CalamityRuTranslate.Instance.BossIntroScreensFont = ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Fonts/BossIntroScreensFont", AssetRequestMode.ImmediateLoad).Value;

        string[] headers = typeof(CreditManager).GetFieldValue<string[]>("Headers");
        headers[0] = "Программисты";
        headers[1] = "Музыкант";
        headers[2] = "Художники";
        headers[3] = "Тестировщики";
        headers[4] = "Тестировщики";
        headers[5] = "Тестировщики";
        headers[6] = "Тестировщики";
    }

    public void Unload()
    {
    }
}