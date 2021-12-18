using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod
{
    public class IvyVenomPatch : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;

        public override void Load()
        {
            IL.FargowiltasSouls.Buffs.Masomode.IvyVenom.Update += Translation;
        }

        public override void Unload()
        {
            IL.FargowiltasSouls.Buffs.Masomode.IvyVenom.Update -= Translation;
        }

        private void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Your Ivy Venom has become an Infestation!", "Ваш яд плюща стал заражением!");
        }
    }
}