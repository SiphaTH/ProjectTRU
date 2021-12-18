using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.NPCs;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class EModeGlobalNPCPreAI : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(EModeGlobalNPC).GetCachedMethod(nameof(EModeGlobalNPC.PreAI));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " sucked dry.", " выдохся.");
            TranslationHelper.ILTranslation(il, "A Clown has exploded!", "Клоун взорвался!");
            TranslationHelper.ILTranslation(il, "A Clown has exploded!", "Клоун взорвался!", 2);
        }
    }
    
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class EModeGlobalNPCOnHitPlayer : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(EModeGlobalNPC).GetCachedMethod(nameof(EModeGlobalNPC.OnHitPlayer));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " was eaten alive by a Man Eater.", " был съеден заживо людоедом.");
            TranslationHelper.ILTranslation(il, " was eaten alive by an Angry Trapper.", " был съеден заживо злым ловцом.");
            TranslationHelper.ILTranslation(il, "An item was stolen from you!", "У вас украли предмет!");
            TranslationHelper.ILTranslation(il, "An item was stolen from you!", "У вас украли предмет!", 2);
            TranslationHelper.ILTranslation(il, "An item was stolen from you!", "У вас украли предмет!", 3);
            TranslationHelper.ILTranslation(il, "An item was stolen from you!", "У вас украли предмет!", 4);
            TranslationHelper.ILTranslation(il, "An item was stolen from you!", "У вас украли предмет!", 5);
            TranslationHelper.ILTranslation(il, "An item was stolen from you!", "У вас украли предмет!", 6);
            TranslationHelper.ILTranslation(il, "An item was stolen from you!", "У вас украли предмет!", 7);
            TranslationHelper.ILTranslation(il, "An item was stolen from you!", "У вас украли предмет!", 8);
        }
    }
    
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class EModeGlobalNPCModifyHitByItem : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(EModeGlobalNPC).GetCachedMethod(nameof(EModeGlobalNPC.ModifyHitByItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, " was impaled by a Giant Tortoise.", " был пронзён гигантской черепахой.");
        }
    }
}