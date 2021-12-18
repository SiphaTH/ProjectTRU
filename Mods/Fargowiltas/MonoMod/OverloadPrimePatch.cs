using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    public class OverloadPrimePatch : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

        public override void Load()
        {
            IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadPrime.ctor += Translation;
        }

        public override void Unload()
        {
            IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadPrime.ctor -= Translation;
        }

        private void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "A sickly chill envelops the world!", "Мерзкий холод окутывает мир!");
        }
    }
}