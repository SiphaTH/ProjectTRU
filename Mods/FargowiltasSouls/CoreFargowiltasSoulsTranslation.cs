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
            BuffTranslation = FargoSoulsCatalog.Buff;
            ItemNameTranslation = FargoSoulsCatalog.ItemName;
            ItemTooltipTranslation = FargoSoulsCatalog.ItemTooltip;
            NPCTranslation = FargoSoulsCatalog.NPC;
            TileTranslation = FargoSoulsCatalog.Tile;
        }

        private readonly Version ExpectedFargoSoulsVersion = new Version(1, 3, 96, 1);

        public override void Load()
        {
            if (ModInstance.Version != ExpectedFargoSoulsVersion)
            {
                throw new ModVersionException("Fargo's Souls Mod", ModInstance.Version, ExpectedFargoSoulsVersion,
                    ModVersionException.ExceptionType.OutdatedFargoSouls);
            }
        }
    }
}