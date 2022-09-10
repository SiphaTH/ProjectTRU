using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class PoDPlayerPreKill : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(PoDPlayer).GetCachedMethod(nameof(PoDPlayer.PreKill));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " could not withstand the red lightning.", " не выдерживает красной молнии.");
        TranslationHelper.ModifyIL(il, " was incinerated by ungodly fire.", " сгорает осквернённым огнём.");
        TranslationHelper.ModifyIL(il, " went mad.", " сходит с ума. ");
    };
}

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class PoDPlayerPostUpdateMiscEffects : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(PoDPlayer).GetCachedMethod(nameof(PoDPlayer.PostUpdateMiscEffects));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Infernum is not allowed in Master Mode, For the Worthy, or Eternity Mode", "Инфернум недоступен с режимами Мастера из стандартной игры, Вечности из Fargo и с генерацией мира «Для достойных»");
    };
}