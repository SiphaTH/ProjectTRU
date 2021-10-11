// using System.Linq;
// using CalamityMod.Items;
// using CalamityRuTranslate.Common.Utilities;
// using Microsoft.Xna.Framework;
// using Terraria;
// using Terraria.ModLoader;
// using static CalamityRuTranslate.Common.ModsCall;
// using static Terraria.ID.ItemID;
//
// namespace CalamityRuTranslate.Content.ClassSetups
// {
//     public class ClassSetups : ModCommand
//     {
//         public override bool Autoload(ref string name) => Calamity != null && TranslationUtils.IsRussianLanguage;
//         
//         public override CommandType Type => CommandType.Chat;
//         
//         public override string Command => "tru";
//
//         public override void Action(CommandCaller caller, string input, string[] args)
//         {
//             if (args.Length < 1)
//             {
//                 caller.Reply("Вы должны использовать подкоманду, напишите /tru help для подробной информации.", Color.Red);
//                 return;
//             }
//
//             switch (args[0])
//             {
//                 case "help":
//                     caller.Reply("Список доступных команд:", Color.Orange);
//                     caller.Reply("/tru KingSlime");
//                     caller.Reply("/tru DesertScourge");
//                     caller.Reply("/tru EyeOfCthulhu");
//                     caller.Reply("/tru Crabulon");
//                     caller.Reply("/tru BrainOfCthulhu");
//                     caller.Reply("/tru EaterOfWorlds");
//                     caller.Reply("/tru HiveMind");
//                     caller.Reply("/tru Perforators");
//                     caller.Reply("/tru QueenBee");
//                     caller.Reply("/tru Skeletron");
//                     caller.Reply("/tru SlimeGod");
//                     caller.Reply("/tru WallOfFlesh");
//                     caller.Reply("/tru Cryogen");
//                     caller.Reply("/tru MechanicalBosses");
//                     caller.Reply("/tru AquaticScourge");
//                     caller.Reply("/tru BrimstoneElemental");
//                     caller.Reply("/tru Calamitas");
//                     caller.Reply("/tru Plantera");
//                     caller.Reply("/tru Leviathan");
//                     caller.Reply("/tru AstrumAureus");
//                     caller.Reply("/tru Golem");
//                     caller.Reply("/tru Goliath");
//                     caller.Reply("/tru DukeFishron");
//                     caller.Reply("/tru Ravager");
//                     caller.Reply("/tru AstrumDeus");
//                     caller.Reply("/tru MoonLord");
//                     caller.Reply("/tru ProfanedGuardians");
//                     caller.Reply("/tru Dragonfolly");
//                     caller.Reply("/tru Providence");
//                     caller.Reply("/tru StormWeaver");
//                     caller.Reply("/tru CeaselessVoid");
//                     caller.Reply("/tru Signus");
//                     caller.Reply("/tru Polterghast");
//                     caller.Reply("/tru OldDuke");
//                     caller.Reply("/tru DevourerOfGods");
//                     caller.Reply("/tru YharonPhase1");
//                     caller.Reply("/tru YharonPhase2");
//                     caller.Reply("/tru SupremeCalamitas");
//                     break;
//                 
//                 case "KingSlime":
//                     Main.NewText("Босс: Король Слизней");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(Starfury, Calamity.ItemType("SeashellBoomerangMelee"), Calamity.ItemType("Cnidarian")),
//                             GetBuildText(Calamity.ItemType("WulfrumHelm"), Calamity.ItemType("WulfrumArmor"), Calamity.ItemType("WulfrumLeggings")),
//                             GetBuildText(WhiteString, BlackCounterweight, FeralClaws),
//                             GetBuildText(HermesBoots, Calamity.ItemType("LuxorsGift"), Calamity.ItemType("FungalSymbiote")),
//                             GetBuildText(Pho)
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(Calamity.ItemType("DesertProwlerHat"), Calamity.ItemType("DesertProwlerShirt"), Calamity.ItemType("DesertProwlerPants")),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//
//                 case "DesertScourge":
//                     Main.NewText("Босс: Пустынный бич");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(Starfury, Calamity.ItemType("SeashellBoomerangMelee"), JungleYoyo, Calamity.ItemType("Cnidarian")),
//                             GetBuildText(Calamity.ItemType("VictideHelm"), Calamity.ItemType("VictideBreastplate"), Calamity.ItemType("VictideLeggings")),
//                             GetBuildText(WhiteString, BlackCounterweight, FeralClaws),
//                             GetBuildText(BundleofBalloons, FrostsparkBoots, SharkToothNecklace, Calamity.ItemType("LuxorsGift"), Calamity.ItemType("FungalSymbiote")),
//                             GetBuildText(SharpeningStation, PumpkinPie)
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(Calamity.ItemType("StormjawStaff"), Calamity.ItemType("BelladonnaSpiritBuff")),
//                             GetBuildText(Calamity.ItemType("VictideHelmet"), Calamity.ItemType("VictideBreastplate"), Calamity.ItemType("VictideLeggings")),
//                             GetBuildText(Calamity.ItemType("SpiritGenerator"), Calamity.ItemType("WulfrumBattery")),
//                             GetBuildText(BundleofBalloons, FrostsparkBoots, SharkToothNecklace, Calamity.ItemType("LuxorsGift")),
//                             GetBuildText(SummoningPotion)
//                                 );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "EyeOfCthulhu":
//                     Main.NewText("Босс: Глаз Ктулху");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(Calamity.ItemType("AmidiasTrident"), Calamity.ItemType("SeashineSword"), Calamity.ItemType("Whirlpool")),
//                             GetBuildText(Calamity.ItemType("VictideHelm"), Calamity.ItemType("VictideBreastplate"), Calamity.ItemType("VictideLeggings")),
//                             GetBuildText(WhiteString, BlackCounterweight, FeralClaws),
//                             GetBuildText(BundleofBalloons, FrostsparkBoots, SharkToothNecklace, Calamity.ItemType("LuxorsGift"), Calamity.ItemType("FungalSymbiote")),
//                             GetBuildText(SharpeningStation, PumpkinPie)
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(Calamity.ItemType("BelladonnaSpiritBuff"), Calamity.ItemType("SeaboundStaff")),
//                             GetBuildText(Calamity.ItemType("VictideHelmet"), Calamity.ItemType("VictideBreastplate"), Calamity.ItemType("VictideLeggings")),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                                 );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Crabulon":
//                     Main.NewText("Босс: Крабулон");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(Calamity.ItemType("AmidiasTrident"), Calamity.ItemType("SeashineSword"), Calamity.ItemType("Whirlpool"), Calamity.ItemType("YateveoBloom")),
//                             GetBuildText(Calamity.ItemType("VictideHelm"), Calamity.ItemType("VictideBreastplate"), Calamity.ItemType("VictideLeggings")),
//                             GetBuildText(WhiteString, BlackCounterweight, FeralClaws),
//                             GetBuildText(BundleofBalloons, FrostsparkBoots, SharkToothNecklace, Calamity.ItemType("LuxorsGift"), Calamity.ItemType("FungalSymbiote")),
//                             GetBuildText(SharpeningStation, PumpkinPie)
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "BrainOfCthulhu":
//                     Main.NewText("Босс: Мозг Ктулху");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "EaterOfWorlds":
//                     Main.NewText("Босс: Пожиратель миров");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "HiveMind":
//                     Main.NewText("Босс: Разум Улья");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Perforators":
//                     Main.NewText("Босс: Перфораторы");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "QueenBee":
//                     Main.NewText("Босс: Королева пчёл");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Skeletron":
//                     Main.NewText("Босс: Скелетрон");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "SlimeGod":
//                     Main.NewText("Босс: Бог слизней");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "WallOfFlesh":
//                     Main.NewText("Босс: Стена Плоти");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(Calamity.ItemType("Archerfish"), Calamity.ItemType("Goobow"), Calamity.ItemType("GunkShot")),
//                             GetBuildText(Calamity.ItemType("StatigelHeadgear"), Calamity.ItemType("StatigelArmor"), Calamity.ItemType("StatigelGreaves")),
//                             GetBuildText(Calamity.ItemType("RustyMedallion")),
//                             GetBuildText(Calamity.ItemType("CounterScarf"), FrostsparkBoots, BundleofBalloons, Calamity.ItemType("SkylineWings"), Calamity.ItemType("LuxorsGift"), Calamity.ItemType("Laudanum"), Calamity.ItemType("StressPills")),
//                             GetBuildText(Calamity.ItemType("SuperballBullet"), Calamity.ItemType("FlashBullet"), HellfireArrow, JestersArrow)
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Cryogen":
//                     Main.NewText("Босс: Криоген");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "MechanicalBosses":
//                     Main.NewText("Босс: Механические боссы");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "AquaticScourge":
//                     Main.NewText("Босс: Акватический бич");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "BrimstoneElemental":
//                     Main.NewText("Босс: Серный элементаль");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Calamitas":
//                     Main.NewText("Босс: Каламитас");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Plantera":
//                     Main.NewText("Босс: Плантера");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Leviathan":
//                     Main.NewText("Босс: Анахита и Левиафан");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "AstrumAureus":
//                     Main.NewText("Босс: Аструм Аурес");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Golem":
//                     Main.NewText("Босс: Голем");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Goliath":
//                     Main.NewText("Босс: Разносчица чумы, Голиаф");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "DukeFishron":
//                     Main.NewText("Босс: Герцог Рыброн");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Ravager":
//                     Main.NewText("Босс: Разрушитель");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "AstrumDeus":
//                     Main.NewText("Босс: Аструм Деус");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "MoonLord":
//                     Main.NewText("Босс: Лунный Лорд");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "ProfanedGuardians":
//                     Main.NewText("Босс: Осквернённые стражи");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Dragonfolly":
//                     Main.NewText("Босс: Псевдодракон");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Providence":
//                     Main.NewText("Босс: Провиденс, Осквернённая богиня");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "Маг",
//                             GetBuildText(Calamity.ItemType("MadAlchemistsCocktailGlove")),
//                             GetBuildText(NebulaHelmet, NebulaBreastplate, NebulaLeggings),
//                             GetBuildText(Calamity.ItemType("SigilofCalamitas")),
//                             GetBuildText(Calamity.ItemType("InfinityBoots")),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "CeaselessVoid":
//                     Main.NewText("Босс: Нескончаемая пустота");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "StormWeaver":
//                     Main.NewText("Босс: Штормовой ткач");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Signus":
//                     Main.NewText("Босс: Сигнус, Посланник Пожирателя");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "Polterghast":
//                     Main.NewText("Босс: Полтергаст");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "OldDuke":
//                     Main.NewText("Босс: Старый Герцог");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "DevourerOfGods":
//                     Main.NewText("Босс: Пожиратель богов");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "YharonPhase1":
//                     Main.NewText("Босс: Ярон, Дракон Джунглей - фаза 1");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "YharonPhase2":
//                     Main.NewText("Босс: Ярон, Дракон Джунглей - фаза 2");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 case "SupremeCalamitas":
//                     Main.NewText("Босс: Высшая Каламитас");
//                     if (caller.Player.HeldItem.melee)
//                     {
//                         ClassSetupHelper(
//                             "[c/ff5555:Воин]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.ranged)
//                     {
//                         ClassSetupHelper(
//                             "[c/50fa7b:Стрелок]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.magic)
//                     {
//                         ClassSetupHelper(
//                             "[c/bd93f9:Маг]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.summon)
//                     {
//                         ClassSetupHelper(
//                             "[c/f1fa8c:Призыватель]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else if (caller.Player.HeldItem.GetGlobalItem<CalamityGlobalItem>().rogue)
//                     {
//                         ClassSetupHelper(
//                             "[c/ffb86c:Разбойник]",
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText(),
//                             GetBuildText()
//                         );
//                     }
//                     else
//                     {
//                         Main.NewText("Класс: Неизвестный");
//                         Main.NewText("Тип оружия не опознан");
//                     }
//                     break;
//                 
//                 default:
//                     caller.Reply("Неизвестная подкоманда, напишите /tru help для подробной информации.", Color.Red);
//                     break;
//             }
//         }
//
//         private void ClassSetupHelper(string classBuild, string weapons, string armors, string accsMain, string accsOther, string misc)
//         {
//             Main.NewText($"Класс: {classBuild}");
//             Main.NewText($"Оружие: {weapons}");
//             Main.NewText($"Броня: {armors}");
//             Main.NewText($"Главные аксессуары: {accsMain}");
//             Main.NewText($"Аксессуары по желанию: {accsOther}");
//             Main.NewText($"Баффы/зелья/боеприпасы: {misc}");
//         }
//
//         private string GetBuildText(params int[] args) => args.Aggregate("", (current, itemType) => current + $"[i:{itemType}]");
//     }
// }