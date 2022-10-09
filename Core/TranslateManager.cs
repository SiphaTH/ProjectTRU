using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.DataStructures;
using CalamityRuTranslate.Common.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core;

public class TranslateManager
{
    private readonly string _internalModName;
    private readonly bool _isItemsEnabled;
    private readonly bool _isBuffsEnabled;
    private readonly bool _isNPCsEnabled;
    private readonly bool _isPrefixesEnabled;
    private readonly List<string> _projectilesList;
    private readonly List<TileData> _tilesList;
    private readonly GameCulture _russian = GameCulture.FromCultureName(GameCulture.CultureName.Russian);

    public TranslateManager(string internalModName, bool isItemsEnabled, bool isBuffsEnabled, bool isNPCsEnabled, bool isPrefixesEnabled, List<string> projectilesList, List<TileData> tilesList)
    {
        _internalModName = internalModName;
        _isItemsEnabled = isItemsEnabled;
        _isBuffsEnabled = isBuffsEnabled;
        _isNPCsEnabled = isNPCsEnabled;
        _isPrefixesEnabled = isPrefixesEnabled;
        _projectilesList = projectilesList;
        _tilesList = tilesList;
    }

    public void TranslateBuffs()
    {
        if (!_isBuffsEnabled)
            return;
        
        foreach (ModBuff modBuff in ModLoader.GetMod(_internalModName).GetContent<ModBuff>())
        {
            if (ModContent.TryFind(_internalModName, modBuff.Name, out ModBuff buff))
            {
                buff.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{_internalModName}.Buffs.{modBuff.Name}.Name"));
                buff.Description.AddTranslation(_russian, LangHelper.GetText($"{_internalModName}.Buffs.{modBuff.Name}.Description"));
            }
        }
    }

    public void TranslateItems()
    {
        if (!_isItemsEnabled)
            return;
        
        string[] excludedItemsFromMods = {"InstantResearch", "ForgorGift", "MasochistReal", "Astral", "Spatial", "Umbral", "DebugCompass", "DebugDisk", "DebugPosition", "DebugVNPreview", "TestDummySpawner", "RogueWeapon"};
        
        foreach (ModItem modItem in ModLoader.GetMod(_internalModName).GetContent<ModItem>().Where(x => !excludedItemsFromMods.Contains(x.Name)))
        {
            if (ModContent.TryFind(_internalModName, modItem.Name, out ModItem item))
            {
                item.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{_internalModName}.Items.{modItem.Name}.Name"));
                item.Tooltip.AddTranslation(_russian, LangHelper.GetText($"{_internalModName}.Items.{modItem.Name}.Tooltip"));
            }
        }
    }

    public void TranslateNPCs()
    {
        if (!_isNPCsEnabled)
            return;
        
        foreach (ModNPC modNPC in ModLoader.GetMod(_internalModName).GetContent<ModNPC>())
        {
            if (ModContent.TryFind(_internalModName, modNPC.Name, out ModNPC npc))
            {
                npc.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{_internalModName}.NPCs.{modNPC.Name}.Name"));
            }
        }
    }

    public void TranslatePrefixes()
    {
        if (!_isPrefixesEnabled)
            return;
        
        string[] excludedPrefixesFromMods = {"RogueAccessoryPrefix", "RogueWeaponPrefix"};
        
        foreach (ModPrefix modPrefix in ModLoader.GetMod(_internalModName).GetContent<ModPrefix>().Where(x => !excludedPrefixesFromMods.Contains(x.Name)))
        {
            if (ModContent.TryFind(_internalModName, modPrefix.Name, out ModPrefix prefix))
            {
                prefix.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{_internalModName}.Prefixes.{modPrefix.Name}.Name"));
            }
        }
    }

    public void TranslateProjectiles()
    {
        if (_projectilesList.Count == 0)
            return;
        
        foreach (string id in _projectilesList)
        {
            if (ModContent.TryFind(_internalModName, id, out ModProjectile projectile))
            {
                projectile.DisplayName.AddTranslation(_russian, LangHelper.GetText($"{_internalModName}.Projectiles.{id}.Name"));
            }
        }
    }

    public void TranslateTiles()
    {
        if (_tilesList.Count == 0)
            return;
        
        foreach (TileData tileData in _tilesList)
        {
            if (ModContent.TryFind(_internalModName, tileData.Id, out ModTile tile))
            {
                ModTranslation modTranslation = tile.CreateMapEntryName(tileData.MapEntryName);
                modTranslation.AddTranslation(_russian, LangHelper.GetText($"{_internalModName}.Tiles.{tileData.TranslationKey}.Name"));
                tile.AddMapEntry(tileData.Color, modTranslation);

                if (tileData.HasContainerName)
                {
                    tile.ContainerName.AddTranslation(_russian, LangHelper.GetText($"{_internalModName}.Tiles.{tileData.TranslationKey}.Container.Name"));
                }
            }
        }
    }
}