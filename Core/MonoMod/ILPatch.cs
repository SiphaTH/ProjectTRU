using System;
using System.Reflection;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Core.MonoMod;

public readonly struct ILPatch : IMonoModPatch
{
    private readonly MethodInfo _baseMethod;

    private readonly Delegate _patchDelegate;

    public ILPatch(MethodInfo baseMethod, ILContext.Manipulator patchMethod)
    {
        _baseMethod = baseMethod;
        _patchDelegate = new ILContext.Manipulator(patchMethod);
    }

    public void Apply() => HookEndpointManager.Modify(_baseMethod, _patchDelegate);

    public void Unapply() => HookEndpointManager.Unmodify(_baseMethod, _patchDelegate);
}