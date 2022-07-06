namespace CalamityRuTranslate.Core.MonoMod;

public interface IMonoModPatch
{
    void Apply();

    void Unapply();
}