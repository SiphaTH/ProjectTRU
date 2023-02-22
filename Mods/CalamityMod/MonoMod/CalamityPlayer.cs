using System.Reflection;
using CalamityMod.CalPlayer;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class CalamityPlayerPreKill : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.PreKill));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " downed too many shots.", " выпивает слишком много напитков.");
        TranslationHelper.ModifyIL(il, "'s liver failed.", " сажает печень.");
        TranslationHelper.ModifyIL(il, " was charred by the brimstone inferno.", " обугливается серным пекло.");
        TranslationHelper.ModifyIL(il, "'s soul was released by the lava.", " освобождает душу лавой.");
        TranslationHelper.ModifyIL(il, "'s soul was extinguished.", " гасит свою душу.");
        TranslationHelper.ModifyIL(il, " was melted by the toxic waste.", " расплавляется токсичными отходами.");
        TranslationHelper.ModifyIL(il, "'s ashes scatter in the wind.", " развеивает по ветру свой прах.");
        TranslationHelper.ModifyIL(il, " was blown away by miraculous technological advancements.", "");
        TranslationHelper.ModifyIL(il, " disintegrated from the overpowering exotic resonance.", "");
        TranslationHelper.ModifyIL(il, " was turned to ashes by the Profaned Goddess.", " обращается Осквернённой богиней в пепел.");
        TranslationHelper.ModifyIL(il, " fell prey to their sins.", " становится жертвой собственных грехов.");
        TranslationHelper.ModifyIL(il, "'s spirit was turned to ash.", " превращает свой дух в пепел.");
        TranslationHelper.ModifyIL(il, " became a blood geyser.", " становится кровавым гейзером.");
        TranslationHelper.ModifyIL(il, " was crushed by the pressure.", " расплющивается давлением.");
        TranslationHelper.ModifyIL(il, "'s lungs collapsed.", " выплёвывает лёгкие.");
        TranslationHelper.ModifyIL(il, " was consumed by the black flames.", " поглощается чёрным пламенем.");
        TranslationHelper.ModifyIL(il, "'s flesh was melted by the plague.", " расплавляет свою плоть чумой.");
        TranslationHelper.ModifyIL(il, " didn't vaccinate.", " не делает прививку.");
        TranslationHelper.ModifyIL(il, "'s infection spread too far.", " распространяет инфекцию слишком сильно.");
        TranslationHelper.ModifyIL(il, "'s skin was replaced by the astral virus.", " сменяет кожу астральным вирусом.");
        TranslationHelper.ModifyIL(il, " was incinerated by lunar rays.", " испепеляется лунными лучами.");
        TranslationHelper.ModifyIL(il, " vaporized into thin air.", " испаряется в воздухе.");
        TranslationHelper.ModifyIL(il, "'s life was completely converted into mana.", " обращает свою жизнь в ману.");
        TranslationHelper.ModifyIL(il, " succumbed to alcohol sickness.", " поддаётся алкогольной болезни.");
        TranslationHelper.ModifyIL(il, " withered away.", " увядает.");
        TranslationHelper.ModifyIL(il, " was summoned too soon.", " призывается слишком рано.");
    };
}

public class CalamityPlayerKillPlayer : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.KillPlayer));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " is food for the Wyrms.", " становится пищей для змей.");
        TranslationHelper.ModifyIL(il, "Oxygen failed to reach ", "Кислород в глубинах бездны не достигает ");
        TranslationHelper.ModifyIL(il, " from the depths of the Abyss.", ".");
        TranslationHelper.ModifyIL(il, " failed the challenge at hand.", " не справляется с испытанием.");
    };
}

public class CalamityPlayerOnConsumeMana : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.OnConsumeMana));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " converted all of their life to mana.", " преобразовывает всё своё здоровье в ману.");
    };
}

public class CalamityPlayerOnEnterWorld : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.OnEnterWorld));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " [c/EE4939:Check out the Official Calamity Mod Wiki at ][c/3989FF:calamitymod.wiki.gg][c/EE4939:!] ", " [c/EE4939:Актуальную информацию вы можете посмотреть на официальной вики Каламити] [c/3989FF:calamitymod.wiki.gg][c/EE4939:!] ");
        TranslationHelper.ModifyIL(il, " [c/EE4939:Note: The Fandom wiki is no longer supported by Calamity.] ", " [c/EE4939:Обратите внимание: Вики Fandom больше не поддерживается Calamity.] ");
    };
}

public class CalamityPlayerUpdateBadLifeRegen : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.UpdateBadLifeRegen));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "'s flesh was dissolved by sulphuric water.", " растворяет свою плоть в сернистых водах.");
    };
}

public class CalamityPlayerHandleTileEffects : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityPlayer).GetCachedMethod("HandleTileEffects");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " was not worthy", " недостоин");
    };
}