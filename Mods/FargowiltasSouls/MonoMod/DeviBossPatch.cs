using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.NPCs.DeviBoss;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    [ModDependency("FargowiltasSouls")]
    [CultureDependency("ru-RU")]
    public class DeviBossPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(DeviBoss).GetCachedMethod(nameof(DeviBoss.AI));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Wait a second...", "Секундочку...");
            TranslationHelper.ILTranslation(il, "You're throwing money at me!", "Ты бросаешь в меня деньги!");
            TranslationHelper.ILTranslation(il, "Trying to bribe me is pretty gutsy, you know!", "Пытаться подкупить меня - довольно смело, знаешь ли!");
            TranslationHelper.ILTranslation(il, "Then again, this is a LOT of money...", "Но опять же, это большие деньги...");
            TranslationHelper.ILTranslation(il, "Show you're tough enough and I won't mind, but not a second before!", "Покажи, что ты достаточно крут, и я не буду возражать, но ни секундой раньше!");
            TranslationHelper.ILTranslation(il, "But my big bro said not to! What to do, what to do...?", "Но мой старший брат сказал не делать этого! Что делать, что делать..?");
            TranslationHelper.ILTranslation(il, "Here, you can have this back.", "Вот, ты можешь забрать это обратно.");
            TranslationHelper.ILTranslation(il, "Aw, what the heck! But this is our little secret, okay?", "О, чёрт возьми! Но это наш маленький секрет, хорошо?");
            TranslationHelper.ILTranslation(il, "Let's get this show back on the road!", "Ну что, начнём нашу вечеринку!");
            TranslationHelper.ILTranslation(il, "UH OH, STINKY", "Оо стинки");
        }
    }
}