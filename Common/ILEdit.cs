namespace CalamityRuTranslate.Common
{
    // Original Code https://github.com/Steviegt6/CataclysmMod
    public abstract class ILEdit
    {
        public virtual bool Autoload() => true;

        public abstract void Load();

        public abstract void Unload();
    }
}