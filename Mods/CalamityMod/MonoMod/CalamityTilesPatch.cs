using System.Reflection;
using CalamityMod.Tiles.FurnitureAbyss;
using CalamityMod.Tiles.FurnitureAcidwood;
using CalamityMod.Tiles.FurnitureAncient;
using CalamityMod.Tiles.FurnitureAshen;
using CalamityMod.Tiles.FurnitureBotanic;
using CalamityMod.Tiles.FurnitureCosmilite;
using CalamityMod.Tiles.FurnitureEutrophic;
using CalamityMod.Tiles.FurnitureExo;
using CalamityMod.Tiles.FurnitureMonolith;
using CalamityMod.Tiles.FurnitureOtherworldly;
using CalamityMod.Tiles.FurniturePlaguedPlate;
using CalamityMod.Tiles.FurnitureProfaned;
using CalamityMod.Tiles.FurnitureSacrilegious;
using CalamityMod.Tiles.FurnitureSilva;
using CalamityMod.Tiles.FurnitureStatigel;
using CalamityMod.Tiles.FurnitureStratus;
using CalamityMod.Tiles.FurnitureVoid;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class AbyssSofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(AbyssSofa).GetCachedMethod(nameof(AbyssSofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class AcidwoodBenchTilePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(AcidwoodBenchTile).GetCachedMethod(nameof(AcidwoodBenchTile.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class AncientSofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(AncientSofa).GetCachedMethod(nameof(AncientSofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class AshenSofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(AshenSofa).GetCachedMethod(nameof(AshenSofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class BotanicBenchPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BotanicBench).GetCachedMethod(nameof(BotanicBench.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class CosmiliteSofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CosmiliteSofa).GetCachedMethod(nameof(CosmiliteSofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class EutrophicBenchPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(EutrophicBench).GetCachedMethod(nameof(EutrophicBench.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class ExoSofaTilePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ExoSofaTile).GetCachedMethod(nameof(ExoSofaTile.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class MonolithBenchPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(MonolithBench).GetCachedMethod(nameof(MonolithBench.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class OtherworldlySofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(OtherworldlySofa).GetCachedMethod(nameof(OtherworldlySofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class PlaguedPlateSofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(PlaguedPlateSofa).GetCachedMethod(nameof(PlaguedPlateSofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class ProfanedBenchPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ProfanedBench).GetCachedMethod(nameof(ProfanedBench.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class LargeRitualCandleTilePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(LargeRitualCandleTile).GetCachedMethod(nameof(LargeRitualCandleTile.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Large Ritual Candle", "Большая ритуальная свеча");
    };
}

public class RitualCandleTilePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(RitualCandleTile).GetCachedMethod(nameof(RitualCandleTile.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Ritual Candle", "Ритуальная свеча");
    };
}

public class SacrilegiousBenchTilePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(SacrilegiousBenchTile).GetCachedMethod(nameof(SacrilegiousBenchTile.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class SilvaBenchPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(SilvaBench).GetCachedMethod(nameof(SilvaBench.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class StatigelSofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(StatigelSofa).GetCachedMethod(nameof(StatigelSofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class StratusSofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(StratusSofa).GetCachedMethod(nameof(StratusSofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class VoidSofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(VoidSofa).GetCachedMethod(nameof(VoidSofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}

public class WulfrumSofaPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(global::CalamityMod.Tiles.FurnitureWulfrum.WulfrumSofa).GetCachedMethod(nameof(global::CalamityMod.Tiles.FurnitureWulfrum.WulfrumSofa.SetStaticDefaults));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Bench", "ItemName.Bench");
    };
}