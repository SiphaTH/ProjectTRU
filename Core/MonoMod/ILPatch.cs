using System;
using System.Reflection;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Core.MonoMod;

public readonly struct ILPatch : IMonoModPatch
{
    public readonly MethodInfo BaseMethod;

    public readonly ILContext.Manipulator PatchMethod;

    public readonly Delegate PatchDelegate;

    public ILPatch(MethodInfo baseMethod, ILContext.Manipulator patchMethod)
    {
        BaseMethod = baseMethod;
        PatchMethod = patchMethod;
            
        PatchDelegate = new ILContext.Manipulator(PatchMethod);
    }

    public void Apply() => HookEndpointManager.Modify(BaseMethod, PatchDelegate);

    public void Unapply() => HookEndpointManager.Unmodify(BaseMethod, PatchDelegate);
}