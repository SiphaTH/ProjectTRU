using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.NPCs
{
    public class AnglerQuestTranslation : GlobalItem
    {
        public override void AnglerChat(int type, ref string chat, ref string catchLocation)
        {
            if (CoreCalamityTranslation.CalamityMod != null && CalamityRuTranslate.TRuConfig.CalamityTranslation)
            {
                if (type == CoreCalamityTranslation.CalamityMod.ItemType("EutrophicSandfish"))
                {
                    chat = Translation.KeyText("Calamity.AnglerQuest.EutrophicSandfish.Chat");
                    catchLocation = Translation.KeyText("Calamity.AnglerQuest.EutrophicSandfish.CatchLocation");
                }

                if (type == CoreCalamityTranslation.CalamityMod.ItemType("Serpentuna"))
                {
                    chat = Translation.KeyText("Calamity.AnglerQuest.Serpentuna.Chat");
                    catchLocation = Translation.KeyText("Calamity.AnglerQuest.Serpentuna.CatchLocation");
                }

                if (type == CoreCalamityTranslation.CalamityMod.ItemType("SurfClam"))
                {
                    chat = Translation.KeyText("Calamity.AnglerQuest.SurfClam.Chat");
                    catchLocation = Translation.KeyText("Calamity.AnglerQuest.SurfClam.CatchLocation");
                }

                if (type == CoreCalamityTranslation.CalamityMod.ItemType("Brimlish"))
                {
                    chat = Translation.KeyText("Calamity.AnglerQuest.Brimlish.Chat");
                    catchLocation = Translation.KeyText("Calamity.AnglerQuest.Brimlish.CatchLocation");
                }

                if (type == CoreCalamityTranslation.CalamityMod.ItemType("Slurpfish"))
                {
                    chat = Translation.KeyText("Calamity.AnglerQuest.Slurpfish.Chat");
                    catchLocation = Translation.KeyText("Calamity.AnglerQuest.Slurpfish.CatchLocation");
                }
            }
        }
    }
}