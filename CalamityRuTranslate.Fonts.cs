using CalamityRuTranslate.Common.Utilities;
using ReLogic.Graphics;
using Terraria;

namespace CalamityRuTranslate
{
    partial class CalamityRuTranslate
    {
        private void LoadFont()
        {
            if (Main.dedServ)
                return;

            if (TRuConfig.Instance.NewRussianTerrariaFont && TranslationUtils.IsRussianLanguage)
            {
                Main.fontItemStack = Instance.GetFont("Fonts/Item_Stack");
                Main.fontMouseText = Instance.GetFont("Fonts/Mouse_Text");
                Main.fontDeathText = Instance.GetFont("Fonts/Death_Text");
                Main.fontCombatText[0] = Instance.GetFont("Fonts/Combat_Text");
                Main.fontCombatText[1] = Instance.GetFont("Fonts/Combat_Crit");
            }
        }

        private void UnloadFont()
        {
            if (Main.dedServ)
                return;

            Main.fontItemStack = Main.instance.OurLoad<DynamicSpriteFont>("Fonts/Item_Stack");
            Main.fontMouseText = Main.instance.OurLoad<DynamicSpriteFont>("Fonts/Mouse_Text");
            Main.fontDeathText = Main.instance.OurLoad<DynamicSpriteFont>("Fonts/Death_Text");
            Main.fontCombatText[0] = Main.instance.OurLoad<DynamicSpriteFont>("Fonts/Combat_Text");
            Main.fontCombatText[1] = Main.instance.OurLoad<DynamicSpriteFont>("Fonts/Combat_Crit");
        }
    }
}