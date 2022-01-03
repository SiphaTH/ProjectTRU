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
//     public class OverloadJellyPatch : MonoModPatcher<string>
//     {
//         public override MethodInfo Method => typeof(OverloadJelly).GetCachedMethod(nameof(OverloadJelly.UseItem));
//
//         public override string ModderMethod => nameof(Translation);
//
//         public static void Translation(ILContext il)
//         {
//             TranslationHelper.ILTranslation(il, "National Jelly Day has arrived!", "Наступил национальный день желе!");
//             TranslationHelper.ILTranslation(il, "National Jelly Day has arrived!", "Наступил национальный день желе!", 2);
//         }
//     }
// }