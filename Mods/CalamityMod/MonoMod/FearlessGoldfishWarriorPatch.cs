using System.Reflection;
using CalamityMod.NPCs.NormalNPCs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class FearlessGoldfishWarriorPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(FearlessGoldfishWarrior).GetCachedMethod(nameof(FearlessGoldfishWarrior.ModifyHitPlayer));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " was once again impaled by Goldfish.", " был снова проткнут Золотой рыбкой.");
    };
}