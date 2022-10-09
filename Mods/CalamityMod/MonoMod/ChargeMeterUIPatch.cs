using System.Reflection;
using CalamityMod.UI.DraedonsArsenal;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class ChargeMeterUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(ChargeMeterUI).GetCachedMethod(nameof(ChargeMeterUI.Draw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Current Charge: ", "Текущий заряд: ");
    };
}