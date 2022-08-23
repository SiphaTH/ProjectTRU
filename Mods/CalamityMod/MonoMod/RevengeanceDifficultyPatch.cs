using System.Reflection;
using CalamityMod.Systems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class RevengeanceDifficultyPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(RevengeanceDifficulty).GetCachedMethod("get_ExpandedDescription");

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, ":Enables the][c/85FFE9: Adrenaline] [c/", ":Активирует механику] [c/85FFE9:Адреналина][c/");
        TranslationHelper.ModifyIL(il, ":mechanic. You gain Adrenaline while fighting bosses. Getting hit drops Adrenaline back to 0] \n[c/", ":. Вы получаете адреналин, сражаясь с боссами. Получение урона опускает шкалу адреналина до 0]\n[c/");
        TranslationHelper.ModifyIL(il, ":    When Adrenaline is maxed, press] ", ":Когда шкала адреналина заполнена, нажмите] ");
        TranslationHelper.ModifyIL(il, ":for a large damage boost] \n[c/", ":для значительного увеличения урона] \n[c/");
        TranslationHelper.ModifyIL(il, ":Enables the ][c/FF8B54:Rage][c/", ":Активирует механику] [c/FF8B54:Ярости][c/");
        TranslationHelper.ModifyIL(il, ": mechanic. You gain Rage when in proximity of enemies or by using certain items] \n[c/", ":. Вы получаете ярость, находясь рядом с врагами или используя специальные предметы]\n[c/");
        TranslationHelper.ModifyIL(il, ":    When Rage is maxed, press] ", ":Когда шкала ярости заполнена, нажмите] ");
        TranslationHelper.ModifyIL(il, ":for a temporary damage boost] \n[c/", ":для временного увеличения урона]\n[c/");
        TranslationHelper.ModifyIL(il, ":Most foes have higher stats and deal more damage] \n[c/", ":Большинство врагов имеют более высокие характеристики и наносят больше урона]\n[c/");
        TranslationHelper.ModifyIL(il, ":Bosses have new AI mechanics, new phases, and will drop Master Mode loot. Enemies spawn more frequently] \n[c/F7342A:This mode is more difficult than Expert. Be sure to prepare for the challenge]", ":У боссов новая механика ИИ, новые фазы, и из них выпадают предметы режима Мастера. Враги появляются чаще]\n[c/F7342A:Этот режим сложнее, чем Эксперт. Будьте готовы к испытаниям]");
    };
}