using System.Reflection;
using CalamityMod.UI.DraedonLogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DraedonLogSnowBiomeGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(DraedonLogSnowBiomeGUI).GetCachedMethod(nameof(DraedonLogSnowBiomeGUI.GetTextByPage));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A freezing tundra, where only creatures that have adapted to the subzero temperatures thrive. Few sapient beings have ever permanently resided here, save for miners and the Archmage. With this fact in mind, Yharim has requested I observe this place for oddities due to the armies largely having glossed over this location. Additionally, I have been requested by the Archmage to perform studies on his frigid metals. There is little else to do in this frozen wasteland, and so his request has been accepted.", "Здесь, в морозной тундре обитают лишь те существа, которые адаптировались к отрицательным температурам. Из всех проживающих тут существ единственными разумными были шахтёры и Архимаг. С учётом этого факта, Ярим поручил мне наблюдать за этим местом на предмет странностей, поскольку армии обходили эти пустоши стороной. Кроме этого, Архимаг попросил мне изучить его холодные слитки. В этой морозной пустоши практически нечего делать, поэтому я согласился выполнить его просьбу.");
        TranslationHelper.ModifyIL(il, "Cryonic Ore, as the Archmage simply calls it, is a material seemingly akin to iced over glass. One would assume it is a fragile material at a glance, yet upon testing it is clear that is not the case. Plating made out of it has been found to be more durable and resilient than mythril alloy via flexural and tensile testing, followed by destruction attempts. Yet, it is but a fraction of the weight. Perhaps mass amounts of this material could be used to forge armor for units who disdain for the usual burden of metal plating. I will likely inquire further about the creation methods of Cryonic Ore to achieve this.", "Крионитовая руда, как её называет Архимаг, - это материал, напоминающий по своей структуре замёрзшее стекло. Изначально может показаться, что она хрупкая, но внешний вид обманчив. Испытания на гибкость и растяжимость с последующими попытками разрушения показали, что покрытие из неё более прочное и устойчивое, чем из сплава мифрила. И при всём этом вес крионитовой руды значительно меньше. Возможно, использование больших объёмов этого материала позволит создавать лёгкие и прочные доспехи для солдат, нежелающих носить тяжёлую металлическую броню. Я намерен расспросить Архимага о способах создания крионитовой руды, чтобы достичь этого.");
        TranslationHelper.ModifyIL(il, "As described earlier, Cryonic Ore was developed by the Archmage, Permafrost. Despite his position as the mage of mages, he has little will to engage in combat. He instead acts as advisor to Yharim, assisting in much of the management of cities and towns taken by or sided with the Godkiller. In addition, he seems to have bonded with the girl who arrived seeking Yharim some months ago, acting as a fatherly figure to her. I myself have taken an interest in her immense natural power.", "Как уже упоминалось ранее, крионитовая руда была создана Архимагом Пермафростом. Несмотря на его выдающиеся магические способности среди магов, он не желает участвовать в боях. Вместо этого он служит советником Яриму, помогая в управлении городами и поселениями, захваченными богоубийцей или вставшими на его сторону. Вдобавок он, похоже, сроднился с девушкой, которая прибыла на поиски Ярима несколько месяцев назад, став для неё отцом. Я и сам заинтересовался её огромной природной силой.");
    };
}