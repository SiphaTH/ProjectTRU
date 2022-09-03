// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using StarsAbove.Items;
// using StarsAbove.Prefixes;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.GlobalModifications;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarsAboveSpecificItemsTooltipTranslation : GlobalItem
// {
//     public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
//     {
//         if (item.type == ModContent.ItemType<BuryTheLight>())
//         {
//             if (ModsCall.Calamity != null)
//             {
//                 foreach (TooltipLine tooltipLine in tooltips)
//                 {
//                     tooltipLine.Text = LangHelper.GetTextValue("StarsAbove.Items.BuryTheLight.Tooltip.Calamity");
//                 }
//             }
//         }
//         
//         if (item.prefix == ModContent.PrefixType<NovaPrefix1>())
//         {
//             ItemHelper.TranslateTooltip(item, tooltips, "StarsAbove: NovaPrefix", tooltip =>
//             {
//                 tooltip.Text = LangHelper.GetTextValue("StarsAbove.Items.TooltipTags.NovaPrefix1");
//             });
//         }
//         if (item.prefix == ModContent.PrefixType<NovaPrefix2>())
//         {
//             ItemHelper.TranslateTooltip(item, tooltips, "StarsAbove: NovaPrefix", tooltip =>
//             {
//                 tooltip.Text = LangHelper.GetTextValue("StarsAbove.Items.TooltipTags.NovaPrefix2");
//             });
//         }
//         if (item.prefix == ModContent.PrefixType<NovaPrefix3>())
//         {
//             ItemHelper.TranslateTooltip(item, tooltips, "StarsAbove: NovaPrefix", tooltip =>
//             {
//                 tooltip.Text = LangHelper.GetTextValue("StarsAbove.Items.TooltipTags.NovaPrefix3");
//             });
//         }
//         if (item.prefix == ModContent.PrefixType<NovaPrefix4>())
//         {
//             ItemHelper.TranslateTooltip(item, tooltips, "StarsAbove: NovaPrefix", tooltip =>
//             {
//                 tooltip.Text = LangHelper.GetTextValue("StarsAbove.Items.TooltipTags.NovaPrefix4");
//             });
//         }
//         if (item.prefix == ModContent.PrefixType<BadNovaPrefix1>())
//         {
//             ItemHelper.TranslateTooltip(item, tooltips, "StarsAbove: NovaPrefix", tooltip =>
//             {
//                 tooltip.Text = LangHelper.GetTextValue("StarsAbove.Items.TooltipTags.BadNovaPrefix1");
//             });
//         }
//         if (item.prefix == ModContent.PrefixType<BadNovaPrefix2>())
//         {
//             ItemHelper.TranslateTooltip(item, tooltips, "StarsAbove: NovaPrefix", tooltip =>
//             {
//                 tooltip.Text = LangHelper.GetTextValue("StarsAbove.Items.TooltipTags.BadNovaPrefix2");
//             });
//         }
//     }
// }