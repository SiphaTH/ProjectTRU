using CalamityRuTranslate.Core.ModCompatibility;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.GlobalModifications
{
    public abstract class ModifyGlobalItem : GlobalItem, IModDependent
    {
        public virtual bool LoadWithValidMods() => true;

        public virtual bool DependsOnMod() => true;

        public sealed override bool Autoload(ref string name)
        {
            ModifyContentName(ref name);
            return !DependsOnMod();
        }

        public virtual void ModifyContentName(ref string name) { }
    }
}