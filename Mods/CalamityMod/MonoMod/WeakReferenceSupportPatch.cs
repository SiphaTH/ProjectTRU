using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CalamityMod;
using CalamityMod.Events;
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
using CalamityMod.World;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [ModDependency("BossChecklist")]
    [CultureDependency("ru-RU")]
    public class WeakReferenceSupportAddCalamityBosses : MonoModPatcher<string>
    {
        public override MethodInfo Method => ModsCall.Calamity.Code.GetType("CalamityMod.WeakReferenceSupport").GetCachedMethod("AddCalamityBosses");

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Desert Biome", "Используйте [i:{0}] в пустыне.");
            TranslationHelper.ILTranslation(il, "The scourge of the desert delved back into the sand.", "Пустынный бич погружается назад в песок.");
            TranslationHelper.ILTranslation(il, "Desert Scourge", "Пустынный бич");
            TranslationHelper.ILTranslation(il, "Can spawn naturally in the Sunken Sea", "Может естественно появится в затерянном море.");
            TranslationHelper.ILTranslation(il, "The Giant Clam returns into hiding in its grotto.", "Гигантский моллюск скрывается в своём гроте.");
            TranslationHelper.ILTranslation(il, "Giant Clam", "Гигантский моллюск");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Mushroom Biome", "Используйте [i:{0}] в грибном биоме.");
            TranslationHelper.ILTranslation(il, "The mycleium crab has lost interest.", "Мицелиевый краб потерял интерес.");
            TranslationHelper.ILTranslation(il, "Crabulon", "Крабулон", 2);
            TranslationHelper.ILTranslation(il, "Kill a Cyst in the Corruption or use a [i:{0}] in the Corruption", "Убейте кисту или используйте [i:{0}] в искажении.");
            TranslationHelper.ILTranslation(il, "The corrupted colony began searching for a new breeding ground.", "Искажённая стая начала поиски нового места для размножения.");
            TranslationHelper.ILTranslation(il, "Hive Mind", "Разум Улья");
            TranslationHelper.ILTranslation(il, "Kill a Cyst in the Crimson or use a [i:{0}] in the Crimson", "Убейте кисту или используйте [i:{0}] в багрянце.");
            TranslationHelper.ILTranslation(il, "The parasitic hive began searching for a new host.", "Паразитический улей начал искать нового носителя.");
            TranslationHelper.ILTranslation(il, "The Perforators", "Перфораторы");
            TranslationHelper.ILTranslation(il, "Use an [i:{0}]", "Используйте [i:{0}].");
            TranslationHelper.ILTranslation(il, "The gelatinous monstrosity achieved vengeance for its brethren.", "Желеподобное чудовище отомстило за своих собратьев.");
            TranslationHelper.ILTranslation(il, "Slime God", "Бог слизней");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Snow Biome", "Используйте [i:{0}] в снегах.");
            TranslationHelper.ILTranslation(il, "Cryogen drifts away, carried on a freezing wind.", "Криоген уносится прочь ледяным ветром.");
            TranslationHelper.ILTranslation(il, "Cryogen", "Криоген", 2);
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Brimstone Crag", "Используйте [i:{0}] в серной скале.");
            TranslationHelper.ILTranslation(il, "Brimstone Elemental withdraws to the ruins of her shrine.", "Серный элементаль отступает к руинам своей святыни.");
            TranslationHelper.ILTranslation(il, "Brimstone Elemental", "Серный элементаль");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Sulphuric Sea or wait for it to spawn in the Sulphuric Sea", "Используйте [i:{0}] или подождите его появление в сернистом море.");
            TranslationHelper.ILTranslation(il, "The Aquatic Scourge swam back into the open ocean.", "Акватический бич уплыл обратно в открытый океан.");
            TranslationHelper.ILTranslation(il, "Aquatic Scourge", "Акватический бич");
            TranslationHelper.ILTranslation(il, "Use an [i:{0}] at Night", "Используйте [i:{0}] ночью.");
            TranslationHelper.ILTranslation(il, "If you wanted a fight, you should've came more prepared.", "Если вы хотели драки, вы должны были прийти более подготовленными.");
            TranslationHelper.ILTranslation(il, "Calamitas", "Каламитас", 2);
            TranslationHelper.ILTranslation(il, "Kill 10 sand sharks after defeating Plantera or use a [i:{0}] in the Desert Biome", "Убейте 10 песчаных акул после победы над Плантерой или используйте [i:{0}] в пустыне.");
            TranslationHelper.ILTranslation(il, "The apex predator of the sands disappears into the dunes...", "Высший хищник песков исчезает в дюнах...");
            TranslationHelper.ILTranslation(il, "Great Sand Shark", "Великая песчаная акула");
            TranslationHelper.ILTranslation(il, "By killing an unknown entity in the Ocean Biome", "Убейте неизвестное существо в океане");
            TranslationHelper.ILTranslation(il, "The aquatic entities sink back beneath the ocean depths.", "Водные существа возвращаются в глубины океана.");
            TranslationHelper.ILTranslation(il, "Leviathan", "Левиафан", 2);
            TranslationHelper.ILTranslation(il, "Use an [i:{0}] at Night in the Astral Biome", "Используйте [i:{0}] ночью в астральном биоме.");
            TranslationHelper.ILTranslation(il, "Astrum Aureus’ program has been executed. Initiate recall.", "Программа Аструм Ареуса выполнена. Инициирую возврат.");
            TranslationHelper.ILTranslation(il, "Astrum Aureus", "Аструм Ареус");
            TranslationHelper.ILTranslation(il, "Use an [i:{0}] in the Jungle Biome", "Используйте [i:{0}] в джунглях.");
            TranslationHelper.ILTranslation(il, "HOSTILE SPECIMENS TERMINATED. INITIATE RECALL TO HOME BASE.", "ВРАЖДЕБНЫЕ СУЩНОСТИ УНИЧТОЖЕНЫ. ИНИЦИИРУЮ ВОЗВРАТ НА БАЗУ.");
            TranslationHelper.ILTranslation(il, "Plaguebringer Goliath", "Разносчица чумы, Голиаф");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}]", "Используйте [i:{0}].");
            TranslationHelper.ILTranslation(il, "The automaton of misshapen victims went looking for the true perpetrator.", "Машина бесформенных жертв отправилась на поиски истинного нарушителя.");
            TranslationHelper.ILTranslation(il, "Ravager", "Разрушитель", 2);
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] or [i:{1}] as offering at an [i:{2}]", "Используйте [i:{0}] или [i:{1}] в качестве подношения на [i:{2}].");
            TranslationHelper.ILTranslation(il, "The infected deity retreats to the heavens.", "Заражённое божество отступает к небесам.");
            TranslationHelper.ILTranslation(il, "Astrum Deus", "Аструм Деус");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Hallow or Underworld Biomes", "Используйте [i:{0}] в святых землях или в аду.");
            TranslationHelper.ILTranslation(il, "The guardians must protect their goddess at all costs.", "Стражи должны защищать свою богиню любой ценой.");
            TranslationHelper.ILTranslation(il, "Profaned Guardians", "Осквернённые стражи");
            TranslationHelper.ILTranslation(il, "Use [i:{0}] in the Jungle Biome", "Используйте [i:{0}] в джунглях.");
            TranslationHelper.ILTranslation(il, "The failed experiment returns to its reproductive routine.", "Неудачный эксперимент вернулся к своему репродуктивному распорядку.");
            TranslationHelper.ILTranslation(il, "Dragonfolly", "Псевдодракон", 2);
            TranslationHelper.ILTranslation(il, "Use [i:{0}] in the Hallow or Underworld Biomes", "Используйте [i:{0}] в святых землях или аду.");
            TranslationHelper.ILTranslation(il, "The Profaned Goddess vanishes in a burning blaze.", "Осквернённая богиня исчезает в горящем пламени.");
            TranslationHelper.ILTranslation(il, "Providence", "Провиденс", 2);
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Dungeon", "Используйте [i:{0}] в темнице.");
            TranslationHelper.ILTranslation(il, "The rift in time and space has moved away from your reach.", "Разлом во времени и пространстве удалился вдаль.");
            TranslationHelper.ILTranslation(il, "Ceaseless Void", "Нескончаемая пустота");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in Space", "Используйте [i:{0}] в космосе.");
            TranslationHelper.ILTranslation(il, "Storm Weaver hid itself once again within the stormfront.", "Штормовой ткач снова спрятался в грозовом фронте.");
            TranslationHelper.ILTranslation(il, "Storm Weaver", "Штормовой ткач");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Underworld", "Используйте [i:{0}] в аду.");
            TranslationHelper.ILTranslation(il, "The Devourer's assassin has finished its easy task.", "Убийца Пожирателя выполнил свою лёгкую задачу.");
            TranslationHelper.ILTranslation(il, "Signus", "Сигнус", 2);
            TranslationHelper.ILTranslation(il, "Kill 30 phantom spirits or use a [i:{0}] in the Dungeon", "Убейте 30 фантомных духов или используйте [i:{0}] в темнице.");
            TranslationHelper.ILTranslation(il, "The volatile spirits disperse throughout the depths of the dungeon.", "Нестабильные духи разбредаются по темнице.");
            TranslationHelper.ILTranslation(il, "Polterghast", "Полтергаст", 2);
            TranslationHelper.ILTranslation(il, "Defeat the Acid Rain event post-Polterghast or fish using a [i:{0}] in the Sulphurous Sea", "Одолейте событие «Кислотный дождь» после победы над Полтергастом или выловите с помощью [i:{0}] в сернистом море");
            TranslationHelper.ILTranslation(il, "The old duke disappears amidst the acidic downpour.", "Старый герцог исчезает посреди кислотного ливня.");
            TranslationHelper.ILTranslation(il, "Old Duke", "Старый герцог");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}]", "Используйте [i:{0}].", 2);
            TranslationHelper.ILTranslation(il, "The Devourer of Gods has slain everyone and feasted on their essence.", "Пожиратель богов убил всех и пировал их сущностью.");
            TranslationHelper.ILTranslation(il, "Devourer of Gods", "Пожиратель богов");
            TranslationHelper.ILTranslation(il, "Use a [i:{0}] in the Jungle Biome", "Используйте [i:{0}] в джунглях.");
            TranslationHelper.ILTranslation(il, "Yharon found you too weak to stay near your gravestone.", "Ярон считает вас слишком слабым, чтобы оставаться с вашим надгробием.");
            TranslationHelper.ILTranslation(il, "Yharon", "Ярон", 2);
            TranslationHelper.ILTranslation(il, "Use [i:{0}] or a [i:{1}] as offering at an [i:{2}]", "Используйте [i:{0}] или [i:{1}] в качестве подношения на [i:{2}]");
            TranslationHelper.ILTranslation(il, "Please don't waste my time.", "Пожалуйста, не трать моё время.");
            TranslationHelper.ILTranslation(il, "Supreme Calamitas", "Высшая Каламитас");
            TranslationHelper.ILTranslation(il, "By using a high-tech computer", "С помощью высокотехнологичного компьютера.");
            TranslationHelper.ILTranslation(il, "An imperfection after all... what a shame.", "Несовершенство... какой позор.");
            TranslationHelper.ILTranslation(il, "Exo Mechs", "Экзо-механизмы");
            TranslationHelper.ILTranslation(il, "While in the Abyss, use an item that inflicts Chaos State", "Находясь в бездне, используйте предмет, который накладывает дебафф «Хаотичность»");
            TranslationHelper.ILTranslation(il, "Adult Eidolon Wyrm", "Фантомный змей");
        }
    }

    public class WeakReferenceSupportCensusSupport : ILEdit
    {
        private readonly MethodInfo _censusSupport = ModsCall.Calamity?.Code.GetType("CalamityMod.WeakReferenceSupport")
            .GetMethod("CensusSupport", BindingFlags.Static | BindingFlags.NonPublic);

        private delegate void orig_CensusSupport();
        private delegate void hook_CensusSupport(orig_CensusSupport orig);

        private event hook_CensusSupport OnCensusSupport
        {
            add => HookEndpointManager.Add<hook_CensusSupport>(_censusSupport, value);
            remove => HookEndpointManager.Remove<hook_CensusSupport>(_censusSupport, value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && ModsCall.Census != null && TranslationHelper.IsRussianLanguage;
    
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
                "Имейте [i:74] в вашем инвентаре после победы над Скелетроном"
            );
            ModsCall.Census.Call(
                "TownNPCCondition",
                ModContent.NPCType<FAP>(),
                $"Имейте [i:{ModContent.ItemType<FabsolsVodka>()}] в вашем инвентаре в Хардмоде"
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

    public class WeakReferenceSupportAddCalamityInvasions : ILEdit
    {
        private readonly MethodInfo _addCalamityInvasions = ModsCall.Calamity?.Code.GetType("CalamityMod.WeakReferenceSupport")
            .GetMethod("AddCalamityInvasions", BindingFlags.Static | BindingFlags.NonPublic);

        private delegate void orig_AddCalamityInvasions(Mod bossChecklist, Mod calamity);
        private delegate void hook_AddCalamityInvasions(orig_AddCalamityInvasions orig, Mod bossChecklist, Mod calamity);

        private event hook_AddCalamityInvasions OnAddCalamityInvasions
        {
            add => HookEndpointManager.Add<hook_AddCalamityInvasions>(_addCalamityInvasions, value);
            remove => HookEndpointManager.Remove<hook_AddCalamityInvasions>(_addCalamityInvasions, value);
        }

        public override bool Autoload() => ModsCall.Calamity != null && ModsCall.BossChecklist != null && TranslationHelper.IsRussianLanguage;
    
        public override void Load()
        {
            OnAddCalamityInvasions += Translation;
        }
    
        public override void Unload()
        {
            OnAddCalamityInvasions -= Translation;
        }
    
        private void Translation(orig_AddCalamityInvasions orig, Mod bossChecklist, Mod calamity)
        {
            List<int> acidRainPreHardNpc = AcidRainEvent.PossibleEnemiesPreHM.Select(enemy => enemy.Key).ToList();

            ModsCall.BossChecklist.Call(
                "AddEvent",
                2.4f,
                acidRainPreHardNpc,
                ModsCall.Calamity,
                "Кислотный дождь",
                (Func<bool>)(() => CalamityWorld.downedEoCAcidRain),
                new List<int> { ModContent.ItemType<CausticTear>() },
                new List<int> { ModContent.ItemType<RadiatingCrystal>() },
                new List<int>
                {
                    ModContent.ItemType<SulfuricScale>(), ModContent.ItemType<ParasiticSceptor>(),
                    ModContent.ItemType<CausticCroakerStaff>()
                },
                $"Используйте [i:{ModContent.ItemType<CausticTear>()}] или дождитесь, пока событие произойдёт естественным образом после победы над глазом Ктулху.",
                CalamityUtils.ColorMessage("Таинственные существа сернистого моря спустились обратно в океан.", new Color(146, 183, 116)),
                "CalamityMod/Events/AcidRainT1_BossChecklist",
                "CalamityMod/ExtraTextures/UI/AcidRainIcon",
                null
            );

            List<int> acidRainPostASNpc = AcidRainEvent.PossibleEnemiesAS.Select(enemy => enemy.Key).ToList();
            acidRainPostASNpc.Add(ModContent.NPCType<IrradiatedSlime>());
            acidRainPostASNpc.AddRange(AcidRainEvent.PossibleMinibossesAS.Select(miniboss => miniboss.Key));

            ModsCall.BossChecklist.Call(
                "AddEvent",
                7.51f,
                acidRainPostASNpc,
                ModsCall.Calamity,
                "Кислотный дождь (Пост-Аб)",
                (Func<bool>)(() => CalamityWorld.downedAquaticScourgeAcidRain),
                new List<int> { ModContent.ItemType<CausticTear>() },
                new List<int> { ModContent.ItemType<RadiatingCrystal>() },
                new List<int>
                {
                    ModContent.ItemType<SulfuricScale>(), ModContent.ItemType<CorrodedFossil>(),
                    ModContent.ItemType<LeadCore>(), ModContent.ItemType<NuclearRod>(),
                    ModContent.ItemType<ParasiticSceptor>(), ModContent.ItemType<CausticCroakerStaff>(),
                    ModContent.ItemType<FlakToxicannon>(), ModContent.ItemType<OrthoceraShell>(),
                    ModContent.ItemType<SkyfinBombers>(), ModContent.ItemType<SlitheringEels>(),
                    ModContent.ItemType<SpentFuelContainer>(), ModContent.ItemType<SulphurousGrabber>()
                },
                $"Используйте [i:{ModContent.ItemType<CausticTear>()}] или дождитесь, пока событие произойдёт естественным образом после победы над Акватическим бичом.",
                CalamityUtils.ColorMessage("Таинственные существа сернистого моря спустились обратно в глубины океана.", new Color(146, 183, 116)),
                "CalamityMod/Events/AcidRainT2_BossChecklist",
                "CalamityMod/ExtraTextures/UI/AcidRainIcon",
                null
            );

            List<int> acidRainPostPolterNpc = AcidRainEvent.PossibleEnemiesPolter.Select(enemy => enemy.Key).ToList();
            acidRainPostPolterNpc.AddRange(AcidRainEvent.PossibleMinibossesPolter.Select(miniboss => miniboss.Key));

            ModsCall.BossChecklist.Call(
                "AddEvent",
                16.49f,
                acidRainPostPolterNpc,
                ModsCall.Calamity,
                "Кислотный дождь (Пост-Полтер)",
                (Func<bool>)(() => CalamityWorld.downedBoomerDuke),
                new List<int> { ModContent.ItemType<CausticTear>() },
                new List<int> { ModContent.ItemType<RadiatingCrystal>() },
                new List<int>
                {
                    ItemID.SharkFin,
                    ModContent.ItemType<SulfuricScale>(), ModContent.ItemType<CorrodedFossil>(),
                    ModContent.ItemType<LeadCore>(), ModContent.ItemType<NuclearRod>(),
                    ModContent.ItemType<ParasiticSceptor>(), ModContent.ItemType<CausticCroakerStaff>(),
                    ModContent.ItemType<FlakToxicannon>(), ModContent.ItemType<OrthoceraShell>(),
                    ModContent.ItemType<SkyfinBombers>(), ModContent.ItemType<SlitheringEels>(),
                    ModContent.ItemType<SpentFuelContainer>(), ModContent.ItemType<SulphurousGrabber>(),
                    ModContent.ItemType<GammaHeart>(), ModContent.ItemType<PhosphorescentGauntlet>(),
                    ModContent.ItemType<SulphuricAcidCannon>()
                },
                $"Используйте [i:{ModContent.ItemType<CausticTear>()}] или дождитесь, пока событие произойдёт естественным образом после победы над Полтергастом.",
                CalamityUtils.ColorMessage("Таинственные существа сернистого моря спустились обратно в глубины океана.", new Color(146, 183, 116)),
                "CalamityMod/Events/AcidRainT3_BossChecklist",
                "CalamityMod/ExtraTextures/UI/AcidRainIcon",
                null
            );
        }
    }
}