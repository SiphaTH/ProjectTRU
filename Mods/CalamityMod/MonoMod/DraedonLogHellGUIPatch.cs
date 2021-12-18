using System.Reflection;
using CalamityMod.UI;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class DraedonLogHellGUIPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(DraedonLogHellGUI).GetCachedMethod(nameof(DraedonLogHellGUI.GetTextByPage));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The entire landscape is a constant source of geothermal energy, and heat for a forge. If it was not entirely uninhabitable save for demons and spirits, I would conduct much more of my research in the bowels of the earth. Where I have actively chosen not to settle however, is in the crags of the underworld. There, the magma is... uncooperative and far more corrosive than should be possible, as it is saturated with cursed, twisted souls, courtesy of that Witch.", "Весь природный ландшафт — постоянный источник геотермальной энергии и тепла для кузни. Если бы он не был совсем необитаемым, за исключением демонов и духов, я бы проводил больше исследований в недрах земли. Где я точно ни поселился бы, так это в скалах ада. Магма там... 'несговорчива' и агрессивна, намного больше, чем это возможно. Всё из-за того, что она пропиталась проклятыми тёмными душами, любезно предоставленными этой Ведьмой.");
            TranslationHelper.ILTranslation(il, "A blade completely inundated with my surroundings during the time of its creation. It was tempered by the fires which are fueled by spirits, and formed in the magma I draw into my laboratories. Its cutting edge, unparalleled, though its reach is limited making general usage questionable. I would consider it my very first foray into work for the sake of craftsmanship and art. If I was born synthetically, any creation which leads one to question whether I was, is a creation I may be proud of. It shows that I can after all, be graced by a muse.", "Меч, полностью окружённый моим вниманием во время создания. Он сформировался в магме, а закалён огнём душ. Его лезвие — непревзойдённое, хотя его дальность ограничена, что делает общее применение сомнительным. Я думаю, что это моя первая работа, сделанная во имя искусства и мастерства. Если я был рождён синтетически, то любое моё творение, вызывающие вопрос: «Был ли я создан?» — результат, которым можно гордиться. Это доказывает, что я всё же могу быть удостоенным музы.");
            TranslationHelper.ILTranslation(il, "What a terrible abomination and yet an enticing subject. Not unlike the fusion of spirits which haunts the dungeons, this entity is formed not of one, but a multitude of sinners. What holds different for it however, is that the limitations caused by the artificiality of the dungeon's existence do not apply to it. It is the laws of hell which brought them together into a single overlord of the underworld. And when an innocent life is sacrificed... Their hunger, which appears to be in tune with the afterlife, surges.", "Какое ужасное существо, но всё же интересное с научной точки зрения. В отличие от сплава душ темницы, эта сущность была сформирована не из одного грешника, а из многих. Ещё одно отличие заключается в том, что ограничения, вызванные искусственным происхождением темницы, неприменимы к нему. Именно законы Ада свели их вместе в единого владыку подземного мира. И когда невинная жизнь приносится в жертву... Их голод, который, кажется, является частью загробной жизни, нарастает.");
        }
    }
}