using System;
using System.Collections.Generic;
using CalamityRuTranslate.Common.DataStructures;
using CalamityRuTranslate.Common.Exceptions;
using CalamityRuTranslate.Common.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core
{
    public abstract class SetupModTranslation
    {
        public Mod ModInstance => ModLoader.GetMod(_innerModName);

        private readonly string _innerModName;
        private readonly string _modName;

        protected List<string> BuffsTranslation;
        protected List<string> ItemsNameTranslation;
        protected List<string> ItemsTooltipTranslation;
        protected List<string> NPCsTranslation;
        protected List<string> ChestsTranslation;
        protected List<string> DressersTranslation;
        protected List<string> ProjectilesTranslation;
        protected List<string> PrefixesTranslation;
        protected List<string> KeysLocalization;
        protected List<TileData> TilesTranslation;

        protected SetupModTranslation(string mod)
        {
            _innerModName = mod;

            BuffsTranslation = new List<string>();
            ItemsNameTranslation = new List<string>();
            ItemsTooltipTranslation = new List<string>();
            NPCsTranslation = new List<string>();
            ChestsTranslation = new List<string>();
            DressersTranslation = new List<string>();
            ProjectilesTranslation = new List<string>();
            PrefixesTranslation = new List<string>();
            KeysLocalization = new List<string>();
            TilesTranslation = new List<TileData>();

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

        public void TryLoad()
        {
            if (ModInstance != null)
                Load();
        }

        public void LoadSetupDialoguesTranslation()
        {
            if (ModInstance != null && TranslationHelper.IsRussianLanguage)
                SetupDialoguesTranslation();
        }

        public void LoadSetupCombatTextsTranslation()
        {
            if (ModInstance != null && TranslationHelper.IsRussianLanguage)
                SetupCombatTextsTranslation();
        }
        
        public void LoadSetupContentTranslation()
        {
            if (ModInstance != null && TranslationHelper.IsRussianLanguage)
                SetupContentTranslation();
        }

        private void SetupContentTranslation()
        {
            foreach (var id in BuffsTranslation)
            {
                try
                {
                    ModInstance.GetBuff(id).DisplayName.AddTranslation(GameCulture.Russian, LangHelper.GetText($"{_modName}.BuffName.{id}"));
                    ModInstance.GetBuff(id).Description.AddTranslation(GameCulture.Russian, LangHelper.GetText($"{_modName}.BuffDescription.{id}"));
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.IsEnabledModVersionException && !BuffsTranslation.Contains(id))
                        continue;

                    if (TRuConfig.Instance.IsEnabledModVersionException)
                        throw new IdTypeException(id);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(id);
                }
            }

            foreach (var id in ItemsNameTranslation)
            {
                try
                {
                    ModInstance.GetItem(id).DisplayName.AddTranslation(GameCulture.Russian, LangHelper.GetText($"{_modName}.ItemName.{id}"));
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.IsEnabledModVersionException && !ItemsNameTranslation.Contains(id))
                        continue;

                    if (TRuConfig.Instance.IsEnabledModVersionException)
                        throw new IdTypeException(id);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(id);
                }
            }

            foreach (var id in ItemsTooltipTranslation)
            {
                try
                {
                    ModInstance.GetItem(id).Tooltip.AddTranslation(GameCulture.Russian, LangHelper.GetText($"{_modName}.ItemTooltip.{id}"));
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.IsEnabledModVersionException && !ItemsTooltipTranslation.Contains(id))
                        continue;

                    if (TRuConfig.Instance.IsEnabledModVersionException)
                        throw new IdTypeException(id);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(id);
                }
            }

            foreach (var id in NPCsTranslation)
            {
                try
                {
                    ModInstance.GetNPC(id).DisplayName.AddTranslation(GameCulture.Russian, LangHelper.GetText($"{_modName}.NpcName.{id}"));
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.IsEnabledModVersionException && !NPCsTranslation.Contains(id))
                        continue;

                    if (TRuConfig.Instance.IsEnabledModVersionException)
                        throw new IdTypeException(id);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(id);
                }
            }

            foreach (var id in TilesTranslation)
            {
                try
                {
                    ModTile modTile = TileLoader.GetTile(ModInstance.TileType(id.TileId));
                    ModTranslation modTranslation = modTile.CreateMapEntryName(id.MapEntryName);
                    modTranslation.AddTranslation(GameCulture.Russian, LangHelper.GetText($"{_modName}.TileName.{id.TranslationKey}"));
                    modTile.AddMapEntry(id.TileColor, modTranslation);
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.IsEnabledModVersionException && !TilesTranslation.Contains(id))
                        continue;

                    if (TRuConfig.Instance.IsEnabledModVersionException)
                        throw new IdTypeException(id.TileId);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(id.TileId);
                }
            }

            foreach (var id in ChestsTranslation)
            {
                try
                {
                    TileLoader.GetTile(ModInstance.TileType(id)).chest = LangHelper.GetText($"{_modName}.ChestName.{id}");
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.IsEnabledModVersionException && !ChestsTranslation.Contains(id))
                        continue;
                    
                    if (TRuConfig.Instance.IsEnabledModVersionException)
                        throw new IdTypeException(id);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(id);
                }
            }

            foreach (var id in DressersTranslation)
            {
                try
                {
                    TileLoader.GetTile(ModInstance.TileType(id)).dresser = LangHelper.GetText($"{_modName}.DresserName.{id}");
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.IsEnabledModVersionException && !DressersTranslation.Contains(id))
                        continue;
                    
                    if (TRuConfig.Instance.IsEnabledModVersionException)
                        throw new IdTypeException(id);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(id);
                }
            }

            foreach (var id in ProjectilesTranslation)
            {
                try
                {
                    ModInstance.GetProjectile(id).DisplayName.AddTranslation(GameCulture.Russian, LangHelper.GetText($"{_modName}.ProjectileName.{id}"));
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.IsEnabledModVersionException && !ProjectilesTranslation.Contains(id))
                        continue;
                    
                    if (TRuConfig.Instance.IsEnabledModVersionException)
                        throw new IdTypeException(id);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(id);
                }
            }

            foreach (var id in PrefixesTranslation)
            {
                try
                {
                    ModInstance.GetPrefix(id).DisplayName.AddTranslation(GameCulture.Russian, LangHelper.GetText($"{_modName}.PrefixName.{id}"));
                }
                catch (NullReferenceException)
                {
                    if (!TRuConfig.Instance.IsEnabledModVersionException && !PrefixesTranslation.Contains(id))
                        continue;
                    
                    if (TRuConfig.Instance.IsEnabledModVersionException)
                        throw new IdTypeException(id);
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyTypeException(id);
                }
            }

            foreach (var id in KeysLocalization)
            {
                ModTranslation modTranslation = ModInstance.CreateTranslation(id);
                modTranslation.SetDefault(LangHelper.GetText($"{_modName}.KeyLocalization.{id}"));
                ModInstance.AddTranslation(modTranslation);
            }
        }

        public virtual void Load() { }

        public virtual void SetupDialoguesTranslation() { }
        
        public virtual void SetupCombatTextsTranslation() { }
    }
}