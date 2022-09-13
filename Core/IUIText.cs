// using CalamityRuTranslate.Common.Utilities;
//
// namespace CalamityRuTranslate.Core;
//
// public interface IUIText
// {
//     public string UITextTranslation();
// }
//
// public class QQQQ : ContentTranslation, IUIText
// {
//     public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;
//
//     public override float Priority => 1f;
//
//     public string UITextTranslation()
//     {
//         string text = "";
//         text = text switch
//         {
//             "Choose a Starfarer to aid you on your journey" => " ЯЧЯЧЯЧ",
//             _ => text
//         };
//
//         return text;
//     }
// }