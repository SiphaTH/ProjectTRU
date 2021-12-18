using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class FargowiltasLoad : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(global::Fargowiltas.Fargowiltas).GetCachedMethod(nameof(global::Fargowiltas.Fargowiltas.Load));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Quick Recall/Mirror", "Быстрый возврат/зеркало");
            TranslationHelper.ILTranslation(il, "Quick Rod of Discord", "Быстрый жезл раздора");
            TranslationHelper.ILTranslation(il, "Quick Use Custom (Bottom Left Inventory Slot)", "Быстрое использование предмета (нижний левый слот в инвентаре)");
            TranslationHelper.ILTranslation(il, "Open Stat Sheet", "Таблица характеристик");
        }
    }
    
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class FargowiltasPostSetupContent : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(global::Fargowiltas.Fargowiltas).GetCachedMethod(nameof(global::Fargowiltas.Fargowiltas.PostSetupContent));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Defeat any rare enemy or... embrace eternity", "Одолейте любого редкого врага или... примите вечность");
            TranslationHelper.ILTranslation(il, "Defeat any boss or miniboss", "Одолейте любого босса или мини-босса");
            TranslationHelper.ILTranslation(il, "Chop down enough trees", "Срубите достаточно деревьев");
            TranslationHelper.ILTranslation(il, "Clear any event", "Пройдите любое событие");
            TranslationHelper.ILTranslation(il, "Have a Top Hat Squirrel ([i:{0}]) in your inventory", "Положите в инвентарь белку в цилиндре ([i:{0}])");
        }
    }
    
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class FargowiltasHandlePacket : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(global::Fargowiltas.Fargowiltas).GetCachedMethod(nameof(global::Fargowiltas.Fargowiltas.HandlePacket));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The event has been cancelled!", "Событие было остановлено!");
        }
    }
}