using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Vanilla.MonoMod
{
    public class DrawInfoAccsIL : ILEdit
    {
        public override bool Autoload() => TranslationHelper.IsRussianLanguage;

        public override void Load() => IL.Terraria.Main.DrawInfoAccs += ChangeDrawInfoAccs;

        public override void Unload() => IL.Terraria.Main.DrawInfoAccs -= ChangeDrawInfoAccs;

        private void ChangeDrawInfoAccs(ILContext il)
        {
            TranslationHelper.ILTranslation(il, 12, 24);
            TranslationHelper.ILTranslation(il, 12, 0, 3);
            TranslationHelper.ILTranslation(il, "AM", "");
            TranslationHelper.ILTranslation(il, "PM", "");
        }
    }
}