// using Terraria;
// using Terraria.Localization;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate
// {
//     public class CalamityRuTranslatePlayer : ModPlayer
//     {
//         public override void OnEnterWorld(Player player)
//         {
//             Main.NewText("Спасибо что используете русификатор модов. Приятной вам игры!", 94, 228, 117);
//             
//             if (CalamityRuTranslate.tRuConfig.NewRussianTerrariaFont && LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
//             {
//                 Main.NewText("Если вам не нравится новый шрифт, вы можете отключить его в настройках конфига!", 178, 34, 34);
//             }
//         }
//     }
// }