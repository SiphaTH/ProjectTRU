namespace CalamityRuTranslate.Core.ModCompatibility
{
    public interface IModDependent
    {
        bool LoadWithValidMods();

        bool DependsOnMod();
    }
}