using CalamityRuTranslate.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.ThoriumMod.NPCs
{
    public class AnglerQuestTranslation : GlobalItem
    {
        public override void AnglerChat(int type, ref string chat, ref string catchLocation)
        {
            if (CoreThoriumTranslation.ThoriumMod != null && CalamityRuTranslate.Config.ThoriumTranslation)
            {
                if (type == CoreThoriumTranslation.ThoriumMod.ItemType("Guppy"))
                {
                    chat = Translation.KeyText("Thorium.AnglerQuest.Guppy.Chat");
                    catchLocation = Translation.KeyText("Thorium.AnglerQuest.Guppy.CatchLocation");
                }
            }
        }
    }
}