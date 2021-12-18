namespace CalamityRuTranslate.Core
{
    public interface ILoadable
    {
        float Priority { get; }

        void Load();

        void Unload();
    }
}