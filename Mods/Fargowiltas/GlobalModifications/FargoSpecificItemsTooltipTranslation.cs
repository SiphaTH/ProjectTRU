using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Fargowiltas.Items.Summons;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.GlobalModifications;

public class FargowiltasSpecificItemsTooltipTranslation : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.type == ModContent.ItemType<MapViewer>())
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                if (Main.netMode != NetmodeID.MultiplayerClient)
                {
                    tooltip.Text = LangHelper.GetTextValue("Fargowiltas.Items.MapViewer.Tooltip.Single");
                }
                else
                {
                    tooltip.Text = LangHelper.GetTextValue("Fargowiltas.Items.MapViewer.Tooltip.Multi");
                }
            });
        }
        
        ItemHelper.TranslateTooltip(item, tooltips, "TooltipSquirrel", tooltip =>
        {
            tooltip.Text = tooltip.Text
                .Replace("Sold By Squirrel", "Продаётся белкой")
                .Replace("Some Materials Sold", "Продаются некоторые материалы")
                .Replace("Craftable Materials Sold", "Продаются материалы для крафта")
                .Replace("Sold At Thirty Stack", "Продаётся по тридцать штук")
                .Replace("None", "Нет");
        });

        if (item.type == ItemID.PureWaterFountain)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:909] [c/AAAAAA:Forces surrounding biome state to Ocean upon activation]", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на океан при активации]";
            });
        }
        
        if (item.type is ItemID.OasisFountain or ItemID.DesertWaterFountain)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:909] [c/AAAAAA:Forces surrounding biome state to Desert upon activation]", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на пустыню при активации]";
            });
        }
        
        if (item.type == ItemID.JungleWaterFountain)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:909] [c/AAAAAA:Forces surrounding biome state to Jungle upon activation]", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на джунгли при активации]";
            });
        }
        
        if (item.type == ItemID.IcyWaterFountain)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:909] [c/AAAAAA:Forces surrounding biome state to Snow upon activation]", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на снега при активации]";
            });
        }
        
        if (item.type == ItemID.CorruptWaterFountain)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:909] [c/AAAAAA:Forces surrounding biome state to Corruption upon activation]", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на искажение при активации]";
            });
        }
        
        if (item.type == ItemID.CrimsonWaterFountain)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:909] [c/AAAAAA:Forces surrounding biome state to Crimson upon activation]", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на багрянец при активации]";
            });
        }
        
        if (item.type == ItemID.HallowedWaterFountain)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:909] [c/AAAAAA:Forces surrounding biome state to Hallow (in hardmode only) upon activation]", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на осящение (только в хардмоде) при активации]";
            });
        }
        
        if (item.type is ItemID.BugNet or ItemID.GoldenBugNet or ItemID.FireproofBugNet)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:1991] [c/AAAAAA:Can also catch townsfolk]", tooltip =>
            {
                tooltip.Text = "[i:1991] [c/AAAAAA:Также позволяет ловить горожан]";
            });
        }
        
        if (item.type == ItemID.FishingPotion)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:2373] [c/AAAAAA:Also grants one extra lure]", tooltip =>
            {
                tooltip.Text = "[i:2373] [c/AAAAAA:Даёт дополнительный поплавок]";
            });
        }
        
        if (item.type is ItemID.FiberglassFishingPole or ItemID.FisherofSouls or ItemID.Fleshcatcher or ItemID.ScarabFishingRod or ItemID.BloodFishingRod)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:2373] [c/AAAAAA:This rod fires 2 lures]", tooltip =>
            {
                tooltip.Text = "[i:2373] [c/AAAAAA:Запускает 2 поплавка]";
            });
        }
        
        if (item.type is ItemID.MechanicsRod or ItemID.SittingDucksFishingRod)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:2373] [c/AAAAAA:This rod fires 3 lures]", tooltip =>
            {
                tooltip.Text = "[i:2373] [c/AAAAAA:Запускает 3 поплавка]";
            });
        }
        
        if (item.type is ItemID.GoldenFishingRod or ItemID.HotlineFishingHook)
        {
            ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Text == "[i:2373] [c/AAAAAA:This rod fires 5 lures]", tooltip =>
            {
                tooltip.Text = "[i:2373] [c/AAAAAA:Запускает 5 поплавков]";
            });
        }
        
        ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "TooltipUnlim" && l.Text == "[i:87] [c/AAAAAA:Unlimited buff at 30 stack in inventory, Piggy Bank, or Safe]", tooltip =>
        {
            tooltip.Text = LangHelper.GetTextValue("Fargowiltas.Items.TooltipTags.TooltipUnlim.ItemBuff");
        });
        
        ItemHelper.ApplyTooltipEdits(item, tooltips, (i, l) => l.Name == "TooltipUnlim" && l.Text == "[i:87] [c/AAAAAA:Works from Piggy Bank and Safe]", tooltip =>
        {
            tooltip.Text = LangHelper.GetTextValue("Fargowiltas.Items.TooltipTags.TooltipUnlim.PiggyBankAcc");
        });
        
        ItemHelper.TranslateTooltip(item, tooltips, "TooltipTorchGod1", tooltip =>
        {
            tooltip.Text = LangHelper.GetTextValue("Fargowiltas.Items.TooltipTags.TooltipTorchGod1");
        });
        
        ItemHelper.TranslateTooltip(item, tooltips, "TooltipTorchGod2", tooltip =>
        {
            tooltip.Text = LangHelper.GetTextValue("Fargowiltas.Items.TooltipTags.TooltipTorchGod2");
        });

        if (item.type is ItemID.SharpeningStation or ItemID.AmmoBox or ItemID.CrystalBall or ItemID.BewitchingTable or ItemID.SliceOfCake)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "TooltipUnlim", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("Fargowiltas.Items.TooltipTags.TooltipUnlim.StationBuff");
            });
        }
    }
}