using System.Collections.Generic;

namespace CalamityRuTranslate.Core.MonoMod;

public interface IPatchRepository
{
    List<IMonoModPatch> Patches { get; }
}