﻿using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;
using Terraria.ID;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeNpcChat : ContentTranslation, INpcChatText
{
    public override bool IsTranslationEnabled => ModsCall.Calamity != null && ModsCall.Infernum != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;
    
    private int Nurse => NPC.FindFirstNPC(NPCID.Nurse);
    private bool IsTalking => Main.LocalPlayer.talkNPC >= 0;
    private int TalkingNpc => Main.player[Main.myPlayer].talkNPC;

    public void NpcChatTextTranslation()
    {
        if (!IsTalking)
            return;

        string npcPhrase = Main.npcChatText;

        if (TalkingNpc == Nurse)
        {
            npcPhrase = npcPhrase switch
            {
                "I cannot help you. Good luck." => LangHelper.GetText("InfernumMode.NPCs.Dialogues.Nurse.1"),
                _ => npcPhrase
            };
        }
        
        Main.npcChatText = npcPhrase;
    }
}