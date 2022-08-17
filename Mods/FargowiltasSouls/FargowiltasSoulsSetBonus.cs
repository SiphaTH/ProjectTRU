using System.Linq;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
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
}