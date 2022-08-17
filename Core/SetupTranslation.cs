using System;
using System.Collections.Generic;
using CalamityRuTranslate.Common.DataStructures;
using CalamityRuTranslate.Common.Exceptions;
using CalamityRuTranslate.Common.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core;

public abstract class SetupTranslation : IModSetup
{
    public abstract string InternalName { get; }
    public abstract Version ExpectedVersion { get; }
    private readonly string _modNameException;
    private readonly ModVersionException.ExceptionType _outdatedType;
    private readonly GameCulture _russian = GameCulture.FromCultureName(GameCulture.CultureName.Russian);

    protected List<string> Buffs;
    protected List<string> Items;
    protected List<string> NPCs;
    protected List<string> Containers;
    protected List<string> Projectiles;
    protected List<string> Prefixes;
    protected List<string> LocalizationKeys;
    protected List<TileData> Tiles;

    public SetupTranslation()
    {
        Buffs = new();
        Items = new();
        NPCs = new();
        Containers = new();
        Projectiles = new ();
        Prefixes = new();
        LocalizationKeys = new();
        Tiles = new();

        switch (InternalName)
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
            default:
                throw new ArgumentException(nameof(InternalName));
        }
    }
    
    public void Load(Mod mod)
    {
        if (TRuConfig.Instance.ModVersionException)
        {
            if (ModLoader.TryGetMod(InternalName, out Mod modInstance))
            {
                if (modInstance.Version != ExpectedVersion)
                {
                    throw new ModVersionException(_modNameException, modInstance.Version, ExpectedVersion,
                        _outdatedType);
                }
            }
        }
    }

    public void LoadSetupContentTranslation()
    {
        if (ModLoader.TryGetMod(InternalName, out Mod modInstance) && TranslationHelper.IsRussianLanguage)
        {
            if (modInstance != null)
            {
                PostSetupContentTranslation();
            }
        }
    }

    private void PostSetupContentTranslation()
    {
        foreach (string id in Buffs)
        {
            try
            {
                if (ModContent.TryFind(InternalName, id, out ModBuff buff))
                {
                    buff.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Buffs.{id}.Name"));
                    buff.Description.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Buffs.{id}.Description"));
                }
            }
            catch (NullReferenceException)
            {
                if (!TRuConfig.Instance.ModVersionException && !Buffs.Contains(id))
                    continue;
        
                if (TRuConfig.Instance.ModVersionException)
                    throw new IdTypeException(id);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyTypeException(id);
            }
        }
        
        foreach (string id in Items)
        {
            try
            {
                if (ModContent.TryFind(InternalName, id, out ModItem item))
                {
                    item.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Items.{id}.Name"));
                    item.Tooltip.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Items.{id}.Tooltip"));
                }
            }
            catch (NullReferenceException)
            {
                if (!TRuConfig.Instance.ModVersionException && !Items.Contains(id))
                    continue;
                    
                if (TRuConfig.Instance.ModVersionException)
                    throw new IdTypeException(id);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyTypeException(id);
            }
        }

        foreach (string id in NPCs)
        {
            try
            {
                if (ModContent.TryFind(InternalName, id, out ModNPC npc))
                {
                    npc.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.NPCs.{id}.Name"));
                }
            }
            catch (NullReferenceException)
            {
                if (!TRuConfig.Instance.ModVersionException && !NPCs.Contains(id))
                    continue;
    
                if (TRuConfig.Instance.ModVersionException)
                    throw new IdTypeException(id);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyTypeException(id);
            }
        }
        
        foreach (string id in Projectiles)
        {
            try
            {
                if (ModContent.TryFind(InternalName, id, out ModProjectile projectile))
                {
                    projectile.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Projectiles.{id}.Name"));
                }
            }
            catch (NullReferenceException)
            {
                if (!TRuConfig.Instance.ModVersionException && !NPCs.Contains(id))
                    continue;
    
                if (TRuConfig.Instance.ModVersionException)
                    throw new IdTypeException(id);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyTypeException(id);
            }
        }
        
        foreach (TileData tileData in Tiles)
        {
            try
            {
                if (ModContent.TryFind(InternalName, tileData.Id, out ModTile tile))
                {
                    ModTranslation modTranslation = tile.CreateMapEntryName(tileData.MapEntryName);
                    modTranslation.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Tiles.{tileData.TranslationKey}.Name"));
                    tile.AddMapEntry(tileData.Color, modTranslation);
                }
            }
            catch (NullReferenceException)
            {
                if (!TRuConfig.Instance.ModVersionException && !Tiles.Contains(tileData))
                    continue;
        
                if (TRuConfig.Instance.ModVersionException)
                    throw new IdTypeException(tileData.Id);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyTypeException(tileData.Id);
            }
        }
        
        foreach (string id in Containers)
        {
            try
            {
                if (ModContent.TryFind(InternalName, id, out ModTile tile))
                {
                    tile.ContainerName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Tiles.{id}.Container.Name"));
                }
            }
            catch (NullReferenceException)
            {
                if (!TRuConfig.Instance.ModVersionException && !Containers.Contains(id))
                    continue;
                    
                if (TRuConfig.Instance.ModVersionException)
                    throw new IdTypeException(id);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyTypeException(id);
            }
        }
        
        foreach (string id in Prefixes)
        {
            try
            {
                if (ModContent.TryFind(InternalName, id, out ModPrefix prefix))
                {
                    prefix.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Prefixes.{id}.Name"));
                }
            }
            catch (NullReferenceException)
            {
                if (!TRuConfig.Instance.ModVersionException && !Prefixes.Contains(id))
                    continue;
                    
                if (TRuConfig.Instance.ModVersionException)
                    throw new IdTypeException(id);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyTypeException(id);
            }
        }
        
        foreach (string id in LocalizationKeys)
        {
            ModTranslation modTranslation = LocalizationLoader.CreateTranslation(ModLoader.GetMod(InternalName), id);
            modTranslation.SetDefault(LangHelper.GetText($"{InternalName}.LocalizationKeys.{id}"));
            LocalizationLoader.AddTranslation(modTranslation);
        }
    }

    public void Unload()
    {
    }
}