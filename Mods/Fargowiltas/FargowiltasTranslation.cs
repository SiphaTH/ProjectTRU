using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Exceptions;
using CalamityRuTranslate.Core;

namespace CalamityRuTranslate.Mods.Fargowiltas
{
    public class FargowiltasTranslation : SetupModTranslation
    {
        public FargowiltasTranslation() : base("Fargowiltas")
        {
            BuffsTranslation = FargoCatalog.Buffs;
            ItemsNameTranslation = FargoCatalog.ItemsName;
            ItemsTooltipTranslation = FargoCatalog.ItemsTooltip;
            NPCsTranslation = FargoCatalog.NPCs;
            TilesTranslation = FargoCatalog.Tiles;
        }

        private Version _expectedFargoVersion = new Version(2, 4, 2);

        public override void Load()
        {
            if (TRuConfig.Instance.IsEnabledModVersionException)
            {
                if (ModInstance.Version != _expectedFargoVersion)
                {
                    throw new ModVersionException("Fargo's Mutant Mod", ModInstance.Version, _expectedFargoVersion,
                        ModVersionException.ExceptionType.OutdatedFargo);
                }
            }

            if (ModsCall.FargoSouls != null)
            {
                ItemsNameTranslation.Add("Squirrel");
                ItemsTooltipTranslation.Add("Squirrel");
                ItemsNameTranslation.Add("InnocuousSkull");
                ItemsTooltipTranslation.Add("InnocuousSkull");
                ItemsNameTranslation.Add("EternityAdvisor");
                ItemsTooltipTranslation.Add("EternityAdvisor");
                NPCsTranslation.Add("Squirrel");
            }

            if (ModsCall.Thorium != null || ModsCall.Calamity != null)
            {
                ItemsNameTranslation.Add("OmnistationPlus");
                ItemsTooltipTranslation.Add("OmnistationPlus");
            }

            if (ModsCall.Thorium != null)
            {
                ItemsNameTranslation.Add("OverloadCoznix");
                ItemsNameTranslation.Add("OverloadJelly");
                ItemsNameTranslation.Add("OverloadLich");
                ItemsNameTranslation.Add("OverloadSaucer");
                ItemsNameTranslation.Add("OverloadStrider");
                ItemsNameTranslation.Add("OverloadThunderbird");

                ItemsTooltipTranslation.Add("OverloadCoznix");
                ItemsTooltipTranslation.Add("OverloadJelly");
                ItemsTooltipTranslation.Add("OverloadLich");
                ItemsTooltipTranslation.Add("OverloadSaucer");
                ItemsTooltipTranslation.Add("OverloadStrider");
                ItemsTooltipTranslation.Add("OverloadThunderbird");
            }
        }

        public override void SetupDialoguesTranslation()
        {
            NpcDialoguesTranslation.SetupTranslation();
        }
    }
}