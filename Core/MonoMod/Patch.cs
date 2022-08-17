using System;
using System.Reflection;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.MonoMod;

public abstract class Patch<T> : IPatch where T : Delegate
{
    public Mod Mod { get; private set; }

    public abstract MethodInfo ModifiedMethod { get; }

    public MethodInfo ModifyingMethod => PatchMethod.Method;

    object IPatch.PatchMethod => PatchMethod;

    protected abstract T PatchMethod { get; }

    public virtual bool AutoLoad => true;

    public virtual void Apply(IPatchRepository patchRepository)
    {
        if (PatchMethod is ILContext.Manipulator manipulator)
        {
            ILPatch patch = new (ModifiedMethod, manipulator);
            patchRepository.Patches.Add(patch);
            patch.Apply();
        }
    }

    public virtual void Load(Mod mod)
    {
        Mod = mod;

        if (Mod is IPatchRepository repo && AutoLoad)
            Apply(repo);
    }

    public virtual void Unload()
    {
    }
}