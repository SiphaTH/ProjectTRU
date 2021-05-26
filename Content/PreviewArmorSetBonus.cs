using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content
{
    public class PreviewArmorSetBonus : GlobalItem
    {
        public override bool Autoload(ref string name) => TranslationUtils.IsRussianLanguage;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if(!TRuConfig.Instance.PreviewArmorSetInfo || !GlobalArmorSetBonus.CheckArmorSetHead(item.type, GlobalArmorSetBonus.ListOfArmorSet))
                return;

            List<string> keys = PlayerInput.CurrentProfile.InputModes[InputMode.Keyboard].KeyStatus[TriggerNames.SmartSelect];
            string key = keys.Count == 0 ? null : keys[0];
            bool showDesc = key == null || Main.LocalPlayer.controlTorch;
            int index = tooltips.FindLastIndex(x => x.mod.Equals("Terraria") && x.Name.StartsWith("Tooltip"));
            TooltipLine tooltipLine = new TooltipLine(mod, "ForMoreInfo", $"Зажмите кнопку ({key}) без автоматической паузы для предосмотра бонуса комплекта")
            {
                overrideColor = Color.Gray
            };

            if (!showDesc && !item.wornArmor)
            {
                if (index != -1)
                    tooltips.Insert(++index, tooltipLine);
                else
                    tooltips.Add(tooltipLine);
            }
            else if (showDesc && !item.wornArmor)
            {
                string CalamityArmorSetName = GlobalArmorSetBonus.GetArmorSetName(item.type, ArmorSetBonusLoader.CalamityArmorSets);
                string FargoSoulsArmorSetName = GlobalArmorSetBonus.GetArmorSetName(item.type, ArmorSetBonusLoader.FargoSoulsArmorSets);
                string VanillaArmorSetName = GlobalArmorSetBonus.GetArmorSetName(item.type, ArmorSetBonusLoader.VanillaArmorSets);
                string CalamitySetBonus = GlobalArmorSetBonus.GetCalamityArmorSetBonusByName(CalamityArmorSetName);
                string FargoSoulsSetBonus = GlobalArmorSetBonus.GetFargoSoulsArmorSetBonusByName(FargoSoulsArmorSetName);
                string VanillaSetBonus = GlobalArmorSetBonus.GetVanillaArmorSetBonusByName(VanillaArmorSetName);

                if (CalamitySetBonus != null)
                {
                    tooltips.Add(new TooltipLine(mod, "ArmorSetBonusInfo", CalamitySetBonus)
                    {
                        overrideColor = Color.Gray
                    });
                }
                
                if (FargoSoulsSetBonus != null)
                {
                    tooltips.Add(new TooltipLine(mod, "ArmorSetBonusInfo", FargoSoulsSetBonus)
                    {
                        overrideColor = Color.Gray
                    });
                }
                
                if (VanillaSetBonus != null)
                {
                    tooltips.Add(new TooltipLine(mod, "ArmorSetBonusInfo", VanillaSetBonus)
                    {
                        overrideColor = Color.Gray
                    });
                }
            }
        }
    }
}