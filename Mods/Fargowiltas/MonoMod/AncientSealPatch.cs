using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.Mutant;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

[JITWhenModsEnabled("Fargowiltas")]
public class AncientSealShoot : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(AncientSeal).GetCachedMethod(nameof(AncientSeal.Shoot));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Every boss has awoken!", "Все боссы пробуждаются!");
        TranslationHelper.ModifyIL(il, "Every boss has awoken!", "Все боссы пробуждаются!", 2);
    };
}

[JITWhenModsEnabled("Fargowiltas")]
public class AncientSealSpawnBoss : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(AncientSeal).GetCachedMethod(nameof(AncientSeal.SpawnBoss));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " has awoken!", " пробуждается!");
    };
}