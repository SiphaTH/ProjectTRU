using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Exceptions;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public class CoreFargowiltasSoulsTranslation : ModRussianTranslation
    {
        public CoreFargowiltasSoulsTranslation() : base("FargowiltasSouls")
        {
            BuffTranslation = FargoSoulsTranslationCatalog.Buff;
            ItemNameTranslation = FargoSoulsTranslationCatalog.ItemName;
            ItemTooltipTranslation = FargoSoulsTranslationCatalog.ItemTooltip;
            NPCTranslation = FargoSoulsTranslationCatalog.NPC;
            TileTranslation = FargoSoulsTranslationCatalog.Tile;
        }

        public override void Load()
        {
            if (ModInstance.Version != new Version(1,3,95))
            {
                throw new ModVersionException("FargowiltasSouls", "1.3.95", ModInstance.Version);
            }
        }
    }
}