using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using FargowiltasSouls;
using FargowiltasSouls.Items.Armor;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsSetBonus : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;
    }

    public override string IsArmorSet(Item head, Item body, Item legs)
    {
        return ArmorSetBonusLoader.FargowiltasSoulsArmorSets
            .Where(set => set.CheckArmorSet(head.type, body.type, legs.type))
            .Select(info => info.ToString())
            .FirstOrDefault();
    }

    public override void UpdateArmorSet(Player player, string set)
    {
        player.setBonus = GlobalArmorSetBonus.GetFargowiltasSoulsArmorSetBonusByName(set);
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        FargoSoulsPlayer fargoPlayer = Main.player[Main.myPlayer].GetModPlayer<FargoSoulsPlayer>();
        
        if (Main.LocalPlayer.armor[0].type == ModContent.ItemType<EridanusHat>() &&
            Main.LocalPlayer.armor[1].type == ModContent.ItemType<EridanusBattleplate>() &&
            Main.LocalPlayer.armor[2].type == ModContent.ItemType<EridanusLegwear>())
        {
            if (fargoPlayer.EridanusEmpower)
            {
                ItemHelper.TranslateTooltip(item, tooltips, "SetBonus", tooltip =>
                {
                    string key = Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN");
                    tooltip.Text = Language.GetTextValue("LegacyTooltip.48") + " " + Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.EridanusOn", key);
                });
            }
        }
    }
}