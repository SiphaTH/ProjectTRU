using System.Reflection;
using CalamityMod.Systems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class WhereMalicePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(WhereMalice).GetCachedMethod("get_ExpandedDescription");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "[c/EDEDED:Malice originally came about from an idea to make obtaining Legendary items less RNG-based]\n[c/EDEDED:It was meant to allow the player to enrage specific bosses, giving them new phases or attacks, to guarantee the drop]\n[c/EDEDED:However, this was watered down to what Malice was on release, being a difficulty which affected all bosses, and included RIV(Rare Item Variants)]\n\n[c/EDEDED:At the time, Malice was received poorly by a lot of players due to the bosses being overtuned to the point of being unfair, while locking items behind them]\n[c/939393:      ...No tester had beaten the Exo Mechs on Malice Mode when it released]\n[c/", "[c/EDEDED:Оригинальная идея Злобы родилась из желания сделать выпадение Легендарных предметов менее случайным]\n[c/EDEDED:Она предполагала возможность привести определённых боссов в ярость, наделяя их новыми фазами или атаки, что гарантировало бы выпадение]\n[c/EDEDED:Но на момент релиза сложность Злобы была снижена до уровня, которая влияла на всех боссов и включала редкие варианты предметов]\n\n[c/EDEDED:Сейчас Злоба получает много плохих отзывов от множества игроков, что боссы нечестные, а предметы, следующие по прогрессу за ними, становятся недоступными]\n[c/939393:...Ни один тестер не смог пройти экзо-механизмы в Злобе, когда она только вышла]\n[c/");
        TranslationHelper.ModifyIL(il, ":The explanation was that it was meant to be a \"refight\" mode, but that was never the real intention]\n\n[c/EDEDED:Malice-exclusive drops were eventually removed, as we did not want players to feel obligated to play a poorly balanced difficulty]\n[c/EDEDED:Over time, Malice was balanced to be less unfair, but we realized that with the exclusive drops gone, it was not worth the effort]\n[c/EDEDED:This is why we came down to deleting Malice, so that dev time and effort may be spent elsewhere, notably Death Mode]\n\n[c/", ":Объяснение этому должно звучать как 'для повторной битвы', но в действительности это никогда не было целью Злобы]\n\n[c/EDEDED:Эксклюзивные для Злобы предметы были удалены, поскольку мы не хотели, чтобы игроки заставляли себя играть в плохо сбалансированную сложность]\n[c/EDEDED:Со временем Злоба была сбалансирована и стала менее нечестной, но мы понимали, что если нет эксклюзивных предметов, то нет и смысла в стараниях её пройти]\n[c/EDEDED:И поэтому нами было принято решение удалить Злобу, переключая время разработчиков на иные вещи, в частности, на режим Смерти]\n\n[c/");
        TranslationHelper.ModifyIL(il, ":We acknowledge that some players liked Malice because Death isn't challenging enough for their tastes]\n[c/", ":Мы понимаем, некоторым игрокам понравилась Злоба, поскольку Смерть недостаточно сложна по их вкусу]\n[c/");
        TranslationHelper.ModifyIL(il, ":If you want more difficulty, try the Infernum Addon, Master Mode, higher Boss HP Config, or for amusement, For The Worthy]", ":Если хотите сложности, попробуйте мод Infernum, режим Мастера, увеличить здоровье боссов в настройках или для веселья генерацию For The Worthy]");
    };
}