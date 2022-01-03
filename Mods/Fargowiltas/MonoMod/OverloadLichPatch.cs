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
//     public class OverloadLichPatch : MonoModPatcher<string>
//     {
//         public override MethodInfo Method => typeof(OverloadLich).GetCachedMethod(nameof(OverloadLich.UseItem));
//
//         public override string ModderMethod => nameof(Translation);
//
//         public static void Translation(ILContext il)
//         {
//             TranslationHelper.ILTranslation(il, "Death is in the air!", "Смерть витает в воздухе!");
//             TranslationHelper.ILTranslation(il, "Death is in the air!", "Смерть витает в воздухе!", 2);
//         }
//     }
// }