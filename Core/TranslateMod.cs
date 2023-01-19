using System;
using System.Collections.Generic;
using CalamityRuTranslate.Common.DataStructures;
using CalamityRuTranslate.Common.Exceptions;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core;

public abstract class TranslateMod : ILoadable
{
    public abstract string InternalModName { get; }
    public abstract Version ExpectedVersion { get; }
    public virtual bool ShouldCheckModVersion => true;
    
    protected bool IsBuffsEnabled;
    protected bool IsItemsEnabled;
    protected bool IsNPCsEnabled;
    protected bool IsPrefixesEnabled;
    protected List<string> Projectiles;
    protected List<TileData> Tiles;
    
    private readonly string _modNameException;
    private readonly ModVersionException.ExceptionType _outdatedType;

    public TranslateMod()
    {
        IsBuffsEnabled = new();
        IsItemsEnabled = new();
        IsNPCsEnabled = new();
        IsPrefixesEnabled = new();
        Projectiles = new ();
        Tiles = new();

        switch (InternalModName)
        {
            case "CalamityMod":
                _modNameException = "Calamity Mod";
                _outdatedType = ModVersionException.ExceptionType.OutdatedCalamity;
                break;
            case "ThoriumMod":
                _modNameException = "Thorium Mod";
                _outdatedType = ModVersionException.ExceptionType.OutdatedThorium;
                break;
            case "Fargowiltas":
                _modNameException = "Fargo's Mutant Mod";
                _outdatedType = ModVersionException.ExceptionType.OutdatedFargowiltas;
                break;
            case "FargowiltasSouls":
                _modNameException = "Fargo's Souls Mod";
                _outdatedType = ModVersionException.ExceptionType.OutdatedFargowiltasSouls;
                break;
            case "StarsAbove":
                _modNameException = "The Stars Above";
                _outdatedType = ModVersionException.ExceptionType.OutdatedStarsAbove;
                break;
            case "InfernumMode":
                _modNameException = "Calamity Mod Infernum Mode";
                _outdatedType = ModVersionException.ExceptionType.OutdatedInfernumMode;
                break;
            default:
                throw new ArgumentException(nameof(InternalModName));
        }
    }
    
    public void Load(Mod mod)
    {
        if (!TranslationHelper.IsRussianLanguage)
            return;
        
        if (ModLoader.TryGetMod(InternalModName, out Mod modInstance) && modInstance.Version != ExpectedVersion && ShouldCheckModVersion)
            throw new ModVersionException(_modNameException, modInstance.Version, ExpectedVersion, _outdatedType);
    }

    public void LoadTranslate()
    {
        if (!TranslationHelper.IsRussianLanguage)
            return;
        
        if (ModLoader.TryGetMod(InternalModName, out Mod modInstance) && modInstance != null)
        {
            TranslateManager translateManager = new TranslateManager(InternalModName, IsItemsEnabled,
                IsBuffsEnabled, IsNPCsEnabled, IsPrefixesEnabled, Projectiles, Tiles);
            translateManager.TranslateBuffs();
            translateManager.TranslateItems();
            translateManager.TranslatePrefixes();
            translateManager.TranslateNPCs();
            translateManager.TranslateProjectiles();
            translateManager.TranslateTiles();
        }
    }

    public void Unload()
    {
    }
}