using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;
using Terraria.ID;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsNpcChat : ContentTranslation
{
    public override bool IsTranslationEnabled => ModsCall.FargoSouls != null && TranslationHelper.IsRussianLanguage;
    
    #region Properties
    private int Nurse => NPC.FindFirstNPC(NPCID.Nurse);
    private bool IsTalking => Main.LocalPlayer.talkNPC >= 0;
    private int TalkingNpc => Main.player[Main.myPlayer].talkNPC;
    #endregion

    private bool IsExistingNPC(int npcType) => npcType >= 0;

    public override void LoadTranslation()
    {
        if (!IsTalking)
            return;
            
        string npcPhrase = Main.npcChatText;

        if (TalkingNpc == Nurse)
        {
            npcPhrase = npcPhrase switch
            {
                "I've done all I can in the time I have!" => LangHelper.GetText("FargowiltasSouls.NPCs.Dialogues.Nurse.1"),
                _ => npcPhrase
            };
        }
        
        Main.npcChatText = npcPhrase;
    }
}