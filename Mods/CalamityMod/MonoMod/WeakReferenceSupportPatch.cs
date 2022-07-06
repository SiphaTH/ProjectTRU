using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityMod;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Pets;
using CalamityMod.Items.Potions.Alcohol;
using CalamityMod.Items.SummonItems.Invasion;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Items.Weapons.Ranged;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.Items.Weapons.Summon;
using CalamityMod.NPCs.AcidRain;
using CalamityMod.NPCs.TownNPCs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using MonoMod.RuntimeDetour.HookGen;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

// [JITWhenModsEnabled("CalamityMod")]
// public class WeakReferenceSupportAddCalamityBosses : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetCachedMethod("AddCalamityBosses");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:");
//         //TranslationHelper.ModifyIL(il, "] in the Desert Biome", "] в пустыне.");
//         //TranslationHelper.ModifyIL(il, "The scourge of the desert delved back into the sand.", "Пустынный бич погружается назад в песок.");
//         //TranslationHelper.ModifyIL(il, "Desert Scourge", "Пустынный бич");
//         //TranslationHelper.ModifyIL(il, "Can spawn naturally in the Sunken Sea", "Может естественно появится в затерянном море.");
//         // TranslationHelper.ModifyIL(il, "The Giant Clam returns into hiding in its grotto.", "Гигантский моллюск скрывается в своём гроте.");
//         // TranslationHelper.ModifyIL(il, "Giant Clam", "Гигантский моллюск");
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 2);
//         // TranslationHelper.ModifyIL(il, "] in the Mushroom Biome", "] в грибном биоме.");
//         // TranslationHelper.ModifyIL(il, "The mycleium crab has lost interest.", "Мицелиевый краб потерял интерес.");
//         // TranslationHelper.ModifyIL(il, "Crabulon", "Крабулон", 2);
//         // TranslationHelper.ModifyIL(il, "Kill a Cyst in the Corruption or use a [i:", "Убейте кисту или используйте [i:");
//         // TranslationHelper.ModifyIL(il, "] in the Corruption", "] в искажении.");
//         // TranslationHelper.ModifyIL(il, "The corrupted colony began searching for a new breeding ground.", "Искажённая стая начала поиски нового места для размножения.");
//         // TranslationHelper.ModifyIL(il, "Hive Mind", "Разум Улья");
//         // TranslationHelper.ModifyIL(il, "Kill a Cyst in the Crimson or use a [i:", "Убейте кисту или используйте [i:");
//         // TranslationHelper.ModifyIL(il, "] in the Crimson", "] в багрянце.");
//         // TranslationHelper.ModifyIL(il, "The parasitic hive began searching for a new host.", "Паразитический улей начал искать нового носителя.");
//         // TranslationHelper.ModifyIL(il, "The Perforators", "Перфораторы");
//         // TranslationHelper.ModifyIL(il, "Use an [i:", "Используйте [i:");
//         // TranslationHelper.ModifyIL(il, "The gelatinous monstrosity achieved vengeance for its brethren.", "Желеподобное чудовище отомстило за своих собратьев.");
//         // TranslationHelper.ModifyIL(il, "Slime God", "Бог слизней");
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 3);
//         // TranslationHelper.ModifyIL(il, "] in the Snow Biome", "] в снегах.");
//         // TranslationHelper.ModifyIL(il, "Cryogen drifts away, carried on a freezing wind.", "Криоген уносится прочь ледяным ветром.");
//         // TranslationHelper.ModifyIL(il, "Cryogen", "Криоген", 2);
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 4);
//         // TranslationHelper.ModifyIL(il, "] in the Sulphuric Sea or wait for it to spawn in the Sulphuric Sea", " или подождите его появление в сернистом море.");
//         // TranslationHelper.ModifyIL(il, "The Aquatic Scourge swam back into the open ocean.", "Акватический бич уплыл обратно в открытый океан.");
//         // TranslationHelper.ModifyIL(il, "Aquatic Scourge", "Акватический бич");
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 5);
//         // TranslationHelper.ModifyIL(il, "] in the Brimstone Crag", "] в серной скале.");
//         // TranslationHelper.ModifyIL(il, "Brimstone Elemental withdraws to the ruins of her shrine.", "Серный элементаль отступает к руинам своей святыни.");
//         // TranslationHelper.ModifyIL(il, "Brimstone Elemental", "Серный элементаль");
//         // TranslationHelper.ModifyIL(il, "Use an [i:", "Используйте [i:", 2);
//         // TranslationHelper.ModifyIL(il, "] at Night", "] ночью.");
//         // TranslationHelper.ModifyIL(il, "If you wanted a fight, you should've came more prepared.", "Если вы хотели драки, вы должны были прийти более подготовленными.");
//         // TranslationHelper.ModifyIL(il, "Calamitas", "Каламитас", 2);
//         // TranslationHelper.ModifyIL(il, "Kill 10 sand sharks after defeating Plantera or use a [i:", "Убейте 10 песчаных акул после победы над Плантерой или используйте [i:");
//         // TranslationHelper.ModifyIL(il, "] in the Desert Biome", "] в пустыне.");
//         // TranslationHelper.ModifyIL(il, "The apex predator of the sands disappears into the dunes...", "Высший хищник песков исчезает в дюнах...");
//         // TranslationHelper.ModifyIL(il, "Great Sand Shark", "Великая песчаная акула");
//         // TranslationHelper.ModifyIL(il, "By killing an unknown entity in the Ocean Biome", "Убейте неизвестное существо в океане");
//         // TranslationHelper.ModifyIL(il, "The aquatic entities sink back beneath the ocean depths.", "Водные существа возвращаются в глубины океана.");
//         // TranslationHelper.ModifyIL(il, "Leviathan", "Левиафан", 2);
//         // TranslationHelper.ModifyIL(il, "Use an [i:", "Используйте [i:", 3);
//         // TranslationHelper.ModifyIL(il, "] at Night in the Astral Biome", "] ночью в астральном биоме.");
//         // TranslationHelper.ModifyIL(il, "Astrum Aureus’ program has been executed. Initiate recall.", "Программа Аструм Ареуса выполнена. Инициирую возврат.");
//         // TranslationHelper.ModifyIL(il, "Astrum Aureus", "Аструм Ареус");
//         // TranslationHelper.ModifyIL(il, "Use an [i:", "Используйте [i:", 4);
//         // TranslationHelper.ModifyIL(il, "] in the Jungle Biome", "] в джунглях.");
//         // TranslationHelper.ModifyIL(il, "HOSTILE SPECIMENS TERMINATED. INITIATE RECALL TO HOME BASE.", "ВРАЖДЕБНЫЕ СУЩНОСТИ УНИЧТОЖЕНЫ. ИНИЦИИРУЮ ВОЗВРАТ НА БАЗУ.");
//         // TranslationHelper.ModifyIL(il, "Plaguebringer Goliath", "Разносчица чумы, Голиаф");
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 6);
//         // TranslationHelper.ModifyIL(il, "The automaton of misshapen victims went looking for the true perpetrator.", "Машина бесформенных жертв отправилась на поиски истинного нарушителя.");
//         // TranslationHelper.ModifyIL(il, "Ravager", "Разрушитель", 2);
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 7);
//         // TranslationHelper.ModifyIL(il, "] or [i:", "] или [i:");
//         // TranslationHelper.ModifyIL(il, "] as offering at an [i:", "] в качестве подношения на [i:");
//         // TranslationHelper.ModifyIL(il, "The infected deity retreats to the heavens.", "Заражённое божество отступает к небесам.");
//         // TranslationHelper.ModifyIL(il, "Astrum Deus", "Аструм Деус");
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 8);
//         // TranslationHelper.ModifyIL(il, "] in the Hallow or Underworld Biomes", "] в святых землях или в аду.");
//         // TranslationHelper.ModifyIL(il, "The guardians must protect their goddess at all costs.", "Стражи должны защищать свою богиню любой ценой.");
//         // TranslationHelper.ModifyIL(il, "Profaned Guardians", "Осквернённые стражи");
//         // TranslationHelper.ModifyIL(il, "Use [i:", "Используйте [i:");
//         // TranslationHelper.ModifyIL(il, "] in the Jungle Biome", "] в джунглях.", 2);
//         // TranslationHelper.ModifyIL(il, "The failed experiment returns to its reproductive routine.", "Неудачный эксперимент вернулся к своему репродуктивному распорядку.");
//         // TranslationHelper.ModifyIL(il, "Dragonfolly", "Псевдодракон", 2);
//         // TranslationHelper.ModifyIL(il, "Use [i:", "Используйте [i:", 2);
//         // TranslationHelper.ModifyIL(il, "] in the Hallow or Underworld Biomes", "] в святых землях или аду.");
//         // TranslationHelper.ModifyIL(il, "The Profaned Goddess vanishes in a burning blaze.", "Осквернённая богиня исчезает в горящем пламени.");
//         // TranslationHelper.ModifyIL(il, "Providence", "Провиденс", 2);
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 9);
//         // TranslationHelper.ModifyIL(il, "] in the Dungeon", "] в темнице.");
//         // TranslationHelper.ModifyIL(il, "The rift in time and space has moved away from your reach.", "Разлом во времени и пространстве удалился вдаль.");
//         // TranslationHelper.ModifyIL(il, "Ceaseless Void", "Нескончаемая пустота");
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 10);
//         // TranslationHelper.ModifyIL(il, "] in Space", "] в космосе.");
//         // TranslationHelper.ModifyIL(il, "Storm Weaver hid itself once again within the stormfront.", "Штормовой ткач снова спрятался в грозовом фронте.");
//         // TranslationHelper.ModifyIL(il, "Storm Weaver", "Штормовой ткач");
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 11);
//         // TranslationHelper.ModifyIL(il, "] in the Underworld", "] в аду.");
//         // TranslationHelper.ModifyIL(il, "The Devourer's assassin has finished its easy task.", "Убийца Пожирателя выполнил свою лёгкую задачу.");
//         // TranslationHelper.ModifyIL(il, "Signus", "Сигнус", 2);
//         // TranslationHelper.ModifyIL(il, "Kill 30 phantom spirits or use a [i:", "Убейте 30 фантомных духов или используйте [i:");
//         // TranslationHelper.ModifyIL(il, "] in the Dungeon", "] в темнице.", 2);
//         // TranslationHelper.ModifyIL(il, "The volatile spirits disperse throughout the depths of the dungeon.", "Нестабильные духи разбредаются по темнице.");
//         // TranslationHelper.ModifyIL(il, "Polterghast", "Полтергаст", 2);
//         // TranslationHelper.ModifyIL(il, "Defeat the Acid Rain event post-Polterghast or fish using a [i:", "Одолейте событие «Кислотный дождь» после победы над Полтергастом или выловите с помощью [i:");
//         // TranslationHelper.ModifyIL(il, "] in the Sulphurous Sea", "] в сернистом море.");
//         // TranslationHelper.ModifyIL(il, "The old duke disappears amidst the acidic downpour.", "Старый герцог исчезает посреди кислотного ливня.");
//         // TranslationHelper.ModifyIL(il, "Old Duke", "Старый герцог");
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 12);
//         // TranslationHelper.ModifyIL(il, "The Devourer of Gods has slain everyone and feasted on their essence.", "Пожиратель богов убил всех и пировал их сущностью.");
//         // TranslationHelper.ModifyIL(il, "Devourer of Gods", "Пожиратель богов");
//         // TranslationHelper.ModifyIL(il, "Use a [i:", "Используйте [i:", 13);
//         // TranslationHelper.ModifyIL(il, "] in the Jungle Biome", "] в джунглях.", 3);
//         // TranslationHelper.ModifyIL(il, "Yharon found you too weak to stay near your gravestone.", "Ярон считает вас слишком слабым, чтобы оставаться с вашим надгробием.");
//         // TranslationHelper.ModifyIL(il, "Yharon", "Ярон", 2);
//         // TranslationHelper.ModifyIL(il, "By using a high-tech computer", "С помощью высокотехнологичного компьютера.");
//         // TranslationHelper.ModifyIL(il, "An imperfection after all... what a shame.", "Несовершенство... какой позор.");
//         // TranslationHelper.ModifyIL(il, "Exo Mechs", "Экзо-механизмы");
//         // TranslationHelper.ModifyIL(il, "Use [i:", "Используйте [i:{", 3);
//         // TranslationHelper.ModifyIL(il, "] or a [i:", "] или [i:");
//         // TranslationHelper.ModifyIL(il, "] as offering at an [i:", "] в качестве подношения на [i:", 2);
//         // TranslationHelper.ModifyIL(il, "Please don't waste my time.", "Пожалуйста, не трать моё время.");
//         // TranslationHelper.ModifyIL(il, "Supreme Calamitas", "Высшая Каламитас");
//         // TranslationHelper.ModifyIL(il, "While in the Abyss, use an item that inflicts Chaos State", "Находясь в бездне, используйте предмет, который накладывает дебафф «Хаотичность»");
//         // TranslationHelper.ModifyIL(il, "Adult Eidolon Wyrm", "Фантомный змей");
//     };
// }

[JITWhenModsEnabled("CalamityMod")]
public class WeakReferenceSupportCensusSupport : ILEdit
{
    private MethodInfo _censusSupport => ModsCall.Calamity?.Code.GetType("CalamityMod.WeakReferenceSupport")
        ?.GetMethod("CensusSupport", BindingFlags.Static | BindingFlags.NonPublic);

    private delegate void orig_CensusSupport();
    private delegate void hook_CensusSupport(orig_CensusSupport orig);

    private event hook_CensusSupport OnCensusSupport
    {
        add => HookEndpointManager.Add<hook_CensusSupport>(_censusSupport, value);
        remove => HookEndpointManager.Remove<hook_CensusSupport>(_censusSupport, value);
    }

    public override bool Autoload() => ModsCall.TryGetCalamity && ModsCall.TryGetCensus && TranslationHelper.IsRussianLanguage;

    public override void Load()
    {
        OnCensusSupport += Translation;
    }

    public override void Unload()
    {
        OnCensusSupport -= Translation;
    }

    private void Translation(orig_CensusSupport orig)
    {
        ModsCall.Census.Call(
            "TownNPCCondition",
            ModContent.NPCType<SEAHOE>(),
            "Одолейте Гигантского моллюска после победы над Пустынным бичом"
        );
        ModsCall.Census.Call(
            "TownNPCCondition",
            ModContent.NPCType<THIEF>(),
            "В инвентаре должна находится [i:74] после победы над Скелетроном"
        );
        ModsCall.Census.Call(
            "TownNPCCondition",
            ModContent.NPCType<FAP>(),
            $"В инвентаре должна находится [i:{ModContent.ItemType<FabsolsVodka>()}] в Хардмоде"
        );
        ModsCall.Census.Call(
            "TownNPCCondition",
            ModContent.NPCType<DILF>(),
            "Одолейте Криогена"
        );
        ModsCall.Census.Call(
            "TownNPCCondition",
            ModContent.NPCType<WITCH>(),
            "Одолейте Высшую Каламитас"
        );
    }
}

// [JITWhenModsEnabled("CalamityMod")]
// public class WeakReferenceSupportAddCalamityInvasions : ILEdit
// {
//     private MethodInfo _addCalamityInvasions => ModsCall.Calamity?.Code.GetType("CalamityMod.WeakReferenceSupport")
//         ?.GetMethod("AddCalamityInvasions", BindingFlags.Static | BindingFlags.NonPublic);
//     private bool DownedEoCAcidRain => DownedBossSystem.downedEoCAcidRain;
//     private bool  DownedAquaticScourgeAcidRain => DownedBossSystem.downedAquaticScourgeAcidRain;
//     private bool  DownedBoomerDuke => DownedBossSystem.downedBoomerDuke;
//     private delegate void orig_AddCalamityInvasions(Mod bossChecklist, Mod calamity);
//     private delegate void hook_AddCalamityInvasions(orig_AddCalamityInvasions orig, Mod bossChecklist, Mod calamity);
//
//     private event hook_AddCalamityInvasions OnAddCalamityInvasions
//     {
//         add => HookEndpointManager.Add<hook_AddCalamityInvasions>(_addCalamityInvasions, value);
//         remove => HookEndpointManager.Remove<hook_AddCalamityInvasions>(_addCalamityInvasions, value);
//     }
//
//     public override bool Autoload() => ModsCall.TryGetCalamity && ModsCall.TryGetBossChecklist && TranslationHelper.IsRussianLanguage;
//
//     public override void Load()
//     {
//         OnAddCalamityInvasions += Translation;
//     }
//
//     public override void Unload()
//     {
//         OnAddCalamityInvasions -= Translation;
//     }
//     
//     private void Translation(orig_AddCalamityInvasions orig, Mod bossChecklist, Mod calamity)
//     {
//         ModsCall.BossChecklist.Call(
//             "AddEvent",
//             2.4f,
//             new List<int>
//             {
//                 ModContent.NPCType<NuclearToad>(),
//                 ModContent.NPCType<AcidEel>(),
//                 ModContent.NPCType<Radiator>(),
//                 ModContent.NPCType<Skyfin>(),
//                 ModContent.NPCType<WaterLeech>(),
//             },
//             ModsCall.Calamity,
//             "Кислотный дождь",
//             (Func<bool>)(() => DownedEoCAcidRain),
//             new List<int> { ModContent.ItemType<CausticTear>() },
//             new List<int> { ModContent.ItemType<RadiatingCrystal>() },
//             new List<int>
//             {
//                 ModContent.ItemType<SulphuricScale>(),
//             ModContent.ItemType<ParasiticSceptor>(),
//             ModContent.ItemType<CausticCroakerStaff>()
//             },
//             $"Используйте [i:{ModContent.ItemType<CausticTear>()}] или дождитесь, пока событие произойдёт естественным образом после победы над глазом Ктулху.",
//             CalamityUtils.ColorMessage("Таинственные существа сернистого моря спустились обратно в океан.", new Color(146, 183, 116))
//         );
//
//         ModsCall.BossChecklist.Call(
//             "AddEvent",
//             9.51f,
//             new List<int>
//             {
//                 ModContent.NPCType<Radiator>(),
//                 ModContent.NPCType<AcidEel>(),
//                 ModContent.NPCType<NuclearToad>(),
//                 ModContent.NPCType<FlakCrab>(),
//                 ModContent.NPCType<Orthocera>(),
//                 ModContent.NPCType<Skyfin>(),
//                 ModContent.NPCType<Trilobite>(),
//                 ModContent.NPCType<WaterLeech>(),
//                 ModContent.NPCType<SulphurousSkater>(),
//                 ModContent.NPCType<IrradiatedSlime>(),
//                 ModContent.NPCType<CragmawMire>(),
//             },
//             ModsCall.Calamity,
//             "Кислотный дождь (Пост-Аб)",
//             (Func<bool>)(() => DownedAquaticScourgeAcidRain),
//             new List<int> { ModContent.ItemType<CausticTear>() },
//             new List<int> { ModContent.ItemType<RadiatingCrystal>() },
//             new List<int>
//             {
//                 ModContent.ItemType<SulphuricScale>(), ModContent.ItemType<CorrodedFossil>(),
//                 ModContent.ItemType<NuclearRod>(), ModContent.ItemType<ParasiticSceptor>(),
//                 ModContent.ItemType<CausticCroakerStaff>(), ModContent.ItemType<FlakToxicannon>(),
//                 ModContent.ItemType<OrthoceraShell>(), ModContent.ItemType<SkyfinBombers>(),
//                 ModContent.ItemType<SlitheringEels>(), ModContent.ItemType<SpentFuelContainer>(),
//                 ModContent.ItemType<SulphurousGrabber>()
//             },
//             $"Используйте [i:{ModContent.ItemType<CausticTear>()}] или дождитесь, пока событие произойдёт естественным образом после победы над Акватическим бичом.",
//             CalamityUtils.ColorMessage("Таинственные существа сернистого моря спустились обратно в глубины океана.", new Color(146, 183, 116))
//         );
//
//          ModsCall.BossChecklist.Call(
//              "AddEvent",
//              19.49f,
//              new List<int>
//              {
//                  ModContent.NPCType<Radiator>(),
//                  ModContent.NPCType<AcidEel>(),
//                  ModContent.NPCType<NuclearToad>(),
//                  ModContent.NPCType<FlakCrab>(),
//                  ModContent.NPCType<Orthocera>(),
//                  ModContent.NPCType<Skyfin>(),
//                  ModContent.NPCType<Trilobite>(),
//                  ModContent.NPCType<WaterLeech>(),
//                  ModContent.NPCType<SulphurousSkater>(),
//                  ModContent.NPCType<GammaSlime>(),
//                  ModContent.NPCType<CragmawMire>(),
//                  ModContent.NPCType<Mauler>(),
//                  ModContent.NPCType<NuclearTerror>(),
//              },
//              ModsCall.Calamity,
//              "Кислотный дождь (Пост-Полтер)",
//              (Func<bool>)(() => DownedBoomerDuke),
//              new List<int> { ModContent.ItemType<CausticTear>() },
//              new List<int> { ModContent.ItemType<RadiatingCrystal>() },
//              new List<int>
//              {
//                  ItemID.SharkFin, ModContent.ItemType<SulphuricScale>(),
//                  ModContent.ItemType<CorrodedFossil>(), ModContent.ItemType<NuclearRod>(),
//                  ModContent.ItemType<ParasiticSceptor>(), ModContent.ItemType<CausticCroakerStaff>(),
//                  ModContent.ItemType<FlakToxicannon>(), ModContent.ItemType<OrthoceraShell>(),
//                  ModContent.ItemType<SkyfinBombers>(), ModContent.ItemType<SlitheringEels>(),
//                  ModContent.ItemType<SpentFuelContainer>(), ModContent.ItemType<SulphurousGrabber>(),
//                  ModContent.ItemType<GammaHeart>(), ModContent.ItemType<PhosphorescentGauntlet>(),
//                  ModContent.ItemType<SulphuricAcidCannon>()
//              },
//              $"Используйте [i:{ModContent.ItemType<CausticTear>()}] или дождитесь, пока событие произойдёт естественным образом после победы над Полтергастом.",
//              CalamityUtils.ColorMessage("Таинственные существа сернистого моря спустились обратно в глубины океана.", new Color(146, 183, 116))
//          );
//     }
// }