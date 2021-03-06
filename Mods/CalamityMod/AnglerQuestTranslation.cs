using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class AnglerQuestTranslation : CalamityCompatItem
    {
        public override void AnglerChat(int type, ref string chat, ref string catchLocation)
        {
            if (type == ModsCall.Calamity.ItemType("EutrophicSandfish"))
            {
                chat = LangUtilities.TranslationKey("Calamity.AnglerQuest.EutrophicSandfish.Chat");
                catchLocation = LangUtilities.TranslationKey("Calamity.AnglerQuest.EutrophicSandfish.CatchLocation");
            }
            else if (type == ModsCall.Calamity.ItemType("Serpentuna"))
            {
                chat = LangUtilities.TranslationKey("Calamity.AnglerQuest.Serpentuna.Chat");
                catchLocation = LangUtilities.TranslationKey("Calamity.AnglerQuest.Serpentuna.CatchLocation");
            }
            else if (type == ModsCall.Calamity.ItemType("SurfClam"))
            {
                chat = LangUtilities.TranslationKey("Calamity.AnglerQuest.SurfClam.Chat");
                catchLocation = LangUtilities.TranslationKey("Calamity.AnglerQuest.SurfClam.CatchLocation");
            }
            else if (type == ModsCall.Calamity.ItemType("Brimlish"))
            {
                chat = LangUtilities.TranslationKey("Calamity.AnglerQuest.Brimlish.Chat");
                catchLocation = LangUtilities.TranslationKey("Calamity.AnglerQuest.Brimlish.CatchLocation");
            }
            else if (type == ModsCall.Calamity.ItemType("Slurpfish"))
            {
                chat = LangUtilities.TranslationKey("Calamity.AnglerQuest.Slurpfish.Chat");
                catchLocation = LangUtilities.TranslationKey("Calamity.AnglerQuest.Slurpfish.CatchLocation");
            }
        }
    }
}