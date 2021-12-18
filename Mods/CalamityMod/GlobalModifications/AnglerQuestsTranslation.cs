using CalamityMod.Items.Fishing.BrimstoneCragCatches;
using CalamityMod.Items.Fishing.SunkenSeaCatches;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications
{
    public class AnglerQuestTranslation : CalamityGlobalItemBase
    {
        public override void AnglerChat(int type, ref string chat, ref string catchLocation)
        {
            if (type == ModContent.ItemType<EutrophicSandfish>())
            {
                chat = LangHelper.GetText("Calamity.AnglerQuest.EutrophicSandfish.Chat");
                catchLocation = LangHelper.GetText("Calamity.AnglerQuest.EutrophicSandfish.CatchLocation");
            }
            else if (type == ModContent.ItemType<Serpentuna>())
            {
                chat = LangHelper.GetText("Calamity.AnglerQuest.Serpentuna.Chat");
                catchLocation = LangHelper.GetText("Calamity.AnglerQuest.Serpentuna.CatchLocation");
            }
            else if (type == ModContent.ItemType<SurfClam>())
            {
                chat = LangHelper.GetText("Calamity.AnglerQuest.SurfClam.Chat");
                catchLocation = LangHelper.GetText("Calamity.AnglerQuest.SurfClam.CatchLocation");
            }
            else if (type == ModContent.ItemType<Brimlish>())
            {
                chat = LangHelper.GetText("Calamity.AnglerQuest.Brimlish.Chat");
                catchLocation = LangHelper.GetText("Calamity.AnglerQuest.Brimlish.CatchLocation");
            }
            else if (type == ModContent.ItemType<Slurpfish>())
            {
                chat = LangHelper.GetText("Calamity.AnglerQuest.Slurpfish.Chat");
                catchLocation = LangHelper.GetText("Calamity.AnglerQuest.Slurpfish.CatchLocation");
            }
        }
    }
}