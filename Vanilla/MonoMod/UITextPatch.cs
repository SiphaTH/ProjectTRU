// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core;
// using On.Terraria.GameContent.UI.Elements;
//
// namespace CalamityRuTranslate.Vanilla.MonoMod;
//
// public class UITextPatch : ContentTranslation, ILoadableContent
// {
//     public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;
//
//     public override float Priority => 1f;
//     
//     public void LoadContent()
//     {
//         UIText.InternalSetText += UITextOnInternalSetText;
//     }
//
//     public void UnloadContent()
//     {
//         UIText.InternalSetText -= UITextOnInternalSetText;
//     }
//
//     private void UITextOnInternalSetText(UIText.orig_InternalSetText orig, Terraria.GameContent.UI.Elements.UIText self, object text, float textscale, bool large)
//     {
//         switch (text as string)
//         {
//             case "Choose a Starfarer to aid you on your journey":
//                 orig.Invoke(self, "Выберите Астру, помогающую вам в пути", textscale, false);
//                 break;
//             case "[c/E36666:This decision is permanent! (per character)]":
//                 orig.Invoke(self, "[c/E36666:Этот выбор не изменить! (для текущего персонажа)]", textscale, false);
//                 break;
//             default:
//                 orig.Invoke(self, text, textscale, large);
//                 break;
//         }
//     }
// }