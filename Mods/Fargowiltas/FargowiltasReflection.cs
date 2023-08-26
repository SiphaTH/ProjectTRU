using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Fargowiltas.UI;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas;

public class FargowiltasReflection : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return !Main.dedServ && ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        StatSheetUI statSheet = global::Fargowiltas.Fargowiltas.UserInterfaceManager.StatSheet;
        const float backWidth = 840f;
        
        statSheet.BackPanel.Width.Set(backWidth, 0f);
        statSheet.InnerPanel.Width.Set(backWidth - 12f, 0f);
    }

    public void Unload()
    {
    }
}