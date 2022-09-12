using System.Reflection;
using CalamityMod.Items.Weapons.Ranged;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class BloodBoilerPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(BloodBoiler).GetCachedMethod(nameof(BloodBoiler.Shoot));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " suffered from severe anemia.", " страдал тяжёлой анемией.");
        TranslationHelper.ModifyIL(il, " was unable to obtain a blood transfusion.", " не удалось добиться переливания крови.");
    };
}