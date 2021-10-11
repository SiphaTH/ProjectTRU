// using System.Collections.Generic;
// using System.Linq;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.SpiritMod
// {
//     public class ModifiedGLobalItemTooltips: GlobalItem
//     {
//         public override bool Autoload(ref string name) => ModsCall.Spirit != null && TranslationUtils.IsRussianLanguage;
//
//         public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
//         {
//             if (item.type == ModsCall.Spirit.ItemType("GlyphBase"))
//             {
//                 TooltipLine tooltip = tooltips.FirstOrDefault(x => x.Name == "GlyphTooltip");
//
//                 if (tooltip != null)
//                 {
//                     
//                 }
//             }
//         }
//     }
// }