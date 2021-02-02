namespace CalamityRuTranslate.Common
{
    public abstract class ILEdit
    {
        public abstract string DictKey { get; }

        public virtual bool Autoload() => true;

        public abstract void Load();

        public abstract void Unload();
    }
    
    public abstract class ILEdit2
    {
        public abstract string DictKey { get; }

        public virtual bool Autoload() => true;

        public abstract void Load();

        public abstract void Unload();
    }
    
    public abstract class ILEdit3
    {
        public abstract string DictKey { get; }

        public virtual bool Autoload() => true;

        public abstract void Load();

        public abstract void Unload();
    }
}