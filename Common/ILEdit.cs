namespace CalamityRuTranslate.Common
{
    public abstract class ILEdit
    {
        public virtual bool Autoload() => true;

        public abstract void Load();

        public abstract void Unload();
    }
}