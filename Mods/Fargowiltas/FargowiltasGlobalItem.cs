using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas;

public class FargowiltasGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "TooltipSquirrel", _ =>
        {
            tooltips.ReplaceText("Sold By Squirrel", "Продаётся белкой");
            tooltips.ReplaceText("Some Materials Sold", "Продаются некоторые материалы");
            tooltips.ReplaceText("Craftable Materials Sold", "Продаются материалы для изготовления");
            tooltips.ReplaceText("Sold At Thirty Stack", "Продаётся от тридцати штук");
            tooltips.ReplaceText("None", "Нет");
        });

        if (item.type == ItemID.PureWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на океан при активации]";
            });
        }

        if (item.type is ItemID.OasisFountain or ItemID.DesertWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на пустыню при активации]";
            });
        }

        if (item.type == ItemID.JungleWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на джунгли при активации]";
            });
        }
        
        if (item.type == ItemID.IcyWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на снега при активации]";
            });
        }
        
        if (item.type == ItemID.CorruptWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на искажение при активации]";
            });
        }
        
        if (item.type == ItemID.CrimsonWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на багрянец при активации]";
            });
        }
        
        if (item.type == ItemID.HallowedWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на осящение (только в хардмоде) при активации]";
            });
        }
        
        if (item.type is ItemID.BugNet or ItemID.GoldenBugNet or ItemID.FireproofBugNet)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:1991] [c/AAAAAA:Также позволяет ловить горожан]";
            });
        }
        
        if (item.type == ItemID.FishingPotion)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip1", tooltip =>
            {
                tooltip.Text = "[i:2373] [c/AAAAAA:Даёт дополнительный поплавок]";
            });
        }
        
        if (item.type is ItemID.FiberglassFishingPole or ItemID.FisherofSouls or ItemID.Fleshcatcher or ItemID.ScarabFishingRod or ItemID.BloodFishingRod)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip1", tooltip =>
            {
                tooltip.Text = "[i:2373] [c/AAAAAA:Эта удочка запускает 2 поплавка]";
            });
        }
        
        if (item.type is ItemID.MechanicsRod or ItemID.SittingDucksFishingRod)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip1", tooltip =>
            {
                tooltip.Text = "[i:2373] [c/AAAAAA:Эта удочка запускает 3 поплавка]";
            });
        }
        
        if (item.type is ItemID.GoldenFishingRod or ItemID.HotlineFishingHook)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip1", tooltip =>
            {
                tooltip.Text = "[i:2373] [c/AAAAAA:Эта удочка запускает 5 поплавков]";
            });
        }
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "TooltipUnlim" && l.Text == "[i:87] [c/AAAAAA:Unlimited buff at 30 stack in inventory, Piggy Bank, or Safe]", tooltip =>
        {
            tooltip.Text = "[i:87] [c/AAAAAA:Бесконечный бафф при стаке в 30 в инвентаре, свинье-копилке или сейфе]";
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "TooltipUnlim" && l.Text == "[i:87] [c/AAAAAA:Works from Piggy Bank and Safe]", tooltip =>
        {
            tooltip.Text = "[i:87] [c/AAAAAA:Работает из свиньи-копилки и сейфа]";
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "TooltipUnlim" && l.Text == "[i:5139] [c/AAAAAA:Unlimited use at 30 stack]", tooltip =>
        {
            tooltip.Text = "[i:5139] [c/AAAAAA:Бесконечное использование при стаке в 30]";
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "TooltipTorchGod1", tooltip =>
        {
            tooltip.Text = "[i:5043] [c/AAAAAA:Автоматически изменяет размещаемые факелы для увеличения удачи]";
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "TooltipTorchGod2", tooltip =>
        {
            tooltip.Text = "[i:5043] [c/AAAAAA:Соответствует истинной удаче факела при замене факелов, может отличаться от выбора по умолчанию]";
        });
        
        if (item.type is ItemID.SharpeningStation or ItemID.AmmoBox or ItemID.CrystalBall or ItemID.BewitchingTable or ItemID.SliceOfCake)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "TooltipUnlim", tooltip =>
            {
                tooltip.Text = "[i:87] [c/AAAAAA:Бесконечный бафф при стаке в 3 в инвентаре, свинье-копилке или сейфе]";
            });
        }
    }
}