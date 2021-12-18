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
            else
            {
                ItemsNameTranslation.Remove("Squirrel");
                ItemsTooltipTranslation.Remove("Squirrel");
                ItemsNameTranslation.Remove("InnocuousSkull");
                ItemsTooltipTranslation.Remove("InnocuousSkull");
                ItemsNameTranslation.Remove("EternityAdvisor");
                ItemsTooltipTranslation.Remove("EternityAdvisor");
                NPCsTranslation.Remove("Squirrel");
            }

            if (ModsCall.Thorium != null || ModsCall.Calamity != null)
            {
                ItemsNameTranslation.Add("OmnistationPlus");
                ItemsTooltipTranslation.Add("OmnistationPlus");
            }
            else if(ModsCall.Thorium == null && ModsCall.Calamity == null)
            {
                ItemsNameTranslation.Remove("OmnistationPlus");
                ItemsTooltipTranslation.Remove("OmnistationPlus");
            }
            else
            {
                ItemsNameTranslation.Remove("OmnistationPlus");
                ItemsTooltipTranslation.Remove("OmnistationPlus");
            }

            if (ModsCall.Thorium != null)
            {
                ItemsNameTranslation.Add("OverloadCoznix");
                //ItemNameTranslation.Add("OverloadGranite");
                ItemsNameTranslation.Add("OverloadJelly");
                ItemsNameTranslation.Add("OverloadLich");
                ItemsNameTranslation.Add("OverloadSaucer");
                ItemsNameTranslation.Add("OverloadStrider");
                ItemsNameTranslation.Add("OverloadThunderbird");

                ItemsTooltipTranslation.Add("OverloadCoznix");
                //ItemTooltipTranslation.Add("OverloadGranite");
                ItemsTooltipTranslation.Add("OverloadJelly");
                ItemsTooltipTranslation.Add("OverloadLich");
                ItemsTooltipTranslation.Add("OverloadSaucer");
                ItemsTooltipTranslation.Add("OverloadStrider");
                ItemsTooltipTranslation.Add("OverloadThunderbird");
            }
            else
            {
                ItemsNameTranslation.Remove("OverloadCoznix");
                //ItemNameTranslation.Remove("OverloadGranite");
                ItemsNameTranslation.Remove("OverloadJelly");
                ItemsNameTranslation.Remove("OverloadLich");
                ItemsNameTranslation.Remove("OverloadSaucer");
                ItemsNameTranslation.Remove("OverloadStrider");
                ItemsNameTranslation.Remove("OverloadThunderbird");

                ItemsNameTranslation.Remove("OverloadCoznix");
                //ItemTooltipTranslation.Remove("OverloadGranite");
                ItemsTooltipTranslation.Remove("OverloadJelly");
                ItemsTooltipTranslation.Remove("OverloadLich");
                ItemsTooltipTranslation.Remove("OverloadSaucer");
                ItemsTooltipTranslation.Remove("OverloadStrider");
                ItemsTooltipTranslation.Remove("OverloadThunderbird");
            }
        }

        public override void SetupDialoguesTranslation()
        {
            NpcDialoguesTranslation.SetupTranslation();
        }
    }
}