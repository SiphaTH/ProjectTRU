using System.Reflection;
using CalamityMod.CalPlayer;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class CalamityPlayerPreKill : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.PreKill));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " downed too many shots.", " выпивает слишком много напитков.");
        TranslationHelper.ModifyIL(il, "'s liver failed.", " отказывает печень.");
        TranslationHelper.ModifyIL(il, " was charred by the brimstone inferno.", " обугливается серным пламенем.");
        TranslationHelper.ModifyIL(il, "'s soul was released by the lava.", " душа освобождается лавой.");
        TranslationHelper.ModifyIL(il, "'s soul was extinguished.", " душа гаснет.");
        TranslationHelper.ModifyIL(il, " was melted by the toxic waste.", " расплавляется токсичными отходами.");
        TranslationHelper.ModifyIL(il, " disintegrated into ashes.", " рассыпается в прах.");
        TranslationHelper.ModifyIL(il, " was turned to ashes by the Profaned Goddess.", " обращается Осквернённой богиней в пепел.");
        TranslationHelper.ModifyIL(il, " fell prey to their sins.", " становится жертвой собственных грехов.");
        TranslationHelper.ModifyIL(il, "'s spirit was turned to ash.", " дух превращается в пепел.");
        TranslationHelper.ModifyIL(il, " became a blood geyser.", " становится кровавым гейзером.");
        TranslationHelper.ModifyIL(il, " was crushed by the pressure.", " расплющивается давлением.");
        TranslationHelper.ModifyIL(il, "'s lungs collapsed.", " отказывают лёгкие.");
        TranslationHelper.ModifyIL(il, " was consumed by the black flames.", " поглощается чёрным пламенем.");
        TranslationHelper.ModifyIL(il, "'s flesh was melted by the plague.", " плоть расплавляется чумой.");
        TranslationHelper.ModifyIL(il, " didn't vaccinate.", " не делает прививку.");
        TranslationHelper.ModifyIL(il, "'s infection spread too far.", " инфекция распространяется слишком сильно.");
        TranslationHelper.ModifyIL(il, "'s skin was replaced by the astral virus.", " кожа заменяется астральным вирусом.");
        TranslationHelper.ModifyIL(il, " was incinerated by lunar rays.", " испепеляется лунными лучами.");
        TranslationHelper.ModifyIL(il, " vaporized into thin air.", " испаряется в воздухе.");
        TranslationHelper.ModifyIL(il, "'s life was completely converted into mana.", " здоровье полностью преобразуется в ману.");
        TranslationHelper.ModifyIL(il, " succumbed to alcohol sickness.", " поддаётся алкогольной болезни.");
        TranslationHelper.ModifyIL(il, " withered away.", " иссушается.");
        TranslationHelper.ModifyIL(il, " was summoned too soon.", " призывается слишком рано.");
    };
}

[JITWhenModsEnabled("CalamityMod")]
public class CalamityPlayerKillPlayer : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.KillPlayer));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " is food for the Wyrms.", " становится пищей для змей.");
        TranslationHelper.ModifyIL(il, "Oxygen failed to reach ", "Не хватило кислорода для ");
        TranslationHelper.ModifyIL(il, " from the depths of the Abyss.", " из глубин бездны.");
        TranslationHelper.ModifyIL(il, " failed the challenge at hand.", " не справляется с испытанием.");
        TranslationHelper.ModifyIL(il, " was destroyed by a mysterious force.", " уничтожается таинственной силой.");
    };
}

[JITWhenModsEnabled("CalamityMod")] 
public class CalamityPlayerOnConsumeMana : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityPlayer).GetCachedMethod(nameof(CalamityPlayer.OnConsumeMana));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " converted all of their life to mana.", " оборачивает всю свою жизнь в ману.");
    };
}
