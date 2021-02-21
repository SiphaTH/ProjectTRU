using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.Items
{
    public class ModifiedGlobalItemTooltips : GlobalItem
    {
        public override bool Autoload(ref string name) => CoreFargowiltasSoulsTranslation.FargoSouls != null;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            // if (item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("EternitySoul"))
            // {
            //     TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "tooltip");
            //     if (tooltip != null)
            //     {
            //         foreach (var translation in FargoSoulsTranslationDictionaries.FargoSoulsEternitySoul)
            //         {
            //             tooltip.text = tooltip.text.Replace(translation.Key, translation.Value);
            //         }
            //     }
            // }

            if (item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("MedallionoftheFallenKing") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("ComputationOrb") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("StaffOfUnleashedOcean") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("RoombaPet") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("PiranhaPlantVoodooDoll") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("FigBranch") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("ParadoxWolfSoul") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("SquidwardDoor") ||
                item.type == CoreFargowiltasSoulsTranslation.FargoSouls.ItemType("MissDrakovisFishingPole"))
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "tooltip");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text.Replace(">> Patreon Item <<", LangUtilities.GetTextValue("FargoSouls", "TooltipName.Tooltip"));
                }
            }
            
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (tooltipLine.Name == "help")
                {
                    tooltipLine.text = tooltipLine.text.Replace("Right click to convert", LangUtilities.GetTextValue("FargoSouls", "TooltipName.Help"));
                }
            }
            
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (tooltipLine.Name == "FargowiltasSouls:Eternity")
                {
                    tooltipLine.text = tooltipLine.text.Replace("Eternity", LangUtilities.GetTextValue("FargoSouls", "TooltipName.Eternity"));
                }
            }
        }
    }
}