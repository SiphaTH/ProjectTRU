using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public class VanillaBuffTranslation : GlobalBuff
    {
        public override bool Autoload(ref string name) => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            switch (type)
            {
                case BuffID.ShadowDodge:
                    tip = LangUtils.GetTextValue("FargoSouls", "Vanilla.BuffDescription.ShadowDodge");
                    break;
                
                case BuffID.IceBarrier:
                    tip = LangUtils.GetTextValue("FargoSouls", "Vanilla.BuffDescription.IceBarrier");
                    break;
            }
        }
    }
}