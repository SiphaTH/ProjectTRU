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
    public class LabHologramProjectorUIPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(LabHologramProjectorUI).GetCachedMethod(nameof(LabHologramProjectorUI.ChooseDialogue));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "To any personnel engaged in the laboratories. Please wear your steel engraved ID badge at all times. It is the easiest method to discern your body if any accidents do occur.", "Напоминаем всему персоналу. Пожалуйста, носите ваш персональный стальной идентификационный значок. Это самый простой способ опознать тело в случае несчастного случая.");
            TranslationHelper.ILTranslation(il, "To experiment is to fail. To fail is to learn. To learn is to advance.", "Экспериментировать — значит терпеть неудачи. Терпеть неудачи — значит учиться. Учиться — значит становиться лучше.");
            TranslationHelper.ILTranslation(il, "Apparent danger while researching serves only to enhance the research experience.", "Кажущаяся опасность во время исследований только усиливает исследовательский опыт.");
            TranslationHelper.ILTranslation(il, "Laser-type weapon prototypes are incredibly lethal and are not to be used within presentation halls.", "Прототипы лазерного оружия невероятно смертоносны и не должны использоваться в презентационных залах.");
            TranslationHelper.ILTranslation(il, "High-energy plasma emissions have adverse effects on both flesh and metal. Do not attempt to handle vented plasma.", "Высокоэнергетические плазменные выбросы оказывают неблагоприятное воздействие как на плоть, так и на металл. Не пытайтесь обращаться с изливающейся плазмой.");
            TranslationHelper.ILTranslation(il, "Electric shocks from military equipment are intended to be fatal. If you survive such a shock, that is a clear indicator that the device is not functioning properly. Please report any such cases.", "Удары электрического тока, вызванные оружием, должны быть летальными. Если вы пережили удар током, это явный признак того, что устройство не функционирует должным образом. Пожалуйста, сообщите о любых таких случаях.");
            TranslationHelper.ILTranslation(il, "All employees are hereby notified that they will be held accountable for any collateral damage caused by Gauss weapon fire, even during sanctioned testing exercises.", "Все сотрудники уведомляются, что они будут нести ответственность за любой сопутствующий ущерб, причинённый огнём гауссовского оружия, даже во время санкционированных испытательных учений.");
            TranslationHelper.ILTranslation(il, "Security Field Emitters will vaporize all unauthorized equipment and personnel. Please leave personal effects in the designated lockers off-site. This also means: Do not bring any family members who are not enlisted as personnel.", "Излучатели защитного поля уничтожат всё несанкционированное оборудование и персонал. Пожалуйста, оставьте личные вещи в специально отведённых запирающихся шкафчиках за пределами поля. Это также означает: Не приводите с собой членов семьи, которые не зачислены в личный состав.");
            TranslationHelper.ILTranslation(il, "If one does manage to breach restricted testing facilities, do at least record any unexpected burns, lacerations, bruising, fractur... ...trauma, shocks and otherwise. Thank you.", "Если кто-то всё же решит пробраться в закрытые испытательные помещения, то хотя бы сделайте запись неожиданных ожогов, рваных ран, кровоизлияний, переломов... травм, шоковых ожогов и др. Спасибо.");
            TranslationHelper.ILTranslation(il, "The power grid has been... ...eavily compromised. Abort research and proceed to the emergency exits located at... ...and egress with haste.", "Энергосистема была... ...кована, серьёзные повреждения. Прервите исследования и пройдите к аварийным выходам, расположенным... ...и выходите с поспешностью.");
            TranslationHelper.ILTranslation(il, "Notify the Security Department of any aggressive local fauna immediately.", "Немедленно сообщите в Службу безопасности о любой местной агрессивной фауне.");
            TranslationHelper.ILTranslation(il, "Sensors have detected a significant breach in the spacetime continuum.", "Сенсоры обнаружили значительное нарушение пространственно-временного континуума.");
            TranslationHelper.ILTranslation(il, "Please help. I'm stuck in this hologram machine.", "Пожалуйста, помогите. Я застрял в голограмме.");
        }
    }
}