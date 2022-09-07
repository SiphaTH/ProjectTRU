using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BossIntroScreens;
using MonoMod.RuntimeDetour.HookGen;
using ReLogic.Graphics;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class InfernumReflectionPatch : ILEdit
{
    private MethodInfo _fontToUse => typeof(BaseIntroScreen).GetCachedMethod("get_FontToUse");

    private delegate DynamicSpriteFont orig_FontToUse();
    private delegate DynamicSpriteFont hook_FontToUse(orig_FontToUse orig);

    private event hook_FontToUse OnFontToUse
    {
        add => HookEndpointManager.Add<hook_FontToUse>(_fontToUse, value);
        remove => HookEndpointManager.Remove<hook_FontToUse>(_fontToUse, value);
    }
    
    public override bool Autoload() => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override void Load()
    {
        OnFontToUse += OnOnFontToUse;
    }
    
    public override void Unload()
    {
        OnFontToUse -= OnOnFontToUse;
    }
    
    private DynamicSpriteFont OnOnFontToUse(orig_FontToUse orig)
    {
        return CalamityRuTranslate.Instance.BossIntroScreensFont;
    }
}