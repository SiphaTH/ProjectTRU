using CalamityRuTranslate.Common.Utilities;
using Terraria.ID;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.GlobalModifications
{
    public class VanillaBuffsTranslation : FargoSoulsGlobalBuffBase
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            switch (type)
            {
                case BuffID.ShadowDodge:
                    tip = LangHelper.GetTextValue("FargoSouls.Vanilla.BuffDescription.ShadowDodge");
                    break;

                case BuffID.IceBarrier:
                    tip = LangHelper.GetTextValue("FargoSouls.Vanilla.BuffDescription.IceBarrier");
                    break;
            }
        }
    }
}