using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Core.GlobalInstances.Systems;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class DifficultyManagementSystemPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DifficultyManagementSystem).GetCachedMethod(nameof(DifficultyManagementSystem.PreUpdateWorld));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Infernum is not allowed in Master Mode or For the Worthy.", "Вы не можете включить сложность Инфернум, потому что создали мир или в режиме Мастер, или в генерации «For the Worthy».");
        TranslationHelper.ModifyIL(il, "Eternity mode's boss AI changes are overridden by Infernum if there are conflicts.", "Изменения ИИ боссов в режиме Вечность из Fargo Souls аннулируются Инфернумом в случае возникновения конфликтов.");
    };
}