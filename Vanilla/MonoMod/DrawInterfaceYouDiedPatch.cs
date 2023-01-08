using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Content;
using CalamityRuTranslate.Core;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class DrawInterfaceYouDiedPatch : ContentTranslation, ILoadableContent
{
    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage && TRuConfig.Instance.RandomDeathText;

    public override float Priority => 1f;

    public void LoadContent()
    {
        IL.Terraria.Main.DrawInterface_35_YouDied += MainOnDrawInterface_35_YouDied;
    }

    public void UnloadContent()
    {
        IL.Terraria.Main.DrawInterface_35_YouDied -= MainOnDrawInterface_35_YouDied;
    }
    
    private void MainOnDrawInterface_35_YouDied(ILContext il)
    {
        ILCursor cursor = new ILCursor(il);

        cursor.TryGotoNext(i => i.MatchLdsfld<Lang>("inter"));
        cursor.TryGotoNext(i => i.MatchLdloc(1));
        cursor.Index++;
        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldsfld, typeof(TRuPlayer).GetField("RandomDeathText"));
        cursor.TryGotoNext(i => i.MatchLdloc(1));
        cursor.Index++;
        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldsfld, typeof(TRuPlayer).GetField("RandomDeathText"));
    }
}