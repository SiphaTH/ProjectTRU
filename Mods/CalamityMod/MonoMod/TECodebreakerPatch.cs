using System;
using System.Reflection;
using CalamityMod;
using CalamityMod.Items.DraedonMisc;
using CalamityMod.TileEntities;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class TECodebreakerPatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(TECodebreaker).GetCachedMethod("get_UnderlyingSchematicText");

    private delegate string UnderlyingSchematicTextDelegate(TECodebreaker self);

    public override Delegate Delegate => Translation;

    private string Translation(UnderlyingSchematicTextDelegate orig, TECodebreaker self)
    {
        if (self.HeldSchematicID == 0 || !CalamityLists.EncryptedSchematicIDRelationship.ContainsKey(self.HeldSchematicID))
        {
            return string.Empty;
        }
        int num = CalamityLists.EncryptedSchematicIDRelationship[self.HeldSchematicID];
        if (num == ModContent.ItemType<EncryptedSchematicPlanetoid>())
        {
            return "В армии солдаты, как и оружие, служат разным целям. Это различие имеет решающее значение, поскольку неправильный инструмент в неправильных руках, каким бы мощным он ни был, с таким же успехом может быть деревянной дубиной.\nДополнение: Найдите мою базу, она недалеко от Храма яхщеров. Искренне желаю вам удачи. Прошло много времени с тех пор, как у меня был достойный испытуемый.";
        }
        if (num == ModContent.ItemType<EncryptedSchematicJungle>())
        {
            return "С ростом в звании неизбежен и рост мощности снаряжения. В компетентных руках оружие способно вносить огромные изменения на всём поле боя. Но эти же руки не самостоятельны, лишь выполняют приказы.\nДополнение: Вы далеко продвинулись. Не разочаровывайте. Теперь идите в ад. Следующий компонент хранится в месте, что некогда было моими кузницами.";
        }
        if (num == ModContent.ItemType<EncryptedSchematicHell>())
        {
            return "Лишь высшие чины армии Ярима обладали столь смертоносным оружием. Но даже им я не мог доверить мои последние разработки. Этим... лицам не было доверия.\nДополнение: Осталось немного. Теперь же путешествуйте от самого жаркого огня, который может предложить эта земля, до самого лютого мороза. Не могу отрицать, у меня есть некоторое чувство поэтической симметрии.";
        }
        if (num == ModContent.ItemType<EncryptedSchematicIce>())
        {
            return "С тех пор я добился немалого прогресса в создании ещё более смертоносного оружия, но они остаются творениями, которыми можно гордиться. Не может быть достигнуто прогресса без желания, проистекающего из неудовлетворённости.\nДополнение: Время пришло. Ты готов.";
        }
        return string.Empty;
    }
}