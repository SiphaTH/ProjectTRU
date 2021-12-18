using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    public class OverloadMoonPatch : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

        public override void Load()
        {
            IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadMoon.ctor += Translation;
        }

        public override void Unload()
        {
            IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadMoon.ctor -= Translation;
        }

        private void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "The wind whispers of death's approach!", "Ветер шепчет о приближающейся смерти!");
        }
    }
}