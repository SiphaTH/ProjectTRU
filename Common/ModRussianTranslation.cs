using System;
using System.Collections.Generic;
using CalamityRuTranslate.Common.Exceptions;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common
{
    public abstract class ModRussianTranslation
    {
        public Mod ModInstance => ModLoader.GetMod(_innerModName);

        private readonly string _innerModName;
        private readonly string _modName;

        protected List<string> BuffTranslation;
        protected List<string> ItemNameTranslation;
        protected List<string> ItemTooltipTranslation;
        protected List<string> NPCTranslation;
        protected List<string> ChestTranslation;
        protected List<string> DresserTranslation;
        protected List<string> ProjectileTranslation;
        protected List<string> PrefixTranslation;
        protected List<string> KeyLocalization;
        protected List<ModTileTranslation> TileTranslation;

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
            TileTranslation = new List<ModTileTranslation>();

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
            if(ModInstance != null)
                Load();
        }

        public void TryDialogueTranslation()
        {
            if (ModInstance != null && TranslationUtils.IsRussianLanguage)
                DialogueTranslation();
        }

        public void TrySetupContentTranslation()
        {
            if (ModInstance != null && TranslationUtils.IsRussianLanguage && !Main.dedServ)
                SetupTranslation();
        }

        private void SetupTranslation()
        {
            foreach (var id in BuffTranslation)
            {
                try
                {
                    ModInstance.GetBuff(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtils.TranslationKey($"{_modName}.BuffName.{id}"));
                    ModInstance.GetBuff(id).Description.AddTranslation(GameCulture.Russian, LangUtils.TranslationKey($"{_modName}.BuffDescription.{id}"));
                }
                catch (NullReferenceException)
                {
                    throw new ModTypeException(id);
                }
            }

            foreach (var id in ItemNameTranslation)
            {
                try
                {
                    ModInstance.GetItem(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtils.TranslationKey($"{_modName}.ItemName.{id}"));
                }
                catch (NullReferenceException)
                {
                    throw new ModTypeException(id);
                }
            }

            foreach (var id in ItemTooltipTranslation)
            {
                try
                {
                    ModInstance.GetItem(id).Tooltip.AddTranslation(GameCulture.Russian, LangUtils.TranslationKey($"{_modName}.ItemTooltip.{id}"));
                }
                catch (NullReferenceException)
                {
                    throw new ModTypeException(id);
                }
            }

            foreach (var id in NPCTranslation)
            {
                try
                {
                    ModInstance.GetNPC(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtils.TranslationKey($"{_modName}.NpcName.{id}"));
                }
                catch (NullReferenceException)
                {
                    throw new ModTypeException(id);
                }
            }

            foreach (var id in TileTranslation)
            {
                try
                {
                    ModTile modTile = TileLoader.GetTile(ModInstance.TileType(id.TileId));
                    ModTranslation modTranslation = modTile.CreateMapEntryName(id.MapEntryName);
                    modTranslation.AddTranslation(GameCulture.Russian, LangUtils.TranslationKey($"{_modName}.TileName.{id.TranslationKey}"));
                    modTile.AddMapEntry(id.TileColor, modTranslation);
                }
                catch (NullReferenceException)
                {
                    throw new ModTypeException(id.TileId);
                }
            }

            foreach (var id in ChestTranslation)
            {
                try
                {
                    TileLoader.GetTile(ModInstance.TileType(id)).chest = LangUtils.TranslationKey($"{_modName}.ChestName.{id}");
                }
                catch (NullReferenceException)
                {
                    throw new ModTypeException(id);
                }
            }

            foreach (var id in DresserTranslation)
            {
                try
                {
                    TileLoader.GetTile(ModInstance.TileType(id)).dresser = LangUtils.TranslationKey($"{_modName}.DresserName.{id}");
                }
                catch (NullReferenceException)
                {
                    throw new ModTypeException(id);
                }
            }

            foreach (var id in ProjectileTranslation)
            {
                try
                {
                    ModInstance.GetProjectile(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtils.TranslationKey($"{_modName}.ProjectileName.{id}"));
                }
                catch (NullReferenceException)
                {
                    throw new ModTypeException(id);
                }
            }

            foreach (var id in PrefixTranslation)
            {
                try
                {
                    ModInstance.GetPrefix(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtils.TranslationKey($"{_modName}.PrefixName.{id}"));
                }
                catch (NullReferenceException)
                {
                    throw new ModTypeException(id);
                }
            }

            foreach (var id in KeyLocalization)
            {
                ModTranslation modTranslation = ModInstance.CreateTranslation(id);
                modTranslation.SetDefault(LangUtils.TranslationKey($"{_modName}.KeyLocalization.{id}"));
                ModInstance.AddTranslation(modTranslation);
            }
        }

        public virtual void Load() { }

        public virtual void DialogueTranslation() { }
    }
}