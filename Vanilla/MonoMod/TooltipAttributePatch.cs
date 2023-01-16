using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria.ModLoader.Config;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class TooltipAttributePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(TooltipAttribute).GetCachedMethod("get_Tooltip");

    private delegate string TooltipDelegate(TooltipAttribute self);

    public override Delegate Delegate => Translation;
    
    private string Translation(TooltipDelegate orig, TooltipAttribute self)
    {
        string header = self.GetType().GetField("tooltip", (BindingFlags)60)?.GetValue(self) as string;
        
        return header switch
        {
            "Enables boss introduction animations. They only activate when Infernum Mode is active." => "",
            "Determines whether the pet from the Blasted Tophat should display its tips in chat or not." => "",
            "Enables reduced graphics mode. Useful if performance is low." => "",
            "How intense color saturation bloom effects should be. Such effects are disabled when this value is zero." => "",
            _ => orig.Invoke(self)
        };
    }
}