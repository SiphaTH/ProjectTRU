using System;
using System.Collections.Generic;
using System.Linq;
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
    public virtual bool CheckModVersion => true;
    private readonly string _modNameException;
    private readonly ModVersionException.ExceptionType _outdatedType;
    private readonly GameCulture _russian = GameCulture.FromCultureName(GameCulture.CultureName.Russian);

    protected bool IsBuffsEndabled;
    protected bool IsItemsEnabled;
    protected bool IsNPCsEnabled;
    protected bool IsPrefixesEnabled;
    protected List<string> Projectiles;
    protected List<string> LocalizationKeys;
    protected List<TileData> Tiles;

    protected SetupTranslation()
    {
        IsBuffsEndabled = new();
        IsItemsEnabled = new();
        IsNPCsEnabled = new();
        IsPrefixesEnabled = new();
        Projectiles = new ();
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
            case "InfernumMode":
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
                if (CheckModVersion && modInstance.Version != ExpectedVersion)
                {
                    throw new ModVersionException(_modNameException, modInstance.Version, ExpectedVersion, _outdatedType);
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
        foreach (ModBuff buffs in ModLoader.GetMod(InternalName).GetContent<ModBuff>())
        {
            if (IsBuffsEndabled)
            {
                try
                {
                    if (ModContent.TryFind(InternalName, buffs.Name, out ModBuff buff))
                    {
                        buff.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Buffs.{buffs.Name}.Name"));
                        buff.Description.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Buffs.{buffs.Name}.Description"));
                    }
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.ModVersionException)
                        continue;
                    
                    throw new IdTypeException(buffs.Name, InternalName);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(buffs.Name);
                }
            }
        }
        
        string[] excludedItems = {"InstantResearch", "ForgorGift", "MasochistReal", "Astral", "Spatial", "Umbral", "DebugCompass", "DebugDisk", "DebugPosition", "DebugVNPreview", "TestDummySpawner"};
        foreach (ModItem items in ModLoader.GetMod(InternalName).GetContent<ModItem>().Where(x => !excludedItems.Contains(x.Name)))
        {
            if (IsItemsEnabled)
            {
                try
                {
                    if (ModContent.TryFind(InternalName, items.Name, out ModItem item))
                    {
                        item.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Items.{items.Name}.Name"));
                        item.Tooltip.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Items.{items.Name}.Tooltip"));
                    }
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.ModVersionException)
                        continue;
                    
                    throw new IdTypeException(items.Name, InternalName);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(items.Name);
                }
            }
        }

        foreach (ModNPC npcs in ModLoader.GetMod(InternalName).GetContent<ModNPC>())
        {
            if (IsNPCsEnabled)
            {
                try
                {
                    if (ModContent.TryFind(InternalName, npcs.Name, out ModNPC npc))
                    {
                        npc.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.NPCs.{npcs.Name}.Name"));
                    }
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.ModVersionException)
                        continue;

                    throw new IdTypeException(npcs.Name, InternalName);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(npcs.Name);
                }
            }
        }
        
        string[] excludedPrefixes = {"RogueAccessoryPrefix", "RogueWeaponPrefix"};
        foreach (ModPrefix prefixes in ModLoader.GetMod(InternalName).GetContent<ModPrefix>().Where(x => !excludedPrefixes.Contains(x.Name)))
        {
            if (IsPrefixesEnabled)
            {
                try
                {
                    if (ModContent.TryFind(InternalName, prefixes.Name, out ModPrefix prefix))
                    {
                        prefix.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Prefixes.{prefixes.Name}.Name"));
                    }
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.ModVersionException)
                        continue;
                    
                    throw new IdTypeException(prefixes.Name, InternalName);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(prefixes.Name);
                }
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
                if (!TRuConfig.Instance.ModVersionException && !Projectiles.Contains(id))
                    continue;
    
                if (TRuConfig.Instance.ModVersionException)
                    throw new IdTypeException(id, InternalName);
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

                    if (tileData.ContainerName)
                    {
                        tile.ContainerName.AddTranslation(_russian, LangHelper.GetText($"{InternalName}.Tiles.{tileData.TranslationKey}.Container.Name"));
                    }
                }
            }
            catch (NullReferenceException)
            {
                if (!TRuConfig.Instance.ModVersionException && !Tiles.Contains(tileData))
                    continue;
        
                if (TRuConfig.Instance.ModVersionException)
                    throw new IdTypeException(tileData.Id, InternalName);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyTypeException(tileData.Id);
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