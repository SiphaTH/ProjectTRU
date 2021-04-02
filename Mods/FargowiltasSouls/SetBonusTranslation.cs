using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public class SetBonusTranslation : GlobalItem
    {
        private static readonly List<ArmorSetInfo> ArmorSets = new List<ArmorSetInfo>
        {
            new ArmorSetInfo(ModsCall.FargoSouls.ItemType("EridanusHat"), ModsCall.FargoSouls.ItemType("EridanusBattleplate"), ModsCall.FargoSouls.ItemType("EridanusLegwear"), "EridanusHat"),
            
            new ArmorSetInfo(ModsCall.FargoSouls.ItemType("GaiaHelmet"), ModsCall.FargoSouls.ItemType("GaiaPlate"), ModsCall.FargoSouls.ItemType("GaiaGreaves"), "GaiaHelmet"),
            
            new ArmorSetInfo(ModsCall.FargoSouls.ItemType("MutantMask"), ModsCall.FargoSouls.ItemType("MutantBody"), ModsCall.FargoSouls.ItemType("MutantPants"), "MutantMask")
        };
        
        public override bool Autoload(ref string name) => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override string IsArmorSet(Item head, Item body, Item legs) => ArmorSets
            .Where(set => set.CheckArmorSet(head.type, body.type, legs.type)).Select(info => info.GetArmorSetName())
            .FirstOrDefault();

        public override void UpdateArmorSet(Player player, string set) => player.setBonus = LangUtils.GetTextValue("FargoSouls", $"SetBonus.{set}");
    }
}