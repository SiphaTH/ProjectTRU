using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.NPCs
{
    public static class NPCTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var id in FargoSoulsTranslationLists.FargoSoulsNPCs)
            {
                try
                {
                    CoreFargowiltasSoulsTranslation.FargoSouls.GetNPC(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"FargoSouls.NpcName.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}