// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Microsoft.Xna.Framework;
// using StarsAbove.Systems;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.GlobalModifications;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class StarsAboveModifiedDamageTypes : GlobalItem
// {
//     public DamageClass Celestial => ModContent.GetInstance<CelestialDamageClass>();
//     public DamageClass Incarnation => ModContent.GetInstance<IncarnationDamageClass>();
//     
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//     }
//     
//     public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
//     {
//         ItemHelper.TranslateTooltip(item, tooltips, "Damage", tooltip =>
//         {
//             if (item.CountsAsClass(Celestial))
//             {
//                 tooltip.Text = tooltip.Text.Replace("celestial damage", "ед. неземного урона");
//             
//                 //if (TRuConfig.Instance.ColoredDamageTypes)
//                     //tooltip.OverrideColor = new Color(255, 184, 108);
//             }
//             else if (item.CountsAsClass(Incarnation))
//             {
//                 tooltip.Text = tooltip.Text.Replace("incarnated damage", "ед. урона");
//                 
//                 if (TRuConfig.Instance.ColoredDamageTypes)
//                     tooltip.OverrideColor = new Color(145, 178, 203);
//             }
//         });
//     }
// }