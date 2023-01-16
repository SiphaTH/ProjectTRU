using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria.ModLoader.Config;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class LabelAttributePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(LabelAttribute).GetCachedMethod("get_Label");

    private delegate string LabelDelegate(LabelAttribute self);

    public override Delegate Delegate => Translation;
    
    private string Translation(LabelDelegate orig, LabelAttribute self)
    {
        string header = self.GetType().GetField("label", (BindingFlags)60)?.GetValue(self) as string;
        
        return header switch
        {
            "Boss Introduction Animations" => "Вступительная анимация босса",
            "Blasted Tophat Tips in Chat" => "Советы в чате проклятого цилиндра",
            "Reduced Graphical Settings" => "Сниженные графические настройки",
            "Saturation Bloom Intensity" => "Интенсивность насыщенности свечения",
            _ => orig.Invoke(self)
        };
    }
}