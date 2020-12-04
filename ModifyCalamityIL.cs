using System;
using System.Reflection;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate
{
    internal static class CalamityIl
    {
        public static void Setup() => Type();
        
        public static void Unload() => UnloadIL();

        private static void Type()
        {
            #region Calamity Type

            Type ripperUI = null;
            Type acidRainUI = null;
            Type stealthUI = null;
            Type calamityPlayer = null;
            Type cheatTestThing = null;
            Type labHologramProjectorUI = null;
            Type draedonLogHellGUI = null;
            Type draedonLogJungleGUI = null;
            Type draedonLogPlanetoidGUI = null;
            Type draedonLogSnowBiomeGUI = null;
            Type draedonLogSunkenSeaGUI = null;
            Type weakReferenceSupport = null;
            Type fap = null;
            Type sEAHOE = null;
            Type tHIEF = null;
            Type astralInjection = null;
            Type thornBlossom = null;
            Type lucrecia = null;
            Type bloodBoiler = null;
            Type molecularManipulator = null;
            Type nullificationRifle = null;
            Type devourerofGodsHead = null;
            Type devourerofGodsHeadS = null;
            Type fearlessGoldfishWarrior = null;
            Type healOrbProv = null;
            Type holyBurnOrb = null;
            Type chibiiDoggo = null;
            Type calamityUtils = null;
            Type plaguedPlateBed = null;
            Type ravagerBody = null;
            Type calamitasRun3 = null;
            Type profanedGuardianBoss2 = null;
            Type bossHPUI = null;
            Type perforatorHeadLarge = null;
            Type perforatorHeadSmall = null;
            Type bumblefuck = null;
            Type perforatorHeadMedium = null;
            Type profanedGuardianBoss3 = null;
            Type profanedGuardianBoss = null;
            Type bossRushUI = null;
            Type coldDivinity = null;

            Assembly calamityAssembly = ModCompatibility.CalamityMod.GetType().Assembly;

            foreach (Type calamityClass in calamityAssembly.GetTypes())
            {
                switch (calamityClass.Name)
                {
                    case "RipperUI":
                        ripperUI = calamityClass;
                        break;
                    case "DraedonLogHellGUI":
                        draedonLogHellGUI = calamityClass;
                        break;
                    case "StealthUI":
                        stealthUI = calamityClass;
                        break;
                    case "CalamityPlayer":
                        calamityPlayer = calamityClass;
                        break;
                    case "CheatTestThing":
                        cheatTestThing = calamityClass;
                        break;
                    case "AcidRainUI":
                        acidRainUI = calamityClass;
                        break;
                    case "DraedonLogJungleGUI":
                        draedonLogJungleGUI = calamityClass;
                        break;
                    case "DraedonLogPlanetoidGUI":
                        draedonLogPlanetoidGUI = calamityClass;
                        break;
                    case "DraedonLogSnowBiomeGUI":
                        draedonLogSnowBiomeGUI = calamityClass;
                        break;
                    case "DraedonLogSunkenSeaGUI":
                        draedonLogSunkenSeaGUI = calamityClass;
                        break;
                    case "WeakReferenceSupport":
                        weakReferenceSupport = calamityClass;
                        break;
                    case "FAP":
                        fap = calamityClass;
                        break;
                    case "SEAHOE":
                        sEAHOE = calamityClass;
                        break;
                    case "THIEF":
                        tHIEF = calamityClass;
                        break;
                    case "LabHologramProjectorUI":
                        labHologramProjectorUI = calamityClass;
                        break;
                    case "AstralInjection":
                        astralInjection = calamityClass;
                        break;
                    case "ThornBlossom":
                        thornBlossom = calamityClass;
                        break;
                    case "Lucrecia":
                        lucrecia = calamityClass;
                        break;
                    case "BloodBoiler":
                        bloodBoiler = calamityClass;
                        break;
                    case "MolecularManipulator":
                        molecularManipulator = calamityClass;
                        break;
                    case "NullificationRifle":
                        nullificationRifle = calamityClass;
                        break;
                    case "DevourerofGodsHead":
                        devourerofGodsHead = calamityClass;
                        break;
                    case "DevourerofGodsHeadS":
                        devourerofGodsHeadS = calamityClass;
                        break;
                    case "FearlessGoldfishWarrior":
                        fearlessGoldfishWarrior = calamityClass;
                        break;
                    case "HealOrbProv":
                        healOrbProv = calamityClass;
                        break;
                    case "HolyBurnOrb":
                        holyBurnOrb = calamityClass;
                        break;
                    case "ChibiiDoggo":
                        chibiiDoggo = calamityClass;
                        break;
                    case "CalamityUtils":
                        calamityUtils = calamityClass;
                        break;
                    case "PlaguedPlateBed" when calamityClass.Namespace == "CalamityMod.Tiles.FurniturePlaguedPlate":
                        plaguedPlateBed = calamityClass;
                        break;
                    case "RavagerBody":
                        ravagerBody = calamityClass;
                        break;
                    case "CalamitasRun3":
                        calamitasRun3 = calamityClass;
                        break;
                    case "BossHPUI":
                        bossHPUI = calamityClass;
                        break;
                    case "ProfanedGuardianBoss2":
                        profanedGuardianBoss2 = calamityClass;
                        break;
                    case "PerforatorHeadLarge":
                        perforatorHeadLarge = calamityClass;
                        break;
                    case "PerforatorHeadSmall":
                        perforatorHeadSmall = calamityClass;
                        break;
                    case "Bumblefuck":
                        bumblefuck = calamityClass;
                        break;
                    case "PerforatorHeadMedium":
                        perforatorHeadMedium = calamityClass;
                        break;
                    case "ProfanedGuardianBoss3":
                        profanedGuardianBoss3 = calamityClass;
                        break;
                    case "ProfanedGuardianBoss":
                        profanedGuardianBoss = calamityClass;
                        break;
                    case "BossRushUI":
                        bossRushUI = calamityClass;
                        break;
                    case "ColdDivinity":
                        coldDivinity = calamityClass;
                        break;
                }
            }
            
            _handleMouseInteraction = ripperUI?.GetMethod("HandleMouseInteraction", BindingFlags.Static | BindingFlags.NonPublic);
            ModifyHandleMouseInteraction += Ru_ModifyHandleMouseInteraction;
            
            DrawAcidRain = acidRainUI?.GetMethod("get_InvasionName", BindingFlags.Instance | BindingFlags.Public);
            ModifyDrawAcidRain += Calamity_ModifyDrawAcidRain;
            
            DrawStealth = stealthUI?.GetMethod("Draw", BindingFlags.Static | BindingFlags.Public);
            ModifyDrawStealth += Ru_ModifyDrawStealth;
            
            KillPlayer = calamityPlayer?.GetMethod("KillPlayer", BindingFlags.Instance | BindingFlags.Public);
            PreKill = calamityPlayer?.GetMethod("PreKill", BindingFlags.Instance | BindingFlags.Public);
            ModifyKillPlayer += Ua_ModifyKillPlayer;
            ModifyPreKill += Ua_ModifyPreKill;

            UpdateAccessory = cheatTestThing?.GetMethod("UpdateAccessory", BindingFlags.Instance | BindingFlags.Public);
            ModifyUpdateAccessory += Ua_ModifyUpdateAccessory;

            ChooseDialogue = labHologramProjectorUI?.GetMethod("ChooseDialogue", BindingFlags.Public | BindingFlags.Static);
            ModifyChooseDialogue += Ua_ModifyChooseDialogue;

            GetTextByPageHellGUI = draedonLogHellGUI?.GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance);
            ModifyGetTextByPageHellGUI += Ru_ModifyGetTextByPageHellGUI;

            GetTextByPageJungleGUI = draedonLogJungleGUI?.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            ModifyGetTextByPageJungleGUI += Calamity_ModifyModifyGetTextByPageJungleGUI;
            
            GetTextByPagePlanetoidGUI = draedonLogPlanetoidGUI?.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            ModifyGetTextByPagePlanetoidGUI += Calamity_ModifyModifyGetTextByPagePlanetoidGUI;
            
            GetTextByPageSnowBiomeGUI = draedonLogSnowBiomeGUI?.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            ModifyGetTextByPageSnowBiomeGUI += Calamity_ModifyModifyGetTextByPageSnowBiomeGUI;

            GetTextByPageSunkenSeaGUI = draedonLogSunkenSeaGUI?.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            ModifyGetTextByPageSunkenSeaGUI += Calamity_ModifyModifyGetTextByPageSunkenSeaGUI;

            AddCalamityBosses = weakReferenceSupport?.GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic);
            ModifyAddCalamityBosses += Ua_ModifyAddCalamityBosses;

            SetChatButtonsFAP = fap?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            ModifySetChatButtonsFAP += Calamity_ModifySetChatButtonsFAP;
            
            SetChatButtonsSEAHOE = sEAHOE?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            ModifySetChatButtonsSEAHOE += Calamity_ModifySetChatButtonsSEAHOE;
            
            SetChatButtonsTHIEF = tHIEF?.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            ModifySetChatButtonsTHIEF += Calamity_ModifySetChatButtonsTHIEF; 
            
            OnConsumeItemAstralInjection = astralInjection?.GetMethod("OnConsumeItem", BindingFlags.Public | BindingFlags.Instance);
            ModifyOnConsumeItemAstralInjection += Ua_ModifyOnConsumeItemAstralInjection;
            
            ShootThornBlossom = thornBlossom?.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyShootThornBlossom += Ua_ModifyShootThornBlossom;

            ShootThornLucrecia = lucrecia?.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyShootThornLucrecia += Ua_ModifyShootThornLucrecia;
            
            ShootBloodBoiler = bloodBoiler?.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyShootBloodBoiler += Ua_ModifyShootBloodBoiler;

            ShootMolecularManipulator = molecularManipulator?.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyMolecularManipulator += Ua_ModifyMolecularManipulator;

            ShootNullificationRifle = nullificationRifle?.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyShootNullificationRifle += Ua_ModifyShootNullificationRifle;

            OnHitPlayerDevourerofGodsHead = devourerofGodsHead?.GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance);
            ModifyOnHitPlayerDevourerofGodsHead += Ua_ModifyOnHitPlayerDevourerofGodsHead;

            OnHitPlayerDevourerofGodsHeadS = devourerofGodsHeadS?.GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance);
            ModifyOnHitPlayerDevourerofGodsHeadS += Ua_ModifyOnHitPlayerDevourerofGodsHeadS;

            ModifyHitPlayerFearlessGoldfishWarrior = fearlessGoldfishWarrior?.GetMethod("ModifyHitPlayer", BindingFlags.Public | BindingFlags.Instance);
            ModifyModifyHitPlayerFearlessGoldfishWarrior += Ua_ModifyModifyHitPlayerFearlessGoldfishWarrior;

            GetChatFAP = fap?.GetMethod("GetChat", BindingFlags.Public | BindingFlags.Instance);
            ModifyGetChatFAP += Ua_ModifyGetChatFAP;

            AIHealOrbProv = healOrbProv?.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            ModifyAIHealOrbProv += Ua_ModifyAIHealOrbProv;

            AIHolyBurnOrb = holyBurnOrb?.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            ModifyAIHolyBurnOrb += Ua_ModifyAIHolyBurnOrb;
            
            AIChibiiDoggo = chibiiDoggo?.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            ModifyAIChibiiDoggo += Ua_ModifyAIChibiiDoggo;
            
            SpawnDoggo = chibiiDoggo?.GetMethod("SpawnDoggo", BindingFlags.Public | BindingFlags.Instance);
            ModifySpawnDoggo += Ua_ModifySpawnDoggo;
            
            BedRightClick = calamityUtils?.GetMethod("BedRightClick", BindingFlags.Public | BindingFlags.Static);
            ModifyBedRightClick += Ua_ModifyBedRightClick;
            
            NewRightClick = plaguedPlateBed?.GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance);
            ModifyNewRightClick += Ua_ModifyNewRightClick;
            
            AddCalamityInvasions = weakReferenceSupport?.GetMethod("AddCalamityInvasions", BindingFlags.NonPublic | BindingFlags.Static);
            ModifyAddCalamityInvasions += Ua_ModifyAddCalamityInvasions;
            
            CensusSupport = weakReferenceSupport?.GetMethod("CensusSupport", BindingFlags.NonPublic | BindingFlags.Static);
            ModifyCensusSupport += Ua_ModifyCensusSupport;
            
            BossLootRavager = ravagerBody?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyBossLootRavager += Ua_ModifyBossLootRavager;
            
            BossLootCalamitasRun3 = calamitasRun3?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyBossLootCalamitasRun3 += Ua_ModifyBossLootCalamitasRun3;
            
            DrawBossHPUI = bossHPUI?.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            ModifyDrawBossHPUI += Ua_ModifyDrawBossHPUI;
            
            DrawOpenAnim = bossHPUI?.GetMethod("DrawOpenAnim", BindingFlags.Public | BindingFlags.Instance);
            ModifyDrawOpenAnim += Ua_ModifyDrawOpenAnim;
            
            BossLootProfanedGuardianBoss2 = profanedGuardianBoss2?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyBossLootProfanedGuardianBoss2 += Ua_ModifyBossLootProfanedGuardianBoss2;
            
            BossLootPerforatorHeadLarge = perforatorHeadLarge?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyBossLootPerforatorHeadLarge += Ua_ModifyBossLootPerforatorHeadLarge;
            
            BossLootPerforatorHeadSmall = perforatorHeadSmall?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyBossLootPerforatorHeadSmall += Ua_ModifyBossLootPerforatorHeadSmall;


            BossLootBumblefuck = bumblefuck?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyBossLootBumblefuck += Ua_ModifyBossLootBumblefuck;
            
            BossLootPerforatorHeadMedium = perforatorHeadMedium?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyBossLootPerforatorHeadMedium += Ua_ModifyBossLootPerforatorHeadMedium;
            
            BossLootProfanedGuardianBoss3 = profanedGuardianBoss3?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyBossLootProfanedGuardianBoss3 += Ua_ModifyBossLootProfanedGuardianBoss3;
            
            BossLootProfanedGuardianBoss = profanedGuardianBoss?.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            ModifyBossLootProfanedGuardianBoss += Ua_ModifyBossLootProfanedGuardianBoss;
            
            InvasionNamebossRushUI = bossRushUI?.GetMethod("get_InvasionName", BindingFlags.Public | BindingFlags.Instance);
            ModifyInvasionNamebossRushUI += Ua_ModifyInvasionNamebossRushUI;
            
            ColdDivinityModifyTooltips = coldDivinity?.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            ModifyColdDivinityModifyTooltips += Ua_ModifyColdDivinityModifyTooltips;

            #endregion
        }

        #region IL Editing

        private static void ModifyCalamityIl(ILContext il, string original, string translation, int iterations)
        {
            var cursor = new ILCursor(il);

            for (int j = 0; j < iterations; j++)
            {
                if (!cursor.TryGotoNext(i => i.MatchLdstr(original)))
                {
                    Utils.WriteWarn($"IL failed when trying edit {original} with {translation}");
                    return;
                }
            }

            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldstr, translation);
        }
        
        private static void ModifyCalamityIl(ILContext il, string original, string translation)
        {
            var cursor = new ILCursor(il);

            if (!cursor.TryGotoNext(i => i.MatchLdstr(original)))
            {
                Utils.WriteWarn($"IL failed when trying edit {original} with {translation}");
                return;
            }
        
            cursor.Index++;
            cursor.Emit(OpCodes.Pop);
            cursor.Emit(OpCodes.Ldstr, translation);
        }
        
        private static void Ua_ModifyColdDivinityModifyTooltips(ILContext il) => ModifyCalamityIl(il, "Tooltip7", "Tooltip6");
        
        private static void Ua_ModifyInvasionNamebossRushUI(ILContext il) => ModifyCalamityIl(il, "Boss Rush", EncodingCyrillic.EncodingTransform("Босс-Раш"));
        
        private static void Ua_ModifyBossLootProfanedGuardianBoss(ILContext il) => ModifyCalamityIl(il, "A Profaned Guardian", EncodingCyrillic.EncodingTransform("Осквернённый страж"));
        
        private static void Ua_ModifyBossLootProfanedGuardianBoss3(ILContext il) => ModifyCalamityIl(il, "A Profaned Guardian", EncodingCyrillic.EncodingTransform("Осквернённый страж"));
        
        private static void Ua_ModifyBossLootPerforatorHeadMedium(ILContext il) => ModifyCalamityIl(il, "The Medium Perforator", EncodingCyrillic.EncodingTransform("Перфоратор средний"));
        
        private static void Ua_ModifyBossLootBumblefuck(ILContext il) => ModifyCalamityIl(il, "A Dragonfolly", EncodingCyrillic.EncodingTransform("Псевдодракон"));
        
        private static void Ua_ModifyBossLootPerforatorHeadSmall(ILContext il) => ModifyCalamityIl(il, "The Small Perforator", EncodingCyrillic.EncodingTransform("Перфоратор младший"));
        
        private static void Ua_ModifyBossLootPerforatorHeadLarge(ILContext il) => ModifyCalamityIl(il, "The Large Perforator", EncodingCyrillic.EncodingTransform("Перфоратор старший"));
        
        private static void Ua_ModifyBossLootProfanedGuardianBoss2(ILContext il) => ModifyCalamityIl(il, "A Profaned Guardian", EncodingCyrillic.EncodingTransform("Осквернённый страж"));
        
        private static void Ua_ModifyDrawBossHPUI(ILContext il)
        {
            ModifyCalamityIl(il, "(Segments left: ", EncodingCyrillic.EncodingTransform("(Осталось сегментов: "));
            ModifyCalamityIl(il, "(Creepers left: ", EncodingCyrillic.EncodingTransform("(Осталось ползунов: "));
            ModifyCalamityIl(il, "(Hands left: ", EncodingCyrillic.EncodingTransform("(Осталось рук: "));
            ModifyCalamityIl(il, "(Arms left: ", EncodingCyrillic.EncodingTransform("(Осталось оружий: "));
            ModifyCalamityIl(il, "(Guns left: ", EncodingCyrillic.EncodingTransform("(Осталось ружей: "));
            ModifyCalamityIl(il, "(Cannons left: ", EncodingCyrillic.EncodingTransform("(Осталось пушек: "));
            ModifyCalamityIl(il, "(Dark Energy left: ", EncodingCyrillic.EncodingTransform("(Осталось тёмной энергии: "));
            ModifyCalamityIl(il, "(Body Parts left: ", EncodingCyrillic.EncodingTransform("(Осталось частей тела: "));
            ModifyCalamityIl(il, "(Large Slimes left: ", EncodingCyrillic.EncodingTransform("(Осталось больших слизней: "));
        }
        
        private static void Ua_ModifyDrawOpenAnim(ILContext il)
        {
            ModifyCalamityIl(il, "(Segments left: ", EncodingCyrillic.EncodingTransform("(Осталось сегментов: "));
            ModifyCalamityIl(il, "(Creepers left: ", EncodingCyrillic.EncodingTransform("(Осталось ползунов: "));
            ModifyCalamityIl(il, "(Hands left: ", EncodingCyrillic.EncodingTransform("(Осталось рук: "));
            ModifyCalamityIl(il, "(Arms left: ", EncodingCyrillic.EncodingTransform("(Осталось оружий: "));
            ModifyCalamityIl(il, "(Guns left: ", EncodingCyrillic.EncodingTransform("(Осталось ружей: "));
            ModifyCalamityIl(il, "(Cannons left: ", EncodingCyrillic.EncodingTransform("(Осталось пушек: "));
            ModifyCalamityIl(il, "(Dark Energy left: ", EncodingCyrillic.EncodingTransform("(Осталось тёмной энергии: "));
            ModifyCalamityIl(il, "(Body Parts left: ", EncodingCyrillic.EncodingTransform("(Осталось частей тела: "));
            ModifyCalamityIl(il, "(Large Slimes left: ", EncodingCyrillic.EncodingTransform("(Осталось больших слизней: "));
        }
        
        private static void Ua_ModifyBossLootCalamitasRun3(ILContext il) => ModifyCalamityIl(il, "The Calamitas Clone", EncodingCyrillic.EncodingTransform("Клон Каламитас"));
        
        private static void Ua_ModifyBossLootRavager(ILContext il) => ModifyCalamityIl(il, "Ravager", EncodingCyrillic.EncodingTransform("Разрушитель"));
        
        private static void Ua_ModifyCensusSupport(ILContext il)
        {
            ModifyCalamityIl(il, "Defeat a Giant Clam after defeating the Desert Scourge", EncodingCyrillic.EncodingTransform("Одолейте Гигантского моллюска после победы над Пустынным бичем"));
            ModifyCalamityIl(il, "Have a [i:", EncodingCyrillic.EncodingTransform($"Имейте ") + "[i:");
            ModifyCalamityIl(il, "] in your inventory after defeating Skeletron", "]" + EncodingCyrillic.EncodingTransform(" в вашем инвентаре после победы над Скелетроном"));
            ModifyCalamityIl(il, "Defeat Cryogen", EncodingCyrillic.EncodingTransform("Одолейте Криогена"));
            ModifyCalamityIl(il, "Have a [i:", EncodingCyrillic.EncodingTransform("Имейте ") + "[i:", 2);
            ModifyCalamityIl(il, "] in your inventory in Hardmode", "]" + EncodingCyrillic.EncodingTransform(" в вашем инвентаре в Хардмоде"));
        }
        
        private static void Ua_ModifyAddCalamityInvasions(ILContext il)
        {
            ModifyCalamityIl(il, "Use a [i:{0}] or wait for the invasion to occur naturally after the Eye of Cthulhu is defeated.", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" или дождитесь, пока событие произойдёт естественным образом после того, как Глаз Ктулху будет побеждён."));
            ModifyCalamityIl(il, "The mysterious creatures of the sulphuric sea descended back into the ocean.", EncodingCyrillic.EncodingTransform("Таинственные существа сернистого моря спустились обратно в океан."));
            ModifyCalamityIl(il, "Acid Rain", EncodingCyrillic.EncodingTransform("Кислотный дождь"));
            ModifyCalamityIl(il, "Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Aquatic Scourge is defeated", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" или ") + "[i:{1}]" + EncodingCyrillic.EncodingTransform(" или дождитесь, пока событие произойдёт естественным образом после того, как Глаз Ктулху будет побеждён."));
            ModifyCalamityIl(il, "The mysterious creatures of the sulphuric sea descended back into the deep ocean.", EncodingCyrillic.EncodingTransform("Таинственные существа сернистого моря спустились обратно в глубины океана."));
            ModifyCalamityIl(il, "Acid Rain (Post-AS)", EncodingCyrillic.EncodingTransform("Кислотный дождь (Пост-Аб)"));
            ModifyCalamityIl(il, "Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Polterghast is defeated", EncodingCyrillic.EncodingTransform("Используйте ")+ "[i:{0}]" + EncodingCyrillic.EncodingTransform(" или ") + "[i:{1}]" + EncodingCyrillic.EncodingTransform(" или дождитесь, пока событие произойдёт естественным образом после того, как Полтергаст будет побеждён."));
            ModifyCalamityIl(il, "Acid Rain (Post-Polter)", EncodingCyrillic.EncodingTransform("Кислотный дождь (Пост-Полтер)"));
            ModifyCalamityIl(il, "The mysterious creatures of the sulphuric sea descended back into the deep ocean.", EncodingCyrillic.EncodingTransform("Таинственные существа сернистого моря спустились обратно в глубины океана."), 2);
        }
        
        private static void Ua_ModifyNewRightClick(ILContext il)
        {
            ModifyCalamityIl(il, "Spawn point removed!", EncodingCyrillic.EncodingTransform("Точка воскрешения удалена!"));
            ModifyCalamityIl(il, "Spawn point set!", EncodingCyrillic.EncodingTransform("Точка воскрешения задана!"));
        }
        
        private static void Ua_ModifyBedRightClick(ILContext il)
        {
            ModifyCalamityIl(il, "Spawn point removed!", EncodingCyrillic.EncodingTransform("Точка воскрешения удалена!"));
            ModifyCalamityIl(il, "Spawn point set!", EncodingCyrillic.EncodingTransform("Точка воскрешения задана!"));
        }
        
        private static void Ua_ModifySpawnDoggo(ILContext il)
        {
            ModifyCalamityIl(il, "It's not over yet, kid!", EncodingCyrillic.EncodingTransform("Это ещё не конец, малыш!"));
            ModifyCalamityIl(il, "Don't get cocky, kid!", EncodingCyrillic.EncodingTransform("Не будь таким самоуверенным, малыш!"));
        }
        
        private static void Ua_ModifyAIChibiiDoggo(ILContext il) => ModifyCalamityIl(il, " couldn't stand the sharp objects.", EncodingCyrillic.EncodingTransform(" не выдерживал острых предметов."));
        
        private static void Ua_ModifyAIHolyBurnOrb(ILContext il) => ModifyCalamityIl(il, " burst into sinless ash.", EncodingCyrillic.EncodingTransform(" превратился в безгрешный пепел."));
        
        private static void Ua_ModifyAIHealOrbProv(ILContext il) => ModifyCalamityIl(il, " burst into sinless ash.", EncodingCyrillic.EncodingTransform(" превратился в безгрешный пепел."));
        
        private static void Ua_ModifyGetChatFAP(ILContext il) => ModifyCalamityIl(il, " was slapped too hard.", EncodingCyrillic.EncodingTransform(" получил слишком сильную пощечину."));
        
        private static void Ua_ModifyModifyHitPlayerFearlessGoldfishWarrior(ILContext il) => ModifyCalamityIl(il, " was once again impaled by Goldfish.", EncodingCyrillic.EncodingTransform(" был снова проткнут Золотой рыбкой."));
        
        private static void Ua_ModifyOnHitPlayerDevourerofGodsHeadS(ILContext il) => ModifyCalamityIl(il, "'s essence was consumed by the devourer.", EncodingCyrillic.EncodingTransform(" сущность была поглощена пожирателем."));
        
        private static void Ua_ModifyOnHitPlayerDevourerofGodsHead(ILContext il) => ModifyCalamityIl(il, "'s essence was consumed by the devourer.", EncodingCyrillic.EncodingTransform(" сущность была поглощена пожирателем."));
        
        private static void Ua_ModifyShootNullificationRifle(ILContext il)
        {
            ModifyCalamityIl(il, " was vaporized by the imbuement of his life.", EncodingCyrillic.EncodingTransform(" испарился из-за насыщенности своей жизни."));
            ModifyCalamityIl(il, " was vaporized by the imbuement of her life.", EncodingCyrillic.EncodingTransform(" испарилась из-за насыщенности своей жизни."));
        }
        
        private static void Ua_ModifyMolecularManipulator(ILContext il)
        {
            ModifyCalamityIl(il, " was vaporized by the imbuement of his life.", EncodingCyrillic.EncodingTransform(" испарился из-за насыщенности своей жизни."));
            ModifyCalamityIl(il, " was vaporized by the imbuement of her life.", EncodingCyrillic.EncodingTransform(" испарилась из-за насыщенности своей жизни."));
        }
        
        private static void Ua_ModifyShootBloodBoiler(ILContext il)
        {
            ModifyCalamityIl(il, " suffered from severe anemia.", EncodingCyrillic.EncodingTransform(" страдал тяжёлой анемией."));
            ModifyCalamityIl(il, " was unable to obtain a blood transfusion.", EncodingCyrillic.EncodingTransform(" не удалось добиться переливания крови."));
        }
        
        private static void Ua_ModifyShootThornLucrecia(ILContext il)
        {
            ModifyCalamityIl(il, "'s DNA was destroyed.", EncodingCyrillic.EncodingTransform(" ДНК была уничтожена."));
        }
        
        private static void Ua_ModifyShootThornBlossom(ILContext il)
        {
            ModifyCalamityIl(il, " was violently pricked by a flower.", EncodingCyrillic.EncodingTransform(" был яростно уколот цветком."));
        }
        
        private static void Ua_ModifyOnConsumeItemAstralInjection(ILContext il)
        {
            ModifyCalamityIl(il, "'s blood vessels burst from drug overdose.", EncodingCyrillic.EncodingTransform(" кровеносные сосуды лопаются от передозировки наркотиков."));
        }

        private static void Ua_ModifyChooseDialogue(ILContext il)
        {
            ModifyCalamityIl(il, "To any personnel engaged in the laboratories. Please wear your steel engraved ID badge at all times. It is the easiest method to discern your body if any accidents do occur.", EncodingCyrillic.EncodingTransform("Напоминаем всему персоналу. Пожалуйста, носите ваш персональный стальной идентификационный значок. Это самый простой способ опознать тело в случае несчастного случая."));
            ModifyCalamityIl(il, "To experiment is to fail. To fail is to learn. To learn is to advance.", EncodingCyrillic.EncodingTransform("Экспериментировать — значит терпеть неудачи. Терпеть неудачи — значит учиться. Учиться — значит становиться лучше."));
            ModifyCalamityIl(il, "Apparent danger while researching serves only to enhance the research experience.", EncodingCyrillic.EncodingTransform("Кажущаяся опасность во время исследований только усиливает исследовательский опыт."));
            ModifyCalamityIl(il, "Laser-type weapon prototypes are incredibly lethal and are not to be used within presentation halls.", EncodingCyrillic.EncodingTransform("Прототипы лазерного оружия невероятно смертоносны и не должны использоваться в презентационных залах."));
            ModifyCalamityIl(il, "High-energy plasma emissions have adverse effects on both flesh and metal. Do not attempt to handle vented plasma.", EncodingCyrillic.EncodingTransform("Высокоэнергетические плазменные выбросы оказывают неблагоприятное воздействие как на плоть, так и на металл. Не пытайтесь обращаться с изливающейся плазмой."));
            ModifyCalamityIl(il, "Electric shocks from military equipment are intended to be fatal. If you survive such a shock, that is a clear indicator that the device is not functioning properly. Please report any such cases.", EncodingCyrillic.EncodingTransform("Удары электрического тока, вызванные оружием, должны быть летальными. Если вы пережили удар током, это явный признак того, что устройство не функционирует должным образом. Пожалуйста, сообщите о любых таких случаях."));
            ModifyCalamityIl(il, "All employees are hereby notified that they will be held accountable for any collateral damage caused by Gauss weapon fire, even during sanctioned testing exercises.", EncodingCyrillic.EncodingTransform("Все сотрудники уведомляются, что они будут нести ответственность за любой сопутствующий ущерб, причинённый огнём гауссовского оружия, даже во время санкционированных испытательных учений."));
            ModifyCalamityIl(il, "Security Field Emitters will vaporize all unauthorized equipment and personnel. Please leave personal effects in the designated lockers off-site. This also means: Do not bring any family members who are not enlisted as personnel.", EncodingCyrillic.EncodingTransform("Излучатели защитного поля уничтожат всё несанкционированное оборудование и персонал. Пожалуйста, оставьте личные вещи в специально отведённых запирающихся шкафчиках за пределами поля. Это также означает: Не приводите с собой членов семьи, которые не зачислены в личный состав."));
            ModifyCalamityIl(il, "If one does manage to breach restricted testing facilities, do at least record any unexpected burns, lacerations, bruising, fractur... ...trauma, shocks and otherwise. Thank you.", EncodingCyrillic.EncodingTransform("Если кто-то всё же решит пробраться в закрытые испытательные помещения, то хотя бы сделайте запись неожиданных ожогов, рваных ран, кровоизлияний, переломов... травм, шоковых ожогов и др. Спасибо."));
            ModifyCalamityIl(il, "The power grid has been... ...eavily compromised. Abort research and proceed to the emergency exits located at... ...and egress with haste.", EncodingCyrillic.EncodingTransform("Энергосистема была... ...кована, серьёзные повреждения. Прервите исследования и пройдите к аварийным выходам, расположенным... ...и выходите с поспешностью."));
            ModifyCalamityIl(il, "Notify the Security Department of any aggressive local fauna immediately.", EncodingCyrillic.EncodingTransform("Немедленно сообщите в Службу безопасности о любой местной агрессивной фауне."));
            ModifyCalamityIl(il, "Sensors have detected a significant breach in the spacetime continuum.", EncodingCyrillic.EncodingTransform("Сенсоры обнаружили значительное нарушение пространственно-временного континуума."));
            ModifyCalamityIl(il, "Please help. I'm stuck in this hologram machine.", EncodingCyrillic.EncodingTransform("Пожалуйста, помогите. Я застрял в голограмме."));
        }
        
        private static void Calamity_ModifySetChatButtonsTHIEF(ILContext il) => ModifyCalamityIl(il, "Refund", EncodingCyrillic.EncodingTransform("Возврат"));
        
        private static void Calamity_ModifySetChatButtonsSEAHOE(ILContext il) => ModifyCalamityIl(il, "Help", EncodingCyrillic.EncodingTransform("Помощь"));
        
        private static void Calamity_ModifySetChatButtonsFAP(ILContext il) => ModifyCalamityIl(il, "Death Count", EncodingCyrillic.EncodingTransform("Количество смертей"));
        
        private static void Ua_ModifyAddCalamityBosses(ILContext il)
        {
            ModifyCalamityIl(il, "Use a [i:{0}] in the Desert Biome", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в Пустыне"));
            ModifyCalamityIl(il, "The scourge of the desert delved back into the sand.", EncodingCyrillic.EncodingTransform("Пустынный бич снова погрузился в песок."));
            ModifyCalamityIl(il, "Desert Scourge", EncodingCyrillic.EncodingTransform("Пустынный бич"));
            ModifyCalamityIl(il, "Can spawn naturally in the Sunken Sea", EncodingCyrillic.EncodingTransform("Может естественно появится в Затерянном море"));
            ModifyCalamityIl(il, "The Giant Clam returns into hiding in its grotto.", EncodingCyrillic.EncodingTransform("Гигантский моллюск скрывается в своём гроту."));
            ModifyCalamityIl(il, "Giant Clam", EncodingCyrillic.EncodingTransform("Гигантский моллюск"));
            ModifyCalamityIl(il, "Use a [i:{0}] in the Mushroom Biome", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в Грибном биоме"));
            ModifyCalamityIl(il, "The mycleium crab has lost interest.", EncodingCyrillic.EncodingTransform("Мицелиевый краб потерял интерес."));
            ModifyCalamityIl(il, "Crabulon", EncodingCyrillic.EncodingTransform("Крабулон"), 2);
            ModifyCalamityIl(il, "Kill a Cyst in the Corruption or use a [i:{0}] in the Corruption", EncodingCyrillic.EncodingTransform("Убейте Кисту в искажении или используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в искажении"));
            ModifyCalamityIl(il, "The corrupted colony began searching for a new breeding ground.", EncodingCyrillic.EncodingTransform("Искажённая колония начала поиски нового места для размножения."));
            ModifyCalamityIl(il, "Hive Mind", EncodingCyrillic.EncodingTransform("Разум Улья"));
            ModifyCalamityIl(il, "Kill a Cyst in the Crimson or use a [i:{0}] in the Crimson", EncodingCyrillic.EncodingTransform("Убейте кисту в багрянце или используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в багрянце"));
            ModifyCalamityIl(il, "The parasitic hive began searching for a new host.", EncodingCyrillic.EncodingTransform("Паразитический улей начал искать нового носителя."));
            ModifyCalamityIl(il, "The Perforators", EncodingCyrillic.EncodingTransform("Перфораторы"));
            ModifyCalamityIl(il, "Use an [i:{0}]", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]");
            ModifyCalamityIl(il, "The gelatinous monstrosity achieved vengeance for its brethren.", EncodingCyrillic.EncodingTransform("Желатиновое чудовище отомстило за своих собратьев."));
            ModifyCalamityIl(il, "Slime God", EncodingCyrillic.EncodingTransform("Бог слизней"));
            ModifyCalamityIl(il, "Use a [i:{0}] in the Snow Biome", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в снежном биоме"));
            ModifyCalamityIl(il, "Cryogen drifts away, carried on a freezing wind.", EncodingCyrillic.EncodingTransform("Криоген уносится прочь, ледяным ветром."));
            ModifyCalamityIl(il, "Cryogen", EncodingCyrillic.EncodingTransform("Криоген"), 2);
            ModifyCalamityIl(il, "Use a [i:{0}] in the Brimstone Crag", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в серных скалах"));
            ModifyCalamityIl(il, "Brimstone Elemental withdraws to the ruins of her shrine.", EncodingCyrillic.EncodingTransform("Серный элементаль отступает к руинам своего святилища."));
            ModifyCalamityIl(il, "Brimstone Elemental", EncodingCyrillic.EncodingTransform("Серный элементаль"));
            ModifyCalamityIl(il, "Use a [i:{0}] in the Sulphuric Sea or wait for it to spawn in the Sulphuric Sea", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в сернистом море или подождите его появление в сернистом море"));
            ModifyCalamityIl(il, "The Aquatic Scourge swam back into the open ocean.", EncodingCyrillic.EncodingTransform("Акватический бич уплыл обратно в открытый океан."));
            ModifyCalamityIl(il, "Aquatic Scourge", EncodingCyrillic.EncodingTransform("Акватический бич"));
            ModifyCalamityIl(il, "Use an [i:{0}] at Night", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" ночью"));
            ModifyCalamityIl(il, "If you wanted a fight, you should've came more prepared.", EncodingCyrillic.EncodingTransform("Если вы хотели драки, вы должны были прийти более подготовленными."));
            ModifyCalamityIl(il, "Calamitas", EncodingCyrillic.EncodingTransform("Каламитас"), 2);
            ModifyCalamityIl(il, "Kill 10 sand sharks after defeating Plantera or use a [i:{0}] in the Desert Biome", EncodingCyrillic.EncodingTransform("Убейте 10 песчаных акул после победы над Плантерой или используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в пустыне"));
            ModifyCalamityIl(il, "The apex predator of the sands disappears into the dunes...", EncodingCyrillic.EncodingTransform("Высший хищник песков исчезает в дюнах..."));
            ModifyCalamityIl(il, "Great Sand Shark", EncodingCyrillic.EncodingTransform("Великая песчаная акула"));
            ModifyCalamityIl(il, "By killing an unknown entity in the Ocean Biome", EncodingCyrillic.EncodingTransform("Убейте неизвестное существо в океане"));
            ModifyCalamityIl(il, "The aquatic entities sink back beneath the ocean depths.", EncodingCyrillic.EncodingTransform("Водные существа погружаются в глубины океана."));
            ModifyCalamityIl(il, "Leviathan", EncodingCyrillic.EncodingTransform("Левиафан"), 2);
            ModifyCalamityIl(il, "Use an [i:{0}] at Night in the Astral Biome", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" ночью или в астральном биоме"));
            ModifyCalamityIl(il, "Astrum Aureus’ program has been executed. Initiate recall.", EncodingCyrillic.EncodingTransform("Программа Аструм Ареуса выполнена. Запущенна программа возврата."));
            ModifyCalamityIl(il, "Astrum Aureus", EncodingCyrillic.EncodingTransform("Аструм Ареус"));
            ModifyCalamityIl(il, "Use an [i:{0}] in the Jungle Biome", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в джунглях"));
            ModifyCalamityIl(il, "HOSTILE SPECIMENS TERMINATED. INITIATE RECALL TO HOME BASE.", EncodingCyrillic.EncodingTransform("ВРАЖДЕБНЫЕ СУЩНОСТИ УНИЧТОЖЕНЫ. ЗАПУЩЕНА ПРОГРАММА ВОЗВРАТА НА БАЗУ."));
            ModifyCalamityIl(il, "Plaguebringer Goliath", EncodingCyrillic.EncodingTransform("Разносчица чумы, Голиаф"));
            ModifyCalamityIl(il, "Use an [i:{0}]", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]", 2);
            ModifyCalamityIl(il, "The automaton of misshapen victims went looking for the true perpetrator.", EncodingCyrillic.EncodingTransform("Машина бесформенных жертв отправилась на поиски истинного нарушителя."));
            ModifyCalamityIl(il, "Ravager", EncodingCyrillic.EncodingTransform("Разрушитель"), 2);
            ModifyCalamityIl(il, "Use a [i:{0}] or [i:{1}] as offering at an [i:{2}]", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" или ") + "[i:{1}]" + EncodingCyrillic.EncodingTransform(" в качестве предложения на ") + "[i:{2}]");
            ModifyCalamityIl(il, "The infected deity retreats to the heavens.", EncodingCyrillic.EncodingTransform("Заражённое божество отступает к небесам."));
            ModifyCalamityIl(il, "Astrum Deus", EncodingCyrillic.EncodingTransform("Аструм Деус"));
            ModifyCalamityIl(il, "Use a [i:{0}] in the Hallow or Underworld Biomes", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в освящении или в аду"));
            ModifyCalamityIl(il, "The guardians must protect their goddess at all costs.", EncodingCyrillic.EncodingTransform("Стражи должны защищать свою богиню любой ценой."));
            ModifyCalamityIl(il, "Profaned Guardians", EncodingCyrillic.EncodingTransform("Осквернённые стражи"));
            ModifyCalamityIl(il, "Use [i:{0}] in the Jungle Biome", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в джунглях"));
            ModifyCalamityIl(il, "The failed experiment returns to its reproductive routine.", EncodingCyrillic.EncodingTransform("Неудачный эксперимент вернулся к своему репродуктивному распорядку."));
            ModifyCalamityIl(il, "Dragonfolly", EncodingCyrillic.EncodingTransform("Псевдодракон"), 2);
            ModifyCalamityIl(il, "Use either [i:{0}] or [i:{1}] in the Hallow or Underworld Biomes", EncodingCyrillic.EncodingTransform("Используйте либо ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(", либо ") + "[i:{1}]" + EncodingCyrillic.EncodingTransform("в освящении или в аду"));
            ModifyCalamityIl(il, "The Profaned Goddess vanishes in a burning blaze.", EncodingCyrillic.EncodingTransform("Осквернённая Богиня исчезает в горящем пламени."));
            ModifyCalamityIl(il, "Providence", EncodingCyrillic.EncodingTransform("Провиденс"), 2);
            ModifyCalamityIl(il, "Use a [i:{0}] in the Dungeon", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в темнице"));
            ModifyCalamityIl(il, "The rift in time and space has moved away from your reach.", EncodingCyrillic.EncodingTransform("Разлом во времени и пространстве удалился вдали от вас."));
            ModifyCalamityIl(il, "Ceaseless Void", EncodingCyrillic.EncodingTransform("Нескончаемая пустота"));
            ModifyCalamityIl(il, "Use a [i:{0}] in Space", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в космосе"));
            ModifyCalamityIl(il, "Storm Weaver hid itself once again within the stormfront.", EncodingCyrillic.EncodingTransform("Штормовой Ткач снова спрятался в грозовом фронте."));
            ModifyCalamityIl(il, "Storm Weaver", EncodingCyrillic.EncodingTransform("Штормовой Ткач"));
            ModifyCalamityIl(il, "Use a [i:{0}] in the Underworld", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в аду"));
            ModifyCalamityIl(il, "The Devourer's assassin has finished its easy task.", EncodingCyrillic.EncodingTransform("Убийца Пожирателя выполнил свою лёгкую задачу."));
            ModifyCalamityIl(il, "Signus", EncodingCyrillic.EncodingTransform("Сигнус"), 2);
            ModifyCalamityIl(il, "Kill 30 phantom spirits or use a [i:{0}] in the Dungeon", EncodingCyrillic.EncodingTransform("Убейте 30 фантомных духов или используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в темнице"));
            ModifyCalamityIl(il, "The volatile spirits disperse throughout the depths of the dungeon.", EncodingCyrillic.EncodingTransform("Неустойчивые духи рассеиваются по глубинам подземелья."));
            ModifyCalamityIl(il, "Polterghast", EncodingCyrillic.EncodingTransform("Полтергаст"), 2);
            ModifyCalamityIl(il, "Defeat the Acid Rain event post-Polterghast or fish using a [i:{0}] in the Sulphurous Sea", EncodingCyrillic.EncodingTransform("Одолейте событие Кислотный дождь после победы над Полтергастом или выловите с помощью ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в сернистом море"));
            ModifyCalamityIl(il, "The old duke disappears amidst the acidic downpour.", EncodingCyrillic.EncodingTransform("Старый Герцог исчезает посреди кислотного ливня."));
            ModifyCalamityIl(il, "Old Duke", EncodingCyrillic.EncodingTransform("Старый Герцог"));
            ModifyCalamityIl(il, "Use a [i:{0}]", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]");
            ModifyCalamityIl(il, "The Devourer of Gods has slain everyone and feasted on their essence.", EncodingCyrillic.EncodingTransform("Пожиратель Богов убил всех и пировал их сущностью."));
            ModifyCalamityIl(il, "Devourer of Gods", EncodingCyrillic.EncodingTransform("Пожиратель Богов"));
            ModifyCalamityIl(il, "Use a [i:{0}] in the Jungle Biome", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в джунглях"));
            ModifyCalamityIl(il, "Yharon found you too weak to stay near your gravestone.", EncodingCyrillic.EncodingTransform("Ярон считает вас слишком слабым, чтобы оставаться с вашим надгробием."));
            ModifyCalamityIl(il, "Yharon", EncodingCyrillic.EncodingTransform("Ярон"), 2);
            ModifyCalamityIl(il, "Use an [i:{0}]", EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]", 3);
            ModifyCalamityIl(il, "Please don't waste my time.", EncodingCyrillic.EncodingTransform("Пожалуйста, не тратьте моё время."));
            ModifyCalamityIl(il, "Supreme Calamitas", EncodingCyrillic.EncodingTransform("Высшая Каламитас"));
        }
        
        private static void Calamity_ModifyModifyGetTextByPageSunkenSeaGUI(ILContext il)
        {
            ModifyCalamityIl(il, "Preserved for millennia, a paradise for the living beings who sought shelter in prehistoric seas. They remain untouched by evolution, save for their adaptations to the oxygen starved waters and dim crystals, continuing to thrive. One mystery which continues to escape my understanding however, is how large some of the creatures have become. There is a blatant lack of nutrition and oxygen in the caves, and yet...", EncodingCyrillic.EncodingTransform("Сохранившийся на протяжении тысячелетий рай для живых существ, искавших убежища в доисторических морях. Они остаются не тронутыми эволюцией, за исключением их адаптации к необогащенной воздухом воде и тусклым кристаллам, продолжая процветать. Однако одна загадка, которая продолжает ускользать от моего понимания, заключается в том, насколько большими стали некоторые из этих существ. В пещерах явно не хватает питания и кислорода, и всё же..."));
            ModifyCalamityIl(il, "A specimen which has developed a grand size, and inexplicably, impressive psychic abilities. What is most curious is its strong connection to its lesser kin. Without any noticeable communication, when it comes under threat, other mollusks rally to its aggressor and begin attacking. Is this perhaps the very first signs of a higher life form, the evolutionary link hidden away in the sunken sea? Or a self sacrificial fluke, which would lead to their destruction if they inhabited any area other than these pacified caverns.", EncodingCyrillic.EncodingTransform("Образец, который развил грандиозные размеры и необъяснимо-впечатляющие телепатические способности. Что самое любопытное, так это его сильная связь со своими меньшими родственниками. Когда он оказывается под угрозой, другие моллюски окружают своего агрессора и начинают атаковать. Может быть, это самые первые признаки высшей формы жизни, эволюционное звено, скрытое в затерянном море? Или самоотверженная случайность, которая привела бы к уничтожению, если они населяли любую область, кроме этих умиротворённых пещер."));
            ModifyCalamityIl(il, "The marine life in these caves do have eyes though they are barely functional, dulled by lack of use and milky white upon observation. On their tough, gnarled hides, crystals find an easy purchase, and grow in great numbers, providing the creatures protection. Perhaps another adaptation to the life they have adopted. The most striking wonder is within their bodies. In specimens dissected, I have noticed that the mineral is buried into their very digestive systems, and perhaps, through some chemical process, pass nutrients into their sluggish hosts. A peculiar yet entirely beneficial interaction.", EncodingCyrillic.EncodingTransform("У морских обитателей в этих пещерах есть глаза-рудименты, внешне они молочно-белые. На их жёстких узловатых шкурах кристаллы растут в большом количестве, обеспечивая существам защиту. Возможно, это ещё одна адаптация к жизни, которую они приняли. Но самое поразительное чудо — внутренности их тел. В образцах, подвергнутых вскрытию, я заметил, что минерал находится в самой их пищеварительной системе и, возможно, через какой-то химический процесс передаёт питательные вещества их вялым хозяевам. Своеобразное, но совершенно благотворное взаимодействие."));
        }
        
        private static void Calamity_ModifyModifyGetTextByPageSnowBiomeGUI(ILContext il)
        {
            ModifyCalamityIl(il, "A freezing tundra, where only creatures entirely adapted to the subzero temperatures exist and thrive. It is a shocking transition from the forests of the purity and the sun baked desert. A climate like this should not exist naturally in this part of the world with ease. The weather patterns seem to shift unnaturally arounds the skies of these icy plains. There is likely a reason for this, which necessitates further research.", EncodingCyrillic.EncodingTransform("Холодная тундра, где существуют и процветают существа, полностью приспособленные к минусовым температурам. Это шокирующий переход от чистых лесов и выжженной солнцем пустыни. Климат, подобный этому, не должен существовать естественно. Погодные условия на этих ледяных равнинах, кажется, неестественно меняются. Вероятно, этому есть причина, которая требует дальнейших исследований."));
            ModifyCalamityIl(il, "I am not the only singular being to inhabit this biome. Once before, the Archmage who opposed the Lord resided here, cloaked by constant artificial blizzards of his own creation, which no longer fall. He likely chose this place as a conduit for research into his ice spells, and extended the period of time that this place remained frozen. Deep underground my research and materials lay well protected, but above in the natural storms there are traces of the prison of ice he resides in, still haunting its place of creation.", EncodingCyrillic.EncodingTransform("Я не единственное разумное существо, находившееся в этом биоме. До этого Архимаг, противостоявший Лорду, жил здесь. Скорее всего, он выбрал это место для изучения ледяных заклятий, одно из которых — нескончаемые ледяные бури. Его действия поддерживали биом в глубокой заморозке. Глубоко под землёй мои исследования хорошо защищены, но снаружи, в естественных бурях, есть следы ледяной тюрьмы, в которой он пребывает по сей день, всё ещё бродящей в месте своего создания."));
            ModifyCalamityIl(il, "Intriguing. Though embedded deep into the caverns of ice and worn from centuries of frost and meltwater, I have uncovered several mechanisms which once filled the tunnels here. The ingenuity present is remarkable, and I have found parallels within my own work, as well as devices even I have something to learn from. From where do these come? Why machinery so complex in so sparse and dreary a habitat? Perhaps, they are related to the unnatural conditions.", EncodingCyrillic.EncodingTransform("Интригующе. Я нашёл механизмы, когда-то заполнявшие туннели. Они находились в ледяных пещерах, поломанные из-за веков во льду и талой воды. Мастерство исполнения поражает. Я нашёл схожести с моими работами, а также узнал что-то новое. Но кто их создал? Почему настолько сложные машины находятся в такой скудной и унылой среде обитания. Возможно, именно они виноваты в настолько неестественных условиях."));
        }
        
        private static void Calamity_ModifyModifyGetTextByPagePlanetoidGUI(ILContext il)
        {
            ModifyCalamityIl(il, "Hung low in orbit, masses of ground and various parts of the world provide a secluded and distant point for research. Undeniably optimal for the science of astronomy and otherwise. In my labs here I grow many things, testing their limits against the cold and vacuum of the stratosphere. Though not many survive, the existence of certain creatures here, confirm the capabilities of life simply given more time.", EncodingCyrillic.EncodingTransform("Висящие низко на орбите массы земли и другие структуры мира, обеспечивают укромное и отдалённое место для исследований. Это оптимальный вариант для изучения астрономии и других наук. В моих лабораториях я выращиваю разные растения и тестирую их способность к выживанию в условиях холода и вакуума стратосферы. Несмотря на то, что многие растения погибают, существование жизни здесь подтверждается. Просто нужно дать этой жизни больше времени на развитие."));
            ModifyCalamityIl(il, "The bloated cosmic worm, though I understand why the Lord decides to employ it given he can control it, is a disgusting existence. However the idea of creating an armor suited to it in every way, was an offer I could not refuse. Forged from the cosmic steel of my own creation, it resists nearly any attack, yet allows the creature the same flexibility it would have without it, as well as augmenting its dimensional abilities. I remain pleased with the result.", EncodingCyrillic.EncodingTransform("Раздутый отвратительный космический червь. Впрочем, я понимаю, почему Лорд его использует, ведь он может его контролировать... Идея создания брони, подходящей ему во всех отношениях, была предложением, от которого я не мог отказаться. Выкованная из космической стали, моего собственного создания, броня защищала практически от любой атаки. А также она не уменьшает изначальной гибкости существа, а ещё увеличивает пространственные способности. Я доволен результатом."));
            ModifyCalamityIl(il, "I do not care much for the interstellar, or the cosmos. Though I have traversed it, there is still plenty in my own world to manage and discover at this time. Even if I once inhabited a different planet, the Lord's wishes that I provide him machinery were the only condition that I needed to leave it and settle elsewhere. Once I have discovered and dissected every part of this place, perhaps then, I could look up towards the macroscopic.", EncodingCyrillic.EncodingTransform("Меня мало волнует космос. Да, я путешествовал по нему, но сейчас мне достаточно работы по изучению собственного мира. Даже если бы я когда-то жил на другой планете, одного желания Лорда получать мои технологии было бы достаточно, чтобы я улетел с неё сюда. Если же я когда-нибудь полностью изучу каждый кусочек этого места, то тогда, возможно, я обращу свой взор наверх, в сторону макроскопического."));
        }
        
        private static void Calamity_ModifyModifyGetTextByPageJungleGUI(ILContext il)
        {
            ModifyCalamityIl(il, "As I record this, it would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately these labs provide everything I need in my research and more. There is no need to ever visit the surface, save for summons on the Lord's orders.", EncodingCyrillic.EncodingTransform("Поскольку я записываю это, не будет ошибкой назвать джунгли центром этой планеты. Всё сосредоточено вокруг них, но мало кто знает об этом. Я испытываю немалое беспокойство, видя неудобные, грубые формы живых существ, которые живут в них наверху. К счастью, эти лаборатории обеспечивают всё, что мне нужно в моих исследованиях и не только. Нет никакой необходимости когда-либо посещать поверхность, за исключением вызова по приказу Лорда."));
            ModifyCalamityIl(il, "Mechanically augmented, the Queen Bee which I had prior experimented on was theoretically a perfect host for the plague virus. When the first sign of the technology bonding with the creature began however, the problems also showed immediately. The mind of the insect fought the control of the nanotechnology, nothing like the simpler creatures I had used as test subjects. It grew increasingly violent, and only once subdued did it receive simple orders. However, if we were to utilize it at all, there is no other way than to let it roam free entirely. I will consider this further.", EncodingCyrillic.EncodingTransform("Механически усиленная королева пчёл, над которой я ранее экспериментировал, теоретически была идеальным разносчиком чумы. Однако, когда технологии начали менять сущность пчелы, начались проблемы. Разум насекомого противостоял нанотехнологиям, такого раньше не происходило. Она выросла невероятно жестокой и почти не подчинялась приказам. Однако, если мы хотим использовать её, нет другого способа, кроме как позволить ей свободно разгуливать. Я продожлу изучать это дальше."));
            ModifyCalamityIl(il, "A virus, capable of devouring and converting almost anything. And nanotechnology, constructed painstakingly for the sake of control. Development was swift, and every piece fell into place almost eerily, forming an abhorrent existence. I struggle to think of practical applications which would be friendly to common life forms. However, it is not a major concern. Many were hesitant to continue its creation, but I granted them leave if they desired. I would have no need for any who were not entirely as dedicated as my machines.", EncodingCyrillic.EncodingTransform("Вирус, способный пожирать и превращать практически всё. И тщательно сделанная нанотехнология контроля. Превращение шло пугающе быстро, создавая мерзкую тварь. Я стараюсь сделать так, чтобы она была дружелюбна к обычным формам жизни. Однако это не главная проблема. Многие не решались продолжать создание, но я разрешил уйти, если они пожелают. Я не нуждался ни в ком, кто не был бы так же предан делу, как мои машины."));
        }
        
        private static void Calamity_ModifyDrawAcidRain(ILContext il) => ModifyCalamityIl(il, "Acid Rain", EncodingCyrillic.EncodingTransform("Кислотный дождь"));
        
        private static void Ua_ModifyUpdateAccessory(ILContext il) => ModifyCalamityIl(il, " isn't worthy.", EncodingCyrillic.EncodingTransform(" не достоин."));
        
        private static void Ua_ModifyKillPlayer(ILContext il)
        {
            ModifyCalamityIl(il, " is food for the Wyrms.", EncodingCyrillic.EncodingTransform(" стал пищей для змей."));
            ModifyCalamityIl(il, "Oxygen failed to reach ", EncodingCyrillic.EncodingTransform("Не хватило кислорода для "));
            ModifyCalamityIl(il, " from the depths of the Abyss.", EncodingCyrillic.EncodingTransform(" из глубин бездны."));
            ModifyCalamityIl(il, " was defeated.", EncodingCyrillic.EncodingTransform(" был повержен."));
            ModifyCalamityIl(il, " was chilled to the bone by the frigid environment.", EncodingCyrillic.EncodingTransform(" промёрз до костей из-за холодной окружающей среды."));
            ModifyCalamityIl(il, " was consumed by his inner hatred.", EncodingCyrillic.EncodingTransform(" был поглощён своей внутренней ненавистью."));
            ModifyCalamityIl(il, " was consumed by her inner hatred.", EncodingCyrillic.EncodingTransform(" была поглощена своей внутренней ненавистью."));
            ModifyCalamityIl(il, " failed the challenge at hand.", EncodingCyrillic.EncodingTransform(" не справился с испытанием."));
            ModifyCalamityIl(il, " was destroyed by a mysterious force.", EncodingCyrillic.EncodingTransform(" был уничтожен таинственной силой."));
        }
        
        private static void Ua_ModifyPreKill(ILContext il)
        {
            ModifyCalamityIl(il, " downed too many shots.", EncodingCyrillic.EncodingTransform(" выпил слишком много напитков."));
            ModifyCalamityIl(il, "'s liver failed.", EncodingCyrillic.EncodingTransform(" отказала печень."));
            ModifyCalamityIl(il, " was charred by the brimstone inferno.", EncodingCyrillic.EncodingTransform(" был обуглен серным пламенем."));
            ModifyCalamityIl(il, "'s soul was released by the lava.", EncodingCyrillic.EncodingTransform(" душа была освобождена лавой."));
            ModifyCalamityIl(il, "'s soul was extinguished.", EncodingCyrillic.EncodingTransform(" душа была погашена."));
            ModifyCalamityIl(il, " was melted by the toxic waste.", EncodingCyrillic.EncodingTransform(" был расплавлен токсичными отходами."));
            ModifyCalamityIl(il, " disintegrated into ashes.", EncodingCyrillic.EncodingTransform(" рассыпался в прах."));
            ModifyCalamityIl(il, " was turned to ashes by the Profaned Goddess.", EncodingCyrillic.EncodingTransform(" был обращён Осквернённой богиней в пепел."));
            ModifyCalamityIl(il, " fell prey to their sins.", EncodingCyrillic.EncodingTransform(" пал жертвой своих грехов."));
            ModifyCalamityIl(il, "'s spirit was turned to ash.", EncodingCyrillic.EncodingTransform(" дух превратился в пепел."));
            ModifyCalamityIl(il, " became a blood geyser.", EncodingCyrillic.EncodingTransform(" стал кровавым гейзером."));
            ModifyCalamityIl(il, " was crushed by the pressure.", EncodingCyrillic.EncodingTransform(" был раздавлен давлением."));
            ModifyCalamityIl(il, "'s lungs collapsed.", EncodingCyrillic.EncodingTransform(" лёгкие отказали."));
            ModifyCalamityIl(il, " was consumed by the black flames.", EncodingCyrillic.EncodingTransform(" был поглощён чёрным пламенем."));
            ModifyCalamityIl(il, "'s flesh was melted by the plague.", EncodingCyrillic.EncodingTransform(" плоть была расплавлена чумой."));
            ModifyCalamityIl(il, " didn't vaccinate.", EncodingCyrillic.EncodingTransform(" не сделал прививок."));
            ModifyCalamityIl(il, "'s infection spread too far.", EncodingCyrillic.EncodingTransform(" инфекция распространилась слишком сильно."));
            ModifyCalamityIl(il, "'s skin was replaced by the astral virus.", EncodingCyrillic.EncodingTransform(" кожа была заменена астральным вирусом."));
            ModifyCalamityIl(il, " was incinerated by lunar rays.", EncodingCyrillic.EncodingTransform(" был испепелён лунными лучами."));
            ModifyCalamityIl(il, " vaporized into thin air.", EncodingCyrillic.EncodingTransform(" растворился в воздухе."));
            ModifyCalamityIl(il, "'s life was completely converted into mana.", EncodingCyrillic.EncodingTransform(" здоровье было полностью преобразовано в ману."));
            ModifyCalamityIl(il, " succumbed to alcohol sickness.", EncodingCyrillic.EncodingTransform(" поддался алкогольной болезни."));
            ModifyCalamityIl(il, " was summoned too soon.", EncodingCyrillic.EncodingTransform(" был призван слишком рано."));
        }
        
        private static void Ru_ModifyGetTextByPageHellGUI(ILContext il)
        {
            ModifyCalamityIl(il, "The entire landscape is a constant source of geothermal energy, and heat for a forge. If it was not entirely uninhabitable save for demons and spirits, I would conduct much more of my research in the bowels of the earth. Where I have actively chosen not to settle however, is in the crags of the underworld. There, the magma is... uncooperative and far more corrosive than should be possible, as it is saturated with cursed, twisted souls, courtesy of that Witch.", EncodingCyrillic.EncodingTransform("Весь природный ландшафт — постоянный источник геотермальной энергии и тепла для кузни. Если бы он не был совсем необитаемым, за исключением демонов и духов, я бы проводил больше исследований в недрах земли. Где я точно ни поселился бы, так это в скалах ада. Магма там... 'несговорчива' и агрессивна, намного больше, чем это возможно. Всё из-за того, что она пропиталась проклятыми тёмными душами, любезно предоставленными этой Ведьмой."));
            ModifyCalamityIl(il, "A blade completely inundated with my surroundings during the time of its creation. It was tempered by the fires which are fueled by spirits, and formed in the magma I draw into my laboratories. Its cutting edge, unparalleled, though its reach is limited making general usage questionable. I would consider it my very first foray into work for the sake of craftsmanship and art. If I was born synthetically, any creation which leads one to question whether I was, is a creation I may be proud of. It shows that I can after all, be graced by a muse.", EncodingCyrillic.EncodingTransform("Меч, полностью окружённый моим вниманием во время создания. Он сформировался в магме, а закалён огнём душ. Его лезвие — непревзойдённое, хотя его дальность ограничена, что делает общее применение сомнительным. Я думаю, что это моя первая работа, сделанная во имя искусства и мастерства. Если я был рождён синтетически, то любое моё творение, вызывающие вопрос: «Был ли я создан?» — результат, которым можно гордиться. Это доказывает, что я всё же могу быть удостоенным музы."));
            ModifyCalamityIl(il, "What a terrible abomination and yet an enticing subject. Not unlike the fusion of spirits which haunts the dungeons, this entity is formed not of one, but a multitude of sinners. What holds different for it however, is that the limitations caused by the artificiality of the dungeon's existence do not apply to it. It is the laws of hell which brought them together into a single overlord of the underworld. And when an innocent life is sacrificed... Their hunger, which appears to be in tune with the afterlife, surges.", EncodingCyrillic.EncodingTransform("Какое ужасное существо, но всё же интересное с научной точки зрения. В отличие от сплава душ темницы, эта сущность была сформирована не из одного грешника, а из многих. Ещё одно отличие заключается в том, что ограничения, вызванные искусственным происхождением темницы, неприменимы к нему. Именно законы Ада свели их вместе в единого владыку подземного мира. И когда невинная жизнь приносится в жертву... Их голод, который, кажется, является частью загробной жизни, нарастает."));
        }
        
        private static void Ru_ModifyHandleMouseInteraction(ILContext il)
        {
            ModifyCalamityIl(il, "Adrenaline: {0} / {1}", EncodingCyrillic.EncodingTransform("Адреналин") + ": {0} / {1}");
            ModifyCalamityIl(il, "Rage: {0} / {1}", EncodingCyrillic.EncodingTransform("Ярость") + ": {0} / {1}");
        }
        
        private static void Ru_ModifyDrawStealth(ILContext il) => ModifyCalamityIl(il, "Stealth: ", EncodingCyrillic.EncodingTransform("Скрытность: "));
        
        #endregion

        private static void UnloadIL()
        {
            ModifyHandleMouseInteraction -= Ru_ModifyHandleMouseInteraction;
            ModifyDrawAcidRain -= Calamity_ModifyDrawAcidRain;
            ModifyDrawStealth -= Ru_ModifyDrawStealth;
            ModifyPreKill -= Ua_ModifyPreKill;
            ModifyKillPlayer -= Ua_ModifyKillPlayer;
            ModifyUpdateAccessory -= Ua_ModifyUpdateAccessory;
            ModifyChooseDialogue -= Ua_ModifyChooseDialogue;
            ModifyGetTextByPageHellGUI -= Ru_ModifyGetTextByPageHellGUI;
            ModifyGetTextByPageJungleGUI -= Calamity_ModifyModifyGetTextByPageJungleGUI;
            ModifyGetTextByPagePlanetoidGUI -= Calamity_ModifyModifyGetTextByPagePlanetoidGUI;
            ModifyGetTextByPageSnowBiomeGUI -= Calamity_ModifyModifyGetTextByPageSnowBiomeGUI;
            ModifyGetTextByPageSunkenSeaGUI -= Calamity_ModifyModifyGetTextByPageSunkenSeaGUI;
            ModifyAddCalamityBosses -= Ua_ModifyAddCalamityBosses;
            ModifySetChatButtonsFAP -= Calamity_ModifySetChatButtonsFAP;
            ModifySetChatButtonsSEAHOE -= Calamity_ModifySetChatButtonsSEAHOE;
            ModifySetChatButtonsTHIEF -= Calamity_ModifySetChatButtonsTHIEF;
            ModifyOnConsumeItemAstralInjection -= Ua_ModifyOnConsumeItemAstralInjection;
            ModifyShootThornBlossom -= Ua_ModifyShootThornBlossom;
            ModifyShootThornLucrecia -= Ua_ModifyShootThornLucrecia;
            ModifyShootBloodBoiler -= Ua_ModifyShootBloodBoiler;
            ModifyMolecularManipulator -= Ua_ModifyMolecularManipulator;
            ModifyShootNullificationRifle -= Ua_ModifyShootNullificationRifle;
            ModifyOnHitPlayerDevourerofGodsHead -= Ua_ModifyOnHitPlayerDevourerofGodsHead;
            ModifyOnHitPlayerDevourerofGodsHeadS -= Ua_ModifyOnHitPlayerDevourerofGodsHeadS;
            ModifyModifyHitPlayerFearlessGoldfishWarrior -= Ua_ModifyModifyHitPlayerFearlessGoldfishWarrior;
            ModifyGetChatFAP -= Ua_ModifyGetChatFAP;
            ModifyAIHealOrbProv -= Ua_ModifyAIHealOrbProv;
            ModifyAIHolyBurnOrb -= Ua_ModifyAIHolyBurnOrb;
            ModifyAIChibiiDoggo -= Ua_ModifyAIChibiiDoggo;
            ModifySpawnDoggo -= Ua_ModifySpawnDoggo;
            ModifyBedRightClick -= Ua_ModifyBedRightClick;
            ModifyNewRightClick -= Ua_ModifyNewRightClick;
            ModifyAddCalamityInvasions -= Ua_ModifyAddCalamityInvasions;
            ModifyCensusSupport -= Ua_ModifyCensusSupport;
            ModifyBossLootRavager -= Ua_ModifyBossLootRavager;
            ModifyBossLootCalamitasRun3 -= Ua_ModifyBossLootCalamitasRun3;
            ModifyDrawBossHPUI -= Ua_ModifyDrawBossHPUI;
            ModifyDrawOpenAnim -= Ua_ModifyDrawOpenAnim;
            ModifyBossLootProfanedGuardianBoss2 -= Ua_ModifyBossLootProfanedGuardianBoss2;
            ModifyBossLootPerforatorHeadLarge -= Ua_ModifyBossLootPerforatorHeadLarge;
            ModifyBossLootPerforatorHeadSmall -= Ua_ModifyBossLootPerforatorHeadSmall;
            ModifyBossLootBumblefuck -= Ua_ModifyBossLootBumblefuck;
            ModifyBossLootPerforatorHeadMedium -= Ua_ModifyBossLootPerforatorHeadMedium;
            ModifyBossLootProfanedGuardianBoss3 -= Ua_ModifyBossLootProfanedGuardianBoss3;
            ModifyBossLootProfanedGuardianBoss -= Ua_ModifyBossLootProfanedGuardianBoss;
            ModifyInvasionNamebossRushUI -= Ua_ModifyInvasionNamebossRushUI;
            ModifyColdDivinityModifyTooltips -= Ua_ModifyColdDivinityModifyTooltips;
        }

        #region Calamity IL Manipulator

        private static event ILContext.Manipulator ModifyHandleMouseInteraction
        {
            add => HookEndpointManager.Modify(_handleMouseInteraction, value);
            remove => HookEndpointManager.Unmodify(_handleMouseInteraction, value);
        }
        private static event ILContext.Manipulator ModifyDrawStealth
        {
            add => HookEndpointManager.Modify(DrawStealth, value);
            remove => HookEndpointManager.Unmodify(DrawStealth, value);
        }
        private static event ILContext.Manipulator ModifyDrawAcidRain
        {
            add => HookEndpointManager.Modify(DrawAcidRain, value);
            remove => HookEndpointManager.Unmodify(DrawAcidRain, value);
        }
        private static event ILContext.Manipulator ModifyPreKill
        {
            add => HookEndpointManager.Modify(PreKill, value);
            remove => HookEndpointManager.Unmodify(PreKill, value);
        }
        private static event ILContext.Manipulator ModifyKillPlayer
        {
            add => HookEndpointManager.Modify(KillPlayer, value);
            remove => HookEndpointManager.Unmodify(KillPlayer, value);
        }
        private static event ILContext.Manipulator ModifyUpdateAccessory
        {
            add => HookEndpointManager.Modify(UpdateAccessory, value);
            remove => HookEndpointManager.Unmodify(UpdateAccessory, value);
        }
        private static event ILContext.Manipulator ModifyGetTextByPageHellGUI
        {
            add => HookEndpointManager.Modify(GetTextByPageHellGUI, value);
            remove => HookEndpointManager.Unmodify(GetTextByPageHellGUI, value);
        }
        private static event ILContext.Manipulator ModifyGetTextByPageJungleGUI
        {
            add => HookEndpointManager.Modify(GetTextByPageJungleGUI, value);
            remove => HookEndpointManager.Unmodify(GetTextByPageJungleGUI, value);
        }
        private static event ILContext.Manipulator ModifyGetTextByPagePlanetoidGUI
        {
            add => HookEndpointManager.Modify(GetTextByPagePlanetoidGUI, value);
            remove => HookEndpointManager.Unmodify(GetTextByPagePlanetoidGUI, value);
        }
        private static event ILContext.Manipulator ModifyGetTextByPageSnowBiomeGUI
        {
            add => HookEndpointManager.Modify(GetTextByPageSnowBiomeGUI, value);
            remove => HookEndpointManager.Unmodify(GetTextByPageSnowBiomeGUI, value);
        }
        private static event ILContext.Manipulator ModifyGetTextByPageSunkenSeaGUI
        {
            add => HookEndpointManager.Modify(GetTextByPageSunkenSeaGUI, value);
            remove => HookEndpointManager.Unmodify(GetTextByPageSunkenSeaGUI, value);
        }
        private static event ILContext.Manipulator ModifyAddCalamityBosses
        {
            add => HookEndpointManager.Modify(AddCalamityBosses, value);
            remove => HookEndpointManager.Unmodify(AddCalamityBosses, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsFAP
        {
            add => HookEndpointManager.Modify(SetChatButtonsFAP, value);
            remove => HookEndpointManager.Unmodify(SetChatButtonsFAP, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsSEAHOE
        {
            add => HookEndpointManager.Modify(SetChatButtonsSEAHOE, value);
            remove => HookEndpointManager.Unmodify(SetChatButtonsSEAHOE, value);
        }
        private static event ILContext.Manipulator ModifySetChatButtonsTHIEF
        {
            add => HookEndpointManager.Modify(SetChatButtonsTHIEF, value);
            remove => HookEndpointManager.Unmodify(SetChatButtonsTHIEF, value);
        }
        private static event ILContext.Manipulator ModifyChooseDialogue
        {
            add => HookEndpointManager.Modify(ChooseDialogue, value);
            remove => HookEndpointManager.Unmodify(ChooseDialogue, value);
        }
        private static event ILContext.Manipulator ModifyOnConsumeItemAstralInjection
        {
            add => HookEndpointManager.Modify(OnConsumeItemAstralInjection, value);
            remove => HookEndpointManager.Unmodify(OnConsumeItemAstralInjection, value);
        }
        private static event ILContext.Manipulator ModifyShootThornBlossom
        {
            add => HookEndpointManager.Modify(ShootThornBlossom, value);
            remove => HookEndpointManager.Unmodify(ShootThornBlossom, value);
        }
        private static event ILContext.Manipulator ModifyShootThornLucrecia
        {
            add => HookEndpointManager.Modify(ShootThornLucrecia, value);
            remove => HookEndpointManager.Unmodify(ShootThornLucrecia, value);
        }
        private static event ILContext.Manipulator ModifyShootBloodBoiler
        {
            add => HookEndpointManager.Modify(ShootBloodBoiler, value);
            remove => HookEndpointManager.Unmodify(ShootBloodBoiler, value);
        }
        private static event ILContext.Manipulator ModifyMolecularManipulator
        {
            add => HookEndpointManager.Modify(ShootMolecularManipulator, value);
            remove => HookEndpointManager.Unmodify(ShootMolecularManipulator, value);
        }
        private static event ILContext.Manipulator ModifyShootNullificationRifle
        {
            add => HookEndpointManager.Modify(ShootNullificationRifle, value);
            remove => HookEndpointManager.Unmodify(ShootNullificationRifle, value);
        }
        private static event ILContext.Manipulator ModifyOnHitPlayerDevourerofGodsHead
        {
            add => HookEndpointManager.Modify(OnHitPlayerDevourerofGodsHead, value);
            remove => HookEndpointManager.Unmodify(OnHitPlayerDevourerofGodsHead, value);
        }
        private static event ILContext.Manipulator ModifyOnHitPlayerDevourerofGodsHeadS
        {
            add => HookEndpointManager.Modify(OnHitPlayerDevourerofGodsHeadS, value);
            remove => HookEndpointManager.Unmodify(OnHitPlayerDevourerofGodsHeadS, value);
        }
        private static event ILContext.Manipulator ModifyModifyHitPlayerFearlessGoldfishWarrior
        {
            add => HookEndpointManager.Modify(ModifyHitPlayerFearlessGoldfishWarrior, value);
            remove => HookEndpointManager.Unmodify(ModifyHitPlayerFearlessGoldfishWarrior, value);
        }
        private static event ILContext.Manipulator ModifyGetChatFAP
        {
            add => HookEndpointManager.Modify(GetChatFAP, value);
            remove => HookEndpointManager.Unmodify(GetChatFAP, value);
        }
        private static event ILContext.Manipulator ModifyAIHealOrbProv
        {
            add => HookEndpointManager.Modify(AIHealOrbProv, value);
            remove => HookEndpointManager.Unmodify(AIHealOrbProv, value);
        }
        private static event ILContext.Manipulator ModifyAIHolyBurnOrb
        {
            add => HookEndpointManager.Modify(AIHolyBurnOrb, value);
            remove => HookEndpointManager.Unmodify(AIHolyBurnOrb, value);
        }
        private static event ILContext.Manipulator ModifyAIChibiiDoggo
        {
            add => HookEndpointManager.Modify(AIChibiiDoggo, value);
            remove => HookEndpointManager.Unmodify(AIChibiiDoggo, value);
        }
        private static event ILContext.Manipulator ModifySpawnDoggo
        {
            add => HookEndpointManager.Modify(SpawnDoggo, value);
            remove => HookEndpointManager.Unmodify(SpawnDoggo, value);
        }
        private static event ILContext.Manipulator ModifyBedRightClick
        {
            add => HookEndpointManager.Modify(BedRightClick, value);
            remove => HookEndpointManager.Unmodify(BedRightClick, value);
        }
        private static event ILContext.Manipulator ModifyNewRightClick
        {
            add => HookEndpointManager.Modify(NewRightClick, value);
            remove => HookEndpointManager.Unmodify(NewRightClick, value);
        }
        private static event ILContext.Manipulator ModifyAddCalamityInvasions
        {
            add => HookEndpointManager.Modify(AddCalamityInvasions, value);
            remove => HookEndpointManager.Unmodify(AddCalamityInvasions, value);
        }
        private static event ILContext.Manipulator ModifyCensusSupport
        {
            add => HookEndpointManager.Modify(CensusSupport, value);
            remove => HookEndpointManager.Unmodify(CensusSupport, value);
        }
        private static event ILContext.Manipulator ModifyBossLootRavager
        {
            add => HookEndpointManager.Modify(BossLootRavager, value);
            remove => HookEndpointManager.Unmodify(BossLootRavager, value);
        }
        private static event ILContext.Manipulator ModifyBossLootCalamitasRun3
        {
            add => HookEndpointManager.Modify(BossLootCalamitasRun3, value);
            remove => HookEndpointManager.Unmodify(BossLootCalamitasRun3, value);
        }
        private static event ILContext.Manipulator ModifyDrawBossHPUI
        {
            add => HookEndpointManager.Modify(DrawBossHPUI, value);
            remove => HookEndpointManager.Unmodify(DrawBossHPUI, value);
        }
        private static event ILContext.Manipulator ModifyDrawOpenAnim
        {
            add => HookEndpointManager.Modify(DrawOpenAnim, value);
            remove => HookEndpointManager.Unmodify(DrawOpenAnim, value);
        }
        private static event ILContext.Manipulator ModifyBossLootProfanedGuardianBoss2
        {
            add => HookEndpointManager.Modify(BossLootProfanedGuardianBoss2, value);
            remove => HookEndpointManager.Unmodify(BossLootProfanedGuardianBoss2, value);
        }
        private static event ILContext.Manipulator ModifyBossLootPerforatorHeadLarge
        {
            add => HookEndpointManager.Modify(BossLootPerforatorHeadLarge, value);
            remove => HookEndpointManager.Unmodify(BossLootPerforatorHeadLarge, value);
        }
        private static event ILContext.Manipulator ModifyBossLootPerforatorHeadSmall
        {
            add => HookEndpointManager.Modify(BossLootPerforatorHeadSmall, value);
            remove => HookEndpointManager.Unmodify(BossLootPerforatorHeadSmall, value);
        }
        private static event ILContext.Manipulator ModifyBossLootBumblefuck
        {
            add => HookEndpointManager.Modify(BossLootBumblefuck, value);
            remove => HookEndpointManager.Unmodify(BossLootBumblefuck, value);
        }
        private static event ILContext.Manipulator ModifyBossLootPerforatorHeadMedium
        {
            add => HookEndpointManager.Modify(BossLootPerforatorHeadMedium, value);
            remove => HookEndpointManager.Unmodify(BossLootPerforatorHeadMedium, value);
        }
        private static event ILContext.Manipulator ModifyBossLootProfanedGuardianBoss3
        {
            add => HookEndpointManager.Modify(BossLootProfanedGuardianBoss3, value);
            remove => HookEndpointManager.Unmodify(BossLootProfanedGuardianBoss3, value);
        }
        private static event ILContext.Manipulator ModifyBossLootProfanedGuardianBoss
        {
            add => HookEndpointManager.Modify(BossLootProfanedGuardianBoss, value);
            remove => HookEndpointManager.Unmodify(BossLootProfanedGuardianBoss, value);
        }
        private static event ILContext.Manipulator ModifyInvasionNamebossRushUI
        {
            add => HookEndpointManager.Modify(InvasionNamebossRushUI, value);
            remove => HookEndpointManager.Unmodify(InvasionNamebossRushUI, value);
        }
        private static event ILContext.Manipulator ModifyColdDivinityModifyTooltips 
        {
            add => HookEndpointManager.Modify(ColdDivinityModifyTooltips, value);
            remove => HookEndpointManager.Unmodify(ColdDivinityModifyTooltips, value);
        }

        #endregion

        #region Calamity MethodInfo

        private static MethodInfo _handleMouseInteraction;
        private static MethodInfo DrawStealth;
        private static MethodInfo DrawAcidRain;
        private static MethodInfo PreKill;
        private static MethodInfo KillPlayer;
        private static MethodInfo UpdateAccessory;
        private static MethodInfo AddCalamityBosses;
        private static MethodInfo ChooseDialogue;
        private static MethodInfo GetTextByPageHellGUI;
        private static MethodInfo GetTextByPageJungleGUI;
        private static MethodInfo GetTextByPagePlanetoidGUI;
        private static MethodInfo GetTextByPageSnowBiomeGUI;
        private static MethodInfo GetTextByPageSunkenSeaGUI;
        private static MethodInfo SetChatButtonsFAP;
        private static MethodInfo SetChatButtonsSEAHOE;
        private static MethodInfo SetChatButtonsTHIEF;
        private static MethodInfo OnConsumeItemAstralInjection;
        private static MethodInfo ShootThornBlossom;
        private static MethodInfo ShootThornLucrecia;
        private static MethodInfo ShootBloodBoiler;
        private static MethodInfo ShootMolecularManipulator;
        private static MethodInfo ShootNullificationRifle;
        private static MethodInfo OnHitPlayerDevourerofGodsHead;
        private static MethodInfo OnHitPlayerDevourerofGodsHeadS;
        private static MethodInfo ModifyHitPlayerFearlessGoldfishWarrior;
        private static MethodInfo GetChatFAP;
        private static MethodInfo AIHealOrbProv;
        private static MethodInfo AIHolyBurnOrb;
        private static MethodInfo AIChibiiDoggo;
        private static MethodInfo SpawnDoggo;
        private static MethodInfo BedRightClick;
        private static MethodInfo NewRightClick;
        private static MethodInfo AddCalamityInvasions;
        private static MethodInfo CensusSupport;
        private static MethodInfo BossLootRavager;
        private static MethodInfo BossLootCalamitasRun3;
        private static MethodInfo BossLootProfanedGuardianBoss2;
        private static MethodInfo BossLootProfanedGuardianBoss3;
        private static MethodInfo DrawBossHPUI;
        private static MethodInfo DrawOpenAnim;
        private static MethodInfo BossLootPerforatorHeadLarge;
        private static MethodInfo BossLootPerforatorHeadMedium;
        private static MethodInfo BossLootPerforatorHeadSmall;
        private static MethodInfo BossLootBumblefuck;
        private static MethodInfo BossLootProfanedGuardianBoss;
        private static MethodInfo InvasionNamebossRushUI;
        private static MethodInfo ColdDivinityModifyTooltips;

        #endregion
    }
}