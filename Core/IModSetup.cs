using System;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core;

public interface IModSetup : ILoadable
{
    string InternalName { get; }
    
    Version ExpectedVersion { get; }
}