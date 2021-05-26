namespace CalamityRuTranslate.Common
{
    public interface ILoadable
    {
        void Load();
        void Unload();
        float Priority { get; }
    }
}