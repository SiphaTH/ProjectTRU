using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common.Exceptions;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public class FargowiltasSoulsTranslation : SetupModTranslation
    {
        public FargowiltasSoulsTranslation() : base("FargowiltasSouls")
        {
            BuffsTranslation = FargoSoulsCatalog.Buffs;
            ItemsNameTranslation = FargoSoulsCatalog.ItemsName;
            ItemsTooltipTranslation = FargoSoulsCatalog.ItemsTooltip;
            NPCsTranslation = FargoSoulsCatalog.NPCs;
            TilesTranslation = FargoSoulsCatalog.Tiles;
        }

        private Version _expectedFargoSoulsVersion = new Version(1, 3, 99, 91);

        public override void Load()
        {
            if (!TRuConfig.Instance.IsEnabledModVersionException)
                return;

            if (ModInstance.Version != _expectedFargoSoulsVersion)
            {
                throw new ModVersionException("Fargo's Souls Mod", ModInstance.Version, _expectedFargoSoulsVersion,
                    ModVersionException.ExceptionType.OutdatedFargoSouls);
            }
        }
        
        public override void SetupCombatTextsTranslation()
        {
            CombatTextsTranslation.SetupTranslation();
        }
    }
}