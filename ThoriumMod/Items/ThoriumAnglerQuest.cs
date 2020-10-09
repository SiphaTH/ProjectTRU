using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Items
{
    public class ThoriumAnglerQuest : GlobalItem
    {
        public override void AnglerChat(int type, ref string chat, ref string catchLocation)
        {
            if (ModLoader.GetMod("ThoriumMod") != null && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (CalamityRuTranslate.TRuConfig.ThoriumTranslation)
                {
                    if (type == ModLoader.GetMod("ThoriumMod").ItemType("Guppy"))
                    {
                        chat = "Находиться в море столь долго было так одиноко... я завел себе друга - маленькую рыбку, которую я назвал Маленьким Гаппи! Однако, он вечно сбегает из своего аквариума! Я его потерял и он мне дорог, так что поймай его, друг мой!";
                        catchLocation = "Поймать в Океане";
                    }
                }
            }
        }
    }
}