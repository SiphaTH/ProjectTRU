using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod.NPCs
{
    public class AnglerQuestTranslation : GlobalItem
    {
        public override void AnglerChat(int type, ref string chat, ref string catchLocation)
        {
            if (CoreThoriumTranslation.ThoriumMod != null && TRuConfig.Instance.ThoriumTranslation)
            {
                if (type == CoreThoriumTranslation.ThoriumMod.ItemType("Guppy"))
                {
                    chat = TranslationUtils.KeyText("Thorium.AnglerQuest.Guppy.Chat");
                    catchLocation = TranslationUtils.KeyText("Thorium.AnglerQuest.Guppy.CatchLocation");
                }
            }
        }
    }
}