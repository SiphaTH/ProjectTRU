using System.Reflection;
using CalamityMod.TileEntities;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class TECodebreakerPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(TECodebreaker).GetCachedMethod("get_UnderlyingSchematicText");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Within an army, as weapons do, the soldiers serve different purposes. That distinction is crucial, as the wrong tool in the wrong hands—no matter how potent—may as well be a wooden club.\nAddendum: Seek out my base of operations closest to the Lihzahrd’s home. I wish you the best of luck with all sincerity, for it has been a long time since I have had a worthy test subject. ", "В армии солдаты, как и оружие, служат разным целям. Это различие имеет решающее значение, поскольку неправильный инструмент в неправильных руках, каким бы мощным он ни был, с таким же успехом может быть деревянной дубиной.\nДополнение: Найдите мою базу, она недалеко от храма ящщеров. Искренне желаю вам удачи. Прошло много времени с тех пор, как у меня был достойный испытуемый.");
            TranslationHelper.ILTranslation(il, "As rank progresses, so often does the lethality of equipment. In the hands of competent soldiers, the weapons have the ability to make change. However, competent soldiers take no action but orders from above.\nAddendum: If you read this, you have come far. Do not disappoint. Go now to Hell, for the next component stored in what were once my forges.", "С ростом в звании неизбежен и рост мощности снаряжения. В компетентных руках оружие способно вносить огромные изменения на всём поле боя. Но эти же руки не самостоятельны, лишь выполняют приказы.\nДополнение: Вы далеко продвинулись. Не разочаровывайте. Теперь идите в Ад. Следующий компонент хранится в месте, что некогда было моими кузницами.");
            TranslationHelper.ILTranslation(il, "Only the highest ranking in the battalions of Yharim’s army held these weapons. However these are still not my most potent tools. Those...characters could not be trusted with them.\nAddendum: The final piece remains. Travel now from the hottest fire this land has to offer, to the most frigid cold. I cannot deny having some sense of poetic symmetry.", "Лишь высшие чины армии Ярима обладали столь смертоносным оружием. Но даже им я не мог доверить мои последние разработки. Этим... лицам не было доверия.\nДополнение: Осталось немного. Теперь же путешествуйте от самого жаркого огня, который может предложить эта земля, до самого лютого мороза. Не могу отрицать, у меня есть некоторое чувство поэтической симметрии.");
            TranslationHelper.ILTranslation(il, "I have since made progress to even greater weapons than these, but they remain creations to be proud of. No progress can be made without a desire that comes from dissatisfaction.\nAddendum: The time has come. You are ready.", "С тех пор я добился немалого прогресса в создании ещё более смертоносного оружия, но они остаются творениями, которыми можно гордиться. Не может быть достигнуто прогресса без желания, проистекающего из неудовлетворённости.\nДополнение: Время пришло. Ты готов.");
        }
    }
}