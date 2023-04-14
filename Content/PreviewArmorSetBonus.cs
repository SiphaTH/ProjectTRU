using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content;

public class PreviewArmorSetBonus : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (!TRuConfig.Instance.PreviewArmorSetBonus || !GlobalArmorSetBonus.CheckArmorSetHead(item.type, GlobalArmorSetBonus.ListOfArmorSet))
            return;

        List<string> keys = PlayerInput.CurrentProfile.InputModes[InputMode.Keyboard].KeyStatus[TriggerNames.SmartSelect];
        string key = keys.Count == 0 ? null : keys[0];
        bool showDesc = key == null || PlayerInput.Triggers.Current.SmartSelect;
        int index = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Tooltip"));
        TooltipLine tooltipLine = new TooltipLine(Mod, "ForMoreInfo", $"Удерживайте клавишу ({key}) без автоматической паузы для предосмотра бонуса комплекта")
        {
            OverrideColor = Color.Gray
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
            string calamitySetBonus = GlobalArmorSetBonus.GetCalamityArmorSetBonusByName(calamityArmorSetName);
            string fargoSoulsArmorSetName = GlobalArmorSetBonus.GetArmorSetName(item.type, ArmorSetBonusLoader.FargowiltasSoulsArmorSets);
            string fargoSoulsSetBonus = GlobalArmorSetBonus.GetFargowiltasSoulsArmorSetBonusByName(fargoSoulsArmorSetName);

            if (calamitySetBonus != null)
            {
                tooltips.Add(new TooltipLine(Mod, "ArmorSetBonusInfo", calamitySetBonus)
                {
                    OverrideColor = Color.Gray
                });
            }
            if (fargoSoulsSetBonus != null)
            {
                tooltips.Add(new TooltipLine(Mod, "ArmorSetBonusInfo", fargoSoulsSetBonus)
                {
                    OverrideColor = Color.Gray
                });
            }
        }
    }
}