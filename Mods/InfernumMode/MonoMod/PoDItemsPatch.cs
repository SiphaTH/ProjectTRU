using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class PoDItemsPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(PoDItems).GetCachedMethod("DoGTeleportDenialText");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "YOU CANNOT EVADE ME SO EASILY!", "ТЫ НЕ СМОЖЕШЬ ТАК ЛЕГКО ОТ МЕНЯ УСКОЛЬЗНУТЬ!");
        TranslationHelper.ModifyIL(il, "YOU CANNOT HOPE TO OUTSMART A MASTER OF DIMENSIONS!", "НЕ НАДЕЙСЯ ПЕРЕХИТРИТЬ МАСТЕРА ИЗМЕРЕНИЙ!");
        TranslationHelper.ModifyIL(il, "NOT SO FAST!", "НЕ ТАК БЫСТРО!");
    };
}