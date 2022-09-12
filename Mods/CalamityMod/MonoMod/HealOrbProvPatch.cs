using System.Reflection;
using CalamityMod.Projectiles.Boss;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;

using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class HealOrbProvPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(HealOrbProv).GetCachedMethod(nameof(HealOrbProv.AI));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " burst into sinless ash.", " превратился в безгрешный пепел.");
    };
}