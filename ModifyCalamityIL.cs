using System;
using System.Reflection;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;
using Terraria.ModLoader;

namespace CalamityRuTranslate
{
    internal class ModifyCalamityIL
    {
        public static void Setup()
        {
            Type();
        }

        public static void Unload()
        {
            UnloadIL();
        }

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
            Type fAP = null;
            Type sEAHOE = null;
            Type tHIEF = null;
            Type armageddon = null;
            Type death = null;
            Type defiledRune = null;
            Type revenge = null;
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

            Assembly calamityAssembly = Calamity.GetType().Assembly;

            foreach (Type a in calamityAssembly.GetTypes())
            {
                if (a.Name == "RipperUI")
                {
                    ripperUI = a;
                }
            }

            foreach (Type b in calamityAssembly.GetTypes())
            {
                if (b.Name == "DraedonLogHellGUI")
                {
                    draedonLogHellGUI = b;
                }
            }

            foreach (Type c in calamityAssembly.GetTypes())
            {
                if (c.Name == "StealthUI")
                {
                    stealthUI = c;
                }
            }

            foreach (Type d in calamityAssembly.GetTypes())
            {
                if (d.Name == "CalamityPlayer")
                {
                    calamityPlayer = d;
                }
            }

            foreach (Type e in calamityAssembly.GetTypes())
            {
                if (e.Name == "CheatTestThing")
                {
                    cheatTestThing = e;
                }
            }

            foreach (Type f in calamityAssembly.GetTypes())
            {
                if (f.Name == "AcidRainUI")
                {
                    acidRainUI = f;
                }
            }

            foreach (Type g in calamityAssembly.GetTypes())
            {
                if (g.Name == "DraedonLogJungleGUI")
                {
                    draedonLogJungleGUI = g;
                }
            }

            foreach (Type h in calamityAssembly.GetTypes())
            {
                if (h.Name == "DraedonLogPlanetoidGUI")
                {
                    draedonLogPlanetoidGUI = h;
                }
            }

            foreach (Type i in calamityAssembly.GetTypes())
            {
                if (i.Name == "DraedonLogSnowBiomeGUI")
                {
                    draedonLogSnowBiomeGUI = i;
                }
            }

            foreach (Type j in calamityAssembly.GetTypes())
            {
                if (j.Name == "DraedonLogSunkenSeaGUI")
                {
                    draedonLogSunkenSeaGUI = j;
                }
            }

            foreach (Type k in calamityAssembly.GetTypes())
            {
                if (k.Name == "WeakReferenceSupport")
                {
                    weakReferenceSupport = k;
                }
            }

            foreach (Type l in calamityAssembly.GetTypes())
            {
                if (l.Name == "FAP")
                {
                    fAP = l;
                }
            }

            foreach (Type m in calamityAssembly.GetTypes())
            {
                if (m.Name == "SEAHOE")
                {
                    sEAHOE = m;
                }
            }

            foreach (Type n in calamityAssembly.GetTypes())
            {
                if (n.Name == "THIEF")
                {
                    tHIEF = n;
                }
            }

            foreach (Type o in calamityAssembly.GetTypes())
            {
                if (o.Name == "LabHologramProjectorUI")
                {
                    labHologramProjectorUI = o;
                }
            }

            foreach (Type p in calamityAssembly.GetTypes())
            {
                if (p.Name == "Armageddon")
                {
                    armageddon = p;
                }
            }

            foreach (Type q in calamityAssembly.GetTypes())
            {
                if (q.Name == "Death")
                {
                    death = q;
                }
            }

            foreach (Type r in calamityAssembly.GetTypes())
            {
                if (r.Name == "DefiledRune")
                {
                    defiledRune = r;
                }
            }

            foreach (Type s in calamityAssembly.GetTypes())
            {
                if (s.Name == "Revenge")
                {
                    revenge = s;
                }
            }

            foreach (Type t in calamityAssembly.GetTypes())
            {
                if (t.Name == "AstralInjection")
                {
                    astralInjection = t;
                }
            }

            foreach (Type u in calamityAssembly.GetTypes())
            {
                if (u.Name == "ThornBlossom")
                {
                    thornBlossom = u;
                }
            }

            foreach (Type v in calamityAssembly.GetTypes())
            {
                if (v.Name == "Lucrecia")
                {
                    lucrecia = v;
                }
            }

            foreach (Type w in calamityAssembly.GetTypes())
            {
                if (w.Name == "BloodBoiler")
                {
                    bloodBoiler = w;
                }
            }

            foreach (Type x in calamityAssembly.GetTypes())
            {
                if (x.Name == "MolecularManipulator")
                {
                    molecularManipulator = x;
                }
            }

            foreach (Type y in calamityAssembly.GetTypes())
            {
                if (y.Name == "NullificationRifle")
                {
                    nullificationRifle = y;
                }
            }

            foreach (Type z in calamityAssembly.GetTypes())
            {
                if (z.Name == "DevourerofGodsHead")
                {
                    devourerofGodsHead = z;
                }
            }

            foreach (Type aa in calamityAssembly.GetTypes())
            {
                if (aa.Name == "DevourerofGodsHeadS")
                {
                    devourerofGodsHeadS = aa;
                }
            }

            foreach (Type ab in calamityAssembly.GetTypes())
            {
                if (ab.Name == "FearlessGoldfishWarrior")
                {
                    fearlessGoldfishWarrior = ab;
                }
            }

            foreach (Type ac in calamityAssembly.GetTypes())
            {
                if (ac.Name == "HealOrbProv")
                {
                    healOrbProv = ac;
                }
            }

            foreach (Type ad in calamityAssembly.GetTypes())
            {
                if (ad.Name == "HolyBurnOrb")
                {
                    holyBurnOrb = ad;
                }
            }

            foreach (Type ae in calamityAssembly.GetTypes())
            {
                if (ae.Name == "ChibiiDoggo")
                {
                    chibiiDoggo = ae;
                }
            }

            foreach (Type af in calamityAssembly.GetTypes())
            {
                if (af.Name == "CalamityUtils")
                {
                    calamityUtils = af;
                }
            }

            foreach (Type ag in calamityAssembly.GetTypes())
            {
                if (ag.Name == "PlaguedPlateBed" && ag.Namespace == "CalamityMod.Tiles.FurniturePlaguedPlate")
                {
                    plaguedPlateBed = ag;
                }
            }

            foreach (Type ah in calamityAssembly.GetTypes())
            {
                if (ah.Name == "RavagerBody")
                {
                    ravagerBody = ah;
                }
            }

            foreach (Type ai in calamityAssembly.GetTypes())
            {
                if (ai.Name == "CalamitasRun3")
                {
                    calamitasRun3 = ai;
                }
            }

            foreach (Type aj in calamityAssembly.GetTypes())
            {
                if (aj.Name == "BossHPUI")
                {
                    bossHPUI = aj;
                }
            }

            foreach (Type ak in calamityAssembly.GetTypes())
            {
                if (ak.Name == "ProfanedGuardianBoss2")
                {
                    profanedGuardianBoss2 = ak;
                }
            }

            foreach (Type al in calamityAssembly.GetTypes())
            {
                if (al.Name == "PerforatorHeadLarge")
                {
                    perforatorHeadLarge = al;
                }
            }

            foreach (Type am in calamityAssembly.GetTypes())
            {
                if (am.Name == "PerforatorHeadSmall")
                {
                    perforatorHeadSmall = am;
                }
            }

            foreach (Type an in calamityAssembly.GetTypes())
            {
                if (an.Name == "Bumblefuck")
                {
                    bumblefuck = an;
                }
            }

            foreach (Type ao in calamityAssembly.GetTypes())
            {
                if (ao.Name == "PerforatorHeadMedium")
                {
                    perforatorHeadMedium = ao;
                }
            }

            foreach (Type ap in calamityAssembly.GetTypes())
            {
                if (ap.Name == "ProfanedGuardianBoss3")
                {
                    profanedGuardianBoss3 = ap;
                }
            }

            foreach (Type aq in calamityAssembly.GetTypes())
            {
                if (aq.Name == "ProfanedGuardianBoss")
                {
                    profanedGuardianBoss = aq;
                }
            }
            
            foreach (Type ar in calamityAssembly.GetTypes())
            {
                if (ar.Name == "BossRushUI")
                {
                    bossRushUI = ar;
                }
            }
            
            foreach (Type at in calamityAssembly.GetTypes())
            {
                if (at.Name == "ColdDivinity")
                {
                    coldDivinity = at;
                }
            }

            if (ripperUI != null)
            {
                HandleMouseInteraction = ripperUI.GetMethod("HandleMouseInteraction", BindingFlags.Static | BindingFlags.NonPublic);
            }

            if (HandleMouseInteraction != null)
            {
                ModifyHandleMouseInteraction += Ua_ModifyHandleMouseInteraction;
            }

            if (acidRainUI != null)
            {
                DrawAcidRain = acidRainUI.GetMethod("get_InvasionName", BindingFlags.Instance | BindingFlags.Public);
            }

            if (DrawAcidRain != null)
            {
                ModifyDrawAcidRain += Calamity_ModifyDrawAcidRain;
            }
            
            if (stealthUI != null)
            {
                DrawStealth = stealthUI.GetMethod("Draw", BindingFlags.Static | BindingFlags.Public);
            }

            if (DrawStealth != null)
            {
                ModifyDrawStealth += Calamity_ModifyDrawStealth;
            }

            if (calamityPlayer != null)
            {
                PreKill = calamityPlayer.GetMethod("PreKill", BindingFlags.Instance | BindingFlags.Public);
                KillPlayer = calamityPlayer.GetMethod("KillPlayer", BindingFlags.Instance | BindingFlags.Public);
            }

            if (PreKill != null)
            {
                ModifyPreKill += Ua_ModifyPreKill;
            }

            if (KillPlayer != null)
            {
                ModifyKillPlayer += Ua_ModifyKillPlayer;
            }

            if (cheatTestThing != null)
            {
                UpdateAccessory = cheatTestThing.GetMethod("UpdateAccessory", BindingFlags.Instance | BindingFlags.Public);
            }

            if (UpdateAccessory != null)
            {
                ModifyUpdateAccessory += Ua_ModifyUpdateAccessory;
            }

            if (labHologramProjectorUI != null)
            {
                ChooseDialogue = labHologramProjectorUI.GetMethod("ChooseDialogue", BindingFlags.Public | BindingFlags.Static);
            }

            if (ChooseDialogue != null)
            {
                ModifyChooseDialogue += Ua_ModifyChooseDialogue;
            }

            if (draedonLogHellGUI != null)
            {
                GetTextByPageHellGUI = draedonLogHellGUI.GetMethod("GetTextByPage", BindingFlags.Public | BindingFlags.Instance);
            }

            if (draedonLogJungleGUI != null)
            {
                GetTextByPageJungleGUI = draedonLogJungleGUI.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            }

            if (draedonLogPlanetoidGUI != null)
            {
                GetTextByPagePlanetoidGUI = draedonLogPlanetoidGUI.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            }

            if (draedonLogSnowBiomeGUI != null)
            {
                GetTextByPageSnowBiomeGUI = draedonLogSnowBiomeGUI.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            }

            if (draedonLogSunkenSeaGUI != null)
            {
                GetTextByPageSunkenSeaGUI = draedonLogSunkenSeaGUI.GetMethod("GetTextByPage", BindingFlags.Instance | BindingFlags.Public);
            }

            if (GetTextByPageHellGUI != null)
            {
                ModifyGetTextByPageHellGUI += Calamity_ModifyGetTextByPageHellGUI;
            }

            if (GetTextByPageJungleGUI != null)
            {
                ModifyGetTextByPageJungleGUI += Calamity_ModifyModifyGetTextByPageJungleGUI;
            }

            if (GetTextByPagePlanetoidGUI != null)
            {
                ModifyGetTextByPagePlanetoidGUI += Calamity_ModifyModifyGetTextByPagePlanetoidGUI;
            }

            if (GetTextByPageSnowBiomeGUI != null)
            {
                ModifyGetTextByPageSnowBiomeGUI += Calamity_ModifyModifyGetTextByPageSnowBiomeGUI;
            }

            if (GetTextByPageSunkenSeaGUI != null)
            {
                ModifyGetTextByPageSunkenSeaGUI += Calamity_ModifyModifyGetTextByPageSunkenSeaGUI;
            }

            if (weakReferenceSupport != null)
            {
                AddCalamityBosses = weakReferenceSupport.GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic);
            }

            if (AddCalamityBosses != null)
            {
                ModifyAddCalamityBosses += Ua_ModifyAddCalamityBosses;
            }

            if (fAP != null)
            {
                SetChatButtonsFAP = fAP.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            }

            if (sEAHOE != null)
            {
                SetChatButtonsSEAHOE = sEAHOE.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            }

            if (tHIEF != null)
            {
                SetChatButtonsTHIEF = tHIEF.GetMethod("SetChatButtons", BindingFlags.Public | BindingFlags.Instance);
            }

            if (SetChatButtonsFAP != null)
            {
                ModifySetChatButtonsFAP += Calamity_ModifySetChatButtonsFAP;
            }

            if (SetChatButtonsSEAHOE != null)
            {
                ModifySetChatButtonsSEAHOE += Calamity_ModifySetChatButtonsSEAHOE;
            }

            if (SetChatButtonsTHIEF != null)
            {
                ModifySetChatButtonsTHIEF += Calamity_ModifySetChatButtonsTHIEF;
            }

            if (armageddon != null)
            {
                UseItemArmageddon = armageddon.GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance);
            }

            if (UseItemArmageddon != null)
            {
                ModifyUseItemArmageddon += Ua_ModifyModifyUseItemArmageddon;
            }

            if (death != null)
            {
                UseItemDeath = death.GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance);
            }

            if (UseItemDeath != null)
            {
                ModifyUseItemDeath += Ua_ModifyModifyUseItemDeath;
            }

            if (defiledRune != null)
            {
                UseItemDefiledRune = defiledRune.GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance);
            }

            if (UseItemDefiledRune != null)
            {
                ModifyUseItemDefiledRune += Ua_ModifyModifyUseItemDefiledRune;
            }

            if (revenge != null)
            {
                UseItemRevenge = revenge.GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance);
            }

            if (UseItemRevenge != null)
            {
                ModifyUseItemRevenge += Ua_ModifyModifyUseItemRevenge;
            }

            if (astralInjection != null)
            {
                OnConsumeItemAstralInjection = astralInjection.GetMethod("OnConsumeItem", BindingFlags.Public | BindingFlags.Instance);
            }

            if (OnConsumeItemAstralInjection != null)
            {
                ModifyOnConsumeItemAstralInjection += Ua_ModifyOnConsumeItemAstralInjection;
            }

            if (thornBlossom != null)
            {
                ShootThornBlossom = thornBlossom.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (ShootThornBlossom != null)
            {
                ModifyShootThornBlossom += Ua_ModifyShootThornBlossom;
            }

            if (lucrecia != null)
            {
                ShootThornLucrecia = lucrecia.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (ShootThornLucrecia != null)
            {
                ModifyShootThornLucrecia += Ua_ModifyShootThornLucrecia;
            }

            if (bloodBoiler != null)
            {
                ShootBloodBoiler = bloodBoiler.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (ShootBloodBoiler != null)
            {
                ModifyShootBloodBoiler += Ua_ModifyShootBloodBoiler;
            }

            if (molecularManipulator != null)
            {
                ShootMolecularManipulator = molecularManipulator.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (ShootMolecularManipulator != null)
            {
                ModifyMolecularManipulator += Ua_ModifyMolecularManipulator;
            }

            if (nullificationRifle != null)
            {
                ShootNullificationRifle = nullificationRifle.GetMethod("Shoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (ShootNullificationRifle != null)
            {
                ModifyShootNullificationRifle += Ua_ModifyShootNullificationRifle;
            }

            if (devourerofGodsHead != null)
            {
                OnHitPlayerDevourerofGodsHead = devourerofGodsHead.GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance);
            }

            if (OnHitPlayerDevourerofGodsHead != null)
            {
                ModifyOnHitPlayerDevourerofGodsHead += Ua_ModifyOnHitPlayerDevourerofGodsHead;
            }

            if (devourerofGodsHeadS != null)
            {
                OnHitPlayerDevourerofGodsHeadS = devourerofGodsHeadS.GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance);
            }

            if (OnHitPlayerDevourerofGodsHeadS != null)
            {
                ModifyOnHitPlayerDevourerofGodsHeadS += Ua_ModifyOnHitPlayerDevourerofGodsHeadS;
            }

            if (fearlessGoldfishWarrior != null)
            {
                ModifyHitPlayerFearlessGoldfishWarrior = fearlessGoldfishWarrior.GetMethod("ModifyHitPlayer", BindingFlags.Public | BindingFlags.Instance);
            }

            if (ModifyHitPlayerFearlessGoldfishWarrior != null)
            {
                ModifyModifyHitPlayerFearlessGoldfishWarrior += Ua_ModifyModifyHitPlayerFearlessGoldfishWarrior;
            }

            if (fAP != null)
            {
                GetChatFAP = fAP.GetMethod("GetChat", BindingFlags.Public | BindingFlags.Instance);
            }

            if (GetChatFAP != null)
            {
                ModifyGetChatFAP += Ua_ModifyGetChatFAP;
            }

            if (healOrbProv != null)
            {
                AIHealOrbProv = healOrbProv.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            }

            if (AIHealOrbProv != null)
            {
                ModifyAIHealOrbProv += Ua_ModifyAIHealOrbProv;
            }

            if (holyBurnOrb != null)
            {
                AIHolyBurnOrb = holyBurnOrb.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            }

            if (AIHolyBurnOrb != null)
            {
                ModifyAIHolyBurnOrb += Ua_ModifyAIHolyBurnOrb;
            }

            if (chibiiDoggo != null)
            {
                AIChibiiDoggo = chibiiDoggo.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            }

            if (AIChibiiDoggo != null)
            {
                ModifyAIChibiiDoggo += Ua_ModifyAIChibiiDoggo;
            }

            if (chibiiDoggo != null)
            {
                SpawnDoggo = chibiiDoggo.GetMethod("SpawnDoggo", BindingFlags.Public | BindingFlags.Instance);
            }

            if (SpawnDoggo != null)
            {
                ModifySpawnDoggo += Ua_ModifySpawnDoggo;
            }

            if (calamityUtils != null)
            {
                BedRightClick = calamityUtils.GetMethod("BedRightClick", BindingFlags.Public | BindingFlags.Static);
            }

            if (BedRightClick != null)
            {
                ModifyBedRightClick += Ua_ModifyBedRightClick;
            }

            if (plaguedPlateBed != null)
            {
                NewRightClick = plaguedPlateBed.GetMethod("NewRightClick", BindingFlags.Public | BindingFlags.Instance);
            }

            if (NewRightClick != null)
            {
                ModifyNewRightClick += Ua_ModifyNewRightClick;
            }

            if (weakReferenceSupport != null)
            {
                AddCalamityInvasions = weakReferenceSupport.GetMethod("AddCalamityInvasions", BindingFlags.NonPublic | BindingFlags.Static);
            }

            if (AddCalamityInvasions != null)
            {
                ModifyAddCalamityInvasions += Ua_ModifyAddCalamityInvasions;
            }

            if (weakReferenceSupport != null)
            {
                CensusSupport = weakReferenceSupport.GetMethod("CensusSupport", BindingFlags.NonPublic | BindingFlags.Static);
            }

            if (CensusSupport != null)
            {
                ModifyCensusSupport += Ua_ModifyCensusSupport;
            }

            if (ravagerBody != null)
            {
                BossLootRavager = ravagerBody.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (BossLootRavager != null)
            {
                ModifyBossLootRavager += Ua_ModifyBossLootRavager;
            }

            if (calamitasRun3 != null)
            {
                BossLootCalamitasRun3 = calamitasRun3.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (BossLootCalamitasRun3 != null)
            {
                ModifyBossLootCalamitasRun3 += Ua_ModifyBossLootCalamitasRun3;
            }

            if (bossHPUI != null)
            {
                DrawBossHPUI = bossHPUI.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            }

            if (DrawBossHPUI != null)
            {
                ModifyDrawBossHPUI += Ua_ModifyDrawBossHPUI;
            }

            if (bossHPUI != null)
            {
                DrawOpenAnim = bossHPUI.GetMethod("DrawOpenAnim", BindingFlags.Public | BindingFlags.Instance);
            }

            if (DrawOpenAnim != null)
            {
                ModifyDrawOpenAnim += Ua_ModifyDrawOpenAnim;
            }

            if (profanedGuardianBoss2 != null)
            {
                BossLootProfanedGuardianBoss2 = profanedGuardianBoss2.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (BossLootProfanedGuardianBoss2 != null)
            {
                ModifyBossLootProfanedGuardianBoss2 += Ua_ModifyBossLootProfanedGuardianBoss2;
            }

            if (perforatorHeadLarge != null)
            {
                BossLootPerforatorHeadLarge = perforatorHeadLarge.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (BossLootPerforatorHeadLarge != null)
            {
                ModifyBossLootPerforatorHeadLarge += Ua_ModifyBossLootPerforatorHeadLarge;
            }

            if (perforatorHeadSmall != null)
            {
                BossLootPerforatorHeadSmall = perforatorHeadSmall.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (BossLootPerforatorHeadSmall != null)
            {
                ModifyBossLootPerforatorHeadSmall += Ua_ModifyBossLootPerforatorHeadSmall;
            }

            if (bumblefuck != null)
            {
                BossLootBumblefuck = bumblefuck.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (BossLootBumblefuck != null)
            {
                ModifyBossLootBumblefuck += Ua_ModifyBossLootBumblefuck;
            }

            if (perforatorHeadMedium != null)
            {
                BossLootPerforatorHeadMedium = perforatorHeadMedium.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (BossLootPerforatorHeadMedium != null)
            {
                ModifyBossLootPerforatorHeadMedium += Ua_ModifyBossLootPerforatorHeadMedium;
            }

            if (profanedGuardianBoss3 != null)
            {
                BossLootProfanedGuardianBoss3 = profanedGuardianBoss3.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (BossLootProfanedGuardianBoss3 != null)
            {
                ModifyBossLootProfanedGuardianBoss3 += Ua_ModifyBossLootProfanedGuardianBoss3;
            }

            if (profanedGuardianBoss != null)
            {
                BossLootProfanedGuardianBoss = profanedGuardianBoss.GetMethod("BossLoot", BindingFlags.Public | BindingFlags.Instance);
            }

            if (BossLootProfanedGuardianBoss != null)
            {
                ModifyBossLootProfanedGuardianBoss += Ua_ModifyBossLootProfanedGuardianBoss;
            }
            
            if (bossRushUI != null)
            {
                InvasionNamebossRushUI = bossRushUI.GetMethod("get_InvasionName", BindingFlags.Public | BindingFlags.Instance);
            }

            if (InvasionNamebossRushUI != null)
            {
                ModifyInvasionNamebossRushUI += Ua_ModifyInvasionNamebossRushUI;
            }
            
            if (coldDivinity != null)
            {
                ColdDivinityModifyTooltips = coldDivinity.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            }

            if (ColdDivinityModifyTooltips != null)
            {
                ModifyColdDivinityModifyTooltips += Ua_ModifyColdDivinityModifyTooltips;
            }

            #endregion
        }

        #region IL Editing

        private static void Ua_ModifyColdDivinityModifyTooltips(ILContext il)
        {
            var a = new ILCursor(il);

            if (!a.TryGotoNext(i => i.MatchLdstr("Tooltip7")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyColdDivinityModifyTooltips a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, "Tooltip6");
        }
        
        private static void Ua_ModifyInvasionNamebossRushUI(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Boss Rush")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyInvasionNamebossRushUI a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Босс-Раш"));
        }
        
        private static void Ua_ModifyBossLootProfanedGuardianBoss(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("A Profaned Guardian")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBossLootProfanedGuardianBoss a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Осквернённый страж"));
        }
        
        private static void Ua_ModifyBossLootProfanedGuardianBoss3(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("A Profaned Guardian")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBossLootProfanedGuardianBoss3 a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Осквернённый страж"));
        }
        
        private static void Ua_ModifyBossLootPerforatorHeadMedium(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("The Medium Perforator")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBossLootPerforatorHeadMedium a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Перфоратор средний"));
        }
        
        private static void Ua_ModifyBossLootBumblefuck(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("A Dragonfolly")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBossLootBumblefuck a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Псевдодракон"));
        }
        
        private static void Ua_ModifyBossLootPerforatorHeadSmall(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("The Small Perforator")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBossLootPerforatorHeadSmall a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Перфоратор младший"));
        }
        
        private static void Ua_ModifyBossLootPerforatorHeadLarge(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("The Large Perforator")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBossLootPerforatorHeadLarge a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Перфоратор старший"));
        }
        
        private static void Ua_ModifyBossLootProfanedGuardianBoss2(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("A Profaned Guardian")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBossLootProfanedGuardianBoss2 a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Осквернённый страж"));
        }
        
        private static void Ua_ModifyDrawBossHPUI(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("(Segments left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawBossHPUI a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось сегментов: "));
            
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("(Creepers left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawBossHPUI b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось ползунов: "));
            
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr("(Hands left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawBossHPUI c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось рук: "));
            
            var d = new ILCursor(il);
        
            if (!d.TryGotoNext(i => i.MatchLdstr("(Arms left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawBossHPUI d failed");
                return;
            }
        
            d.Index++;
            d.Emit(OpCodes.Pop);
            d.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось оружий: "));
            
            var e = new ILCursor(il);
        
            if (!e.TryGotoNext(i => i.MatchLdstr("(Guns left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawBossHPUI e failed");
                return;
            }
        
            e.Index++;
            e.Emit(OpCodes.Pop);
            e.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось ружей: "));
            
            var f = new ILCursor(il);
        
            if (!f.TryGotoNext(i => i.MatchLdstr("(Cannons left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawBossHPUI f failed");
                return;
            }
        
            f.Index++;
            f.Emit(OpCodes.Pop);
            f.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось пушек: "));
            
            var g = new ILCursor(il);
        
            if (!g.TryGotoNext(i => i.MatchLdstr("(Dark Energy left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawBossHPUI g failed");
                return;
            }
        
            g.Index++;
            g.Emit(OpCodes.Pop);
            g.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось тёмной энергии: "));
            
            var h = new ILCursor(il);
        
            if (!h.TryGotoNext(i => i.MatchLdstr("(Body Parts left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawBossHPUI h failed");
                return;
            }
        
            h.Index++;
            h.Emit(OpCodes.Pop);
            h.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось частей тела: "));
            
            var ii = new ILCursor(il);
        
            if (!ii.TryGotoNext(i => i.MatchLdstr("(Large Slimes left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawBossHPUI ii failed");
                return;
            }
        
            ii.Index++;
            ii.Emit(OpCodes.Pop);
            ii.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Осталось больших слизней: "));
        }
        
        private static void Ua_ModifyDrawOpenAnim(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("(Segments left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawOpenAnim a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось сегментов: "));
            
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("(Creepers left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawOpenAnim b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось ползунов: "));
            
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr("(Hands left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawOpenAnim c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось рук: "));
            
            var d = new ILCursor(il);
        
            if (!d.TryGotoNext(i => i.MatchLdstr("(Arms left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawOpenAnim d failed");
                return;
            }
        
            d.Index++;
            d.Emit(OpCodes.Pop);
            d.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось оружий: "));
            
            var e = new ILCursor(il);
        
            if (!e.TryGotoNext(i => i.MatchLdstr("(Guns left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawOpenAnim e failed");
                return;
            }
        
            e.Index++;
            e.Emit(OpCodes.Pop);
            e.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось ружей: "));
            
            var f = new ILCursor(il);
        
            if (!f.TryGotoNext(i => i.MatchLdstr("(Cannons left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawOpenAnim f failed");
                return;
            }
        
            f.Index++;
            f.Emit(OpCodes.Pop);
            f.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось пушек: "));
            
            var g = new ILCursor(il);
        
            if (!g.TryGotoNext(i => i.MatchLdstr("(Dark Energy left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawOpenAnim g failed");
                return;
            }
        
            g.Index++;
            g.Emit(OpCodes.Pop);
            g.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось тёмной энергии: "));
            
            var h = new ILCursor(il);
        
            if (!h.TryGotoNext(i => i.MatchLdstr("(Body Parts left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawOpenAnim h failed");
                return;
            }
        
            h.Index++;
            h.Emit(OpCodes.Pop);
            h.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("(Осталось частей тела: "));
            
            var ii = new ILCursor(il);
        
            if (!ii.TryGotoNext(i => i.MatchLdstr("(Large Slimes left: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyDrawOpenAnim ii failed");
                return;
            }
        
            ii.Index++;
            ii.Emit(OpCodes.Pop);
            ii.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Осталось больших слизней: "));
        }
        
        private static void Ua_ModifyBossLootCalamitasRun3(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("The Calamitas Clone")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBossLootCalamitasRun3 a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Клон Каламитас"));
        }
        
        private static void Ua_ModifyBossLootRavager(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Ravager")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBossLootRavager a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Разрушитель"));
        }
        
        private static void Ua_ModifyCensusSupport(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Defeat a Giant Clam after defeating the Desert Scourge")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyCensusSupport a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Одолейте Гигантского моллюска после победы над Пустынным бичем"));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("Have a [i:")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyCensusSupport b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Имейте ") + "[i:");
        
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr("] in your inventory after defeating Skeletron" )))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyCensusSupport c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, "]" + EncodingCyrillic.EncodingTransform(" в вашем инвентаре после победы над Скелетроном"));
        
            var d = new ILCursor(il);
        
            if (!d.TryGotoNext(i => i.MatchLdstr("Defeat Cryogen")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyCensusSupport d failed");
                return;
            }
        
            d.Index++;
            d.Emit(OpCodes.Pop);
            d.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Одолейте Криогена"));
        
            var e = new ILCursor(il);
        
            if (!e.TryGotoNext(i => i.MatchLdstr("Have [i:")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyCensusSupport e failed");
                return;
            }
        
            e.Index++;
            e.Emit(OpCodes.Pop);
            e.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Имейте ") + "[i:");
        
            var f = new ILCursor(il);
        
            if (!f.TryGotoNext(i => i.MatchLdstr("] in your inventory in Hardmode")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyCensusSupport f failed");
                return;
            }
        
            f.Index++;
            f.Emit(OpCodes.Pop);
            f.Emit(OpCodes.Ldstr, "]"+ EncodingCyrillic.EncodingTransform(" в вашем инвентаре в Хардмоде"));
        }
        
        private static void Ua_ModifyAddCalamityInvasions(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] or wait for the invasion to occur naturally after the Eye of Cthulhu is defeated.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityInvasions a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" или дождитесь, пока событие произойдёт естественным образом после того, как Глаз Ктулху будет побеждён."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("The mysterious creatures of the sulphuric sea descended back into the ocean.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityInvasions b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Таинственные существа сернистого моря спустились обратно в океан."));
        
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr("Acid Rain")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityInvasions c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Кислотный дождь"));
        
            var d = new ILCursor(il);
        
            if (!d.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Aquatic Scourge is defeated")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityInvasions d failed");
                return;
            }
        
            d.Index++;
            d.Emit(OpCodes.Pop);
            d.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" или ") + "[i:{1}]" + EncodingCyrillic.EncodingTransform(" или дождитесь, пока событие произойдёт естественным образом после того, как Глаз Ктулху будет побеждён."));
        
            var e = new ILCursor(il);
        
            if (!e.TryGotoNext(i => i.MatchLdstr("The mysterious creatures of the sulphuric sea descended back into the deep ocean.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityInvasions e failed");
                return;
            }
        
            e.Index++;
            e.Emit(OpCodes.Pop);
            e.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Таинственные существа сернистого моря спустились обратно в глубины океана."));
        
            var f = new ILCursor(il);
        
            if (!f.TryGotoNext(i => i.MatchLdstr("Acid Rain (Post-AS)")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityInvasions f failed");
                return;
            }
        
            f.Index++;
            f.Emit(OpCodes.Pop);
            f.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Кислотный дождь (Пост-Аб)"));
        
            var g = new ILCursor(il);
        
            if (!g.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] or [i:{1}] or wait for the invasion to occur naturally after the Polterghast is defeated")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityInvasions g failed");
                return;
            }
        
            g.Index++;
            g.Emit(OpCodes.Pop);
            g.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ")+ "[i:{0}]" + EncodingCyrillic.EncodingTransform(" или ") + "[i:{1}]" + EncodingCyrillic.EncodingTransform(" или дождитесь, пока событие произойдёт естественным образом после того, как Полтергаст будет побеждён."));
        
            var h = new ILCursor(il);
        
            if (!h.TryGotoNext(i => i.MatchLdstr("The mysterious creatures of the sulphuric sea descended back into the deep ocean.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityInvasions h failed");
                return;
            }
            if (!h.TryGotoNext(i => i.MatchLdstr("The mysterious creatures of the sulphuric sea descended back into the deep ocean.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityInvasions h failed");
                return;
            }
        
            h.Index++;
            h.Emit(OpCodes.Pop);
            h.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Таинственные существа сернистого моря спустились обратно в глубины океана."));
        
            var ii = new ILCursor(il);
        
            if (!ii.TryGotoNext(i => i.MatchLdstr("Acid Rain (Post-Polter)")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityInvasions ii failed");
                return;
            }
        
            ii.Index++;
            ii.Emit(OpCodes.Pop);
            ii.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Кислотный дождь (Пост-Полтер)"));
        }
        
        private static void Ua_ModifyNewRightClick(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Spawn point removed!")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyNewRightClick a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Точка воскрешения удалена!"));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("Spawn point set!")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyNewRightClick b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Точка воскрешения задана!"));
        }
        
        private static void Ua_ModifyBedRightClick(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Spawn point removed!")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBedRightClick a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Точка воскрешения удалена!"));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("Spawn point set!")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyBedRightClick b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Точка воскрешения задана!"));
        }
        
        private static void Ua_ModifySpawnDoggo(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("It's not over yet, kid!")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifySpawnDoggo a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Это ещё не конец, малыш!"));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("Don't get cocky, kid!")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifySpawnDoggo b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Не будь таким самоуверенным, малыш!"));
        }
        
        private static void Ua_ModifyAIChibiiDoggo(ILContext il)
        {
            var a = new ILCursor(il);
            
            if (!a.TryGotoNext(i => i.MatchLdstr(" couldn't stand the sharp objects.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAIChibiiDoggo a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" не выдерживал острых предметов."));
        }
        
        private static void Ua_ModifyAIHolyBurnOrb(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" burst into sinless ash.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAIHolyBurnOrb a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" превратился в безгрешный пепел."));
        }
        
        private static void Ua_ModifyAIHealOrbProv(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" burst into sinless ash.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAIHealOrbProv a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" превратился в безгрешный пепел."));
        }
        
        private static void Ua_ModifyGetChatFAP(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" was slapped too hard.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyGetChatFAP a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" получил слишком сильную пощечину."));
        }
        
        private static void Ua_ModifyModifyHitPlayerFearlessGoldfishWarrior(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" was once again impaled by Goldfish.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyModifyHitPlayerFearlessGoldfishWarrior a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был снова проткнут Золотой рыбкой."));
        }
        
        private static void Ua_ModifyOnHitPlayerDevourerofGodsHeadS(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("'s essence was consumed by the devourer.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyOnHitPlayerDevourerofGodsHeadS a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" сущность была поглощена пожирателем."));
        }
        
        private static void Ua_ModifyOnHitPlayerDevourerofGodsHead(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("'s essence was consumed by the devourer.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyOnHitPlayerDevourerofGodsHead a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" сущность была поглощена пожирателем."));
        }
        
        private static void Ua_ModifyShootNullificationRifle(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" was vaporized by the imbuement of his life.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyShootNullificationRifle a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" испарился из-за насыщенности своей жизни."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr(" was vaporized by the imbuement of her life.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyShootNullificationRifle b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" испарилась из-за насыщенности своей жизни."));
        }
        
        private static void Ua_ModifyMolecularManipulator(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" was vaporized by the imbuement of his life.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyMolecularManipulator a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" испарился из-за насыщенности своей жизни."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr(" was vaporized by the imbuement of her life.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyMolecularManipulator b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" испарилась из-за насыщенности своей жизни."));
        }
        
        private static void Ua_ModifyShootBloodBoiler(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" suffered from severe anemia.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyShootBloodBoiler a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" страдал тяжёлой анемией."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr(" was unable to obtain a blood transfusion.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyShootBloodBoiler b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" не удалось добиться переливания крови."));
        }
        
        private static void Ua_ModifyShootThornLucrecia(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("'s DNA was destroyed.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyShootThornLucrecia a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" ДНК была уничтожена."));
        }
        
        private static void Ua_ModifyShootThornBlossom(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" was violently pricked by a flower.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyShootThornBlossom a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был яростно уколот цветком."));
        }
        
        private static void Ua_ModifyOnConsumeItemAstralInjection(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("'s blood vessels burst from drug overdose.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyOnConsumeItemAstralInjection a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" кровеносные сосуды лопаются от передозировки наркотиков."));
        }
        
        private static void Ua_ModifyModifyUseItemRevenge(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" tried to change the rules.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyModifyUseItemRevenge a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" пытался изменить правила."));
        }
        
        private static void Ua_ModifyModifyUseItemDefiledRune(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" tried to change the rules.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyModifyUseItemDefiledRune a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" пытался изменить правила."));
        }
        
        private static void Ua_ModifyModifyUseItemDeath(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" tried to change the rules.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyModifyUseItemDeath a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" пытался изменить правила."));
        }
        
        private static void Ua_ModifyModifyUseItemArmageddon(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" tried to change the rules.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyModifyUseItemArmageddon a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" пытался изменить правила."));
        }
        
        private static void Ua_ModifyChooseDialogue(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("To any personnel engaged in the laboratories. Please wear your steel engraved ID badge at all times. It is the easiest method to discern your body if any accidents do occur.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Напоминаем всему персоналу. Пожалуйста, носите ваш персональный стальной идентификационный значок. Это самый простой способ опознать тело в случае несчастного случая."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("To experiment is to fail. To fail is to learn. To learn is to advance.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Экспериментировать — значит терпеть неудачи. Терпеть неудачи — значит учиться. Учиться — значит становиться лучше."));
        
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr("Apparent danger while researching serves only to enhance the research experience.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Кажущаяся опасность во время исследований только усиливает исследовательский опыт."));
        
            var d = new ILCursor(il);
        
            if (!d.TryGotoNext(i => i.MatchLdstr("Laser-type weapon prototypes are incredibly lethal and are not to be used within presentation halls.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue d failed");
                return;
            }
        
            d.Index++;
            d.Emit(OpCodes.Pop);
            d.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Прототипы лазерного оружия невероятно смертоносны и не должны использоваться в презентационных залах."));
        
            var e = new ILCursor(il);
        
            if (!e.TryGotoNext(i => i.MatchLdstr("High-energy plasma emissions have adverse effects on both flesh and metal. Do not attempt to handle vented plasma.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue e failed");
                return;
            }
        
            e.Index++;
            e.Emit(OpCodes.Pop);
            e.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Высокоэнергетические плазменные выбросы оказывают неблагоприятное воздействие как на плоть, так и на металл. Не пытайтесь обращаться с изливающейся плазмой."));
        
            var f = new ILCursor(il);
        
            if (!f.TryGotoNext(i => i.MatchLdstr("Electric shocks from military equipment are intended to be fatal. If you survive such a shock, that is a clear indicator that the device is not functioning properly. Please report any such cases.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue f failed");
                return;
            }
        
            f.Index++;
            f.Emit(OpCodes.Pop);
            f.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Удары электрического тока, вызванные оружием, должны быть летальными. Если вы пережили удар током, это явный признак того, что устройство не функционирует должным образом. Пожалуйста, сообщите о любых таких случаях"));
        
            var g = new ILCursor(il);
        
            if (!g.TryGotoNext(i => i.MatchLdstr("All employees are hereby notified that they will be held accountable for any collateral damage caused by Gauss weapon fire, even during sanctioned testing exercises.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue g failed");
                return;
            }
        
            g.Index++;
            g.Emit(OpCodes.Pop);
            g.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Все сотрудники уведомляются, что они будут нести ответственность за любой сопутствующий ущерб, причинённый огнём гауссовского оружия, даже во время санкционированных испытательных учений."));
        
            var h = new ILCursor(il);
        
            if (!h.TryGotoNext(i => i.MatchLdstr("Security Field Emitters will vaporize all unauthorized equipment and personnel. Please leave personal effects in the designated lockers off-site. This also means: Do not bring any family members who are not enlisted as personnel.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue h failed");
                return;
            }
        
            h.Index++;
            h.Emit(OpCodes.Pop);
            h.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Излучатели защитного поля уничтожат всё несанкционированное оборудование и персонал. Пожалуйста, оставьте личные вещи в специально отведённых запирающихся шкафчиках за пределами поля. Это также означает: Не приводите с собой членов семьи, которые не зачислены в личный состав."));
        
            var ii = new ILCursor(il);
        
            if (!ii.TryGotoNext(i => i.MatchLdstr("If one does manage to breach restricted testing facilities, do at least record any unexpected burns, lacerations, bruising, fractur... ...trauma, shocks and otherwise. Thank you.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue ii failed");
                return;
            }
        
            ii.Index++;
            ii.Emit(OpCodes.Pop);
            ii.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Если кто-то всё же решит пробраться в закрытые испытательные помещения, то хотя бы сделайте запись неожиданных ожогов, рваных ран, кровоизлияний, переломов... травм, шоковых ожогов и др. Спасибо."));
        
            var j = new ILCursor(il);
        
            if (!j.TryGotoNext(i => i.MatchLdstr("The power grid has been... ...eavily compromised. Abort research and proceed to the emergency exits located at... ...and egress with haste.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue j failed");
                return;
            }
        
            j.Index++;
            j.Emit(OpCodes.Pop);
            j.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Энергосистема была... ...кована, серьёзные повреждения. Прервите исследования и пройдите к аварийным выходам, расположенным... ...и выходите с поспешностью."));
        
            var k = new ILCursor(il);
        
            if (!k.TryGotoNext(i => i.MatchLdstr("Notify the Security Department of any aggressive local fauna immediately.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue k failed");
                return;
            }
        
            k.Index++;
            k.Emit(OpCodes.Pop);
            k.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Немедленно сообщите в Службу безопасности о любой местной агрессивной фауне."));
        
            var l = new ILCursor(il);
        
            if (!l.TryGotoNext(i => i.MatchLdstr("Sensors have detected a significant breach in the spacetime continuum.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue l failed");
                return;
            }
        
            l.Index++;
            l.Emit(OpCodes.Pop);
            l.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Сенсоры обнаружили значительное нарушение пространственно-временного континуума."));
        
            var m = new ILCursor(il);
        
            if (!m.TryGotoNext(i => i.MatchLdstr("Please help. I'm stuck in this hologram machine.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyChooseDialogue m failed");
                return;
            }
        
            m.Index++;
            m.Emit(OpCodes.Pop);
            m.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Пожалуйста, помогите. Я застрял в голограмме."));
        }
        
        private static void Calamity_ModifySetChatButtonsTHIEF(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Refund")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifySetChatButtonsTHIEF a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Возврат"));
        }
        
        private static void Calamity_ModifySetChatButtonsSEAHOE(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Help")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifySetChatButtonsSEAHOE a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Помощь"));
        }
        
        private static void Calamity_ModifySetChatButtonsFAP(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Death Count")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifySetChatButtonsFAP a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Количество смертей"));
        }
        
        private static void Ua_ModifyAddCalamityBosses(ILContext il)
        {
            var a = new ILCursor(il);
            
            if (!a.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] in the Desert Biome")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses a failed");
                return;
            }
            
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в Пустыне"));
            
            var b = new ILCursor(il);
            
            if (!b.TryGotoNext(i => i.MatchLdstr("The scourge of the desert delved back into the sand.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses b failed");
                return;
            }
            
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Пустынный бич снова погрузился в песок."));
            
            var c = new ILCursor(il);
            
            if (!c.TryGotoNext(i => i.MatchLdstr("Desert Scourge")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses c failed");
                return;
            }
            
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Пустынный бич"));
            
            var d = new ILCursor(il);
            
            if (!d.TryGotoNext(i => i.MatchLdstr("Can spawn naturally in the Sunken Sea")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses d failed");
                return;
            }
            
            d.Index++;
            d.Emit(OpCodes.Pop);
            d.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Может естественно появится в Затерянном море"));
            
            var e = new ILCursor(il);
            
            if (!e.TryGotoNext(i => i.MatchLdstr("The Giant Clam returns into hiding in its grotto.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses e failed");
                return;
            }
            
            e.Index++;
            e.Emit(OpCodes.Pop);
            e.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Гигантский моллюск скрывается в своём гроту."));
            
            var f = new ILCursor(il);
            
            if (!f.TryGotoNext(i => i.MatchLdstr("Giant Clam")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses f failed");
                return;
            }
            
            f.Index++;
            f.Emit(OpCodes.Pop);
            f.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Гигантский моллюск"));
            
            var g = new ILCursor(il);
            
            if (!g.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] in the Mushroom Biome")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses g failed");
                return;
            }
            
            g.Index++;
            g.Emit(OpCodes.Pop);
            g.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в Грибном биоме"));
            
            var h = new ILCursor(il);
            
            if (!h.TryGotoNext(i => i.MatchLdstr("The mycleium crab has lost interest.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses h failed");
                return;
            }
            
            h.Index++;
            h.Emit(OpCodes.Pop);
            h.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Мицелиевый краб потерял интерес."));
            
        
            var ii = new ILCursor(il);
            
            if (!ii.TryGotoNext(i => i.MatchLdstr("Crabulon")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ii failed");
                return;
            }
            if (!ii.TryGotoNext(i => i.MatchLdstr("Crabulon")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ii failed");
                return;
            }
            
            ii.Index++;
            ii.Emit(OpCodes.Pop);
            ii.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Крабулон"));
            
            var j = new ILCursor(il);
            
            if (!j.TryGotoNext(i => i.MatchLdstr("Kill a Cyst in the Corruption or use a [i:{0}] in the Corruption")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses j failed");
                return;
            }
            
            j.Index++;
            j.Emit(OpCodes.Pop);
            j.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Убейте Кисту в искажении или используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в искажении"));
            
            var k = new ILCursor(il);
            
            if (!k.TryGotoNext(i => i.MatchLdstr("The corrupted colony began searching for a new breeding ground.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses k failed");
                return;
            }
            
            k.Index++;
            k.Emit(OpCodes.Pop);
            k.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Искажённая колония начала поиски нового места для размножения."));
            
            var l = new ILCursor(il);
            
            if (!l.TryGotoNext(i => i.MatchLdstr("Hive Mind")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses l failed");
                return;
            }
            
            l.Index++;
            l.Emit(OpCodes.Pop);
            l.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Разум Улья"));
            
            var m = new ILCursor(il);
            
            if (!m.TryGotoNext(i => i.MatchLdstr("Kill a Cyst in the Crimson or use a [i:{0}] in the Crimson")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses m failed");
                return;
            }
            
            m.Index++;
            m.Emit(OpCodes.Pop);
            m.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Убейте кисту в багрянце или используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в багрянце"));
            
            var n = new ILCursor(il);
            
            if (!n.TryGotoNext(i => i.MatchLdstr("The parasitic hive began searching for a new host.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses n failed");
                return;
            }
            
            n.Index++;
            n.Emit(OpCodes.Pop);
            n.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Паразитический улей начал искать нового носителя."));
            
            var o = new ILCursor(il);
            
            if (!o.TryGotoNext(i => i.MatchLdstr("The Perforators")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses o failed");
                return;
            }
            
            o.Index++;
            o.Emit(OpCodes.Pop);
            o.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Перфораторы"));
            
            var p = new ILCursor(il);
            
            if (!p.TryGotoNext(i => i.MatchLdstr("Use an [i:{0}]")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses p failed");
                return;
            }
            
            p.Index++;
            p.Emit(OpCodes.Pop);
            p.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]");
            
            var q = new ILCursor(il);
            
            if (!q.TryGotoNext(i => i.MatchLdstr("The gelatinous monstrosity achieved vengeance for its brethren.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses q failed");
                return;
            }
            
            q.Index++;
            q.Emit(OpCodes.Pop);
            q.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Желатиновое чудовище отомстило за своих собратьев."));
            
            var r = new ILCursor(il);
            
            if (!r.TryGotoNext(i => i.MatchLdstr("Slime God")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses r failed");
                return;
            }
            
            r.Index++;
            r.Emit(OpCodes.Pop);
            r.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Бог слизней"));
            
            var s = new ILCursor(il);
            
            if (!s.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] in the Snow Biome")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses s failed");
                return;
            }
            
            s.Index++;
            s.Emit(OpCodes.Pop);
            s.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в снежном биоме"));
            
            var t = new ILCursor(il);
            
            if (!t.TryGotoNext(i => i.MatchLdstr("Cryogen drifts away, carried on a freezing wind.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses t failed");
                return;
            }
            
            t.Index++;
            t.Emit(OpCodes.Pop);
            t.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Криоген уносится прочь, ледяным ветром."));
            
            var u = new ILCursor(il);
            
            if (!u.TryGotoNext(i => i.MatchLdstr("Cryogen")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses u failed");
                return;
            }
            if (!u.TryGotoNext(i => i.MatchLdstr("Cryogen")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses u failed");
                return;
            }
            
            u.Index++;
            u.Emit(OpCodes.Pop);
            u.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Криоген"));
            
            var v = new ILCursor(il);
            
            if (!v.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] in the Brimstone Crag")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses v failed");
                return;
            }
            
            v.Index++;
            v.Emit(OpCodes.Pop);
            v.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в серных скалах"));
            
            var w = new ILCursor(il);
            
            if (!w.TryGotoNext(i => i.MatchLdstr("Brimstone Elemental withdraws to the ruins of her shrine.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses w failed");
                return;
            }
            
            w.Index++;
            w.Emit(OpCodes.Pop);
            w.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Серный элементаль отступает к руинам своего святилища."));
            
            var x = new ILCursor(il);
            
            if (!x.TryGotoNext(i => i.MatchLdstr("Brimstone Elemental")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses x failed");
                return;
            }
            
            x.Index++;
            x.Emit(OpCodes.Pop);
            x.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Серный элементаль"));
            
            var y = new ILCursor(il);
            
            if (!y.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] in the Sulphuric Sea or wait for it to spawn in the Sulphuric Sea")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses y failed");
                return;
            }
            
            y.Index++;
            y.Emit(OpCodes.Pop);
            y.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в сернистом море или подождите его появление в сернистом море"));
            
            var z = new ILCursor(il);
            
            if (!z.TryGotoNext(i => i.MatchLdstr("The Aquatic Scourge swam back into the open ocean.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses z failed");
                return;
            }
            
            z.Index++;
            z.Emit(OpCodes.Pop);
            z.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Акватический бич уплыл обратно в открытый океан."));
            
            var aa = new ILCursor(il);
            
            if (!aa.TryGotoNext(i => i.MatchLdstr("Aquatic Scourge")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses aa failed");
                return;
            }
            
            aa.Index++;
            aa.Emit(OpCodes.Pop);
            aa.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Акватический бич"));
            
            var ab = new ILCursor(il);
            
            if (!ab.TryGotoNext(i => i.MatchLdstr("Use an [i:{0}] at Night")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ab failed");
                return;
            }
            
            ab.Index++;
            ab.Emit(OpCodes.Pop);
            ab.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" ночью"));
            
            var ac = new ILCursor(il);
            
            if (!ac.TryGotoNext(i => i.MatchLdstr("If you wanted a fight, you should've came more prepared.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ac failed");
                return;
            }
            
            ac.Index++;
            ac.Emit(OpCodes.Pop);
            ac.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Если вы хотели драки, вы должны были прийти более подготовленными."));
            
            var ad = new ILCursor(il);
            
            if (!ad.TryGotoNext(i => i.MatchLdstr("Calamitas")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ad failed");
                return;
            }
            if (!ad.TryGotoNext(i => i.MatchLdstr("Calamitas")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ad failed");
                return;
            }
            
            ad.Index++;
            ad.Emit(OpCodes.Pop);
            ad.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Каламитас"));
            
            var ae = new ILCursor(il);
            
            if (!ae.TryGotoNext(i => i.MatchLdstr("Kill 10 sand sharks after defeating Plantera or use a [i:{0}] in the Desert Biome")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ae failed");
                return;
            }
            
            ae.Index++;
            ae.Emit(OpCodes.Pop);
            ae.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Убейте 10 песчаных акул после победы над Плантерой или используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в пустыне"));
            
            var af = new ILCursor(il);
            
            if (!af.TryGotoNext(i => i.MatchLdstr("The apex predator of the sands disappears into the dunes...")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses af failed");
                return;
            }
            
            af.Index++;
            af.Emit(OpCodes.Pop);
            af.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Высший хищник песков исчезает в дюнах..."));
            
            var ag = new ILCursor(il);
            
            if (!ag.TryGotoNext(i => i.MatchLdstr("Great Sand Shark")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ag failed");
                return;
            }
            
            ag.Index++;
            ag.Emit(OpCodes.Pop);
            ag.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Великая песчаная акула"));
            
            var ah = new ILCursor(il);
            
            if (!ah.TryGotoNext(i => i.MatchLdstr("By killing an unknown entity in the Ocean Biome")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ah failed");
                return;
            }
            
            ah.Index++;
            ah.Emit(OpCodes.Pop);
            ah.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Убейте неизвестное существо в океане"));
            
            var ai = new ILCursor(il);
            
            if (!ai.TryGotoNext(i => i.MatchLdstr("The aquatic entities sink back beneath the ocean depths.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ai failed");
                return;
            }
            
            ai.Index++;
            ai.Emit(OpCodes.Pop);
            ai.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Водные существа погружаются в глубины океана."));
            
            var aj = new ILCursor(il);
            
            if (!aj.TryGotoNext(i => i.MatchLdstr("Leviathan")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses aj failed");
                return;
            }
            if (!aj.TryGotoNext(i => i.MatchLdstr("Leviathan")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses aj failed");
                return;
            }
            
            aj.Index++;
            aj.Emit(OpCodes.Pop);
            aj.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Левиафан"));
            
            var ak = new ILCursor(il);
            
            if (!ak.TryGotoNext(i => i.MatchLdstr("Use an [i:{0}] at Night in the Astral Biome")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ak failed");
                return;
            }
            
            ak.Index++;
            ak.Emit(OpCodes.Pop);
            ak.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" ночью или в астральном биоме"));
            
            var al = new ILCursor(il);
            
            if (!al.TryGotoNext(i => i.MatchLdstr("Astrum Aureus’ program has been executed. Initiate recall.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses al failed");
                return;
            }
            
            al.Index++;
            al.Emit(OpCodes.Pop);
            al.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Программа Аструм Ареуса выполнена. Запущенна программа возврата."));
            
            var am = new ILCursor(il);
            
            if (!am.TryGotoNext(i => i.MatchLdstr("Astrum Aureus")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses am failed");
                return;
            }
            
            am.Index++;
            am.Emit(OpCodes.Pop);
            am.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Аструм Ареус"));
            
            var an = new ILCursor(il);
            
            if (!an.TryGotoNext(i => i.MatchLdstr("Use an [i:{0}] in the Jungle Biome")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses an failed");
                return;
            }
            
            an.Index++;
            an.Emit(OpCodes.Pop);
            an.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в джунглях"));
            
            var ao = new ILCursor(il);
            
            if (!ao.TryGotoNext(i => i.MatchLdstr("HOSTILE SPECIMENS TERMINATED. INITIATE RECALL TO HOME BASE.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ao failed");
                return;
            }
            
            ao.Index++;
            ao.Emit(OpCodes.Pop);
            ao.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("ВРАЖДЕБНЫЕ СУЩНОСТИ УНИЧТОЖЕНЫ. ЗАПУЩЕНА ПРОГРАММА ВОЗВРАТА НА БАЗУ."));
            
            var ap = new ILCursor(il);
            
            if (!ap.TryGotoNext(i => i.MatchLdstr("Plaguebringer Goliath")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ap failed");
                return;
            }
            
            ap.Index++;
            ap.Emit(OpCodes.Pop);
            ap.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Разносчица чумы, Голиаф"));
            
            var aq = new ILCursor(il);
            
            if (!aq.TryGotoNext(i => i.MatchLdstr("Use an [i:{0}]")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses aq failed");
                return;
            }
            if (!aq.TryGotoNext(i => i.MatchLdstr("Use an [i:{0}]")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses aq failed");
                return;
            }
            
            aq.Index++;
            aq.Emit(OpCodes.Pop);
            aq.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]");
            
            var ar = new ILCursor(il);
            
            if (!ar.TryGotoNext(i => i.MatchLdstr("The automaton of misshapen victims went looking for the true perpetrator.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ar failed");
                return;
            }
            
            ar.Index++;
            ar.Emit(OpCodes.Pop);
            ar.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Машина бесформенных жертв отправилась на поиски истинного нарушителя."));
            
            var cz = new ILCursor(il);
            
            if (!cz.TryGotoNext(i => i.MatchLdstr("Ravager")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses cz failed");
                return;
            }
            if (!cz.TryGotoNext(i => i.MatchLdstr("Ravager")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses cz failed");
                return;
            }
            
            cz.Index++;
            cz.Emit(OpCodes.Pop);
            cz.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Разрушитель"));
            
            var at = new ILCursor(il);
            
            if (!at.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] or [i:{1}] as offering at an [i:{2}]")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses at failed");
                return;
            }
            
            at.Index++;
            at.Emit(OpCodes.Pop);
            at.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" или ") + "[i:{1}]" + EncodingCyrillic.EncodingTransform(" в качестве предложения на ") + "[i:{2}]");
            
            var au = new ILCursor(il);
            
            if (!au.TryGotoNext(i => i.MatchLdstr("The infected deity retreats to the heavens.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses au failed");
                return;
            }
            
            au.Index++;
            au.Emit(OpCodes.Pop);
            au.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Заражённое божество отступает к небесам."));
            
            var av = new ILCursor(il);
            
            if (!av.TryGotoNext(i => i.MatchLdstr("Astrum Deus")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses av failed");
                return;
            }
            
            av.Index++;
            av.Emit(OpCodes.Pop);
            av.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Аструм Деус"));
            
            var aw = new ILCursor(il);
            
            if (!aw.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] in the Hallow or Underworld Biomes")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses aw failed");
                return;
            }
            
            aw.Index++;
            aw.Emit(OpCodes.Pop);
            aw.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в освящении или в аду"));
            
            var ax = new ILCursor(il);
            
            if (!ax.TryGotoNext(i => i.MatchLdstr("The guardians must protect their goddess at all costs.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ax failed");
                return;
            }
            
            ax.Index++;
            ax.Emit(OpCodes.Pop);
            ax.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Стражи должны защищать свою богиню любой ценой."));
            
            var ay = new ILCursor(il);
            
            if (!ay.TryGotoNext(i => i.MatchLdstr("Profaned Guardians")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ay failed");
                return;
            }
            
            ay.Index++;
            ay.Emit(OpCodes.Pop);
            ay.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Осквернённые стражи"));
            
            var az = new ILCursor(il);
            
            if (!az.TryGotoNext(i => i.MatchLdstr("Use [i:{0}] in the Jungle Biome")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses az failed");
                return;
            }
            
            az.Index++;
            az.Emit(OpCodes.Pop);
            az.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в джунглях"));
            
            var ba = new ILCursor(il);
            
            if (!ba.TryGotoNext(i => i.MatchLdstr("The failed experiment returns to its reproductive routine.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ba failed");
                return;
            }
            
            ba.Index++;
            ba.Emit(OpCodes.Pop);
            ba.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Неудачный эксперимент вернулся к своему репродуктивному распорядку."));
            
            var bb = new ILCursor(il);
            
            if (!bb.TryGotoNext(i => i.MatchLdstr("Dragonfolly")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bb failed");
                return;
            }
            if (!bb.TryGotoNext(i => i.MatchLdstr("Dragonfolly")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bb failed");
                return;
            }
            
            bb.Index++;
            bb.Emit(OpCodes.Pop);
            bb.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Псевдодракон"));
            
            var bc = new ILCursor(il);
            
            if (!bc.TryGotoNext(i => i.MatchLdstr("Use either [i:{0}] or [i:{1}] in the Hallow or Underworld Biomes")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bc failed");
                return;
            }
            
            bc.Index++;
            bc.Emit(OpCodes.Pop);
            bc.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте либо ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(", либо ") + "[i:{1}]" + EncodingCyrillic.EncodingTransform("в освящении или в аду"));
            
            var bd = new ILCursor(il);
            
            if (!bd.TryGotoNext(i => i.MatchLdstr("The Profaned Goddess vanishes in a burning blaze.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bd failed");
                return;
            }
            
            bd.Index++;
            bd.Emit(OpCodes.Pop);
            bd.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Осквернённая Богиня исчезает в горящем пламени."));
            
            var be = new ILCursor(il);
            
            if (!be.TryGotoNext(i => i.MatchLdstr("Providence")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses be failed");
                return;
            }
            if (!be.TryGotoNext(i => i.MatchLdstr("Providence")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses be failed");
                return;
            }
            
            be.Index++;
            be.Emit(OpCodes.Pop);
            be.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Провиденс"));
            
            var bf = new ILCursor(il);
            
            if (!bf.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] in the Dungeon")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bf failed");
                return;
            }
            
            bf.Index++;
            bf.Emit(OpCodes.Pop);
            bf.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в темнице"));
            
            var bg = new ILCursor(il);
            
            if (!bg.TryGotoNext(i => i.MatchLdstr("The rift in time and space has moved away from your reach.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bg failed");
                return;
            }
            
            bg.Index++;
            bg.Emit(OpCodes.Pop);
            bg.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Разлом во времени и пространстве удалился вдали от вас."));
            
            var bh = new ILCursor(il);
            
            if (!bh.TryGotoNext(i => i.MatchLdstr("Ceaseless Void")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bh failed");
                return;
            }
            
            bh.Index++;
            bh.Emit(OpCodes.Pop);
            bh.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Нескончаемая пустота"));
            
            var bi = new ILCursor(il);
            
            if (!bi.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] in Space")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bi failed");
                return;
            }
            
            bi.Index++;
            bi.Emit(OpCodes.Pop);
            bi.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в космосе"));
            
            var bj = new ILCursor(il);
            
            if (!bj.TryGotoNext(i => i.MatchLdstr("Storm Weaver hid itself once again within the stormfront.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bj failed");
                return;
            }
            
            bj.Index++;
            bj.Emit(OpCodes.Pop);
            bj.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Штормовой Ткач снова спрятался в грозовом фронте."));
            
            var bk = new ILCursor(il);
            
            if (!bk.TryGotoNext(i => i.MatchLdstr("Storm Weaver")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bk failed");
                return;
            }
            
            bk.Index++;
            bk.Emit(OpCodes.Pop);
            bk.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Штормовой Ткач"));
            
            var bl = new ILCursor(il);
            
            if (!bl.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] in the Underworld")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bl failed");
                return;
            }
            
            bl.Index++;
            bl.Emit(OpCodes.Pop);
            bl.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в аду"));
            
            var bm = new ILCursor(il);
            
            if (!bm.TryGotoNext(i => i.MatchLdstr("The Devourer's assassin has finished its easy task.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bm failed");
                return;
            }
            
            bm.Index++;
            bm.Emit(OpCodes.Pop);
            bm.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Убийца Пожирателя выполнил свою лёгкую задачу."));
            
            var bn = new ILCursor(il);
            
            if (!bn.TryGotoNext(i => i.MatchLdstr("Signus")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bn failed");
                return;
            }
            if (!bn.TryGotoNext(i => i.MatchLdstr("Signus")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bn failed");
                return;
            }
            
            bn.Index++;
            bn.Emit(OpCodes.Pop);
            bn.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Сигнус"));
            
            var bo = new ILCursor(il);
            
            if (!bo.TryGotoNext(i => i.MatchLdstr("Kill 30 phantom spirits or use a [i:{0}] in the Dungeon")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bo failed");
                return;
            }
            
            bo.Index++;
            bo.Emit(OpCodes.Pop);
            bo.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Убейте 30 фантомных духов или используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в темнице"));
            
            var bp = new ILCursor(il);
            
            if (!bp.TryGotoNext(i => i.MatchLdstr("The volatile spirits disperse throughout the depths of the dungeon.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bp failed");
                return;
            }
            
            bp.Index++;
            bp.Emit(OpCodes.Pop);
            bp.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Неустойчивые духи рассеиваются по глубинам подземелья."));
            
            var bq = new ILCursor(il);
            
            if (!bq.TryGotoNext(i => i.MatchLdstr("Polterghast")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bq failed");
                return;
            }
            if (!bq.TryGotoNext(i => i.MatchLdstr("Polterghast")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bq failed");
                return;
            }
            
            bq.Index++;
            bq.Emit(OpCodes.Pop);
            bq.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Полтергаст"));
            
            var br = new ILCursor(il);
            
            if (!br.TryGotoNext(i => i.MatchLdstr("Defeat the Acid Rain event post-Polterghast or fish using a [i:{0}] in the Sulphurous Sea")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses br failed");
                return;
            }
            
            br.Index++;
            br.Emit(OpCodes.Pop);
            br.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Одолейте событие Кислотный дождь после победы над Полтергастом или выловите с помощью ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в сернистом море"));
            
            var bs = new ILCursor(il);
            
            if (!bs.TryGotoNext(i => i.MatchLdstr("The old duke disappears amidst the acidic downpour.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bs failed");
                return;
            }
            
            bs.Index++;
            bs.Emit(OpCodes.Pop);
            bs.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Старый Герцог исчезает посреди кислотного ливня."));
            
            var bu = new ILCursor(il);
            
            if (!bu.TryGotoNext(i => i.MatchLdstr("Old Duke")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bu failed");
                return;
            }
            
            bu.Index++;
            bu.Emit(OpCodes.Pop);
            bu.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Старый Герцог"));
            
            var bv = new ILCursor(il);
            
            if (!bv.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}]")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bv failed");
                return;
            }
        
            bv.Index++;
            bv.Emit(OpCodes.Pop);
            bv.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]");
            
            var bw = new ILCursor(il);
            
            if (!bw.TryGotoNext(i => i.MatchLdstr("The Devourer of Gods has slain everyone and feasted on their essence.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bw failed");
                return;
            }
            
            bw.Index++;
            bw.Emit(OpCodes.Pop);
            bw.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Пожиратель Богов убил всех и пировал их сущностью."));
            
            var bx = new ILCursor(il);
            
            if (!bx.TryGotoNext(i => i.MatchLdstr("Devourer of Gods")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bx failed");
                return;
            }
            
            bx.Index++;
            bx.Emit(OpCodes.Pop);
            bx.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Пожиратель Богов"));
            
            var by = new ILCursor(il);
            
            if (!by.TryGotoNext(i => i.MatchLdstr("Use a [i:{0}] in the Jungle Biome")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses by failed");
                return;
            }
            
            by.Index++;
            by.Emit(OpCodes.Pop);
            by.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]" + EncodingCyrillic.EncodingTransform(" в джунглях"));
            
            var bz = new ILCursor(il);
            
            if (!bz.TryGotoNext(i => i.MatchLdstr("Yharon found you too weak to stay near your gravestone.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses bz failed");
                return;
            }
            
            bz.Index++;
            bz.Emit(OpCodes.Pop);
            bz.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Ярон считает вас слишком слабым, чтобы оставаться с вашим надгробием."));
            
            var ca = new ILCursor(il);
            
            if (!ca.TryGotoNext(i => i.MatchLdstr("Yharon")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ca failed");
                return;
            }
            if (!ca.TryGotoNext(i => i.MatchLdstr("Yharon")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ca failed");
                return;
            }
            
            ca.Index++;
            ca.Emit(OpCodes.Pop);
            ca.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Ярон"));
            
            var cb = new ILCursor(il);
            
            if (!cb.TryGotoNext(i => i.MatchLdstr("Use an [i:{0}]")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses cb failed");
                return;
            }
            if (!cb.TryGotoNext(i => i.MatchLdstr("Use an [i:{0}]")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses cb failed");
                return;
            }
            if (!cb.TryGotoNext(i => i.MatchLdstr("Use an [i:{0}]")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses cb failed");
                return;
            }
            
            cb.Index++;
            cb.Emit(OpCodes.Pop);
            cb.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Используйте ") + "[i:{0}]");
            
            var cd = new ILCursor(il);
            
            if (!cd.TryGotoNext(i => i.MatchLdstr("Please don't waste my time.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses cd failed");
                return;
            }
            
            cd.Index++;
            cd.Emit(OpCodes.Pop);
            cd.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Пожалуйста, не тратьте моё время."));
            
            var ce = new ILCursor(il);
            
            if (!ce.TryGotoNext(i => i.MatchLdstr("Supreme Calamitas")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyAddCalamityBosses ce failed");
                return;
            }
            
            ce.Index++;
            ce.Emit(OpCodes.Pop);
            ce.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Высшая Каламитас"));
        }
        
        private static void Calamity_ModifyModifyGetTextByPageSunkenSeaGUI(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Preserved for millennia, a paradise for the living beings who sought shelter in prehistoric seas. They remain untouched by evolution, save for their adaptations to the oxygen starved waters and dim crystals, continuing to thrive. One mystery which continues to escape my understanding however, is how large some of the creatures have become. There is a blatant lack of nutrition and oxygen in the caves, and yet...")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPageSunkenSeaGUI a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Сохранившийся на протяжении тысячелетий рай для живых существ, искавших убежища в доисторических морях. Они остаются не тронутыми эволюцией, за исключением их адаптации к необогащенной воздухом воде и тусклым кристаллам, продолжая процветать. Однако одна загадка, которая продолжает ускользать от моего понимания, заключается в том, насколько большими стали некоторые из этих существ. В пещерах явно не хватает питания и кислорода, и всё же..."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("A specimen which has developed a grand size, and inexplicably, impressive psychic abilities. What is most curious is its strong connection to its lesser kin. Without any noticeable communication, when it comes under threat, other mollusks rally to its aggressor and begin attacking. Is this perhaps the very first signs of a higher life form, the evolutionary link hidden away in the sunken sea? Or a self sacrificial fluke, which would lead to their destruction if they inhabited any area other than these pacified caverns.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPageSunkenSeaGUI b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Образец, который развил грандиозные размеры и необъяснимо-впечатляющие телепатические способности. Что самое любопытное, так это его сильная связь со своими меньшими родственниками. Когда он оказывается под угрозой, другие моллюски окружают своего агрессора и начинают атаковать. Может быть, это самые первые признаки высшей формы жизни, эволюционное звено, скрытое в затерянном море? Или самоотверженная случайность, которая привела бы к уничтожению, если они населяли любую область, кроме этих умиротворённых пещер."));
        
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr("The marine life in these caves do have eyes though they are barely functional, dulled by lack of use and milky white upon observation. On their tough, gnarled hides, crystals find an easy purchase, and grow in great numbers, providing the creatures protection. Perhaps another adaptation to the life they have adopted. The most striking wonder is within their bodies. In specimens dissected, I have noticed that the mineral is buried into their very digestive systems, and perhaps, through some chemical process, pass nutrients into their sluggish hosts. A peculiar yet entirely beneficial interaction.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPageSunkenSeaGUI c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("У морских обитателей в этих пещерах есть глаза-рудименты, внешне они молочно-белые. На их жёстких узловатых шкурах кристаллы растут в большом количестве, обеспечивая существам защиту. Возможно, это ещё одна адаптация к жизни, которую они приняли. Но самое поразительное чудо — внутренности их тел. В образцах, подвергнутых вскрытию, я заметил, что минерал находится в самой их пищеварительной системе и, возможно, через какой-то химический процесс передаёт питательные вещества их вялым хозяевам. Своеобразное, но совершенно благотворное взаимодействие."));
        }
        
        private static void Calamity_ModifyModifyGetTextByPageSnowBiomeGUI(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("A freezing tundra, where only creatures entirely adapted to the subzero temperatures exist and thrive. It is a shocking transition from the forests of the purity and the sun baked desert. A climate like this should not exist naturally in this part of the world with ease. The weather patterns seem to shift unnaturally arounds the skies of these icy plains. There is likely a reason for this, which necessitates further research.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPageSnowBiomeGUI a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Холодная тундра, где существуют и процветают существа, полностью приспособленные к минусовым температурам. Это шокирующий переход от чистых лесов и выжженной солнцем пустыни. Климат, подобный этому, не должен существовать естественно. Погодные условия на этих ледяных равнинах, кажется, неестественно меняются. Вероятно, этому есть причина, которая требует дальнейших исследований."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("I am not the only singular being to inhabit this biome. Once before, the Archmage who opposed the Lord resided here, cloaked by constant artificial blizzards of his own creation, which no longer fall. He likely chose this place as a conduit for research into his ice spells, and extended the period of time that this place remained frozen. Deep underground my research and materials lay well protected, but above in the natural storms there are traces of the prison of ice he resides in, still haunting its place of creation.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPageSnowBiomeGUI b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Я не единственное разумное существо, находившееся в этом биоме. До этого Архимаг, противостоявший Лорду, жил здесь. Скорее всего, он выбрал это место для изучения ледяных заклятий, одно из которых — нескончаемые ледяные бури. Его действия поддерживали биом в глубокой заморозке. Глубоко под землёй мои исследования хорошо защищены, но снаружи, в естественных бурях, есть следы ледяной тюрьмы, в которой он пребывает по сей день, всё ещё бродящей в месте своего создания."));
        
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr("Intriguing. Though embedded deep into the caverns of ice and worn from centuries of frost and meltwater, I have uncovered several mechanisms which once filled the tunnels here. The ingenuity present is remarkable, and I have found parallels within my own work, as well as devices even I have something to learn from. From where do these come? Why machinery so complex in so sparse and dreary a habitat? Perhaps, they are related to the unnatural conditions.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPageSnowBiomeGUI c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Интригующе. Я нашёл механизмы, когда-то заполнявшие туннели. Они находились в ледяных пещерах, поломанные из-за веков во льду и талой воды. Мастерство исполнения поражает. Я нашёл схожести с моими работами, а также узнал что-то новое. Но кто их создал? Почему настолько сложные машины находятся в такой скудной и унылой среде обитания. Возможно, именно они виноваты в настолько неестественных условиях."));
        }
        
        private static void Calamity_ModifyModifyGetTextByPagePlanetoidGUI(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Hung low in orbit, masses of ground and various parts of the world provide a secluded and distant point for research. Undeniably optimal for the science of astronomy and otherwise. In my labs here I grow many things, testing their limits against the cold and vacuum of the stratosphere. Though not many survive, the existence of certain creatures here, confirm the capabilities of life simply given more time.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPagePlanetoidGUI a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Висящие низко на орбите массы земли и другие структуры мира, обеспечивают укромное и отдалённое место для исследований. Это оптимальный вариант для изучения астрономии и других наук. В моих лабораториях я выращиваю разные растения и тестирую их способность к выживанию в условиях холода и вакуума стратосферы. Несмотря на то, что многие растения погибают, существование жизни здесь подтверждается. Просто нужно дать этой жизни больше времени на развитие."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("The bloated cosmic worm, though I understand why the Lord decides to employ it given he can control it, is a disgusting existence. However the idea of creating an armor suited to it in every way, was an offer I could not refuse. Forged from the cosmic steel of my own creation, it resists nearly any attack, yet allows the creature the same flexibility it would have without it, as well as augmenting its dimensional abilities. I remain pleased with the result.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPagePlanetoidGUI b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Раздутый отвратительный космический червь. Впрочем, я понимаю, почему Лорд его использует, ведь он может его контролировать... Идея создания брони, подходящей ему во всех отношениях, была предложением, от которого я не мог отказаться. Выкованная из космической стали, моего собственного создания, броня защищала практически от любой атаки. А также она не уменьшает изначальной гибкости существа, а ещё увеличивает пространственные способности. Я доволен результатом."));
        
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr("I do not care much for the interstellar, or the cosmos. Though I have traversed it, there is still plenty in my own world to manage and discover at this time. Even if I once inhabited a different planet, the Lord's wishes that I provide him machinery were the only condition that I needed to leave it and settle elsewhere. Once I have discovered and dissected every part of this place, perhaps then, I could look up towards the macroscopic.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPagePlanetoidGUI c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Меня мало волнует космос. Да, я путешествовал по нему, но сейчас мне достаточно работы по изучению собственного мира. Даже если бы я когда-то жил на другой планете, одного желания Лорда получать мои технологии было бы достаточно, чтобы я улетел с неё сюда. Если же я когда-нибудь полностью изучу каждый кусочек этого места, то тогда, возможно, я обращу свой взор наверх, в сторону макроскопического."));
         }
        
        private static void Calamity_ModifyModifyGetTextByPageJungleGUI(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("As I record this, it would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately these labs provide everything I need in my research and more. There is no need to ever visit the surface, save for summons on the Lord's orders.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPageJungleGUI a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Поскольку я записываю это, не будет ошибкой назвать джунгли центром этой планеты. Всё сосредоточено вокруг них, но мало кто знает об этом. Я испытываю немалое беспокойство, видя неудобные, грубые формы живых существ, которые живут в них наверху. К счастью, эти лаборатории обеспечивают всё, что мне нужно в моих исследованиях и не только. Нет никакой необходимости когда-либо посещать поверхность, за исключением вызова по приказу Лорда."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("Mechanically augmented, the Queen Bee which I had prior experimented on was theoretically a perfect host for the plague virus. When the first sign of the technology bonding with the creature began however, the problems also showed immediately. The mind of the insect fought the control of the nanotechnology, nothing like the simpler creatures I had used as test subjects. It grew increasingly violent, and only once subdued did it receive simple orders. However, if we were to utilize it at all, there is no other way than to let it roam free entirely. I will consider this further.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPageJungleGUI b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Механически усиленная королева пчёл, над которой я ранее экспериментировал, теоретически была идеальным разносчиком чумы. Однако, когда технологии начали менять сущность пчелы, начались проблемы. Разум насекомого противостоял нанотехнологиям, такого раньше не происходило. Она выросла невероятно жестокой и почти не подчинялась приказам. Однако, если мы хотим использовать её, нет другого способа, кроме как позволить ей свободно разгуливать. Я продожлу изучать это дальше."));
        
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr("A virus, capable of devouring and converting almost anything. And nanotechnology, constructed painstakingly for the sake of control. Development was swift, and every piece fell into place almost eerily, forming an abhorrent existence. I struggle to think of practical applications which would be friendly to common life forms. However, it is not a major concern. Many were hesitant to continue its creation, but I granted them leave if they desired. I would have no need for any who were not entirely as dedicated as my machines.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyModifyGetTextByPageJungleGUI c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Вирус, способный пожирать и превращать практически всё. И тщательно сделанная нанотехнология контроля. Превращение шло пугающе быстро, создавая мерзкую тварь. Я стараюсь сделать так, чтобы она была дружелюбна к обычным формам жизни. Однако это не главная проблема. Многие не решались продолжать создание, но я разрешил уйти, если они пожелают. Я не нуждался ни в ком, кто не был бы так же предан делу, как мои машины."));
        }
        
        private static void Calamity_ModifyDrawAcidRain(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Acid Rain")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyDrawAcidRain a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Кислотный дождь"));
         }
        
        private static void Ua_ModifyUpdateAccessory(ILContext il)
        {
            var a = new ILCursor(il);
            
            if (!a.TryGotoNext(i => i.MatchLdstr(" isn't worthy.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyUpdateAccessory a failed");
                return;
            }
            
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" не достоин."));
        }
        
        private static void Ua_ModifyKillPlayer(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" is food for the Wyrms.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyKillPlayer a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" стал пищей для змей."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("Oxygen failed to reach ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyKillPlayer b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Не хватило кислорода для "));
        
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr(" from the depths of the Abyss.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyKillPlayer c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" из глубин бездны."));
        
            var d = new ILCursor(il);
        
            if (!d.TryGotoNext(i => i.MatchLdstr(" was defeated.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyKillPlayer d failed");
                return;
            }
        
            d.Index++;
            d.Emit(OpCodes.Pop);
            d.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был повержен."));
        
            var e = new ILCursor(il);
        
            if (!e.TryGotoNext(i => i.MatchLdstr(" was chilled to the bone by the frigid environment.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyKillPlayer e failed");
                return;
            }
        
            e.Index++;
            e.Emit(OpCodes.Pop);
            e.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" промёрз до костей из-за холодной окружающей среды."));
        
            var f = new ILCursor(il);
        
            if (!f.TryGotoNext(i => i.MatchLdstr(" was consumed by his inner hatred.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyKillPlayer f failed");
                return;
            }
        
            f.Index++;
            f.Emit(OpCodes.Pop);
            f.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был поглощён своей внутренней ненавистью."));
        
            var g = new ILCursor(il);
        
            if (!g.TryGotoNext(i => i.MatchLdstr(" was consumed by her inner hatred.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyKillPlayer g failed");
                return;
            }
        
            g.Index++;
            g.Emit(OpCodes.Pop);
            g.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" была поглощена своей внутренней ненавистью."));
        
            var h = new ILCursor(il);
        
            if (!h.TryGotoNext(i => i.MatchLdstr(" failed the challenge at hand.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyKillPlayer h failed");
                return;
            }
        
            h.Index++;
            h.Emit(OpCodes.Pop);
            h.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" не справился с испытанием."));
        
            var ii = new ILCursor(il);
        
            if (!ii.TryGotoNext(i => i.MatchLdstr(" was destroyed by a mysterious force.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyKillPlayer ii failed");
                return;
            }
        
            ii.Index++;
            ii.Emit(OpCodes.Pop);
            ii.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был уничтожен таинственной силой."));
         }
        
        private static void Ua_ModifyPreKill(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr(" downed too many shots.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" выпил слишком много напитков."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("'s liver failed.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" отказала печень."));
        
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr(" was charred by the brimstone inferno.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был обуглен серным пламенем."));
        
            var d = new ILCursor(il);
        
            if (!d.TryGotoNext(i => i.MatchLdstr("'s soul was released by the lava.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill d failed");
                return;
            }
        
            d.Index++;
            d.Emit(OpCodes.Pop);
            d.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" душа была освобождена лавой."));
        
            var e = new ILCursor(il);
        
            if (!e.TryGotoNext(i => i.MatchLdstr("'s soul was extinguished.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill e failed");
                return;
            }
        
            e.Index++;
            e.Emit(OpCodes.Pop);
            e.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" душа была погашена."));
        
            var f = new ILCursor(il);
        
            if (!f.TryGotoNext(i => i.MatchLdstr(" was melted by the toxic waste.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill f failed");
                return;
            }
        
            f.Index++;
            f.Emit(OpCodes.Pop);
            f.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был расплавлен токсичными отходами."));
        
            var g = new ILCursor(il);
        
            if (!g.TryGotoNext(i => i.MatchLdstr(" disintegrated into ashes.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill g failed");
                return;
            }
        
            g.Index++;
            g.Emit(OpCodes.Pop);
            g.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" рассыпался в прах."));
        
            var h = new ILCursor(il);
        
            if (!h.TryGotoNext(i => i.MatchLdstr(" was turned to ashes by the Profaned Goddess.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill h failed");
                return;
            }
        
            h.Index++;
            h.Emit(OpCodes.Pop);
            h.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был обращён Осквернённой богиней в пепел."));
        
            var ii = new ILCursor(il);
        
            if (!ii.TryGotoNext(i => i.MatchLdstr(" fell prey to their sins.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill ii failed");
                return;
            }
        
            ii.Index++;
            ii.Emit(OpCodes.Pop);
            ii.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" пал жертвой своих грехов."));
        
            var j = new ILCursor(il);
        
            if (!j.TryGotoNext(i => i.MatchLdstr("'s spirit was turned to ash.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill j failed");
                return;
            }
        
            j.Index++;
            j.Emit(OpCodes.Pop);
            j.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" дух превратился в пепел."));
        
            var k = new ILCursor(il);
        
            if (!k.TryGotoNext(i => i.MatchLdstr(" became a blood geyser.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill k failed");
                return;
            }
        
            k.Index++;
            k.Emit(OpCodes.Pop);
            k.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" стал кровавым гейзером."));
        
            var l = new ILCursor(il);
        
            if (!l.TryGotoNext(i => i.MatchLdstr(" was crushed by the pressure.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill l failed");
                return;
            }
        
            l.Index++;
            l.Emit(OpCodes.Pop);
            l.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был раздавлен давлением."));
        
            var m = new ILCursor(il);
        
            if (!m.TryGotoNext(i => i.MatchLdstr("'s lungs collapsed.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill m failed");
                return;
            }
        
            m.Index++;
            m.Emit(OpCodes.Pop);
            m.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" лёгкие отказали."));
        
            var n = new ILCursor(il);
        
            if (!n.TryGotoNext(i => i.MatchLdstr(" was consumed by the black flames.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill n failed");
                return;
            }
        
            n.Index++;
            n.Emit(OpCodes.Pop);
            n.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был поглощён чёрным пламенем."));
        
            var o = new ILCursor(il);
        
            if (!o.TryGotoNext(i => i.MatchLdstr("'s flesh was melted by the plague.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill o failed");
                return;
            }
        
            o.Index++;
            o.Emit(OpCodes.Pop);
            o.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" плоть была расплавлена чумой."));
        
            var p = new ILCursor(il);
        
            if (!p.TryGotoNext(i => i.MatchLdstr(" didn't vaccinate.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill p failed");
                return;
            }
        
            p.Index++;
            p.Emit(OpCodes.Pop);
            p.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" не сделал прививок."));
        
            var q = new ILCursor(il);
        
            if (!q.TryGotoNext(i => i.MatchLdstr("'s infection spread too far.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill q failed");
                return;
            }
        
            q.Index++;
            q.Emit(OpCodes.Pop);
            q.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" инфекция распространилась слишком сильно."));
        
            var r = new ILCursor(il);
        
            if (!r.TryGotoNext(i => i.MatchLdstr("'s skin was replaced by the astral virus.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill r failed");
                return;
            }
        
            r.Index++;
            r.Emit(OpCodes.Pop);
            r.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" кожа была заменена астральным вирусом."));
        
            var s = new ILCursor(il);
        
            if (!s.TryGotoNext(i => i.MatchLdstr(" was incinerated by lunar rays.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill s failed");
                return;
            }
        
            s.Index++;
            s.Emit(OpCodes.Pop);
            s.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был испепелён лунными лучами."));
        
            var t = new ILCursor(il);
        
            if (!t.TryGotoNext(i => i.MatchLdstr(" vaporized into thin air.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill t failed");
                return;
            }
        
            t.Index++;
            t.Emit(OpCodes.Pop);
            t.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" растворился в воздухе."));
        
            var u = new ILCursor(il);
        
            if (!u.TryGotoNext(i => i.MatchLdstr("'s life was completely converted into mana.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill u failed");
                return;
            }
        
            u.Index++;
            u.Emit(OpCodes.Pop);
            u.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" здоровье было полностью преобразовано в ману."));
        
            var v = new ILCursor(il);
        
            if (!v.TryGotoNext(i => i.MatchLdstr(" succumbed to alcohol sickness.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill v failed");
                return;
            }
        
            v.Index++;
            v.Emit(OpCodes.Pop);
            v.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" поддался алкогольной болезни."));
        
            var w = new ILCursor(il);
        
            if (!w.TryGotoNext(i => i.MatchLdstr(" was summoned too soon.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyPreKill w failed");
                return;
            }
        
            w.Index++;
            w.Emit(OpCodes.Pop);
            w.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform(" был призван слишком рано."));
        }
        
        private static void Calamity_ModifyGetTextByPageHellGUI(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("The entire landscape is a constant source of geothermal energy, and heat for a forge. If it was not entirely uninhabitable save for demons and spirits, I would conduct much more of my research in the bowels of the earth. Where I have actively chosen not to settle however, is in the crags of the underworld. There, the magma is... uncooperative and far more corrosive than should be possible, as it is saturated with cursed, twisted souls, courtesy of that Witch.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyGetTextByPageHellGUI a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Весь природный ландшафт — постоянный источник геотермальной энергии и тепла для кузни. Если бы он не был совсем необитаемым, за исключением демонов и духов, я бы проводил больше исследований в недрах земли. Где я точно ни поселился бы, так это в скалах ада. Магма там... 'несговорчива' и агрессивна, намного больше, чем это возможно. Всё из-за того, что она пропиталась проклятыми тёмными душами, любезно предоставленными этой Ведьмой."));
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("A blade completely inundated with my surroundings during the time of its creation. It was tempered by the fires which are fueled by spirits, and formed in the magma I draw into my laboratories. Its cutting edge, unparalleled, though its reach is limited making general usage questionable. I would consider it my very first foray into work for the sake of craftsmanship and art. If I was born synthetically, any creation which leads one to question whether I was, is a creation I may be proud of. It shows that I can after all, be graced by a muse.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyGetTextByPageHellGUI b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Меч, полностью окружённый моим вниманием во время создания. Он сформировался в магме, а закалён огнём душ. Его лезвие — непревзойдённое, хотя его дальность ограничена, что делает общее применение сомнительным. Я думаю, что это моя первая работа, сделанная во имя искусства и мастерства. Если я был рождён синтетически, то любое моё творение, вызывающие вопрос: «Был ли я создан?» — результат, которым можно гордиться. Это доказывает, что я всё же могу быть удостоенным музы."));
        
            var c = new ILCursor(il);
        
            if (!c.TryGotoNext(i => i.MatchLdstr("What a terrible abomination and yet an enticing subject. Not unlike the fusion of spirits which haunts the dungeons, this entity is formed not of one, but a multitude of sinners. What holds different for it however, is that the limitations caused by the artificiality of the dungeon's existence do not apply to it. It is the laws of hell which brought them together into a single overlord of the underworld. And when an innocent life is sacrificed... Their hunger, which appears to be in tune with the afterlife, surges.")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyGetTextByPageHellGUI c failed");
                return;
            }
        
            c.Index++;
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Какое ужасное существо, но всё же интересное с научной точки зрения. В отличие от сплава душ темницы, эта сущность была сформирована не из одного грешника, а из многих. Ещё одно отличие заключается в том, что ограничения, вызванные искусственным происхождением темницы, неприменимы к нему. Именно законы Ада свели их вместе в единого владыку подземного мира. И когда невинная жизнь приносится в жертву... Их голод, который, кажется, является частью загробной жизни, нарастает."));
        }
        
        private static void Ua_ModifyHandleMouseInteraction(ILContext il)
        {
            var a = new ILCursor(il);
        
            if (!a.TryGotoNext(i => i.MatchLdstr("Rage: {0} / {1}")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyHandleMouseInteraction a failed");
                return;
            }
        
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Ярость") + ": {0} / {1}");
        
            var b = new ILCursor(il);
        
            if (!b.TryGotoNext(i => i.MatchLdstr("Adrenaline: {0} / {1}")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Ua_ModifyHandleMouseInteraction b failed");
                return;
            }
        
            b.Index++;
            b.Emit(OpCodes.Pop);
            b.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Адреналин") + ": {0} / {1}");
        }
        
        private static void Calamity_ModifyDrawStealth(ILContext il)
        {
            var a = new ILCursor(il);

            if (!a.TryGotoNext(i => i.MatchLdstr("Stealth: ")))
            {
                CalamityRuTranslate.Instance.Logger.Warn("IL edit Calamity_ModifyDrawStealth a failed");
                return;
            }
            
            a.Index++;
            a.Emit(OpCodes.Pop);
            a.Emit(OpCodes.Ldstr, EncodingCyrillic.EncodingTransform("Скрытность: "));
        }
        
        #endregion

        private static void UnloadIL()
        {
            #region Calamity Unload IL

            if (HandleMouseInteraction != null) ModifyHandleMouseInteraction -= Ua_ModifyHandleMouseInteraction;
            if (DrawAcidRain != null) ModifyDrawAcidRain -= Calamity_ModifyDrawAcidRain;
            if (DrawStealth != null) ModifyDrawStealth -= Calamity_ModifyDrawStealth;
            if (PreKill != null) ModifyPreKill -= Ua_ModifyPreKill;
            if (KillPlayer != null) ModifyKillPlayer -= Ua_ModifyKillPlayer;
            if (UpdateAccessory != null) ModifyUpdateAccessory -= Ua_ModifyUpdateAccessory;
            if (ChooseDialogue != null) ModifyChooseDialogue -= Ua_ModifyChooseDialogue;
            if (GetTextByPageHellGUI != null) ModifyGetTextByPageHellGUI -= Calamity_ModifyGetTextByPageHellGUI;
            if (GetTextByPageJungleGUI != null) ModifyGetTextByPageJungleGUI -= Calamity_ModifyModifyGetTextByPageJungleGUI;
            if (GetTextByPagePlanetoidGUI != null) ModifyGetTextByPagePlanetoidGUI -= Calamity_ModifyModifyGetTextByPagePlanetoidGUI;
            if (GetTextByPageSnowBiomeGUI != null) ModifyGetTextByPageSnowBiomeGUI -= Calamity_ModifyModifyGetTextByPageSnowBiomeGUI;
            if (GetTextByPageSunkenSeaGUI != null) ModifyGetTextByPageSunkenSeaGUI -= Calamity_ModifyModifyGetTextByPageSunkenSeaGUI;
            if (AddCalamityBosses != null) ModifyAddCalamityBosses -= Ua_ModifyAddCalamityBosses;
            if (SetChatButtonsFAP != null) ModifySetChatButtonsFAP -= Calamity_ModifySetChatButtonsFAP;
            if (SetChatButtonsSEAHOE != null) ModifySetChatButtonsSEAHOE -= Calamity_ModifySetChatButtonsSEAHOE;
            if (SetChatButtonsTHIEF != null) ModifySetChatButtonsTHIEF -= Calamity_ModifySetChatButtonsTHIEF;
            if (UseItemArmageddon != null) ModifyUseItemArmageddon -= Ua_ModifyModifyUseItemArmageddon;
            if (UseItemDeath != null) ModifyUseItemDeath -= Ua_ModifyModifyUseItemDeath;
            if (UseItemDefiledRune != null) ModifyUseItemDefiledRune -= Ua_ModifyModifyUseItemDefiledRune;
            if (UseItemRevenge != null) ModifyUseItemRevenge -= Ua_ModifyModifyUseItemRevenge;
            if (OnConsumeItemAstralInjection != null) ModifyOnConsumeItemAstralInjection -= Ua_ModifyOnConsumeItemAstralInjection;
            if (ShootThornBlossom != null) ModifyShootThornBlossom -= Ua_ModifyShootThornBlossom;
            if (ShootThornLucrecia != null) ModifyShootThornLucrecia -= Ua_ModifyShootThornLucrecia;
            if (ShootBloodBoiler != null) ModifyShootBloodBoiler -= Ua_ModifyShootBloodBoiler;
            if (ShootMolecularManipulator != null) ModifyMolecularManipulator -= Ua_ModifyMolecularManipulator;
            if (ShootNullificationRifle != null) ModifyShootNullificationRifle -= Ua_ModifyShootNullificationRifle;
            if (OnHitPlayerDevourerofGodsHead != null) ModifyOnHitPlayerDevourerofGodsHead -= Ua_ModifyOnHitPlayerDevourerofGodsHead;
            if (OnHitPlayerDevourerofGodsHeadS != null) ModifyOnHitPlayerDevourerofGodsHeadS -= Ua_ModifyOnHitPlayerDevourerofGodsHeadS;
            if (ModifyHitPlayerFearlessGoldfishWarrior != null) ModifyModifyHitPlayerFearlessGoldfishWarrior -= Ua_ModifyModifyHitPlayerFearlessGoldfishWarrior;
            if (GetChatFAP != null) ModifyGetChatFAP -= Ua_ModifyGetChatFAP;
            if (AIHealOrbProv != null) ModifyAIHealOrbProv -= Ua_ModifyAIHealOrbProv;
            if (AIHolyBurnOrb != null) ModifyAIHolyBurnOrb -= Ua_ModifyAIHolyBurnOrb;
            if (AIChibiiDoggo != null) ModifyAIChibiiDoggo -= Ua_ModifyAIChibiiDoggo;
            if (SpawnDoggo != null) ModifySpawnDoggo -= Ua_ModifySpawnDoggo;
            if (BedRightClick != null) ModifyBedRightClick -= Ua_ModifyBedRightClick;
            if (NewRightClick != null) ModifyNewRightClick -= Ua_ModifyNewRightClick;
            if (AddCalamityInvasions != null) ModifyAddCalamityInvasions -= Ua_ModifyAddCalamityInvasions;
            if (CensusSupport != null) ModifyCensusSupport -= Ua_ModifyCensusSupport;
            if (BossLootRavager != null) ModifyBossLootRavager -= Ua_ModifyBossLootRavager;
            if (BossLootCalamitasRun3 != null) ModifyBossLootCalamitasRun3 -= Ua_ModifyBossLootCalamitasRun3;
            if (DrawBossHPUI != null) ModifyDrawBossHPUI -= Ua_ModifyDrawBossHPUI;
            if (DrawOpenAnim != null) ModifyDrawOpenAnim -= Ua_ModifyDrawOpenAnim;
            if (BossLootProfanedGuardianBoss2 != null) ModifyBossLootProfanedGuardianBoss2 -= Ua_ModifyBossLootProfanedGuardianBoss2;
            if (BossLootPerforatorHeadLarge != null) ModifyBossLootPerforatorHeadLarge -= Ua_ModifyBossLootPerforatorHeadLarge;
            if (BossLootPerforatorHeadSmall != null) ModifyBossLootPerforatorHeadSmall -= Ua_ModifyBossLootPerforatorHeadSmall;
            if (BossLootBumblefuck != null) ModifyBossLootBumblefuck -= Ua_ModifyBossLootBumblefuck;
            if (BossLootPerforatorHeadMedium != null) ModifyBossLootPerforatorHeadMedium -= Ua_ModifyBossLootPerforatorHeadMedium;
            if (BossLootProfanedGuardianBoss3 != null) ModifyBossLootProfanedGuardianBoss3 -= Ua_ModifyBossLootProfanedGuardianBoss3;
            if (BossLootProfanedGuardianBoss != null) ModifyBossLootProfanedGuardianBoss -= Ua_ModifyBossLootProfanedGuardianBoss;
            if (InvasionNamebossRushUI != null) ModifyInvasionNamebossRushUI -= Ua_ModifyInvasionNamebossRushUI;
            if (ColdDivinityModifyTooltips != null) ModifyColdDivinityModifyTooltips -= Ua_ModifyColdDivinityModifyTooltips;

            #endregion
        }

        #region Calamity IL Manipulator

        private static event ILContext.Manipulator ModifyHandleMouseInteraction
        {
            add => HookEndpointManager.Modify(HandleMouseInteraction, value);
            remove => HookEndpointManager.Unmodify(HandleMouseInteraction, value);
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
        private static event ILContext.Manipulator ModifyUseItemArmageddon
        {
            add => HookEndpointManager.Modify(UseItemArmageddon, value);
            remove => HookEndpointManager.Unmodify(UseItemArmageddon, value);
        }
        private static event ILContext.Manipulator ModifyUseItemDeath
        {
            add => HookEndpointManager.Modify(UseItemDeath, value);
            remove => HookEndpointManager.Unmodify(UseItemDeath, value);
        }
        private static event ILContext.Manipulator ModifyUseItemDefiledRune
        {
            add => HookEndpointManager.Modify(UseItemDefiledRune, value);
            remove => HookEndpointManager.Unmodify(UseItemDefiledRune, value);
        }
        private static event ILContext.Manipulator ModifyUseItemRevenge
        {
            add => HookEndpointManager.Modify(UseItemRevenge, value);
            remove => HookEndpointManager.Unmodify(UseItemRevenge, value);
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

        private static MethodInfo HandleMouseInteraction;
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
        private static MethodInfo UseItemArmageddon;
        private static MethodInfo UseItemDeath;
        private static MethodInfo UseItemDefiledRune;
        private static MethodInfo UseItemRevenge;
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

        private static Mod Calamity => ModLoader.GetMod("CalamityMod");
    }
}