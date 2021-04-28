using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public class AnglerQuestTranslation : CalamityAutoLoad
    {
        public override void AnglerChat(int type, ref string chat, ref string catchLocation)
        {
            if (type == ModsCall.Calamity.ItemType("EutrophicSandfish"))
            {
                chat = LangUtils.TranslationKey("Calamity.AnglerQuest.EutrophicSandfish.Chat");
                catchLocation = LangUtils.TranslationKey("Calamity.AnglerQuest.EutrophicSandfish.CatchLocation");
            }
            else if (type == ModsCall.Calamity.ItemType("Serpentuna"))
            {
                chat = LangUtils.TranslationKey("Calamity.AnglerQuest.Serpentuna.Chat");
                catchLocation = LangUtils.TranslationKey("Calamity.AnglerQuest.Serpentuna.CatchLocation");
            }
            else if (type == ModsCall.Calamity.ItemType("SurfClam"))
            {
                chat = LangUtils.TranslationKey("Calamity.AnglerQuest.SurfClam.Chat");
                catchLocation = LangUtils.TranslationKey("Calamity.AnglerQuest.SurfClam.CatchLocation");
            }
            else if (type == ModsCall.Calamity.ItemType("Brimlish"))
            {
                chat = LangUtils.TranslationKey("Calamity.AnglerQuest.Brimlish.Chat");
                catchLocation = LangUtils.TranslationKey("Calamity.AnglerQuest.Brimlish.CatchLocation");
            }
            else if (type == ModsCall.Calamity.ItemType("Slurpfish"))
            {
                chat = LangUtils.TranslationKey("Calamity.AnglerQuest.Slurpfish.Chat");
                catchLocation = LangUtils.TranslationKey("Calamity.AnglerQuest.Slurpfish.CatchLocation");
            }
        }
    }
}