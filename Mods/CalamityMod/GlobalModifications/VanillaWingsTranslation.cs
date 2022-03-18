using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class VanillaWingsTranslation : CalamityGlobalItemBase
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.ButterflyWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.ButterflyWings");
                        break;

                    case ItemID.DemonWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.DemonWings");
                        break;

                    case ItemID.AngelWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.AngelWings");
                        break;

                    case ItemID.BeeWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.BeeWings");
                        break;

                    case ItemID.FairyWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.FairyWings");
                        break;

                    case ItemID.HarpyWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.HarpyWings");
                        break;

                    case ItemID.BoneWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.BoneWings");
                        break;

                    case ItemID.FlameWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.FlameWings");
                        break;

                    case ItemID.FrozenWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.FrozenWings");
                        break;

                    case ItemID.GhostWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.GhostWings");
                        break;

                    case ItemID.SteampunkWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.SteampunkWings");
                        break;

                    case ItemID.BatWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.BatWings");
                        break;

                    case ItemID.TatteredFairyWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.TatteredFairyWings");
                        break;

                    case ItemID.SpookyWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.SpookyWings");
                        break;

                    case ItemID.FestiveWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.FestiveWings");
                        break;

                    case ItemID.BeetleWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.BeetleWings");
                        break;

                    case ItemID.FinWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.FinWings");
                        break;

                    case ItemID.FishronWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.FishronWings");
                        break;

                    case ItemID.MothronWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.MothronWings");
                        break;

                    case ItemID.WingsSolar:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.WingsSolar");
                        break;

                    case ItemID.WingsVortex:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.WingsVortex");
                        break;

                    case ItemID.WingsStardust:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.WingsStardust");
                        break;

                    case ItemID.LeafWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.LeafWings");
                        break;

                    case ItemID.RedsWings:
                    case ItemID.DTownsWings:
                    case ItemID.WillsWings:
                    case ItemID.CrownosWings:
                    case ItemID.CenxsWings:
                    case ItemID.BejeweledValkyrieWing:
                    case ItemID.Yoraiz0rWings:
                    case ItemID.JimsWings:
                    case ItemID.SkiphsWings:
                    case ItemID.LokisWings:
                    case ItemID.ArkhalisWings:
                    case ItemID.LeinforsWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.Mix");
                        break;

                    case ItemID.WingsNebula:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.WingsNebula");
                        break;

                    case ItemID.Jetpack:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.Jetpack");
                        break;

                    case ItemID.Hoverboard:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.Hoverboard");
                        break;
                }
            });

            ItemHelper.TranslateTooltip(item, tooltips, "Equipable", tooltip =>
            {
                switch (item.type)
                {
                    case ItemID.BetsyWings:
                        tooltip.text = LangHelper.GetTextValue("Calamity.Vanilla.Wings.BetsyWings");
                        break;
                }
            });
        }
    }
}