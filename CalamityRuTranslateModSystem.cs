using System;
using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate;

public class CalamityRuTranslateModSystem : ModSystem
{
    public static Dictionary<int, string> ArmorSetBonus = new();
    private List<INpcChatText> _npcChatText = new();
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void OnModLoad()
    {
        IEnumerable<Type> types = CalamityRuTranslate.Instance.Code.GetTypes().Where(t => !t.IsAbstract && t.GetInterfaces().Contains(typeof(INpcChatText)) && t.GetInterfaces().Contains(typeof(ILoadable)));
        
        foreach (Type type in types)
        {
            object instance = Activator.CreateInstance(type);
            if (instance is ILoadable loadable && loadable.IsLoadingEnabled(CalamityRuTranslate.Instance))
            {
                if (instance is INpcChatText npcChatTextInstance)
                {
                    _npcChatText.Add(npcChatTextInstance);
                }
            }
        }
    }

    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        foreach (INpcChatText npcChatText in _npcChatText)
        {
            npcChatText.NpcChatTextTranslation();
        }
    }

    public override void OnModUnload()
    {
        ArmorSetBonus.Clear();
        ArmorSetBonus = null;
    }

    public override void OnLocalizationsLoaded()
    {
        ArmorSetBonus[ItemID.ShroomiteHeadgear] = Language.GetTextValue("ArmorSetBonus.Shroomite");
        ArmorSetBonus[ItemID.ShroomiteMask] = Language.GetTextValue("ArmorSetBonus.Shroomite");
        ArmorSetBonus[ItemID.ShroomiteHelmet] = Language.GetTextValue("ArmorSetBonus.Shroomite");
        ArmorSetBonus[ItemID.WoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonus[ItemID.EbonwoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonus[ItemID.RichMahoganyHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonus[ItemID.PearlwoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonus[ItemID.ShadewoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonus[ItemID.BorealWoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonus[ItemID.PalmWoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonus[ItemID.AshWoodHelmet] = Language.GetTextValue("ArmorSetBonus.AshWood");
        ArmorSetBonus[ItemID.CopperHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier1");
        ArmorSetBonus[ItemID.AncientIronHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier1");
        ArmorSetBonus[ItemID.IronHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier1");
        ArmorSetBonus[ItemID.TinHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier1");
        ArmorSetBonus[ItemID.SilverHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier2");
        ArmorSetBonus[ItemID.AncientGoldHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier2");
        ArmorSetBonus[ItemID.LeadHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier2");
        ArmorSetBonus[ItemID.TungstenHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier2");
        ArmorSetBonus[ItemID.PlatinumHelmet] = Language.GetTextValue("ArmorSetBonus.Platinum");
        ArmorSetBonus[ItemID.PumpkinHelmet] = Language.GetTextValue("ArmorSetBonus.Pumpkin");
        ArmorSetBonus[ItemID.GladiatorHelmet] = Language.GetTextValue("ArmorSetBonus.Gladiator");
        ArmorSetBonus[ItemID.NinjaHood] = Language.GetTextValue("ArmorSetBonus.Ninja");
        ArmorSetBonus[ItemID.FossilHelm] = Language.GetTextValue("ArmorSetBonus.Fossil");
        ArmorSetBonus[ItemID.AncientNecroHelmet] = Language.GetTextValue("ArmorSetBonus.Bone");
        ArmorSetBonus[ItemID.NecroHelmet] = Language.GetTextValue("ArmorSetBonus.Bone");
        ArmorSetBonus[ItemID.BeetleHelmet] = $"Если надета {Language.GetTextValue("ItemName.BeetleScaleMail")}: {Language.GetTextValue("ArmorSetBonus.BeetleDamage")}\nЕсли надет {Language.GetTextValue("ItemName.BeetleShell")}: {Language.GetTextValue("ArmorSetBonus.BeetleDefense")}";
        ArmorSetBonus[ItemID.WizardHat] = Language.GetTextValue("ArmorSetBonus.Wizard");
        ArmorSetBonus[ItemID.MagicHat] = Language.GetTextValue("ArmorSetBonus.MagicHat");
        ArmorSetBonus[ItemID.ShadowHelmet] = Language.GetTextValue("ArmorSetBonus.ShadowScale");
        ArmorSetBonus[ItemID.AncientShadowHelmet] = Language.GetTextValue("ArmorSetBonus.ShadowScale");
        ArmorSetBonus[ItemID.CrimsonHelmet] = Language.GetTextValue("ArmorSetBonus.Crimson");
        ArmorSetBonus[ItemID.SpectreHood] = Language.GetTextValue("ArmorSetBonus.SpectreHealing");
        ArmorSetBonus[ItemID.SpectreMask] = Language.GetTextValue("ArmorSetBonus.SpectreDamage");
        ArmorSetBonus[ItemID.MeteorHelmet] = Language.GetTextValue("ArmorSetBonus.Meteor");
        ArmorSetBonus[ItemID.FrostHelmet] = Language.GetTextValue("ArmorSetBonus.Frost");
        ArmorSetBonus[ItemID.AncientCobaltHelmet] = Language.GetTextValue("ArmorSetBonus.Jungle");
        ArmorSetBonus[ItemID.JungleHat] = Language.GetTextValue("ArmorSetBonus.Jungle");
        ArmorSetBonus[ItemID.MoltenHelmet] = Language.GetTextValue("ArmorSetBonus.Molten");
        ArmorSetBonus[ItemID.EskimoHood] = Language.GetTextValue("ArmorSetBonus.Snow");
        ArmorSetBonus[ItemID.PinkEskimoHood] = Language.GetTextValue("ArmorSetBonus.Snow");
        ArmorSetBonus[ItemID.MiningHelmet] = Language.GetTextValue("ArmorSetBonus.Mining");
        ArmorSetBonus[ItemID.UltrabrightHelmet] = Language.GetTextValue("ArmorSetBonus.Mining");
        ArmorSetBonus[ItemID.ChlorophyteMask] = Language.GetTextValue("ArmorSetBonus.ChlorophyteMelee");
        ArmorSetBonus[ItemID.ChlorophyteHelmet] = Language.GetTextValue("ArmorSetBonus.Chlorophyte");
        ArmorSetBonus[ItemID.ChlorophyteHeadgear] = Language.GetTextValue("ArmorSetBonus.Chlorophyte");
        ArmorSetBonus[ItemID.AnglerHat] = Language.GetTextValue("ArmorSetBonus.Angler");
        ArmorSetBonus[ItemID.CactusHelmet] = Language.GetTextValue("ArmorSetBonus.Cactus");
        ArmorSetBonus[ItemID.TurtleHelmet] = Language.GetTextValue("ArmorSetBonus.Turtle");
        ArmorSetBonus[ItemID.CobaltHat] = Language.GetTextValue("ArmorSetBonus.CobaltCaster");
        ArmorSetBonus[ItemID.CobaltHelmet] = Language.GetTextValue("ArmorSetBonus.CobaltMelee");
        ArmorSetBonus[ItemID.CobaltMask] = Language.GetTextValue("ArmorSetBonus.CobaltRanged");
        ArmorSetBonus[ItemID.MythrilHood] = Language.GetTextValue("ArmorSetBonus.MythrilCaster");
        ArmorSetBonus[ItemID.MythrilHelmet] = Language.GetTextValue("ArmorSetBonus.MythrilMelee");
        ArmorSetBonus[ItemID.MythrilHat] = Language.GetTextValue("ArmorSetBonus.MythrilRanged");
        ArmorSetBonus[ItemID.AdamantiteHeadgear] = Language.GetTextValue("ArmorSetBonus.AdamantiteCaster");
        ArmorSetBonus[ItemID.AdamantiteHelmet] = Language.GetTextValue("ArmorSetBonus.AdamantiteMelee");
        ArmorSetBonus[ItemID.AdamantiteMask] = Language.GetTextValue("ArmorSetBonus.AdamantiteRanged");
        ArmorSetBonus[ItemID.PalladiumMask] = Language.GetTextValue("ArmorSetBonus.Palladium");
        ArmorSetBonus[ItemID.PalladiumHelmet] = Language.GetTextValue("ArmorSetBonus.Palladium");
        ArmorSetBonus[ItemID.PalladiumHeadgear] = Language.GetTextValue("ArmorSetBonus.Palladium");
        ArmorSetBonus[ItemID.OrichalcumMask] = Language.GetTextValue("ArmorSetBonus.Orichalcum");
        ArmorSetBonus[ItemID.OrichalcumHelmet] = Language.GetTextValue("ArmorSetBonus.Orichalcum");
        ArmorSetBonus[ItemID.OrichalcumHeadgear] = Language.GetTextValue("ArmorSetBonus.Orichalcum");
        ArmorSetBonus[ItemID.TitaniumHeadgear] = Language.GetTextValue("ArmorSetBonus.Titanium");
        ArmorSetBonus[ItemID.TitaniumMask] = Language.GetTextValue("ArmorSetBonus.Titanium");
        ArmorSetBonus[ItemID.TitaniumHelmet] = Language.GetTextValue("ArmorSetBonus.Titanium");
        ArmorSetBonus[ItemID.HallowedHeadgear] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonus[ItemID.HallowedHelmet] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonus[ItemID.HallowedMask] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonus[ItemID.HallowedHood] = Language.GetTextValue("ArmorSetBonus.HallowedSummoner");
        ArmorSetBonus[ItemID.AncientHallowedHeadgear] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonus[ItemID.AncientHallowedHelmet] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonus[ItemID.AncientHallowedMask] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonus[ItemID.AncientHallowedHood] = Language.GetTextValue("ArmorSetBonus.HallowedSummoner");
        ArmorSetBonus[ItemID.CrystalNinjaHelmet] = Language.GetTextValue("ArmorSetBonus.CrystalNinja");
        ArmorSetBonus[ItemID.TikiMask] = Language.GetTextValue("ArmorSetBonus.Tiki");
        ArmorSetBonus[ItemID.SpookyHelmet] = Language.GetTextValue("ArmorSetBonus.Spooky");
        ArmorSetBonus[ItemID.BeeHeadgear] = Language.GetTextValue("ArmorSetBonus.Bee");
        ArmorSetBonus[ItemID.SpiderMask] = Language.GetTextValue("ArmorSetBonus.Spider");
        ArmorSetBonus[ItemID.SolarFlareHelmet] = Language.GetTextValue("ArmorSetBonus.Solar");
        ArmorSetBonus[ItemID.VortexHelmet] = Language.GetTextValue("ArmorSetBonus.Vortex", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
        ArmorSetBonus[ItemID.NebulaHelmet] = Language.GetTextValue("ArmorSetBonus.Nebula");
        ArmorSetBonus[ItemID.StardustHelmet] = Language.GetTextValue("ArmorSetBonus.Stardust", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
        ArmorSetBonus[ItemID.AncientBattleArmorHat] = Language.GetTextValue("ArmorSetBonus.Forbidden", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
        ArmorSetBonus[ItemID.SquireGreatHelm] = Language.GetTextValue("ArmorSetBonus.SquireTier2");
        ArmorSetBonus[ItemID.ApprenticeHat] = Language.GetTextValue("ArmorSetBonus.ApprenticeTier2");
        ArmorSetBonus[ItemID.HuntressWig] = Language.GetTextValue("ArmorSetBonus.HuntressTier2");
        ArmorSetBonus[ItemID.MonkBrows] = Language.GetTextValue("ArmorSetBonus.MonkTier2");
        ArmorSetBonus[ItemID.SquireAltHead] = Language.GetTextValue("ArmorSetBonus.SquireTier3");
        ArmorSetBonus[ItemID.ApprenticeAltHead] = Language.GetTextValue("ArmorSetBonus.ApprenticeTier3");
        ArmorSetBonus[ItemID.HuntressAltHead] = Language.GetTextValue("ArmorSetBonus.HuntressTier3");
        ArmorSetBonus[ItemID.MonkAltHead] = Language.GetTextValue("ArmorSetBonus.MonkTier3");
        ArmorSetBonus[ItemID.ObsidianHelm] = Language.GetTextValue("ArmorSetBonus.ObsidianOutlaw");
        
        if (ModsCall.Calamity != null)
        {
            ArmorSetBonus[ItemID.AdamantiteHeadgear] = $"{Language.GetTextValue("ArmorSetBonus.AdamantiteCaster")}\nПоловина текущего сопротивления урону добавляется к шансу критического удара\nНепрерывно нанося урон, вы постепенно получаете всё больше и больше защиты, вплоть до 15\nПри бездействии, этот бонус постепенно убывает\nЭта дополнительная защита может быть снижена уроном по защите";
            ArmorSetBonus[ItemID.AdamantiteHelmet] = "Увеличивает скорость атаки ближнего боя на 15% и скорость передвижения на 20%\nПоловина текущего сопротивления урону добавляется к шансу критического удара\nНепрерывно нанося урон, вы постепенно получаете всё больше и больше защиты, вплоть до 15\nПри бездействии, этот бонус постепенно убывает\nЭта дополнительная защита может быть снижена уроном по защите";
            ArmorSetBonus[ItemID.AdamantiteMask] = $"{Language.GetTextValue("ArmorSetBonus.AdamantiteRanged")}\nПоловина текущего сопротивления урону добавляется к шансу критического удара\nНепрерывно нанося урон, вы постепенно получаете всё больше и больше защиты, вплоть до 15\nПри бездействии, этот бонус постепенно убывает\nЭта дополнительная защита может быть снижена уроном по защите";
            ArmorSetBonus[ItemID.CobaltHelmet] = "Увеличивает скорость атаки ближнего боя 10%\nУвеличивает максимальную скорость передвижения и ускорение на 10%\nВы получаете бонус к урону и шансу критического удара относительно текущей скорости передвижения, максимум 10%";
            ArmorSetBonus[ItemID.CobaltHat] = $"{Language.GetTextValue("ArmorSetBonus.CobaltCaster")}\nУвеличивает максимальную скорость передвижения и ускорение на 10%\nВы получаете бонус к урону и шансу критического удара относительно текущей скорости передвижения, максимум 10%";
            ArmorSetBonus[ItemID.CobaltMask] = $"{Language.GetTextValue("ArmorSetBonus.CobaltRanged")}\nУвеличивает максимальную скорость передвижения и ускорение на 10%\nВы получаете бонус к урону и шансу критического удара относительно текущей скорости передвижения, максимум 10%";
            ArmorSetBonus[ItemID.MythrilHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MythrilMelee")}\nУдары по врагам вызывают мифриловые вспышки, которые нацеливаются на врагов после небольшой задержки\nПосле создания вспышки происходит задержка в 12 кадров до появления новой вспышки";
            ArmorSetBonus[ItemID.MythrilHood] = $"{Language.GetTextValue("ArmorSetBonus.MythrilCaster")}\nУдары по врагам вызывают мифриловые вспышки, которые нацеливаются на врагов после небольшой задержки\nПосле создания вспышки происходит задержка в 12 кадров до появления новой вспышки";
            ArmorSetBonus[ItemID.MythrilHat] = $"{Language.GetTextValue("ArmorSetBonus.MythrilRanged")}\nУдары по врагам вызывают мифриловые вспышки, которые нацеливаются на врагов после небольшой задержки\nПосле создания вспышки происходит задержка в 12 кадров до появления новой вспышки";
            ArmorSetBonus[ItemID.ShadowHelmet] = "Увеличивает максимальную скорость передвижения и ускорение на 15%";
            ArmorSetBonus[ItemID.AncientShadowHelmet] = "Увеличивает максимальную скорость передвижения и ускорение на 15%";
            ArmorSetBonus[ItemID.EskimoHood] = $"Увеличивает урон всех дебаффов связанных с холодом на 25%\nВраги, связанные с холодом, наносят сниженный контактный урон\nОбеспечивает невосприимчивостью к дебаффам «{Language.GetTextValue("BuffName.Chilled")}», «{Language.GetTextValue("BuffName.Frozen")}», «{Language.GetTextValue("BuffName.Frostburn")}» и «{Language.GetTextValue("Mods.CalamityMod.Buffs.GlacialState.DisplayName")}»";
            ArmorSetBonus[ItemID.PinkEskimoHood] = $"Увеличивает урон всех дебаффов связанных с холодом на 25%\nВраги, связанные с холодом, наносят сниженный контактный урон\nОбеспечивает невосприимчивостью к дебаффам «{Language.GetTextValue("BuffName.Chilled")}», «{Language.GetTextValue("BuffName.Frozen")}», «{Language.GetTextValue("BuffName.Frostburn")}» и «{Language.GetTextValue("Mods.CalamityMod.Buffs.GlacialState.DisplayName")}»";
            ArmorSetBonus[ItemID.ChlorophyteHeadgear] = "Призывает мощный кристальный лист, стреляющий импульсами жизни каждые 5 секунд\nИмпульсы наносят базовый урон в 300 единиц врагам в радиусе действия\nИмпульсы также увеличивают здоровье на 10 единиц вам и всем игрокам команды\nИгроки, исцелившиеся от предыдущих импульсов, не могут быть исцелены другим, пока не пройдёт 4.5 секунды\nКак увеличение здоровья, так и урон, зависят от вашего сильнейшего класса";
            ArmorSetBonus[ItemID.ChlorophyteMask] = "Призывает мощный кристальный лист, стреляющий импульсами жизни каждые 5 секунд\nИмпульсы наносят базовый урон в 300 единиц врагам в радиусе действия\nИмпульсы также увеличивают здоровье на 10 единиц вам и всем игрокам команды\nИгроки, исцелившиеся от предыдущих импульсов, не могут быть исцелены другим, пока не пройдёт 4.5 секунды\nКак увеличение здоровья, так и урон, зависят от вашего сильнейшего класса";
            ArmorSetBonus[ItemID.ChlorophyteHelmet] = "Призывает мощный кристальный лист, стреляющий импульсами жизни каждые 5 секунд\nИмпульсы наносят базовый урон в 300 единиц врагам в радиусе действия\nИмпульсы также увеличивают здоровье на 10 единиц вам и всем игрокам команды\nИгроки, исцелившиеся от предыдущих импульсов, не могут быть исцелены другим, пока не пройдёт 4.5 секунды\nКак увеличение здоровья, так и урон, зависят от вашего сильнейшего класса";
            ArmorSetBonus[ItemID.SpectreHood] = $"{Language.GetText("ArmorSetBonus.SpectreHealing").Value.Replace("40%", "20%")}";
            ArmorSetBonus[ItemID.MiningHelmet] = "Увеличивает скорость добычи на 10%\nДобываемая вами руда иногда даёт дополнительный кусок руды";
            ArmorSetBonus[ItemID.UltrabrightHelmet] = "Увеличивает скорость добычи на 10%\nДобываемая вами руда иногда даёт дополнительный кусок руды";
            ArmorSetBonus[ItemID.MeteorHelmet] = "Космическая пушка потребляет на 50% меньше маны";
            ArmorSetBonus[ItemID.CopperHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier1")}\nУвеличивает весь урон на 2";
            ArmorSetBonus[ItemID.TinHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier1")}\nУвеличивает пробивание брони на 5";
            ArmorSetBonus[ItemID.IronHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier1")}\nУвеличивает сопротивление урону на 6%\nУвеличивает регенерацию здоровья на 2";
            ArmorSetBonus[ItemID.AncientIronHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier1")}\nУвеличивает сопротивление урону на 6%\nУвеличивает регенерацию здоровья на 2";
            ArmorSetBonus[ItemID.LeadHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier2")}\nУвеличивает сопротивление урону на 3%\nУвеличивает регенерацию здоровья на 1\nДаёт невосприимчивость к отбрасыванию";
            ArmorSetBonus[ItemID.SilverHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier2")}\nУвеличивает регенерацию здоровья на 1\nЧерез две секунды после получения 20 или более урона восстанавливает 10 единиц здоровья\nПовторное попадание сбрасывает таймер, откладывая восстановление здоровья";
            ArmorSetBonus[ItemID.TungstenHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier2")}\nУвеличивает шанс критического удара на 100% от отбрасывания удерживаемого оружия\nЭтот эффект ограничивается безумным отбрасыванием, увеличивая шанс критического удара на 10%\nУвеличивает всё отбрасывание на 33%, это учитывается для вышеуказанного усиления";
            ArmorSetBonus[ItemID.GoldHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier2")}\nВсе враги с 4% шансом могут выронить 1 золотую монету. Со всех убитых боссов выпадает 3 золотые монеты\nВы получаете 1% шанса критического удара за каждые 5 золотых монет в инвентаре, максимум 10%";
            ArmorSetBonus[ItemID.AncientGoldHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier2")}\nВсе враги с 4% шансом могут выронить 1 золотую монету. Со всех убитых боссов выпадает 3 золотые монеты\nВы получаете 1% шанса критического удара за каждые 5 золотых монет в инвентаре, максимум 10%";
            ArmorSetBonus[ItemID.PlatinumHelmet] = $"{Language.GetTextValue("ArmorSetBonus.Platinum")}\nКаждые 15 единиц защиты дают 1 единицу регенерации здоровья и 1% шанс критического удара\nЭти эффекты ограничены максимумом в 45 единиц защиты";
            ArmorSetBonus[ItemID.MoltenHelmet] = $"{Language.GetTextValue("ArmorSetBonus.Molten")}\nУвеличивает истинный урон ближнего боя на 20%\nДаёт невосприимчивость к огненным блокам и временную невосприимчивость к лаве";
            ArmorSetBonus[ItemID.MonkBrows] = $"{Language.GetTextValue("ArmorSetBonus.MonkTier2")}\nУвеличивает урон, шанс критического удара и скорость атаки ближнего боя на 10%\nУвеличивает урон призывателя на 15%";
            ArmorSetBonus[ItemID.SquireGreatHelm] = $"{Language.GetTextValue("ArmorSetBonus.SquireTier2")}\nУвеличивает регенерацию здоровья\nУвеличивает урон призывателя на 15% и шанс критического удара ближнего боя на 10%";
            ArmorSetBonus[ItemID.HuntressWig] = $"{Language.GetTextValue("ArmorSetBonus.HuntressTier2")}\nУвеличивает урон призывателя и стрелковый урон на 10%";
            ArmorSetBonus[ItemID.ApprenticeHat] = $"{Language.GetTextValue("ArmorSetBonus.ApprenticeTier2")}\nУвеличивает урон призывателя на 5% и магический шанс критического удара на 15%";
            ArmorSetBonus[ItemID.MonkAltHead] = $"{Language.GetTextValue("ArmorSetBonus.MonkTier3")}\nУвеличивает урон, шанс критического удара и скорость атаки ближнего боя на 10%\nУвеличивает урон призывателя на 30%";
            ArmorSetBonus[ItemID.SquireAltHead] = $"{Language.GetTextValue("ArmorSetBonus.SquireTier3")}\nЗначительно увеличивает регенерацию здоровья\nУвеличивает урон призывателя и шанс критического удара ближнего боя на 10%";
            ArmorSetBonus[ItemID.HuntressAltHead] = $"{Language.GetTextValue("ArmorSetBonus.HuntressTier3")}\nУвеличивает урон призывателя и стрелковый урон на 10%";
            ArmorSetBonus[ItemID.ApprenticeAltHead] = $"{Language.GetTextValue("ArmorSetBonus.ApprenticeTier3")}\nУвеличивает урон призывателя на 10% и магический шанс критического удара на 15%";
            ArmorSetBonus[ItemID.GladiatorHelmet] = $"{Language.GetTextValue("ArmorSetBonus.Gladiator")}\nУвеличивает защиту на 3\nУвеличивает максимальную скрытность на 60\nУвеличивает разбойный урон на 5% и скорость снарядов на 10%";
            ArmorSetBonus[ItemID.ObsidianHelm] = $"{Language.GetTextValue("ArmorSetBonus.ObsidianOutlaw")}\nДаёт невосприимчивость к огненным блокам и временную невосприимчивость к лаве";
            
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AstralHelm").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.AstralHelm.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "BrimflameScowl").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.BrimflameScowl.SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "DaedalusHeadMagic").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.DaedalusHeadMagic.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "DaedalusHeadMelee").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.DaedalusHeadMelee.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "DaedalusHeadRanged").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.DaedalusHeadRogue.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "DaedalusHeadRanged").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.DaedalusHeadRogue.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "DaedalusHeadSummon").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.DaedalusHeadSummon.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "FathomSwarmerVisage").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.FathomSwarmerVisage.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "ForbiddenCirclet").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.ForbiddenCirclet.SetBonus", "[Бонус комплекта брони]", 60f * Main.player[Main.myPlayer].manaCost);
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "LunicCorpsHelmet").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.LunicCorpsHelmet.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "MolluskShellmet").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.MolluskShellmet.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "PlaguebringerVisor").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.PlaguebringerVisor.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "PlagueReaperMask").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.PlagueReaperMask.SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "ReaverHeadExplore").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.ReaverHeadExplore.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "ReaverHeadMobility").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.ReaverHeadMobility.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "ReaverHeadTank").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.ReaverHeadTank.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "TitanHeartMask").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.TitanHeartMask.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "UmbraphileHood").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.UmbraphileHood.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AuricTeslaHoodedFacemask").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.AuricTeslaHoodedFacemask.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AuricTeslaPlumedHelm").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.AuricTeslaPlumedHelm.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AuricTeslaRoyalHelm").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.AuricTeslaRoyalHelm.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AuricTeslaSpaceHelmet").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.AuricTeslaSpaceHelmet.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AuricTeslaWireHemmedVisage").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.AuricTeslaWireHemmedVisage.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "DemonshadeHelm").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.DemonshadeHelm.SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "EmpyreanMask").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.EmpyreanMask.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "FearmongerGreathelm").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.FearmongerGreathelm.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "OmegaBlueHelmet").Type] =Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.OmegaBlueHelmet.SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "PrismaticHelmet").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.PrismaticHelmet.SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "SnowRuffianMask").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.SnowRuffianMask.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "SulphurousHelmet").Type] =Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.SulphurousHelmet.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "VictideHeadRanged").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.VictideBreastplate.CommonSetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "VictideHeadMagic").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.VictideBreastplate.CommonSetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "StatigelHeadMagic").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.StatigelArmor.CommonSetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "StatigelHeadRanged").Type] = Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.StatigelArmor.CommonSetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "HydrothermicHeadMagic").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.HydrothermicArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.HydrothermicHeadMagic.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "HydrothermicHeadMelee").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.HydrothermicArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.HydrothermicHeadMelee.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "HydrothermicHeadRanged").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.HydrothermicArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.HydrothermicHeadRanged.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "HydrothermicHeadRogue").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.HydrothermicArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.HydrothermicHeadRogue.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "HydrothermicHeadSummon").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.HydrothermicArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.Hardmode.HydrothermicHeadSummon.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "BloodflareHeadMagic").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.BloodflareBodyArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.BloodflareHeadMagic.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "BloodflareHeadMelee").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.BloodflareBodyArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.BloodflareHeadMelee.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "BloodflareHeadRanged").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.BloodflareBodyArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.BloodflareHeadRanged.SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "BloodflareHeadRogue").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.BloodflareBodyArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.BloodflareHeadRogue.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "BloodflareHeadSummon").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.BloodflareBodyArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.BloodflareHeadSummon.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "GodSlayerHeadMelee").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.GodSlayerChestplate.CommonSetBonus", "[Бонус комплекта брони]", 45) + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.GodSlayerHeadMelee.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "GodSlayerHeadRanged").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.GodSlayerChestplate.CommonSetBonus", "[Бонус комплекта брони]", 45) + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.GodSlayerHeadRanged.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "GodSlayerHeadRogue").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.GodSlayerChestplate.CommonSetBonus", "[Бонус комплекта брони]", 45) + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.GodSlayerHeadRogue.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "SilvaHeadMagic").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.SilvaArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.SilvaHeadMagic.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "SilvaHeadSummon").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.SilvaArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.SilvaHeadSummon.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "TarragonHeadMagic").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.TarragonBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.TarragonHeadMagic.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "TarragonHeadMelee").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.TarragonBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.TarragonHeadMelee.SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "TarragonHeadRanged").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.TarragonBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.TarragonHeadRanged.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "TarragonHeadRogue").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.TarragonBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.TarragonHeadRogue.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "TarragonHeadSummon").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.TarragonBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PostMoonLord.TarragonHeadSummon.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AerospecHat").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.AerospecBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.AerospecHat.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AerospecHeadgear").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.AerospecBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.AerospecHeadgear.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AerospecHelm").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.AerospecBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.AerospecHelm.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AerospecHelmet").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.AerospecBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.AerospecHelmet.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "AerospecHood").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.AerospecBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.AerospecHood.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "DesertProwlerHat").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.DesertProwlerHat.SetBonus", 1) + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.DesertProwlerHat.AbilityBrief") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.DesertProwlerHat.AbilityDescription", 200, 100, 1.5f);
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "StatigelHeadMelee").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.StatigelArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.StatigelHeadMelee.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "StatigelHeadRogue").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.StatigelArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.StatigelHeadRogue.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "StatigelHeadSummon").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.StatigelArmor.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.StatigelHeadSummon.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "VictideHeadMelee").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.VictideBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.VictideHeadMelee.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "VictideHeadRogue").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.VictideBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.VictideHeadRogue.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "VictideHeadSummon").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.VictideBreastplate.CommonSetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.VictideHeadSummon.SetBonus");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "WulfrumHat").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.WulfrumHat.SetBonus") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.WulfrumHat.AbilityBrief") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.WulfrumHat.AbilityDescription",
                    $"[i:{ModContent.Find<ModItem>("CalamityMod", "WulfrumMetalScrap").Type}] {Language.GetTextValue("Mods.CalamityMod.Items.Materials.WulfrumMetalScrap.DisplayName")}");
            ArmorSetBonus[ModContent.Find<ModItem>("CalamityMod", "MarniteArchitectHeadgear").Type] =
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.MarniteArchitectHeadgear.AbilityBrief") + "\n" +
                Language.GetTextValue("Mods.CalamityMod.Items.Armor.PreHardmode.MarniteArchitectHeadgear.AbilityDescription");
        }
    }
}