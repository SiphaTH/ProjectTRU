using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public class FargoPlayerIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            IL.FargowiltasSouls.FargoPlayer.OnEnterWorld += TranslationOnEnterWorldHook;
            IL.FargowiltasSouls.FargoPlayer.PreUpdate += TranslationPreUpdateHook;
            IL.FargowiltasSouls.FargoPlayer.PreKill += TranslationPreKill;
            IL.FargowiltasSouls.FargoPlayer.CatchFish += TranslationCatchFishHook;
        }

        public override void Unload()
        {
            IL.FargowiltasSouls.FargoPlayer.OnEnterWorld -= TranslationOnEnterWorldHook;
            IL.FargowiltasSouls.FargoPlayer.PreUpdate -= TranslationPreUpdateHook;
            IL.FargowiltasSouls.FargoPlayer.PreKill -= TranslationPreKill;
            IL.FargowiltasSouls.FargoPlayer.CatchFish -= TranslationCatchFishHook;
        }

        private void TranslationOnEnterWorldHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Fargo's Music Mod not found!", TranslationUtils.EncodeToUtf16("Fargo's Music Mod не найден"));
            TranslationUtils.ILTranslate(il, "Please install Fargo's Music Mod for the full experience!!", TranslationUtils.EncodeToUtf16("Пожалуйста, установите Fargo's Music Mod для полноценного опыта!"));
        }
        
        private void TranslationPreUpdateHook(ILContext il) => TranslationUtils.ILTranslate(il, " was pricked by a Cactus.", TranslationUtils.EncodeToUtf16(" был проколот кактусом."));
        
        private void TranslationPreKill(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "You've been revived!", TranslationUtils.EncodeToUtf16("Вы возродились!"));
            TranslationUtils.ILTranslate(il, "You've been revived!", TranslationUtils.EncodeToUtf16("Вы возродились!"), 2);
            TranslationUtils.ILTranslate(il, "You've been revived!", TranslationUtils.EncodeToUtf16("Вы возродились!"), 3);
            TranslationUtils.ILTranslate(il, " could not handle the infection.", TranslationUtils.EncodeToUtf16(" не справился с инфекцией."));
            TranslationUtils.ILTranslate(il, " rotted away.", TranslationUtils.EncodeToUtf16(" сгнил."));
            TranslationUtils.ILTranslate(il, " was annihilated by divine wrath.", TranslationUtils.EncodeToUtf16(" был истреблён божественным гневом."));
            TranslationUtils.ILTranslate(il, " was reaped by the cold hand of death.", TranslationUtils.EncodeToUtf16(" был сожжён холодной рукой смерти."));
        }
        
        private void TranslationCatchFishHook(ILContext il) => TranslationUtils.ILTranslate(il, "Duke Fishron EX has awoken!", TranslationUtils.EncodeToUtf16("Герцог Рыброн ЕХ пробудился!"));
    }
    
    public class FargowiltasIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => IL.FargowiltasSouls.Fargowiltas.HandlePacket += TranslationFargowiltasHook;
        
        public override void Unload() => IL.FargowiltasSouls.Fargowiltas.HandlePacket -= TranslationFargowiltasHook;
        
        private void TranslationFargowiltasHook(ILContext il) => TranslationUtils.ILTranslate(il, "Duke Fishron EX has awoken!", TranslationUtils.EncodeToUtf16("Герцог Рыброн ЕХ пробудился!"));
    }
    
     public class BossChecklistCompatibilityIL : ILEdit
     {
         private event ILContext.Manipulator InitializeBossesHook
         {
             add => HookEndpointManager.Modify(ModsCall.FargoSouls.Code.GetType("FargowiltasSouls.ModCompatibilities.BossChecklistCompatibility").GetMethod("InitializeBosses", BindingFlags.NonPublic | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(ModsCall.FargoSouls.Code.GetType("FargowiltasSouls.ModCompatibilities.BossChecklistCompatibility").GetMethod("InitializeBosses", BindingFlags.NonPublic | BindingFlags.Instance), value);
         }
         
         private event ILContext.Manipulator InitializeMinibossesHook
         {
             add => HookEndpointManager.Modify(ModsCall.FargoSouls.Code.GetType("FargowiltasSouls.ModCompatibilities.BossChecklistCompatibility").GetMethod("InitializeMinibosses", BindingFlags.NonPublic | BindingFlags.Instance), value);
         
             remove => HookEndpointManager.Unmodify(ModsCall.FargoSouls.Code.GetType("FargowiltasSouls.ModCompatibilities.BossChecklistCompatibility").GetMethod("InitializeMinibosses", BindingFlags.NonPublic | BindingFlags.Instance), value);
         }
         
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

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
             TranslationUtils.ILTranslate(il, "Deviantt", TranslationUtils.EncodeToUtf16("Девиантт"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}].", TranslationUtils.EncodeToUtf16("Используйте [i:{0}]."));
             TranslationUtils.ILTranslate(il, "Deviantt is satisfied with its show of love.", TranslationUtils.EncodeToUtf16("Девиантт доволен своим проявлением любви."));
             TranslationUtils.ILTranslate(il, "Abominationn", TranslationUtils.EncodeToUtf16("Мерзостть"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}].", TranslationUtils.EncodeToUtf16("Используйте [i:{0}]."), 2);
             TranslationUtils.ILTranslate(il, "Abominationn has destroyed everyone.", TranslationUtils.EncodeToUtf16("Мерзостть уничтожил всех."));
             TranslationUtils.ILTranslate(il, "Mutant", TranslationUtils.EncodeToUtf16("Мутант"));
             TranslationUtils.ILTranslate(il, "Throw [i:{0}] into a pool of lava while Abominationn is alivem in Mutant's presence.", TranslationUtils.EncodeToUtf16("Бросьте [i:{0}] в лаву, пока Мерзостть жив и в присутствие Мутанта."));
             TranslationUtils.ILTranslate(il, "Mutant has eviscerated everyone under its hands.", TranslationUtils.EncodeToUtf16("Мутант выпотрошил всех своими руки."));
         }

         private void TranslationInitializeMinibossesHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "Champion of Timber", TranslationUtils.EncodeToUtf16("Чемпион леса"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] on the surface during the day.", TranslationUtils.EncodeToUtf16("Используйте [i:{0}] днём на поверхности."));
             TranslationUtils.ILTranslate(il, "Champion of Timber returns to its squirrel clan...", TranslationUtils.EncodeToUtf16("Чемпион леса возвращается в свой белчий клан..."));
             TranslationUtils.ILTranslate(il, "Champion of Terra", TranslationUtils.EncodeToUtf16("Чемпион земли"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] underground.", TranslationUtils.EncodeToUtf16("Используйте [i:{0}] под землёй."));
             TranslationUtils.ILTranslate(il, "Champion of Terra vanishes into the caverns...", TranslationUtils.EncodeToUtf16("Чемпион земли исчезает в пещерах..."));
             TranslationUtils.ILTranslate(il, "Champion of Earth", TranslationUtils.EncodeToUtf16("Чемпион планеты"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in the underworld.", TranslationUtils.EncodeToUtf16("Используйте [i:{0}] в аду."));
             TranslationUtils.ILTranslate(il, "Champion of Earth disappears beneath the magma...", TranslationUtils.EncodeToUtf16("Чемпион планеты исчезает под магмой..."));
             TranslationUtils.ILTranslate(il, "Champion of Nature", TranslationUtils.EncodeToUtf16("Чемпион природы"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in underground snow.", TranslationUtils.EncodeToUtf16("Используйте [i:{0}] подземных снегах."));
             TranslationUtils.ILTranslate(il, "Champion of Nature returns to its slumber", TranslationUtils.EncodeToUtf16("Чемпион природы возвращается в свой сон."));
             TranslationUtils.ILTranslate(il, "Champion of Life", TranslationUtils.EncodeToUtf16("Чемпион жизни"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in the Hallow at day.", TranslationUtils.EncodeToUtf16("Используйте [i:{0}] днём в святых землях."));
             TranslationUtils.ILTranslate(il, "Champion of Life fades away...", TranslationUtils.EncodeToUtf16("Чемпион жизни исчезает..."));
             TranslationUtils.ILTranslate(il, "Champion of Shadow", TranslationUtils.EncodeToUtf16("Чемпион тени"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in the Corruption or Crimson at night.", TranslationUtils.EncodeToUtf16("Используйте [i:{0}] ночью в искажении или багрянце."));
             TranslationUtils.ILTranslate(il, "Champion of Shadow fades away...", TranslationUtils.EncodeToUtf16("Чемпион тени исчезает..."));
             TranslationUtils.ILTranslate(il, "Champion of Spirit", TranslationUtils.EncodeToUtf16("Чемпион духа"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in the underground desert.", TranslationUtils.EncodeToUtf16("Используйте [i:{0}] в подземной пустыне."));
             TranslationUtils.ILTranslate(il, "Champion of Spirit vanishes into the desert...", TranslationUtils.EncodeToUtf16("Чемпион духа исчезает в пустыне..."));
             TranslationUtils.ILTranslate(il, "Champion of Will", TranslationUtils.EncodeToUtf16("Чемпион воли"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] at the ocean.", TranslationUtils.EncodeToUtf16("Используйте [i:{0}] в океане."));
             TranslationUtils.ILTranslate(il, "Champion of Will returns to the depths...", TranslationUtils.EncodeToUtf16("Чемпион воли возвращается в глубины..."));
             TranslationUtils.ILTranslate(il, "Eridanus, Champion of Cosmos", TranslationUtils.EncodeToUtf16("Эридан, чемпион космоса"));
             TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in space.", TranslationUtils.EncodeToUtf16("Используйте [i:{0}] в космосе."));
             TranslationUtils.ILTranslate(il, "Eridanus, Champion of Cosmos returns to the stars...", TranslationUtils.EncodeToUtf16("Эридан, чемпион космоса возвращается к звёздам..."));
         }
     }

     public class EModeGlobalNPCIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load()
         {
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.KingSlimeAI += TranslationKingSlimeAIHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.QueenBeeAI += TranslationQueenBeeAIHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.SetDefaults += TranslationSetDefaultsHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.PreAI += TranslationPreAIHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.OnHitPlayer += TranslationOnHitPlayerHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.CheckDead += TranslationCheckDeadHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.ModifyHitByItem += TranslationModifyHitByItemHook;
         }

         public override void Unload()
         {
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.KingSlimeAI -= TranslationKingSlimeAIHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.QueenBeeAI -= TranslationQueenBeeAIHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.SetDefaults -= TranslationSetDefaultsHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.PreAI -= TranslationPreAIHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.OnHitPlayer -= TranslationOnHitPlayerHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.CheckDead -= TranslationCheckDeadHook;
             IL.FargowiltasSouls.NPCs.EModeGlobalNPC.ModifyHitByItem -= TranslationModifyHitByItemHook;
         }

         private void TranslationKingSlimeAIHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "King Slime has enraged!", TranslationUtils.EncodeToUtf16("Король слизней в ярости!"));
             TranslationUtils.ILTranslate(il, "King Slime has enraged!", TranslationUtils.EncodeToUtf16("Король слизней в ярости!"), 2);
         }
         
         private void TranslationQueenBeeAIHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "Royal Subject has awoken!", TranslationUtils.EncodeToUtf16("Королевская особа пробудилась!"));
             TranslationUtils.ILTranslate(il, "Royal Subject has awoken!", TranslationUtils.EncodeToUtf16("Королевская особа пробудилась!"), 2);
             TranslationUtils.ILTranslate(il, "Royal Subject has awoken!", TranslationUtils.EncodeToUtf16("Королевская особа пробудилась!"), 3);
             TranslationUtils.ILTranslate(il, "Royal Subject has awoken!", TranslationUtils.EncodeToUtf16("Королевская особа пробудилась!"), 4);
         }
         
         private void TranslationSetDefaultsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Duke Fishron EX", TranslationUtils.EncodeToUtf16("Герцог Рыброн ЕХ"));
         
         private void TranslationPreAIHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, " sucked dry.", TranslationUtils.EncodeToUtf16(" выдохся."));
             TranslationUtils.ILTranslate(il, "A Clown has begun ticking!", TranslationUtils.EncodeToUtf16("Клоун начал тикать!"));
             TranslationUtils.ILTranslate(il, "A Clown has begun ticking!", TranslationUtils.EncodeToUtf16("Клоун начал тикать!"), 2);
             TranslationUtils.ILTranslate(il, "A Clown has exploded!", TranslationUtils.EncodeToUtf16("Клоун взорвался!"));
             TranslationUtils.ILTranslate(il, "A Clown has exploded!", TranslationUtils.EncodeToUtf16("Клоун взорвался!"), 2);
         }
         
         private void TranslationOnHitPlayerHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, " was eaten alive by a Man Eater.", TranslationUtils.EncodeToUtf16(" был съеден заживо людоедом."));
             TranslationUtils.ILTranslate(il, " was eaten alive by an Angry Trapper.", TranslationUtils.EncodeToUtf16(" был съеден заживо злым ловцом."));
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"));
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 2);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 3);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 4);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 5);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 6);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 7);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 8);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 9);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 10);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 11);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", TranslationUtils.EncodeToUtf16("У вас украли предмет!"), 12);
         }
         
         private void TranslationCheckDeadHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "Skeletron has entered Dungeon Guardian form!", TranslationUtils.EncodeToUtf16("Скелетрон принял форму стража темницы!"));
             TranslationUtils.ILTranslate(il, "Skeletron has entered Dungeon Guardian form!", TranslationUtils.EncodeToUtf16("Скелетрон принял форму стража темницы!"), 2);
             TranslationUtils.ILTranslate(il, "Duke Fishron EX has been defeated!", TranslationUtils.EncodeToUtf16("Герцог Рыброн ЕХ был побеждён!"));
             TranslationUtils.ILTranslate(il, "Duke Fishron EX has been defeated!", TranslationUtils.EncodeToUtf16("Герцог Рыброн ЕХ был побеждён!"), 2);
         }
         
         private void TranslationModifyHitByItemHook(ILContext il) => TranslationUtils.ILTranslate(il, " was impaled by a Giant Tortoise.", TranslationUtils.EncodeToUtf16(" был пронзён гигантской черепахой."));
     }

     public class MutantsFuryIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load() => IL.FargowiltasSouls.Items.Misc.MutantsFury.UseItem += TranslationMutantsFuryHook;
         
         public override void Unload() => IL.FargowiltasSouls.Items.Misc.MutantsFury.UseItem -= TranslationMutantsFuryHook;
         
         private void TranslationMutantsFuryHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "Mutant is angered!", TranslationUtils.EncodeToUtf16("Мутант в ярости!"));
             TranslationUtils.ILTranslate(il, "Mutant is calm.", TranslationUtils.EncodeToUtf16("Мутант спокоен."));
         }
     }
     
     public class AbominationnVoodooDollIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load() => IL.FargowiltasSouls.Items.Summons.AbominationnVoodooDoll.Update += TranslationAbominationnVoodooDollHook;
         
         public override void Unload() => IL.FargowiltasSouls.Items.Summons.AbominationnVoodooDoll.Update -= TranslationAbominationnVoodooDollHook;
         
         private void TranslationAbominationnVoodooDollHook(ILContext il) => TranslationUtils.ILTranslate(il, "Mutant has been enraged by the death of his brother!", TranslationUtils.EncodeToUtf16("Мутант в ярости от гибели брата!"));
     }
     
     public class AbomsCurseIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load() => IL.FargowiltasSouls.Items.Summons.AbomsCurse.UseItem += TranslationAbomsCurseHook;
         
         public override void Unload() => IL.FargowiltasSouls.Items.Summons.AbomsCurse.UseItem -= TranslationAbomsCurseHook;
         
         private void TranslationAbomsCurseHook(ILContext il) => TranslationUtils.ILTranslate(il, "Abominationn has awoken!", TranslationUtils.EncodeToUtf16("Мерзостть пробудился!"));
     }
     
     public class DevisCurseIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load() => IL.FargowiltasSouls.Items.Summons.DevisCurse.UseItem += TranslationDevisCurseHook;
         
         public override void Unload() => IL.FargowiltasSouls.Items.Summons.DevisCurse.UseItem -= TranslationDevisCurseHook;
         
         private void TranslationDevisCurseHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "Deviantt has awoken!", TranslationUtils.EncodeToUtf16("Девиантт пробудился!"));
             TranslationUtils.ILTranslate(il, "Deviantt has awoken!", TranslationUtils.EncodeToUtf16("Девиантт пробудился!"), 2);
         }
     }
     
     public class MutantsCurseIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load() => IL.FargowiltasSouls.Items.Summons.MutantsCurse.UseItem += TranslationMutantsCurseHook;
         
         public override void Unload() => IL.FargowiltasSouls.Items.Summons.MutantsCurse.UseItem -= TranslationMutantsCurseHook;
         
         private void TranslationMutantsCurseHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "Mutant has awoken!", TranslationUtils.EncodeToUtf16("Мутант пробудился!"));
             TranslationUtils.ILTranslate(il, "Mutant has awoken!", TranslationUtils.EncodeToUtf16("Мутант пробудился!"), 2);
         }
     }
     
     public class SigilOfChampionsIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load() => IL.FargowiltasSouls.Items.Summons.SigilOfChampions.UseItem += TranslationSigilOfChampionsHook;
         
         public override void Unload() => IL.FargowiltasSouls.Items.Summons.SigilOfChampions.UseItem -= TranslationSigilOfChampionsHook;
         
         private void TranslationSigilOfChampionsHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "A strong spirit stirs...", TranslationUtils.EncodeToUtf16("Сильный дух будоражит..."));
             TranslationUtils.ILTranslate(il, "The core of the planet rumbles...", TranslationUtils.EncodeToUtf16("Ядро планеты урчит..."));
             TranslationUtils.ILTranslate(il, "A verdant wind is blowing...", TranslationUtils.EncodeToUtf16("Дует зелёный ветер..."));
             TranslationUtils.ILTranslate(il, "The stones tremble around you...", TranslationUtils.EncodeToUtf16("Камни дрожат вокруг вас..."));
             TranslationUtils.ILTranslate(il, "The stars are aligning...", TranslationUtils.EncodeToUtf16("Звезды выравниваются..."));
             TranslationUtils.ILTranslate(il, "Metallic groans echo from the depths...", TranslationUtils.EncodeToUtf16("Металлические стоны эхом разносятся из глубины..."));
             TranslationUtils.ILTranslate(il, "A wave of warmth passes over you...", TranslationUtils.EncodeToUtf16("Волна тепла проходит по тебе..."));
             TranslationUtils.ILTranslate(il, "The darkness of the night feels deeper...", TranslationUtils.EncodeToUtf16("Темнота ночи кажется глубже..."));
             TranslationUtils.ILTranslate(il, "You are surrounded by the rustling of trees...", TranslationUtils.EncodeToUtf16("Вы окружены шорохом деревьев..."));
             TranslationUtils.ILTranslate(il, "Nothing seems to answer the call...", TranslationUtils.EncodeToUtf16("Кажется, никто не отвечает на звонок..."));
         }
     }
     
     public class PiranhaPlantVoodooDollIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load() => IL.FargowiltasSouls.Patreon.LaBonez.PiranhaPlantVoodooDoll.UseItem += TranslationPiranhaPlantVoodooDollHook;
         
         public override void Unload() => IL.FargowiltasSouls.Patreon.LaBonez.PiranhaPlantVoodooDoll.UseItem -= TranslationPiranhaPlantVoodooDollHook;
         
         private void TranslationPiranhaPlantVoodooDollHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "The suffering continues.", TranslationUtils.EncodeToUtf16("Страдания продолжаются."));
             TranslationUtils.ILTranslate(il, "The suffering wanes.", TranslationUtils.EncodeToUtf16("Страдания ослабевают."));
         }
     }
     
     public class PatreonPlayerIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load() => IL.FargowiltasSouls.PatreonPlayer.OnEnterWorld += TranslationPatreonPlayerHook;
         
         public override void Unload() => IL.FargowiltasSouls.PatreonPlayer.OnEnterWorld -= TranslationPatreonPlayerHook;
         
         private void TranslationPatreonPlayerHook(ILContext il) => TranslationUtils.ILTranslate(il, "Your special patreon effects are active ", TranslationUtils.EncodeToUtf16("Ваш особый эффект патреона - "));
     }
     
     public class MutantSpawnIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load() => IL.FargowiltasSouls.Projectiles.Pets.MutantSpawn.BeCompanionCube += TranslationMutantSpawnHook;
         
         public override void Unload() => IL.FargowiltasSouls.Projectiles.Pets.MutantSpawn.BeCompanionCube -= TranslationMutantSpawnHook;
         
         private void TranslationMutantSpawnHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "Mutant has awoken!", TranslationUtils.EncodeToUtf16("Мутант пробудился!"));
             TranslationUtils.ILTranslate(il, "Mutant has awoken!", TranslationUtils.EncodeToUtf16("Мутант пробудился!"), 2);
             TranslationUtils.ILTranslate(il, "You think you're safe?", TranslationUtils.EncodeToUtf16("Думаете, вы в безопасности?"));
         }
     }
     
     public class MasochistIL : ILEdit
     {
         public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;
         
         public override void Load() => IL.FargowiltasSouls.Items.Masochist.UseItem += TranslationUseItemHook;
         
         public override void Unload() => IL.FargowiltasSouls.Items.Masochist.UseItem -= TranslationUseItemHook;
         
         private void TranslationUseItemHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "Eternity Mode initiated!", TranslationUtils.EncodeToUtf16("Режим Вечности активирован!"));
             TranslationUtils.ILTranslate(il, "Eternity Mode deactivated!", TranslationUtils.EncodeToUtf16("Режим Вечности деактивирован!"));
             TranslationUtils.ILTranslate(il, "Deviantt has awoken!", TranslationUtils.EncodeToUtf16("Девиантт пробудился!"));
             TranslationUtils.ILTranslate(il, "Deviantt has awoken!", TranslationUtils.EncodeToUtf16("Девиантт пробудился!"), 2);
         }
     }
}