using Mono.Cecil.Cil;
using MonoMod.Cil;

namespace CalamityRuTranslate.Vanilla
{
    public static class VanillaIL
    {
        public static void LoadIL()
        {
            IL.Terraria.Main.DrawInfoAccs += RU_DrawInfoAccs;
        }

        public static void UnloadIL()
        {
            IL.Terraria.Main.DrawInfoAccs -= RU_DrawInfoAccs;
        }

        private static void RU_DrawInfoAccs(ILContext il)
        {
            ILCursor cursor = new ILCursor(il);

            for (int j = 0; j < 1; j++)
            {
                if (!cursor.TryGotoNext(i => i.MatchLdcI4(12))) return;
            }
            
            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldc_I4, 1000);
            
            cursor = new ILCursor(il);
            
            for (int j = 0; j < 3; j++)
            {
                if (!cursor.TryGotoNext(i => i.MatchLdcI4(12))) return;
            }
            
            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldc_I4, 0);
            
            cursor = new ILCursor(il);
            
            if (!cursor.TryGotoNext(i => i.MatchLdstr("AM"))) return;

            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldstr, "");
            
            cursor = new ILCursor(il);
            
            if (!cursor.TryGotoNext(i => i.MatchLdstr("PM"))) return;

            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldstr, "");
        }
    }
}