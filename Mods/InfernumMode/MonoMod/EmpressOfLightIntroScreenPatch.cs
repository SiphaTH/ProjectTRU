using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BossIntroScreens;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class EmpressOfLightIntroScreenPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(EmpressOfLightIntroScreen).GetCachedMethod("get_TextToDisplay");

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Prismatic Fae\nThe Empress of Light", "ПРИЗМАТИЧЕСКАЯ ФЕЯ\nИМПЕРАТРИЦА СВЕТА");
    };
}