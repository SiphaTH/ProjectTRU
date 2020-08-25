using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Items
{
    internal class ThoriumPrefixName
    {
        public static void Setup()
        {
            PrefixName();
        }
        
        private static void PrefixName()
        {
            Mod thorium = ModLoader.GetMod("ThoriumMod");
            
            thorium.GetPrefix("Loud").DisplayName.AddTranslation(GameCulture.Russian, "Громкий");
            thorium.GetPrefix("Supersonic").DisplayName.AddTranslation(GameCulture.Russian, "Сверхзвуковой");
            thorium.GetPrefix("Vibrant").DisplayName.AddTranslation(GameCulture.Russian, "Вибрирующий");
            thorium.GetPrefix("Euphonic").DisplayName.AddTranslation(GameCulture.Russian, "Благозвучный");
            thorium.GetPrefix("Melodic").DisplayName.AddTranslation(GameCulture.Russian, "Мелодичный");
            thorium.GetPrefix("Inspiring").DisplayName.AddTranslation(GameCulture.Russian, "Вдохновляющий");
            thorium.GetPrefix("Muted").DisplayName.AddTranslation(GameCulture.Russian, "Приглушенный");
            thorium.GetPrefix("OffKey").DisplayName.AddTranslation(GameCulture.Russian, "Нескладный");
            thorium.GetPrefix("Rambling").DisplayName.AddTranslation(GameCulture.Russian, "Бессвязный");
            thorium.GetPrefix("Refined").DisplayName.AddTranslation(GameCulture.Russian, "Настроенный");
            thorium.GetPrefix("Buzzing").DisplayName.AddTranslation(GameCulture.Russian, "Гудящий");
            thorium.GetPrefix("Fabled").DisplayName.AddTranslation(GameCulture.Russian, "Сказочный");
        }
    }
}