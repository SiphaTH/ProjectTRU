using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    public class OverloadSlimeCrownPatch : ILEdit
    {
        public override bool Autoload() => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

        public override void Load()
        {
            IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadSlimeCrown.ctor += Translation;
        }

        public override void Unload()
        {
            IL.Fargowiltas.Items.Summons.SwarmSummons.OverloadSlimeCrown.ctor -= Translation;
        }

        private void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Welcome to the true slime rain!", "Добро пожаловать в истинный дождь слизней!");
        }
    }
}