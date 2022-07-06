using System.Reflection;
using CalamityMod.Tiles.FurniturePlaguedPlate;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class PlaguedPlateBedPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(PlaguedPlateBed).GetCachedMethod(nameof(PlaguedPlateBed.RightClick));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Spawn point removed!", "Точка воскрешения удалена!");
        TranslationHelper.ModifyIL(il, "Spawn point set!", "Точка воскрешения задана!");
    };
}