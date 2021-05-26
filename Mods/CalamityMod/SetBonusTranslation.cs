using System.Collections.Generic;
using System.Linq;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class SetBonusTranslation : CalamityAutoLoad
    {
        public override string IsArmorSet(Item head, Item body, Item legs) => ArmorSetBonusLoader.CalamityArmorSets
            .Where(set => set.CheckArmorSet(head.type, body.type, legs.type)).Select(info => info.ToString()).FirstOrDefault();

        public override void UpdateArmorSet(Player player, string set) => player.setBonus = GlobalArmorSetBonus.GetCalamityArmorSetBonusByName(set);

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.AncientBattleArmorHat ||
                item.type == ItemID.AncientBattleArmorShirt ||
                item.type == ItemID.AncientBattleArmorPants ||
                !Main.player[Main.myPlayer].Calamity().forbiddenCirclet)
            {
                TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "SetBonus");
                if (tooltip != null)
                {
                    tooltip.text = tooltip.text.Replace("The minion damage nerf is reduced while wielding magic weapons", LangUtils.GetTextValue("Calamity", "SetBonus.Forbidden"));
                }
            }
        }
    }
}