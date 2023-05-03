using System.Collections.Generic;

namespace CalamityRuTranslate.Vanilla;

public interface IItemGender
{
    List<int> Feminine { get; }
    List<int> Neuter { get; }
    List<int> Plural { get; }
}