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
        public override bool Autoload(ref string name) => TranslationHelper.IsRussianLanguage;

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
                string calamityArmorSetName = GlobalArmorSetBonus.GetArmorSetName(item.type, ArmorSetBonusLoader.CalamityArmorSets);
                string fargoSoulsArmorSetName = GlobalArmorSetBonus.GetArmorSetName(item.type, ArmorSetBonusLoader.FargoSoulsArmorSets);
                string vanillaArmorSetName = GlobalArmorSetBonus.GetArmorSetName(item.type, ArmorSetBonusLoader.VanillaArmorSets);

                string calamitySetBonus = GlobalArmorSetBonus.GetCalamityArmorSetBonusByName(calamityArmorSetName);
                string fargoSoulsSetBonus = GlobalArmorSetBonus.GetFargoSoulsArmorSetBonusByName(fargoSoulsArmorSetName);
                string vanillaSetBonus = GlobalArmorSetBonus.GetVanillaArmorSetBonusByName(vanillaArmorSetName);

                if (calamitySetBonus != null)
                {
                    tooltips.Add(new TooltipLine(mod, "ArmorSetBonusInfo", calamitySetBonus)
                    {
                        overrideColor = Color.Gray
                    });
                }

                if (fargoSoulsSetBonus != null)
                {
                    tooltips.Add(new TooltipLine(mod, "ArmorSetBonusInfo", fargoSoulsSetBonus)
                    {
                        overrideColor = Color.Gray
                    });
                }

                if (vanillaSetBonus != null)
                {
                    tooltips.Add(new TooltipLine(mod, "ArmorSetBonusInfo", vanillaSetBonus)
                    {
                        overrideColor = Color.Gray
                    });
                }
            }
        }
    }
}