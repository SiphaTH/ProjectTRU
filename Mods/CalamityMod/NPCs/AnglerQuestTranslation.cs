using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.NPCs
{
    public class AnglerQuestTranslation : GlobalItem
    {
        public override void AnglerChat(int type, ref string chat, ref string catchLocation)
        {
            if (CoreCalamityTranslation.CalamityMod != null && CalamityRuTranslate.Config.CalamityTranslation)
            {
                if (type == CoreCalamityTranslation.CalamityMod.ItemType("EutrophicSandfish"))
                {
                    chat = Translation.KeyText("Calamity.AnglerQuest.EutrophicSandfish.Chat");
                    catchLocation = Translation.KeyText("Calamity.AnglerQuest.EutrophicSandfish.CatchLocation");
                }
                else if (type == CoreCalamityTranslation.CalamityMod.ItemType("Serpentuna"))
                {
                    chat = Translation.KeyText("Calamity.AnglerQuest.Serpentuna.Chat");
                    catchLocation = Translation.KeyText("Calamity.AnglerQuest.Serpentuna.CatchLocation");
                }
                else if (type == CoreCalamityTranslation.CalamityMod.ItemType("SurfClam"))
                {
                    chat = Translation.KeyText("Calamity.AnglerQuest.SurfClam.Chat");
                    catchLocation = Translation.KeyText("Calamity.AnglerQuest.SurfClam.CatchLocation");
                }
                else if (type == CoreCalamityTranslation.CalamityMod.ItemType("Brimlish"))
                {
                    chat = Translation.KeyText("Calamity.AnglerQuest.Brimlish.Chat");
                    catchLocation = Translation.KeyText("Calamity.AnglerQuest.Brimlish.CatchLocation");
                }
                else if (type == CoreCalamityTranslation.CalamityMod.ItemType("Slurpfish"))
                {
                    chat = Translation.KeyText("Calamity.AnglerQuest.Slurpfish.Chat");
                    catchLocation = Translation.KeyText("Calamity.AnglerQuest.Slurpfish.CatchLocation");
                }
            }
        }
    }
}