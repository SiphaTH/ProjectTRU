﻿using System;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Exceptions;

namespace CalamityRuTranslate.Mods.Fargowiltas
{
    public class CoreFargowiltasTranslation : ModRussianTranslation
    {
        public CoreFargowiltasTranslation() : base("Fargowiltas")
        {
            BuffTranslation = FargoCatalog.Buff;
            ItemNameTranslation = FargoCatalog.ItemName;
            ItemTooltipTranslation = FargoCatalog.ItemTooltip;
            NPCTranslation = FargoCatalog.NPC;
            TileTranslation = FargoCatalog.Tile;
        }

        private readonly Version ExpectedFargoVersion = new Version(2, 4, 2);

        public override void Load()
        {
            if (TRuConfig.Instance.IsEnabledModVersionException)
            {
                if (ModInstance.Version != ExpectedFargoVersion)
                {
                    throw new ModVersionException("Fargo's Mutant Mod", ModInstance.Version, ExpectedFargoVersion,
                        ModVersionException.ExceptionType.OutdatedFargo);
                }
            }

            if (ModsCall.FargoSouls != null)
            {
                ItemNameTranslation.Add("Squirrel");
                ItemTooltipTranslation.Add("Squirrel");
                ItemNameTranslation.Add("InnocuousSkull");
                ItemTooltipTranslation.Add("InnocuousSkull");
                ItemNameTranslation.Add("EternityAdvisor");
                ItemTooltipTranslation.Add("EternityAdvisor");
                NPCTranslation.Add("Squirrel");
            }
            else
            {
                ItemNameTranslation.Remove("Squirrel");
                ItemTooltipTranslation.Remove("Squirrel");
                ItemNameTranslation.Remove("InnocuousSkull");
                ItemTooltipTranslation.Remove("InnocuousSkull");
                ItemNameTranslation.Remove("EternityAdvisor");
                ItemTooltipTranslation.Remove("EternityAdvisor");
                NPCTranslation.Remove("Squirrel");
            }

            if (ModsCall.Thorium != null || ModsCall.Calamity != null)
            {
                ItemNameTranslation.Add("OmnistationPlus");
                ItemTooltipTranslation.Add("OmnistationPlus");
            }
            else if(ModsCall.Thorium == null && ModsCall.Calamity == null)
            {
                ItemNameTranslation.Remove("OmnistationPlus");
                ItemTooltipTranslation.Remove("OmnistationPlus");
            }
            else
            {
                ItemNameTranslation.Remove("OmnistationPlus");
                ItemTooltipTranslation.Remove("OmnistationPlus");
            }

            if (ModsCall.Thorium != null)
            {
                ItemNameTranslation.Add("OverloadCoznix");
                //ItemNameTranslation.Add("OverloadGranite");
                ItemNameTranslation.Add("OverloadJelly");
                ItemNameTranslation.Add("OverloadLich");
                ItemNameTranslation.Add("OverloadSaucer");
                ItemNameTranslation.Add("OverloadStrider");
                ItemNameTranslation.Add("OverloadThunderbird");

                ItemTooltipTranslation.Add("OverloadCoznix");
                //ItemTooltipTranslation.Add("OverloadGranite");
                ItemTooltipTranslation.Add("OverloadJelly");
                ItemTooltipTranslation.Add("OverloadLich");
                ItemTooltipTranslation.Add("OverloadSaucer");
                ItemTooltipTranslation.Add("OverloadStrider");
                ItemTooltipTranslation.Add("OverloadThunderbird");
            }
            else
            {
                ItemNameTranslation.Remove("OverloadCoznix");
                //ItemNameTranslation.Remove("OverloadGranite");
                ItemNameTranslation.Remove("OverloadJelly");
                ItemNameTranslation.Remove("OverloadLich");
                ItemNameTranslation.Remove("OverloadSaucer");
                ItemNameTranslation.Remove("OverloadStrider");
                ItemNameTranslation.Remove("OverloadThunderbird");

                ItemTooltipTranslation.Remove("OverloadCoznix");
                //ItemTooltipTranslation.Remove("OverloadGranite");
                ItemTooltipTranslation.Remove("OverloadJelly");
                ItemTooltipTranslation.Remove("OverloadLich");
                ItemTooltipTranslation.Remove("OverloadSaucer");
                ItemTooltipTranslation.Remove("OverloadStrider");
                ItemTooltipTranslation.Remove("OverloadThunderbird");
            }
        }

        public override void DialogueTranslation() => NPCDialogueTranslation.SetupTranslation();
    }
}