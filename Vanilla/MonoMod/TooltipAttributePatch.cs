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
        string tooltip = self.GetType().GetField("tooltip", (BindingFlags)60)?.GetValue(self) as string;
        
        return tooltip switch
        {
            "Enables boss introduction animations. They only activate when Infernum Mode is active." => "Включает вступительную анимацию босса. Она активируются только когда включёна сложность Инфернум.",
            "Determines whether the pet from the Blasted Tophat should display its tips in chat or not." => "Отвечает за то, должен ли питомец проклятого цилиндра отображать свои подсказки в чате или нет.",
            "Enables reduced graphics mode. Useful if performance is low." => "Включает режим сниженной графики. Полезно при низкой производительности.",
            "How intense color saturation bloom effects should be. Such effects are disabled when this value is zero." => "Насколько интенсивными должны быть эффекты насыщенности свечения. Такие эффекты отключаются, когда эта настройка равняется нулю.",
            _ => orig.Invoke(self)
        };
    }
}