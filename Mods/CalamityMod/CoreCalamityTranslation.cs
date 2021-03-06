using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class CoreCalamityTranslation : ModRussianTranslation
    {
        public CoreCalamityTranslation() : base("CalamityMod")
        {
            BuffTranslation = CalamityTranslationCatalog.Buff;
            ItemNameTranslation = CalamityTranslationCatalog.ItemName;
            ItemTooltipTranslation = CalamityTranslationCatalog.ItemTooltip;
            ProjectileTranslation = CalamityTranslationCatalog.Projectile;
            NPCTranslation = CalamityTranslationCatalog.NPC;
            ChestTranslation = CalamityTranslationCatalog.Chest;
            DresserTranslation = CalamityTranslationCatalog.Dresser;
            PrefixTranslation = CalamityTranslationCatalog.Prefix;
            KeyLocalization = CalamityTranslationCatalog.KeyLocalization;
            TileTranslation = CalamityTranslationCatalog.Tile;
        }

        public override void Load()
        {
            if (IsLoaded && ModInstance.Version != new Version(1, 4, 5, 7))
            {
                throw new ModVersionException("Calamity", "1.4.5.7", ModsCall.Calamity.Version);
            }
        }
        
        public override void DialogueTranslation()
        {
            NPCDialogueTranslation.SetupTranslation();
        }
    }
}