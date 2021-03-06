using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Catalogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public class SetBonusTranslation : GlobalItem
    {
        private static readonly Dictionary<string, (int Head, int Body, int Legs)> FargoSoulsArmorSet =
            new Dictionary<string, (int Head, int Body, int Legs)>
            {
                {"EridanusHat", (ModsCall.FargoSouls.ItemType("EridanusHat"), ModsCall.FargoSouls.ItemType("EridanusBattleplate"), ModsCall.FargoSouls.ItemType("EridanusLegwear"))},
                {"GaiaHelmet", (ModsCall.FargoSouls.ItemType("GaiaHelmet"), ModsCall.FargoSouls.ItemType("GaiaPlate"), ModsCall.FargoSouls.ItemType("GaiaGreaves"))},
                {"MutantMask", (ModsCall.FargoSouls.ItemType("MutantMask"), ModsCall.FargoSouls.ItemType("MutantBody"), ModsCall.FargoSouls.ItemType("MutantPants"))}
                
            };
        
        public override bool Autoload(ref string name) => ModsCall.FargoSouls != null && Translation.IsRussianLanguage;

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            foreach (var armorSet in FargoSoulsArmorSet.Where(armorSet => head.type == armorSet.Value.Head && body.type == armorSet.Value.Body && legs.type == armorSet.Value.Legs))
            {
                return armorSet.Key;
            }

            return "";
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            switch (set)
            {
                case "EridanusHat":
                case "GaiaHelmet":
                case "MutantMask":
                    player.setBonus = LangUtilities.GetTextValue("FargoSouls", $"SetBonus.{set}");
                    break;
                
                default:
                    player.setBonus = LangUtilities.GetTextValue("FargoSouls", $"SetBonus.{set}");
                    break;
            }
        }
    }
}