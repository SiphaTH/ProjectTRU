using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core;

public interface IContentTranslation
{
    bool IsTranslationEnabled => false;
    
    void LoadTranslation();
}