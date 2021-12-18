using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    public class OverloadWormPatch : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

        public override void Load()
        {
            IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadWorm.ctor += Translation;
        }

        public override void Unload()
        {
            IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadWorm.ctor -= Translation;
        }

        private void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The ground shifts with formulated precision!", "Земля под вашими ногами раздвигается с удивительной точностью!");
        }
    }
}