using System.Collections.Generic;
using System.Linq;
using CalamityMod;
using CalamityMod.Items.Armor.DesertProwler;
using CalamityMod.Items.Armor.GemTech;
using CalamityMod.Items.Armor.MarniteArchitect;
using CalamityMod.Items.Armor.Wulfrum;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamitySetBonus : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

    public override string IsArmorSet(Item head, Item body, Item legs)
    {
        return ArmorSetBonusLoader.CalamityArmorSets
            .Where(set => set.CheckArmorSet(head.type, body.type, legs.type))
            .Select(info => info.ToString())
            .FirstOrDefault();
    }

    public override void UpdateArmorSet(Player player, string set)
    {
        player.setBonus = GlobalArmorSetBonus.GetCalamityArmorSetBonusByName(set);
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.type == ItemID.AncientBattleArmorHat || item.type == ItemID.AncientBattleArmorShirt ||
            item.type == ItemID.AncientBattleArmorPants && !Main.player[Main.myPlayer].Calamity().forbiddenCirclet)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "SetBonus", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("The minion damage nerf is reduced while wielding magic weapons",
                    LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Forbidden"));
            });
        }
        if (Main.LocalPlayer.armor[0].type == ModContent.ItemType<DesertProwlerHat>() &&
            Main.LocalPlayer.armor[1].type == ModContent.ItemType<DesertProwlerShirt>() &&
            Main.LocalPlayer.armor[2].type == ModContent.ItemType<DesertProwlerPants>())
        {
            ItemHelper.SetBonusColorTooltip(item, tooltips, "CalamityMod.Items.SetBonus.DesertProwlerEquipped.Tooltip", "CalamityMod.Items.SetBonus.DesertProwlerEquipped.Tooltip.1", "CalamityMod.Items.SetBonus.DesertProwlerEquipped.Tooltip.2", "CalamityMod.Items.SetBonus.DesertProwlerEquipped.Tooltip.3");
        }
        if (Main.LocalPlayer.armor[0].type == ModContent.ItemType<MarniteArchitectHeadgear>() &&
            Main.LocalPlayer.armor[1].type == ModContent.ItemType<MarniteArchitectToga>())
        {
            ItemHelper.SetBonusColorTooltip(item, tooltips, "",
                "CalamityMod.Items.SetBonus.MarniteArchitectEquipped.Tooltip.1",
                "CalamityMod.Items.SetBonus.MarniteArchitectEquipped.Tooltip.2",
                "CalamityMod.Items.SetBonus.MarniteArchitectEquipped.Tooltip.3");
            
            ItemHelper.TranslateTooltip(item, tooltips, "SetBonus", tooltip =>
            {
                tooltip.Text = "";
            });
        }
        if (Main.LocalPlayer.armor[0].type == ModContent.ItemType<WulfrumHat>() &&
            Main.LocalPlayer.armor[1].type == ModContent.ItemType<WulfrumJacket>() &&
            Main.LocalPlayer.armor[2].type == ModContent.ItemType<WulfrumOveralls>())
        {
            ItemHelper.SetBonusColorTooltip(item, tooltips, "CalamityMod.Items.SetBonus.WulfrumEquipped.Tooltip",
                "CalamityMod.Items.SetBonus.WulfrumEquipped.Tooltip.1",
                "CalamityMod.Items.SetBonus.WulfrumEquipped.Tooltip.2",
                "CalamityMod.Items.SetBonus.WulfrumEquipped.Tooltip.3");
            
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:ArmorItemDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.WulfrumEquipped.Tooltip.ArmorItemDisplay");
            });
        }
        if (Main.LocalPlayer.armor[0].type == ModContent.ItemType<GemTechHeadgear>() &&
            Main.LocalPlayer.armor[1].type == ModContent.ItemType<GemTechBodyArmor>() &&
            Main.LocalPlayer.armor[2].type == ModContent.ItemType<GemTechSchynbaulds>())
        {
            ItemHelper.SetBonusColorTooltip(item, tooltips, "CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip",
                Main.keyState.IsKeyDown(Keys.LeftShift) ? "CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.1.IsKeyDown" : "CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.1",
                "CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.2",
                "CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.3",
                "CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.4",
                "CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.5",
                "CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.6",
                "CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.7",
                "CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.8");
            
            ItemHelper.TranslateTooltip(item, tooltips, "CalamityMod:ExpandedDisplay", tooltip =>
            {
                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.ExpandedDisplay");
            });
        }
    }
}