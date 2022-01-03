// using System.Reflection;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.ModCompatibility;
// using CalamityRuTranslate.Core.MonoMod;
// using Fargowiltas.Items.Summons.SwarmSummons.Thorium;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
// {
//     [ModDependency("Fargowiltas")]
//     [ModDependency("ThoriumMod")]
//     [CultureDependency("ru-RU")]
//     public class OverloadStriderPatch : MonoModPatcher<string>
//     {
//         public override MethodInfo Method => typeof(OverloadStrider).GetCachedMethod(nameof(OverloadStrider.UseItem));
//
//         public override string ModderMethod => nameof(Translation);
//
//         private void Translation(ILContext il)
//         {
//             TranslationHelper.ILTranslation(il, "A wave of frozen air begins howling!", "Морозный ветер завывает!");
//             TranslationHelper.ILTranslation(il, "A wave of frozen air begins howling!", "Морозный ветер завывает!", 2);
//         }
//     }
// }