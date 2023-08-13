using System;

namespace CalamityRuTranslate.ModCompatibilities;

public record ModInfo(string InternalName, Version ExpectedVersion, bool ShouldCheckVersion);