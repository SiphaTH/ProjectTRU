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
            ArmorSetBonus[ItemID.AncientNecroHelmet] = $"{Language.GetTextValue("ArmorSetBonus.Bone")}\nДаёт возможность временно пережить смертельный удар\nДаёт до 7 секунд жизни перед неминуемой смертью";
            ArmorSetBonus[ItemID.NecroHelmet] = $"{Language.GetTextValue("ArmorSetBonus.Bone")}\nДаёт возможность временно пережить смертельный удар\nДаёт до 7 секунд жизни перед неминуемой смертью";
            
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AstralHelm")] = TranslationHelper.GetTextValue("CalamityMod/AstralHelm", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/BrimflameScowl")] = TranslationHelper.GetTextValue("CalamityMod/BrimflameScowl", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/DaedalusHeadMagic")] = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadMagic", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/DaedalusHeadMelee")] = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadMelee", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/DaedalusHeadRanged")] = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadRanged", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/DaedalusHeadRogue")] = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadRogue", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/DaedalusHeadSummon")] = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadSummon", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/FathomSwarmerVisage")] = TranslationHelper.GetTextValue("CalamityMod/FathomSwarmerVisage", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/ForbiddenCirclet")] = TranslationHelper.GetTextValue("CalamityMod/ForbiddenCirclet", "SetBonus", "[Бонус комплекта брони]", "[X]");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/LunicCorpsHelmet")] = TranslationHelper.GetTextValue("CalamityMod/LunicCorpsHelmet", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/MolluskShellmet")] = TranslationHelper.GetTextValue("CalamityMod/MolluskShellmet", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/PlaguebringerVisor")] = TranslationHelper.GetTextValue("CalamityMod/PlaguebringerVisor", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/PlagueReaperMask")] = TranslationHelper.GetTextValue("CalamityMod/PlagueReaperMask", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/ReaverHeadExplore")] = TranslationHelper.GetTextValue("CalamityMod/ReaverHeadExplore", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/ReaverHeadMobility")] = TranslationHelper.GetTextValue("CalamityMod/ReaverHeadMobility", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/ReaverHeadTank")] = TranslationHelper.GetTextValue("CalamityMod/ReaverHeadTank", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/TitanHeartMask")] = TranslationHelper.GetTextValue("CalamityMod/TitanHeartMask", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/UmbraphileHood")] = TranslationHelper.GetTextValue("CalamityMod/UmbraphileHood", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AuricTeslaHoodedFacemask")] = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaHoodedFacemask", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AuricTeslaPlumedHelm")] = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaPlumedHelm", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AuricTeslaRoyalHelm")] = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaRoyalHelm", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AuricTeslaSpaceHelmet")] = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaSpaceHelmet", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AuricTeslaWireHemmedVisage")] = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaWireHemmedVisage", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/DemonshadeHelm")] = TranslationHelper.GetTextValue("CalamityMod/DemonshadeHelm", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/EmpyreanMask")] = TranslationHelper.GetTextValue("CalamityMod/EmpyreanMask", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/FearmongerGreathelm")] = TranslationHelper.GetTextValue("CalamityMod/FearmongerGreathelm", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/OmegaBlueHelmet")] = TranslationHelper.GetTextValue("CalamityMod/OmegaBlueHelmet", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/PrismaticHelmet")] = TranslationHelper.GetTextValue("CalamityMod/PrismaticHelmet", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/SnowRuffianMask")] = TranslationHelper.GetTextValue("CalamityMod/SnowRuffianMask", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/SulphurousHelmet")] =TranslationHelper.GetTextValue("CalamityMod/SulphurousHelmet", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/VictideHeadRanged")] =
                TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/VictideHeadRanged", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/VictideHeadMagic")] =
                TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/VictideHeadMagic", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/StatigelHeadMagic")] = TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/StatigelHeadRanged")] = TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadMagic")] =
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadMagic", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadMelee", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadRanged")] =
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadRanged", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadRogue", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadSummon", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/BloodflareHeadMagic")] =
                TranslationHelper.GetTextValue("CalamityMod/BloodflareBodyArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadMagic", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/BloodflareHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/BloodflareBodyArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadMelee", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/BloodflareHeadRanged")] =
                TranslationHelper.GetTextValue("CalamityMod/BloodflareBodyArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadRanged", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/BloodflareHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/BloodflareBodyArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadRogue", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/BloodflareHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/BloodflareBodyArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadSummon", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/GodSlayerHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerChestplate", "CommonSetBonus", "[Бонус комплекта брони]", 45) + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerHeadMelee", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/GodSlayerHeadRanged")] =
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerChestplate", "CommonSetBonus", "[Бонус комплекта брони]", 45) + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerHeadRanged", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/GodSlayerHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerChestplate", "CommonSetBonus", "[Бонус комплекта брони]", 45) + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerHeadRogue", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/SilvaHeadMagic")] =
                TranslationHelper.GetTextValue("CalamityMod/SilvaArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/SilvaHeadMagic", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/SilvaHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/SilvaArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/SilvaHeadSummon", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/TarragonHeadMagic")] =
                TranslationHelper.GetTextValue("CalamityMod/TarragonBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/TarragonHeadMagic", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/TarragonHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/TarragonBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/TarragonHeadMelee", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/TarragonHeadRanged")] =
                TranslationHelper.GetTextValue("CalamityMod/TarragonBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/TarragonHeadRanged", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/TarragonHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/TarragonBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/TarragonHeadRogue", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/TarragonHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/TarragonBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/TarragonHeadSummon", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AerospecHat")] =
                TranslationHelper.GetTextValue("CalamityMod/AerospecBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/AerospecHat", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AerospecHeadgear")] =
                TranslationHelper.GetTextValue("CalamityMod/AerospecBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/AerospecHeadgear", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AerospecHelm")] =
                TranslationHelper.GetTextValue("CalamityMod/AerospecBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/AerospecHelm", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AerospecHelmet")] =
                TranslationHelper.GetTextValue("CalamityMod/AerospecBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/AerospecHelmet", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/AerospecHood")] =
                TranslationHelper.GetTextValue("CalamityMod/AerospecBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/AerospecHood", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/DesertProwlerHat")] =
                TranslationHelper.GetTextValue("CalamityMod/DesertProwlerHat", "SetBonus", 1) + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/DesertProwlerHat", "AbilityBrief") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/DesertProwlerHat", "AbilityDescription", 200, 100, 1.5f);
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/StatigelHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/StatigelHeadMelee", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/StatigelHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/StatigelHeadRogue", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/StatigelHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/StatigelHeadSummon", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/VictideHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/VictideHeadMelee", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/VictideHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/VictideHeadRogue", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/VictideHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/VictideHeadSummon", "SetBonus");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/WulfrumHat")] =
                TranslationHelper.GetTextValue("CalamityMod/WulfrumHat", "SetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/WulfrumHat", "AbilityBrief") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/WulfrumHat", "AbilityDescription",
                    $"[i:{TranslationHelper.GetItemID("CalamityMod/WulfrumMetalScrap")}] {TranslationHelper.GetTextValue("CalamityMod/WulfrumMetalScrap", "DisplayName")}");
            ArmorSetBonus[TranslationHelper.GetItemID("CalamityMod/MarniteArchitectHeadgear")] =
                TranslationHelper.GetTextValue("CalamityMod/MarniteArchitectHeadgear", "AbilityBrief") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/MarniteArchitectHeadgear", "AbilityDescription");
        }

        if (ModsCall.FargoSouls != null)
        {
            ArmorSetBonus[TranslationHelper.GetItemID("FargowiltasSouls/EridanusHat")] = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.EridanusOff", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
            ArmorSetBonus[TranslationHelper.GetItemID("FargowiltasSouls/GaiaHelmet")] = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Gaia", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
            ArmorSetBonus[TranslationHelper.GetItemID("FargowiltasSouls/MutantMask")] = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Mutant");
            ArmorSetBonus[TranslationHelper.GetItemID("FargowiltasSouls/StyxCrown")] = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Styx", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
            ArmorSetBonus[TranslationHelper.GetItemID("FargowiltasSouls/NekomiHood")] = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Nekomi", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
        }
    }
}