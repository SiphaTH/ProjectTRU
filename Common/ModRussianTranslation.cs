using System;
using System.Collections.Generic;
using CalamityRuTranslate.Utilities;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common
{
    public abstract class ModRussianTranslation
    {
        public Mod ModInstance => ModLoader.GetMod(_innerModName);
        
        public bool IsLoaded => ModInstance != null;
        
        private string _innerModName;
        private string _modName;
        
        protected List<string> BuffTranslation;
        protected List<string> ItemNameTranslation;
        protected List<string> ItemTooltipTranslation;
        protected List<string> NPCTranslation;
        protected List<string> ChestTranslation;
        protected List<string> DresserTranslation;
        protected List<string> ProjectileTranslation;
        protected List<string> PrefixTranslation;
        protected List<string> KeyLocalization;
        protected Dictionary<string, (string, Color)> TileTranslation;

        protected ModRussianTranslation(string mod)
        {
            _innerModName = mod;
            
            BuffTranslation = new List<string>();
            ItemNameTranslation = new List<string>();
            ItemTooltipTranslation = new List<string>();
            NPCTranslation = new List<string>();
            ChestTranslation = new List<string>();
            DresserTranslation = new List<string>();
            ProjectileTranslation = new List<string>();
            PrefixTranslation = new List<string>();
            KeyLocalization = new List<string>();
            TileTranslation = new Dictionary<string, (string, Color)>();
            
            switch (mod)
            {
                case "CalamityMod":
                    _modName = "Calamity";
                    break;
                
                case "ThoriumMod":
                    _modName = "Thorium";
                    break;
                
                case "Fargowiltas":
                    _modName = "Fargo";
                    break;
                
                case "FargowiltasSouls":
                    _modName = "FargoSouls";
                    break;
                
                default:
                    throw new ArgumentException(nameof(mod));
            }
        }

        public virtual void Load()
        {
        }

        public virtual void DialogueTranslation()
        {
        }

        public void SetupTranslation()
        {
            foreach (var id in BuffTranslation)
            {
                try
                {
                    SetBuffTranslation(id);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
            
            foreach (var id in ItemNameTranslation)
            {
                try
                {
                    SetItemNameTranslation(id);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
            
            foreach (var id in ItemTooltipTranslation)
            {
                try
                {
                    SetItemTooltipTranslation(id);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
            
            foreach (var id in NPCTranslation)
            {
                try
                {
                    SetNPCTranslation(id);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
            
            foreach (var id in TileTranslation)
            {
                try
                {
                    SetTileTranslation(id.Key, id.Value.Item1, id.Value.Item2);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id.Key);
                }
            }
            
            foreach (var id in ChestTranslation)
            {
                try
                {
                    SetChestTranslation(id);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
            
            foreach (var id in DresserTranslation)
            {
                try
                {
                    SetDresserTranslation(id);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
            
            foreach (var id in ProjectileTranslation)
            {
                try
                {
                    SetProjectileTranslation(id);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
            
            foreach (var id in PrefixTranslation)
            {
                try
                {
                    SetPrefixTranslation(id);
                }
                catch (NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
            
            foreach (var id in KeyLocalization)
            {
                SetKeyLocalizationTranslation(id);
            }
        }

        private void SetBuffTranslation(string buffId)
        {
             ModInstance.GetBuff(buffId).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"{_modName}.BuffName.{buffId}"));
            ModInstance.GetBuff(buffId).Description.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"{_modName}.BuffDescription.{buffId}"));
        }
        
        private void SetItemNameTranslation(string itemId)
        {
            ModInstance.GetItem(itemId).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"{_modName}.ItemName.{itemId}"));
        }
        
        private void SetItemTooltipTranslation(string itemId)
        {
            ModInstance.GetItem(itemId).Tooltip.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"{_modName}.ItemTooltip.{itemId}"));
        }
        
        private void SetNPCTranslation(string npcId)
        {
            ModInstance.GetNPC(npcId).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"{_modName}.NpcName.{npcId}"));
        }
        
        private void SetTileTranslation(string tileId, string mapEntryName, Color colorTile)
        {
            ModTile modTile = TileLoader.GetTile(ModInstance.TileType(tileId));
            ModTranslation modTranslation = modTile.CreateMapEntryName(mapEntryName);
            modTranslation.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"{_modName}.TileName.{tileId}"));
            modTile.AddMapEntry(colorTile, modTranslation);
        }

        private void SetChestTranslation(string tileId)
        {
            TileLoader.GetTile(ModInstance.TileType(tileId)).chest = LangUtilities.TranslationKey($"{_modName}.ChestName.{tileId}");
        }

        private void SetDresserTranslation(string tileId)
        {
            TileLoader.GetTile(ModInstance.TileType(tileId)).dresser = LangUtilities.TranslationKey($"{_modName}.DresserName.{tileId}");
        }
        
        private void SetProjectileTranslation(string projectileId)
        {
            ModInstance.GetProjectile(projectileId).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"{_modName}.ProjectileName.{projectileId}"));
        }
        
        private void SetPrefixTranslation(string prefixId)
        {
            ModInstance.GetPrefix(prefixId).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"{_modName}.PrefixName.{prefixId}"));
        }

        private void SetKeyLocalizationTranslation(string key)
        {
            ModTranslation translation = ModInstance.CreateTranslation(key);
            translation.SetDefault(LangUtilities.TranslationKey($"{_modName}.KeyLocalization.{key}"));
            ModInstance.AddTranslation(translation);
        }
    }
}