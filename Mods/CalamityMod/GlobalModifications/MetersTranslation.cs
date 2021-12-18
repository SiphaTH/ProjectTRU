using System.Collections.Generic;
using System.Text.RegularExpressions;
using CalamityMod.Items.Accessories;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class MetersTranslation : CalamityGlobalItemBase
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<StatMeter>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    string[] array = Regex.Split(tooltip.text, "\n\n");

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i].Contains("Adrenaline"))
                        {
                            array[i] = LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.RevStats", 
                                array[i].Split(' ')[3],
                                array[i].Split(' ')[6],
                                array[i].Split(' ')[11]);
                        }
                        else if (array[i].Contains("Displays"))
                        {
                            array[i] = LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter");
                        }
                        else if (array[i].Contains("Defense: "))
                        {
                            array[i] = LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.DefStats",
                                array[i].Split(' ')[1],
                                array[i].Split(' ')[4],
                                array[i].Split(' ')[8].Split('\n')[0],
                                array[i].Split(' ')[10],
                                array[i].Split(' ')[15],
                                array[i].Split(' ')[19],
                                array[i].Split(' ')[24]);
                        }
                        else if (array[i].Contains("True Melee Damage: "))
                        {
                            array[i] = LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.MeleeStats",
                                array[i].Split(' ')[2],
                                array[i].Split(' ')[7],
                                array[i].Split(' ')[12].Split('\n')[0],
                                array[i].Split(' ')[15]);
                        }
                        else if (array[i].Contains("Ranged Damage: "))
                        {
                            array[i] = LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.RangedStats",
                                array[i].Split(' ')[2],
                                array[i].Split(' ')[7].Split('\n')[0],
                                array[i].Split(' ')[10]);
                        }
                        else if (array[i].Contains("Magic Damage: "))
                        {
                            array[i] = LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.MagicStats",
                                array[i].Split(' ')[2],
                                array[i].Split(' ')[7].Split('\n')[0],
                                array[i].Split(' ')[9],
                                array[i].Split(' ')[13]);
                        }
                        else if (array[i].Contains("Minion Damage: "))
                        {
                            array[i] = LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.MinionStats",
                                array[i].Split(' ')[2],
                                array[i].Split(' ')[6]);
                        }
                        else if (array[i].Contains("Rogue Damage: "))
                        {
                            array[i] = LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.RogueStats",
                                array[i].Split(' ')[2],
                                array[i].Split(' ')[7].Split('\n')[0],
                                array[i].Split(' ')[10],
                                array[i].Split(' ')[16].Split('\n')[0],
                                array[i].Split(' ')[18],
                                array[i].Split(' ')[22],
                                array[i].Split(' ')[28]);
                        }
                        else if (array[i].Contains("Light Strength"))
                        {
                            array[i] = ModsCall.DeathMode
                                ? LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.CaveLightStrength",
                                    array[i].Split(' ')[3])
                                : LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.AbyssLightStrength",
                                    array[i].Split(' ')[3]);
                        }
                        else if (array[i].Contains("Other Abyss"))
                        {
                            array[i] = ModsCall.CalamityGetInZone
                                ? LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.AbyssStats",
                                    array[i].Split(' ')[6],
                                    array[i].Split(' ')[11].Split('\n')[0],
                                    array[i].Split(' ')[18].Split('\n')[0],
                                    array[i].Split(' ')[20])
                                : LangHelper.GetTextValue("Calamity.ItemTooltip.StatMeter.AbyssZone");
                        }
                    }

                    tooltip.text = string.Join("\n\n", array).Replace("Adrenaline", "");
                });
            }

            else if (item.type == ModContent.ItemType<MeleeLevelMeter>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    string[] array = Regex.Split(tooltip.text, "\n");

                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.MeleeLevelMeter",
                        Regex.Split(array[3], ": ")[1],
                        Regex.Split(array[4], ": ")[1],
                        Regex.Split(array[5], ": ")[1],
                        Regex.Split(array[6], ": ")[1],
                        Regex.Split(array[7], ": ")[1]);
                });
            }

            else if (item.type == ModContent.ItemType<MagicLevelMeter>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    string[] array = Regex.Split(tooltip.text, "\n");

                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.MagicLevelMeter",
                        Regex.Split(array[3], ": ")[1],
                        Regex.Split(array[4], ": ")[1],
                        Regex.Split(array[5], ": ")[1],
                        Regex.Split(array[6], ": ")[1],
                        Regex.Split(array[7], ": ")[1]);
                });
            }

            else if (item.type == ModContent.ItemType<RangedLevelMeter>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    string[] array = Regex.Split(tooltip.text, "\n");

                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.RangedLevelMeter",
                        Regex.Split(array[3], ": ")[1],
                        Regex.Split(array[4], ": ")[1],
                        Regex.Split(array[5], ": ")[1],
                        Regex.Split(array[6], ": ")[1],
                        Regex.Split(array[7], ": ")[1]);
                });
            }

            else if (item.type == ModContent.ItemType<RogueLevelMeter>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    string[] array = Regex.Split(tooltip.text, "\n");

                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.RogueLevelMeter",
                        Regex.Split(array[3], ": ")[1],
                        Regex.Split(array[4], ": ")[1],
                        Regex.Split(array[5], ": ")[1],
                        Regex.Split(array[6], ": ")[1],
                        Regex.Split(array[7], ": ")[1]);
                });
            }

            else if (item.type == ModContent.ItemType<SummonLevelMeter>())
            {
                ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
                {
                    string[] array = Regex.Split(tooltip.text, "\n");

                    tooltip.text = LangHelper.GetTextValue("Calamity.ItemTooltip.SummonLevelMeter",
                        Regex.Split(array[3], ": ")[1],
                        Regex.Split(array[4], ": ")[1],
                        Regex.Split(array[5], ": ")[1],
                        Regex.Split(array[6], ": ")[1]);
                });
            }
        }
    }
}