using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsNpcChat : ILoadable, INpcChatText
{
    private int Nurse => NPC.FindFirstNPC(NPCID.Nurse);
    private bool IsTalking => Main.LocalPlayer.talkNPC >= 0;
    private int TalkingNpc => Main.player[Main.myPlayer].talkNPC;
    
    public bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;
    }

    public void NpcChatTextTranslation()
    {
        if (!IsTalking)
            return;

        if (TalkingNpc == Nurse)
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "I've done all I can in the time I have!" => "За это время я сделала всё, что могла!",
                _ => Main.npcChatText
            };
        }
    }
    
    public void Load(Mod mod)
    {
    }

    public void Unload()
    {
    }
}