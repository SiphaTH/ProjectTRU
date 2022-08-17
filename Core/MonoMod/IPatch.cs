using System.Reflection;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.MonoMod;

public interface IPatch : ILoadable
{
    Mod Mod { get; }

    MethodInfo ModifiedMethod { get; }

    MethodInfo ModifyingMethod { get; }
        
    bool AutoLoad { get; }

    object PatchMethod { get; }

    void Apply(IPatchRepository patchRepository);
}