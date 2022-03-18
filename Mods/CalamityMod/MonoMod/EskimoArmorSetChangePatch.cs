using System.Reflection;
using CalamityMod.Items.VanillaArmorChanges;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class EskimoArmorSetChangePatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(EskimoArmorSetChange).GetCachedMethod(nameof(EskimoArmorSetChange.UpdateSetBonusText));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, $"All ice-themed damage over time debuffs receive a 50% damage bonus\nCold enemies will deal reduced contact damage to the player\nProvides immunity to the Frostburn and Glacial State debuffs", $"Все дебаффы связанные с холодом, наносящие постепенный урон, получают 50% бонус к урону\nВраги, связанные с холодом, наносят сниженный урон\nОбеспечивает невосприимчивостью к дебаффам «{Language.GetTextValue("BuffName.Frostburn")}» и «{Language.GetTextValue("Mods.CalamityRuTranslate.Calamity.BuffName.GlacialState")}»");
        }
    }
}