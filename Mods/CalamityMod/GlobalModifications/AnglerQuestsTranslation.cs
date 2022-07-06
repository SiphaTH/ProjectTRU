using CalamityMod.Items.Fishing.BrimstoneCragCatches;
using CalamityMod.Items.Fishing.SunkenSeaCatches;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications;

[JITWhenModsEnabled("CalamityMod")]
public class AnglerQuestTranslation : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
    }

    public override void AnglerChat(int type, ref string chat, ref string catchLocation)
    {
        if (type == ModContent.ItemType<EutrophicSandfish>())
        {
            chat = LangHelper.GetText("CalamityMod.AnglerQuest.EutrophicSandfish.Chat");
            catchLocation = LangHelper.GetText("CalamityMod.AnglerQuest.EutrophicSandfish.CatchLocation");
        }
        else if (type == ModContent.ItemType<Serpentuna>())
        {
            chat = LangHelper.GetText("CalamityMod.AnglerQuest.Serpentuna.Chat");
            catchLocation = LangHelper.GetText("CalamityMod.AnglerQuest.Serpentuna.CatchLocation");
        }
        else if (type == ModContent.ItemType<SurfClam>())
        {
            chat = LangHelper.GetText("CalamityMod.AnglerQuest.SurfClam.Chat");
            catchLocation = LangHelper.GetText("CalamityMod.AnglerQuest.SurfClam.CatchLocation");
        }
        else if (type == ModContent.ItemType<Brimlish>())
        {
            chat = LangHelper.GetText("CalamityMod.AnglerQuest.Brimlish.Chat");
            catchLocation = LangHelper.GetText("CalamityMod.AnglerQuest.Brimlish.CatchLocation");
        }
        else if (type == ModContent.ItemType<Slurpfish>())
        {
            chat = LangHelper.GetText("CalamityMod.AnglerQuest.Slurpfish.Chat");
            catchLocation = LangHelper.GetText("CalamityMod.AnglerQuest.Slurpfish.CatchLocation");
        }
    }
}