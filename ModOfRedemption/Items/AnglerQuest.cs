using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ModOfRedemption.Items
{
    public class AnglerQuest : GlobalItem
    {
        public override void AnglerChat(int type, ref string chat, ref string catchLocation)
        {
            Mod redemption = ModLoader.GetMod("Redemption");
            if (redemption != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian && type == redemption.ItemType("XenChomper"))
            {
                chat = "Ну, я отправился на рыбалку в пустошь, захотелось поймать одну из этих странных зеленых рыб. А потом увидел странную желтую, покрытую желтыми кристаллами! Хочу сделать с ней что-нибудь. Принеси мне её!";
                catchLocation = "Поймать в Пустоши";
            }
        }
    }
}