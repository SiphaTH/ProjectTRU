using Terraria;

namespace CalamityRuTranslate.Mods.CalamityMod
{
    public static class CombatTranslation
    {
        internal static void SetupTranslation()
        {
            for (int i = 0; i < 100; i++)
            {
                if (Main.combatText[i].active)
                {
                    if (Main.combatText[i].text == "No decryption computer installed")
                    {
                        Main.combatText[i].text = "Дешифровальный компьютер не установлен";
                    }
                    if (Main.combatText[i].text == "The Community cracks...")
                    {
                        Main.combatText[i].text = "Сообщество трескается...";
                    }
                    if (Main.combatText[i].text == "The invasion hastens!")
                    {
                        Main.combatText[i].text = "Вторжение ускоряется!";
                    }
                    if (Main.combatText[i].text == "The ethereal invaders march ever-faster!")
                    {
                        Main.combatText[i].text = "Этерианские захватчики маршируют всё быстрее!";
                    }
                    if (Main.combatText[i].text == "You learned how to create new things!")
                    {
                        Main.combatText[i].text = "Вы изучили изготовление новых предметов!";
                    }
                }
            }
        }
    }
}