using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications;

public class VanillaWingsTranslation : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(item, tooltips, "Tooltip0", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.CreativeWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CreativeWings.Tooltip"),
                ItemID.AngelWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.AngelWings.Tooltip"),
                ItemID.DemonWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.DemonWings.Tooltip"),
                ItemID.Jetpack => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Jetpack.Tooltip"),
                ItemID.ButterflyWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ButterflyWings.Tooltip"),
                ItemID.FairyWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FairyWings.Tooltip"),
                ItemID.BeeWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BeeWings.Tooltip"),
                ItemID.HarpyWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.HarpyWings.Tooltip"),
                ItemID.BoneWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BoneWings.Tooltip"),
                ItemID.FlameWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FlameWings.Tooltip"),
                ItemID.FrozenWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FrozenWings.Tooltip"),
                ItemID.GhostWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GhostWings.Tooltip"),
                ItemID.BeetleWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BeetleWings.Tooltip"),
                ItemID.FinWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FinWings.Tooltip"),
                ItemID.FishronWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FishronWings.Tooltip"),
                ItemID.SteampunkWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SteampunkWings.Tooltip"),
                ItemID.LeafWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LeafWings.Tooltip"),
                ItemID.BatWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BatWings.Tooltip"),
                ItemID.Yoraiz0rWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Yoraiz0rWings.Tooltip"),
                ItemID.JimsWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.JimsWings.Tooltip"),
                ItemID.SkiphsWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SkiphsWings.Tooltip"),
                ItemID.LokisWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LokisWings.Tooltip"),
                ItemID.ArkhalisWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.ArkhalisWings.Tooltip"),
                ItemID.LeinforsWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LeinforsWings.Tooltip"),
                ItemID.BejeweledValkyrieWing => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BejeweledValkyrieWing.Tooltip"),
                ItemID.RedsWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.RedsWings.Tooltip"),
                ItemID.DTownsWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.DTownsWings.Tooltip"),
                ItemID.WillsWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.WillsWings.Tooltip"),
                ItemID.CrownosWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CrownosWings.Tooltip"),
                ItemID.CenxsWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.CenxsWings.Tooltip"),
                ItemID.FoodBarbarianWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FoodBarbarianWings.Tooltip"),
                ItemID.GroxTheGreatWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GroxTheGreatWings.Tooltip"),
                ItemID.GhostarsWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.GhostarsWings.Tooltip"),
                ItemID.SafemanWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SafemanWings.Tooltip"),
                ItemID.TatteredFairyWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.TatteredFairyWings.Tooltip"),
                ItemID.SpookyWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.SpookyWings.Tooltip"),
                ItemID.Hoverboard => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.Hoverboard.Tooltip"),
                ItemID.FestiveWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.FestiveWings.Tooltip"),
                ItemID.MothronWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.MothronWings.Tooltip"),
                ItemID.WingsSolar => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.WingsSolar.Tooltip"),
                ItemID.WingsStardust => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.WingsStardust.Tooltip"),
                ItemID.WingsVortex => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.WingsVortex.Tooltip"),
                ItemID.WingsNebula => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.WingsNebula.Tooltip"),
                ItemID.RainbowWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.RainbowWings.Tooltip"),
                ItemID.LongRainbowTrailWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.LongRainbowTrailWings.Tooltip"),
                _ => tooltip.Text
            };
        });

        ItemHelper.TranslateTooltip(item, tooltips, "Equipable", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.BetsyWings => LangHelper.GetTextValue("CalamityMod.Items.Vanilla.BetsyWings.Tooltip"),
                _ => tooltip.Text
            };
        });
    }
}