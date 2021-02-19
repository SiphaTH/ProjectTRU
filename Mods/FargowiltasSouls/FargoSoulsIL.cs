using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Utilities;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public class FargoPlayerIL : ILEdit
    {
        public override string DictKey => "FargowiltasSouls";
        
        private event ILContext.Manipulator OnEnterWorldHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.FargoPlayer").GetMethod("OnEnterWorld", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.FargoPlayer").GetMethod("OnEnterWorld", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        private event ILContext.Manipulator PreUpdateHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.FargoPlayer").GetMethod("PreUpdate", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.FargoPlayer").GetMethod("PreUpdate", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        private event ILContext.Manipulator PreKillHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.FargoPlayer").GetMethod("PreKill", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.FargoPlayer").GetMethod("PreKill", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        private event ILContext.Manipulator CatchFishHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.FargoPlayer").GetMethod("CatchFish", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.FargoPlayer").GetMethod("CatchFish", BindingFlags.Public | BindingFlags.Instance), value);
        }

        public override bool Autoload() => CoreFargowiltasSoulsTranslation.FargoSouls != null;

        public override void Load()
        {
            OnEnterWorldHook += TranslationOnEnterWorldHook;
            PreUpdateHook += TranslationPreUpdateHook;
            PreKillHook += TranslationPreKill;
            CatchFishHook += TranslationCatchFishHook;
        }

        public override void Unload()
        {
            OnEnterWorldHook -= TranslationOnEnterWorldHook;
            PreUpdateHook -= TranslationPreUpdateHook;
            PreKillHook -= TranslationPreKill;
            CatchFishHook -= TranslationCatchFishHook;
        }

        private void TranslationOnEnterWorldHook(ILContext il)
        {
            Translation.ILTranslate(il, "Fargo's Music Mod not found!", Translation.EncodeToUtf16("Fargo's Music Mod не найден"));
            Translation.ILTranslate(il, "Please install Fargo's Music Mod for the full experience!!", Translation.EncodeToUtf16("Пожалуйста, установите Fargo's Music Mod для полноценного опыта!!"));
        }
        
        private void TranslationPreUpdateHook(ILContext il) => Translation.ILTranslate(il, " was pricked by a Cactus.", Translation.EncodeToUtf16(" был проколот кактусом."));
        
        private void TranslationPreKill(ILContext il)
        {
            Translation.ILTranslate(il, "You've been revived!", Translation.EncodeToUtf16("Вы возродились!"));
            Translation.ILTranslate(il, "You've been revived!", Translation.EncodeToUtf16("Вы возродились!"), 2);
            Translation.ILTranslate(il, "You've been revived!", Translation.EncodeToUtf16("Вы возродились!"), 3);
            Translation.ILTranslate(il, " could not handle the infection.", Translation.EncodeToUtf16(" не справился с инфекцией."));
            Translation.ILTranslate(il, " rotted away.", Translation.EncodeToUtf16(" сгнил."));
            Translation.ILTranslate(il, " was annihilated by divine wrath.", Translation.EncodeToUtf16(" был истреблён божественным гневом."));
            Translation.ILTranslate(il, " was reaped by the cold hand of death.", Translation.EncodeToUtf16(" был сожжён холодной рукой смерти."));
        }
        
        private void TranslationCatchFishHook(ILContext il) => Translation.ILTranslate(il, "Duke Fishron EX has awoken!", Translation.EncodeToUtf16("Пробудился босс Герцог Рыброн ЕХ!"));
    }
    
    public class FargowiltasIL : ILEdit
    {
        public override string DictKey => "FargowiltasSouls2";
        
        private event ILContext.Manipulator FargowiltasHook
        {
            add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Fargowiltas").GetMethod("HandlePacket", BindingFlags.Public | BindingFlags.Instance), value);
        
            remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Fargowiltas").GetMethod("HandlePacket", BindingFlags.Public | BindingFlags.Instance), value);
        }
        
        public override bool Autoload() => CoreFargowiltasSoulsTranslation.FargoSouls != null;

        public override void Load() => FargowiltasHook += TranslationFargowiltasHook;
        
        public override void Unload() => FargowiltasHook -= TranslationFargowiltasHook;
        
        private void TranslationFargowiltasHook(ILContext il) => Translation.ILTranslate(il, "Duke Fishron EX has awoken!", Translation.EncodeToUtf16("Пробудился босс Герцог Рыброн ЕХ!"));
    }
    
     public class BossChecklistCompatibilityIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls.ModCompatibilities";
         
         private event ILContext.Manipulator InitializeBossesHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.ModCompatibilities.BossChecklistCompatibility").GetMethod("InitializeBosses", BindingFlags.NonPublic | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.ModCompatibilities.BossChecklistCompatibility").GetMethod("InitializeBosses", BindingFlags.NonPublic | BindingFlags.Instance), value);
         }
         
         private event ILContext.Manipulator InitializeMinibossesHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.ModCompatibilities.BossChecklistCompatibility").GetMethod("InitializeMinibosses", BindingFlags.NonPublic | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.ModCompatibilities.BossChecklistCompatibility").GetMethod("InitializeMinibosses", BindingFlags.NonPublic | BindingFlags.Instance), value);
         }
         
         public override bool Autoload() => CoreFargowiltasSoulsTranslation.FargoSouls != null;

         public override void Load()
         {
             InitializeBossesHook += TranslationInitializeBossesHook;
             InitializeMinibossesHook += TranslationInitializeMinibossesHook;
         }

         public override void Unload()
         {
             InitializeBossesHook -= TranslationInitializeBossesHook;
             InitializeMinibossesHook -= TranslationInitializeMinibossesHook;
         }

         private void TranslationInitializeBossesHook(ILContext il)
         {
             Translation.ILTranslate(il, "Deviantt", Translation.EncodeToUtf16("Девиантт"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}].", Translation.EncodeToUtf16("Используйте [i:{0}]."));
             Translation.ILTranslate(il, "Deviantt is satisfied with its show of love.", Translation.EncodeToUtf16("Девиантт доволен своим проявлением любви."));
             Translation.ILTranslate(il, "Abominationn", Translation.EncodeToUtf16("Мерзостть"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}].", Translation.EncodeToUtf16("Используйте [i:{0}]."), 2);
             Translation.ILTranslate(il, "Abominationn has destroyed everyone.", Translation.EncodeToUtf16("Мерзостть уничтожил всех."));
             Translation.ILTranslate(il, "Mutant", Translation.EncodeToUtf16("Мутант"));
             Translation.ILTranslate(il, "Throw [i:{0}] into a pool of lava while Abominationn is alivem in Mutant's presence.", Translation.EncodeToUtf16("Бросьте [i:{0}] в лаву, пока Мерзостть жив и в присутствие Мутанта."));
             Translation.ILTranslate(il, "Mutant has eviscerated everyone under its hands.", Translation.EncodeToUtf16("Мутант выпотрошил всех своими руки."));
         }

         private void TranslationInitializeMinibossesHook(ILContext il)
         {
             Translation.ILTranslate(il, "Champion of Timber", Translation.EncodeToUtf16("Чемпион леса"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}] on the surface during the day.", Translation.EncodeToUtf16("Используйте [i:{0}] днём на поверхности."));
             Translation.ILTranslate(il, "Champion of Timber returns to its squirrel clan...", Translation.EncodeToUtf16("Чемпион леса возвращается в свой белчий клан..."));
             Translation.ILTranslate(il, "Champion of Terra", Translation.EncodeToUtf16("Чемпион земли"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}] underground.", Translation.EncodeToUtf16("Используйте [i:{0}] под землёй."));
             Translation.ILTranslate(il, "Champion of Terra vanishes into the caverns...", Translation.EncodeToUtf16("Чемпион земли исчезает в пещерах..."));
             Translation.ILTranslate(il, "Champion of Earth", Translation.EncodeToUtf16("Чемпион планеты"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}] in the underworld.", Translation.EncodeToUtf16("Используйте [i:{0}] в аду."));
             Translation.ILTranslate(il, "Champion of Earth disappears beneath the magma...", Translation.EncodeToUtf16("Чемпион планеты исчезает под магмой..."));
             Translation.ILTranslate(il, "Champion of Nature", Translation.EncodeToUtf16("Чемпион природы"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}] in underground snow.", Translation.EncodeToUtf16("Используйте [i:{0}] подземных снегах."));
             Translation.ILTranslate(il, "Champion of Nature returns to its slumber", Translation.EncodeToUtf16("Чемпион природы возвращается в свой сон."));
             Translation.ILTranslate(il, "Champion of Life", Translation.EncodeToUtf16("Чемпион жизни"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}] in the Hallow at day.", Translation.EncodeToUtf16("Используйте [i:{0}] днём в святых землях."));
             Translation.ILTranslate(il, "Champion of Life fades away...", Translation.EncodeToUtf16("Чемпион жизни исчезает..."));
             Translation.ILTranslate(il, "Champion of Shadow", Translation.EncodeToUtf16("Чемпион тени"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}] in the Corruption or Crimson at night.", Translation.EncodeToUtf16("Используйте [i:{0}] ночью в искажении или багрянце."));
             Translation.ILTranslate(il, "Champion of Shadow fades away...", Translation.EncodeToUtf16("Чемпион тени исчезает..."));
             Translation.ILTranslate(il, "Champion of Spirit", Translation.EncodeToUtf16("Чемпион духа"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}] in the underground desert.", Translation.EncodeToUtf16("Используйте [i:{0}] в подземной пустыне."));
             Translation.ILTranslate(il, "Champion of Spirit vanishes into the desert...", Translation.EncodeToUtf16("Чемпион духа исчезает в пустыне..."));
             Translation.ILTranslate(il, "Champion of Will", Translation.EncodeToUtf16("Чемпион воли"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}] at the ocean.", Translation.EncodeToUtf16("Используйте [i:{0}] в океане."));
             Translation.ILTranslate(il, "Champion of Will returns to the depths...", Translation.EncodeToUtf16("Чемпион воли возвращается в глубины..."));
             Translation.ILTranslate(il, "Eridanus, Champion of Cosmos", Translation.EncodeToUtf16("Эридан, чемпион космоса"));
             Translation.ILTranslate(il, "Spawn by using [i:{0}] in space.", Translation.EncodeToUtf16("Используйте [i:{0}] в космосе."));
             Translation.ILTranslate(il, "Eridanus, Champion of Cosmos returns to the stars...", Translation.EncodeToUtf16("Эридан, чемпион космоса возвращается к звёздам..."));
         }
     }

     public class EModeGlobalNPCIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls.NPCs";
         
         private event ILContext.Manipulator KingSlimeAIHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("KingSlimeAI", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("KingSlimeAI", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         private event ILContext.Manipulator QueenBeeAIHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("QueenBeeAI", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("QueenBeeAI", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         private event ILContext.Manipulator SetDefaultsHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         private event ILContext.Manipulator PreAIHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("PreAI", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("PreAI", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         private event ILContext.Manipulator OnHitPlayerHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("OnHitPlayer", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         private event ILContext.Manipulator CheckDeadHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("CheckDead", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("CheckDead", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         private event ILContext.Manipulator ModifyHitByItemHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("ModifyHitByItem", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.NPCs.EModeGlobalNPC").GetMethod("ModifyHitByItem", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         public override bool Autoload() => CoreFargowiltasSoulsTranslation.FargoSouls != null;
         
         public override void Load()
         {
             KingSlimeAIHook += TranslationKingSlimeAIHook;
             QueenBeeAIHook += TranslationQueenBeeAIHook;
             SetDefaultsHook += TranslationSetDefaultsHook;
             PreAIHook += TranslationPreAIHook;
             OnHitPlayerHook += TranslationOnHitPlayerHook;
             CheckDeadHook += TranslationCheckDeadHook;
             ModifyHitByItemHook += TranslationModifyHitByItemHook;
         }

         public override void Unload()
         {
             KingSlimeAIHook -= TranslationKingSlimeAIHook;
             QueenBeeAIHook -= TranslationQueenBeeAIHook;
             SetDefaultsHook -= TranslationSetDefaultsHook;
             PreAIHook -= TranslationPreAIHook;
             OnHitPlayerHook -= TranslationOnHitPlayerHook;
             CheckDeadHook -= TranslationCheckDeadHook;
             ModifyHitByItemHook -= TranslationModifyHitByItemHook;
         }

         private void TranslationKingSlimeAIHook(ILContext il)
         {
             Translation.ILTranslate(il, "King Slime has enraged!", Translation.EncodeToUtf16("Король Слизней в ярости!"));
             Translation.ILTranslate(il, "King Slime has enraged!", Translation.EncodeToUtf16("Король Слизней в ярости!"), 2);
         }
         
         private void TranslationQueenBeeAIHook(ILContext il)
         {
             Translation.ILTranslate(il, "Royal Subject has awoken!", Translation.EncodeToUtf16("Пробудился босс Королевская особа!"));
             Translation.ILTranslate(il, "Royal Subject has awoken!", Translation.EncodeToUtf16("Пробудился босс Королевская особа!"), 2);
             Translation.ILTranslate(il, "Royal Subject has awoken!", Translation.EncodeToUtf16("Пробудился босс Королевская особа!"), 3);
             Translation.ILTranslate(il, "Royal Subject has awoken!", Translation.EncodeToUtf16("Пробудился босс Королевская особа!"), 4);
         }
         
         private void TranslationSetDefaultsHook(ILContext il) => Translation.ILTranslate(il, "Duke Fishron EX", Translation.EncodeToUtf16("Герцог Рыброн ЕХ"));
         
         private void TranslationPreAIHook(ILContext il)
         {
             Translation.ILTranslate(il, " sucked dry.", Translation.EncodeToUtf16(" выдохся."));
             Translation.ILTranslate(il, "A Clown has begun ticking!", Translation.EncodeToUtf16("Клоун начал тикать!"));
             Translation.ILTranslate(il, "A Clown has begun ticking!", Translation.EncodeToUtf16("Клоун начал тикать!"), 2);
             Translation.ILTranslate(il, "A Clown has exploded!", Translation.EncodeToUtf16("Клоун взорвался!"));
             Translation.ILTranslate(il, "A Clown has exploded!", Translation.EncodeToUtf16("Клоун взорвался!"), 2);
         }
         
         private void TranslationOnHitPlayerHook(ILContext il)
         {
             Translation.ILTranslate(il, " was eaten alive by a Man Eater.", Translation.EncodeToUtf16(" был съеден заживо людоедом."));
             Translation.ILTranslate(il, " was eaten alive by an Angry Trapper.", Translation.EncodeToUtf16(" был съеден заживо злым ловцом."));
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"));
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 2);
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 3);
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 4);
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 5);
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 6);
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 7);
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 8);
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 9);
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 10);
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 11);
             Translation.ILTranslate(il, "An item was stolen from you!", Translation.EncodeToUtf16("У вас украли предмет!"), 12);
         }
         
         private void TranslationCheckDeadHook(ILContext il)
         {
             Translation.ILTranslate(il, "Skeletron has entered Dungeon Guardian form!", Translation.EncodeToUtf16("Скелетрон принял форму стража темницы!"));
             Translation.ILTranslate(il, "Skeletron has entered Dungeon Guardian form!", Translation.EncodeToUtf16("Скелетрон принял форму стража темницы!"), 2);
             Translation.ILTranslate(il, "Duke Fishron EX has been defeated!", Translation.EncodeToUtf16("Герцог Рыброн ЕХ был побеждён!"));
             Translation.ILTranslate(il, "Duke Fishron EX has been defeated!", Translation.EncodeToUtf16("Герцог Рыброн ЕХ был побеждён!"), 2);
         }
         
         private void TranslationModifyHitByItemHook(ILContext il) => Translation.ILTranslate(il, " was impaled by a Giant Tortoise.", Translation.EncodeToUtf16(""));
     }

     public class MutantsFuryIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls.Items.Misc";
         
         private event ILContext.Manipulator MutantsFuryHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Misc.MutantsFury").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Misc.MutantsFury").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         public override void Load() => MutantsFuryHook += TranslationMutantsFuryHook;
         
         public override void Unload() => MutantsFuryHook -= TranslationMutantsFuryHook;
         
         private void TranslationMutantsFuryHook(ILContext il)
         {
             Translation.ILTranslate(il, "Mutant is angered!", Translation.EncodeToUtf16("Мутант в ярости!"));
             Translation.ILTranslate(il, "Mutant is calm.", Translation.EncodeToUtf16("Мутант спокоен."));
         }
     }
     
     public class AbominationnVoodooDollIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls.Items.Summons";
         
         private event ILContext.Manipulator AbominationnVoodooDollHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Summons.AbominationnVoodooDoll").GetMethod("Update", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Summons.AbominationnVoodooDoll").GetMethod("Update", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         public override void Load() => AbominationnVoodooDollHook += TranslationAbominationnVoodooDollHook;
         
         public override void Unload() => AbominationnVoodooDollHook -= TranslationAbominationnVoodooDollHook;
         
         private void TranslationAbominationnVoodooDollHook(ILContext il) => Translation.ILTranslate(il, "Mutant has been enraged by the death of his brother!", Translation.EncodeToUtf16("Мутант в ярости от гибели брата!"));
     }
     
     public class AbomsCurseIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls.Items.Summons2";
         
         private event ILContext.Manipulator AbomsCurseHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Summons.AbomsCurse").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Summons.AbomsCurse").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         public override void Load() => AbomsCurseHook += TranslationAbomsCurseHook;
         
         public override void Unload() => AbomsCurseHook -= TranslationAbomsCurseHook;
         
         private void TranslationAbomsCurseHook(ILContext il) => Translation.ILTranslate(il, "Abominationn has awoken!", Translation.EncodeToUtf16("Пробудился босс Мерзостть!"));
     }
     
     public class DevisCurseIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls.Items.Summons3";
         
         private event ILContext.Manipulator DevisCurseHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Summons.DevisCurse").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Summons.DevisCurse").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         public override void Load() => DevisCurseHook += TranslationDevisCurseHook;
         
         public override void Unload() => DevisCurseHook -= TranslationDevisCurseHook;
         
         private void TranslationDevisCurseHook(ILContext il)
         {
             Translation.ILTranslate(il, "Deviantt has awoken!", Translation.EncodeToUtf16("Пробудился босс Девиантт!"));
             Translation.ILTranslate(il, "Deviantt has awoken!", Translation.EncodeToUtf16("Пробудился босс Девиантт!"), 2);
         }
     }
     
     public class MutantsCurseIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls.Items.Summons4";
         
         private event ILContext.Manipulator MutantsCurseHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Summons.MutantsCurse").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Summons.MutantsCurse").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         public override void Load() => MutantsCurseHook += TranslationMutantsCurseHook;
         
         public override void Unload() => MutantsCurseHook -= TranslationMutantsCurseHook;
         
         private void TranslationMutantsCurseHook(ILContext il)
         {
             Translation.ILTranslate(il, "Mutant has awoken!", Translation.EncodeToUtf16("Пробудился босс Мутант!"));
             Translation.ILTranslate(il, "Mutant has awoken!", Translation.EncodeToUtf16("Пробудился босс Мутант!"), 2);
         }
     }
     
     public class SigilOfChampionsIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls.Items.Summons5";
         
         private event ILContext.Manipulator SigilOfChampionsHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Summons.SigilOfChampions").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Items.Summons.SigilOfChampions").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         public override void Load() => SigilOfChampionsHook += TranslationSigilOfChampionsHook;
         
         public override void Unload() => SigilOfChampionsHook -= TranslationSigilOfChampionsHook;
         
         private void TranslationSigilOfChampionsHook(ILContext il)
         {
             Translation.ILTranslate(il, "A strong spirit stirs...", Translation.EncodeToUtf16("Сильный дух будоражит..."));
             Translation.ILTranslate(il, "The core of the planet rumbles...", Translation.EncodeToUtf16("Ядро планеты урчит..."));
             Translation.ILTranslate(il, "A verdant wind is blowing...", Translation.EncodeToUtf16("Дует зелёный ветер..."));
             Translation.ILTranslate(il, "The stones tremble around you...", Translation.EncodeToUtf16("Камни дрожат вокруг вас..."));
             Translation.ILTranslate(il, "The stars are aligning...", Translation.EncodeToUtf16("Звезды выравниваются..."));
             Translation.ILTranslate(il, "Metallic groans echo from the depths...", Translation.EncodeToUtf16("Металлические стоны эхом разносятся из глубины..."));
             Translation.ILTranslate(il, "A wave of warmth passes over you...", Translation.EncodeToUtf16("Волна тепла проходит по тебе..."));
             Translation.ILTranslate(il, "The darkness of the night feels deeper...", Translation.EncodeToUtf16("Темнота ночи кажется глубже..."));
             Translation.ILTranslate(il, "You are surrounded by the rustling of trees...", Translation.EncodeToUtf16("Вы окружены шорохом деревьев..."));
             Translation.ILTranslate(il, "Nothing seems to answer the call...", Translation.EncodeToUtf16("Кажется, никто не отвечает на звонок..."));
         }
     }
     
     public class PiranhaPlantVoodooDollIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls.Patreon.LaBonez";
         
         private event ILContext.Manipulator PiranhaPlantVoodooDollHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Patreon.LaBonez.PiranhaPlantVoodooDoll").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Patreon.LaBonez.PiranhaPlantVoodooDoll").GetMethod("UseItem", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         public override void Load() => PiranhaPlantVoodooDollHook += TranslationPiranhaPlantVoodooDollHook;
         
         public override void Unload() => PiranhaPlantVoodooDollHook -= TranslationPiranhaPlantVoodooDollHook;
         
         private void TranslationPiranhaPlantVoodooDollHook(ILContext il)
         {
             Translation.ILTranslate(il, "The suffering continues.", Translation.EncodeToUtf16("Страдания продолжаются."));
             Translation.ILTranslate(il, "The suffering wanes.", Translation.EncodeToUtf16("Страдания ослабевают."));
         }
     }
     
     public class PatreonPlayerIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls3";
         
         private event ILContext.Manipulator PatreonPlayerHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.PatreonPlayer").GetMethod("OnEnterWorld", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.PatreonPlayer").GetMethod("OnEnterWorld", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         public override void Load() => PatreonPlayerHook += TranslationPatreonPlayerHook;
         
         public override void Unload() => PatreonPlayerHook -= TranslationPatreonPlayerHook;
         
         private void TranslationPatreonPlayerHook(ILContext il) => Translation.ILTranslate(il, "Your special patreon effects are active ", Translation.EncodeToUtf16("Ваш особый эффект патреона - "));
     }
     
     public class MutantSpawnIL : ILEdit
     {
         public override string DictKey => "FargowiltasSouls.Projectiles.Pets";
         
         private event ILContext.Manipulator MutantSpawnHook
         {
             add => HookEndpointManager.Modify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Projectiles.Pets.MutantSpawn").GetMethod("BeCompanionCube", BindingFlags.Public | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(CoreFargowiltasSoulsTranslation.FargoSouls.Code.GetType("FargowiltasSouls.Projectiles.Pets.MutantSpawn").GetMethod("BeCompanionCube", BindingFlags.Public | BindingFlags.Instance), value);
         }
         
         public override void Load() => MutantSpawnHook += TranslationMutantSpawnHook;
         
         public override void Unload() => MutantSpawnHook -= TranslationMutantSpawnHook;
         
         private void TranslationMutantSpawnHook(ILContext il)
         {
             Translation.ILTranslate(il, "Mutant has awoken!", Translation.EncodeToUtf16("Пробудился босс Мутант!"));
             Translation.ILTranslate(il, "Mutant has awoken!", Translation.EncodeToUtf16("Пробудился босс Мутант!"), 2);
             Translation.ILTranslate(il, "You think you're safe?", Translation.EncodeToUtf16("Думаете, вы в безопасности?"));
         }
     }
}