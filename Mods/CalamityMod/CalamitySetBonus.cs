using System.Collections.Generic;
using System.Linq;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

[JITWhenModsEnabled("CalamityMod")]
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
    }
}