using System;
using CalamityRuTranslate.DictionariesAndLists;
using CalamityRuTranslate.Utilities;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.Fargowiltas.NPCs
{
    public static class NPCTranslation
    {
        internal static void SetupTranslation()
        {
            foreach (var id in FargoTranslationLists.FargoNPCs)
            {
                try
                {
                    CoreFargowiltasTranslation.Fargo.GetNPC(id).DisplayName.AddTranslation(GameCulture.Russian, LangUtilities.TranslationKey($"Fargo.NpcName.{id}"));
                }
                catch(NullReferenceException)
                {
                    throw new TranslationException(id);
                }
            }
        }
    }
}