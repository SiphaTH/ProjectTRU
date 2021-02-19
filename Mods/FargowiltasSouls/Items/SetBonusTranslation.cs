using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.Items
{
    public class SetBonusTranslation : GlobalItem
    {
        public override bool Autoload(ref string name) => CoreFargowiltasSoulsTranslation.FargoSouls != null;

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (Translation.IsRussianLanguage)
            {
                var armorSet = FargoSoulsTranslationDictionaries.FargoSoulsArmorSets.FirstOrDefault(x =>
                    head.type == x.Key.Head && body.type == x.Key.Body && legs.type == x.Key.Legs);
                if (!armorSet.Equals(new KeyValuePair<(int Head, int Body, int Legs), string>()))
                {
                    return armorSet.Value;
                }
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
                    player.setBonus = LangUtilities.GetTextValue("FargoSouls",$"SetBonus.{set}");
                    break;
                default:
                    player.setBonus = LangUtilities.GetTextValue("FargoSouls",$"SetBonus.{set}");
                    break;
            }
        }
    }
}