using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod
{
    public class AnglerQuestTranslation : GlobalItem
    {
        public override bool Autoload(ref string name) => ModsCall.Thorium != null && TranslationUtils.IsRussianLanguage;

        public override void AnglerChat(int type, ref string chat, ref string catchLocation)
        {
            if (type == ModsCall.Thorium.ItemType("Guppy"))
            {
                chat = LangUtils.TranslationKey("Thorium.AnglerQuest.Guppy.Chat");
                catchLocation = LangUtils.TranslationKey("Thorium.AnglerQuest.Guppy.CatchLocation");
            }
        }
    }
}