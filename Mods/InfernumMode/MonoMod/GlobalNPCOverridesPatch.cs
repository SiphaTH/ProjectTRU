using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.GlobalInstances;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class GlobalNPCOverridesPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(GlobalNPCOverrides).GetCachedMethod(nameof(GlobalNPCOverrides.OnKill));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A profaned shrine has erupted from the ashes at the underworld's edge!", "Осквернённое святилище вырывается из пепла на границе ада!");
    };
}