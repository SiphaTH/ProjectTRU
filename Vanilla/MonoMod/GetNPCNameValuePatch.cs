using CalamityMod.NPCs.GreatSandShark;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using InfernumMode.Core.GlobalInstances.Systems;
using On.Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class GetNPCNameValuePatch : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => ModsCall.Calamity != null && ModsCall.Infernum != null && TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;

    public void LoadContent()
    {
        Lang.GetNPCNameValue += LangOnGetNPCNameValue;
    }

    public void UnloadContent()
    {
        Lang.GetNPCNameValue -= LangOnGetNPCNameValue;
    }
    
    private string LangOnGetNPCNameValue(Lang.orig_GetNPCNameValue orig, int netid)
    {
        if (netid == ModContent.NPCType<GreatSandShark>() && WorldSaveSystem.InfernumMode)
            return "Taurus, the Great Sand Shark";

        return orig(netid);
    }
}