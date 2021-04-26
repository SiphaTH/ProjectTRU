using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using IL.FargowiltasSouls;
using IL.FargowiltasSouls.Items;
using IL.FargowiltasSouls.Items.Misc;
using IL.FargowiltasSouls.Items.Summons;
using IL.FargowiltasSouls.NPCs;
using IL.FargowiltasSouls.Patreon.LaBonez;
using IL.FargowiltasSouls.Projectiles.Pets;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Mods.FargowiltasSouls
{
    public class FargoPlayerIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            FargoPlayer.OnEnterWorld += TranslationOnEnterWorldHook;
            FargoPlayer.PreUpdate += TranslationPreUpdateHook;
            FargoPlayer.PreKill += TranslationPreKill;
            FargoPlayer.CatchFish += TranslationCatchFishHook;
        }

        public override void Unload()
        {
            FargoPlayer.OnEnterWorld -= TranslationOnEnterWorldHook;
            FargoPlayer.PreUpdate -= TranslationPreUpdateHook;
            FargoPlayer.PreKill -= TranslationPreKill;
            FargoPlayer.CatchFish -= TranslationCatchFishHook;
        }

        private void TranslationOnEnterWorldHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Fargo's Music Mod not found!", "Fargo's Music Mod не найден");
            TranslationUtils.ILTranslate(il, "Please install Fargo's Music Mod for the full experience!!", "Пожалуйста, установите Fargo's Music Mod для полноценного опыта!");
        }

        private void TranslationPreUpdateHook(ILContext il) => TranslationUtils.ILTranslate(il, " was pricked by a Cactus.", " был проколот кактусом.");

        private void TranslationPreKill(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "You've been revived!", "Вы возродились!");
            TranslationUtils.ILTranslate(il, "You've been revived!", "Вы возродились!", 2);
            TranslationUtils.ILTranslate(il, "You've been revived!", "Вы возродились!", 3);
            TranslationUtils.ILTranslate(il, " could not handle the infection.", " не справился с инфекцией.");
            TranslationUtils.ILTranslate(il, " rotted away.", " сгнил.");
            TranslationUtils.ILTranslate(il, " was annihilated by divine wrath.", " был истреблён божественным гневом.");
            TranslationUtils.ILTranslate(il, " was reaped by the cold hand of death.", " был сожжён холодной рукой смерти.");
        }

        private void TranslationCatchFishHook(ILContext il) => TranslationUtils.ILTranslate(il, "Duke Fishron EX has awoken!", "Герцог Рыброн ЕХ пробудился!");
    }

    public class FargowiltasIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => IL.FargowiltasSouls.Fargowiltas.HandlePacket += TranslationFargowiltasHook;

        public override void Unload() => IL.FargowiltasSouls.Fargowiltas.HandlePacket -= TranslationFargowiltasHook;

        private void TranslationFargowiltasHook(ILContext il) => TranslationUtils.ILTranslate(il, "Duke Fishron EX has awoken!", "Герцог Рыброн ЕХ пробудился!");
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
            TranslationUtils.ILTranslate(il, "Deviantt", "Девиантт");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}].", "Используйте [i:{0}].");
            TranslationUtils.ILTranslate(il, "Deviantt is satisfied with its show of love.", "Девиантт доволен своим проявлением любви.");
            TranslationUtils.ILTranslate(il, "Abominationn", "Мерзостть");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}].", "Используйте [i:{0}].", 2);
            TranslationUtils.ILTranslate(il, "Abominationn has destroyed everyone.", "Мерзостть уничтожил всех.");
            TranslationUtils.ILTranslate(il, "Mutant", "Мутант");
            TranslationUtils.ILTranslate(il, "Throw [i:{0}] into a pool of lava while Abominationn is alivem in Mutant's presence.", "Бросьте [i:{0}] в лаву, пока Мерзостть жив и в присутствие Мутанта.");
            TranslationUtils.ILTranslate(il, "Mutant has eviscerated everyone under its hands.", "Мутант выпотрошил всех своими руки.");
        }

        private void TranslationInitializeMinibossesHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Champion of Timber", "Чемпион леса");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] on the surface during the day.", "Используйте [i:{0}] днём на поверхности.");
            TranslationUtils.ILTranslate(il, "Champion of Timber returns to its squirrel clan...", "Чемпион леса возвращается в свой белчий клан...");
            TranslationUtils.ILTranslate(il, "Champion of Terra", "Чемпион земли");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] underground.", "Используйте [i:{0}] под землёй.");
            TranslationUtils.ILTranslate(il, "Champion of Terra vanishes into the caverns...", "Чемпион земли исчезает в пещерах...");
            TranslationUtils.ILTranslate(il, "Champion of Earth", "Чемпион планеты");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in the underworld.", "Используйте [i:{0}] в аду.");
            TranslationUtils.ILTranslate(il, "Champion of Earth disappears beneath the magma...", "Чемпион планеты исчезает под магмой...");
            TranslationUtils.ILTranslate(il, "Champion of Nature", "Чемпион природы");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in underground snow.", "Используйте [i:{0}] подземных снегах.");
            TranslationUtils.ILTranslate(il, "Champion of Nature returns to its slumber", "Чемпион природы возвращается в свой сон.");
            TranslationUtils.ILTranslate(il, "Champion of Life", "Чемпион жизни");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in the Hallow at day.", "Используйте [i:{0}] днём в святых землях.");
            TranslationUtils.ILTranslate(il, "Champion of Life fades away...", "Чемпион жизни исчезает...");
            TranslationUtils.ILTranslate(il, "Champion of Shadow", "Чемпион тени");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in the Corruption or Crimson at night.", "Используйте [i:{0}] ночью в искажении или багрянце.");
            TranslationUtils.ILTranslate(il, "Champion of Shadow fades away...", "Чемпион тени исчезает...");
            TranslationUtils.ILTranslate(il, "Champion of Spirit", "Чемпион духа");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in the underground desert.", "Используйте [i:{0}] в подземной пустыне.");
            TranslationUtils.ILTranslate(il, "Champion of Spirit vanishes into the desert...", "Чемпион духа исчезает в пустыне...");
            TranslationUtils.ILTranslate(il, "Champion of Will", "Чемпион воли");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] at the ocean.", "Используйте [i:{0}] в океане.");
            TranslationUtils.ILTranslate(il, "Champion of Will returns to the depths...", "Чемпион воли возвращается в глубины...");
            TranslationUtils.ILTranslate(il, "Eridanus, Champion of Cosmos", "Эридан, чемпион космоса");
            TranslationUtils.ILTranslate(il, "Spawn by using [i:{0}] in space.", "Используйте [i:{0}] в космосе.");
            TranslationUtils.ILTranslate(il, "Eridanus, Champion of Cosmos returns to the stars...", "Эридан, чемпион космоса возвращается к звёздам...");
        }
     }

    public class EModeGlobalNPCIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load()
        {
            EModeGlobalNPC.KingSlimeAI += TranslationKingSlimeAIHook;
            EModeGlobalNPC.QueenBeeAI += TranslationQueenBeeAIHook;
            EModeGlobalNPC.SetDefaults += TranslationSetDefaultsHook;
            EModeGlobalNPC.PreAI += TranslationPreAIHook;
            EModeGlobalNPC.OnHitPlayer += TranslationOnHitPlayerHook;
            EModeGlobalNPC.CheckDead += TranslationCheckDeadHook;
            EModeGlobalNPC.ModifyHitByItem += TranslationModifyHitByItemHook;
        }

        public override void Unload()
        {
            EModeGlobalNPC.KingSlimeAI -= TranslationKingSlimeAIHook;
            EModeGlobalNPC.QueenBeeAI -= TranslationQueenBeeAIHook;
            EModeGlobalNPC.SetDefaults -= TranslationSetDefaultsHook;
            EModeGlobalNPC.PreAI -= TranslationPreAIHook;
            EModeGlobalNPC.OnHitPlayer -= TranslationOnHitPlayerHook;
            EModeGlobalNPC.CheckDead -= TranslationCheckDeadHook;
            EModeGlobalNPC.ModifyHitByItem -= TranslationModifyHitByItemHook;
        }

         private void TranslationKingSlimeAIHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "King Slime has enraged!", "Король слизней в ярости!");
             TranslationUtils.ILTranslate(il, "King Slime has enraged!", "Король слизней в ярости!", 2);
         }

         private void TranslationQueenBeeAIHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "Royal Subject has awoken!", "Королевская особа пробудилась!");
             TranslationUtils.ILTranslate(il, "Royal Subject has awoken!", "Королевская особа пробудилась!", 2);
             TranslationUtils.ILTranslate(il, "Royal Subject has awoken!", "Королевская особа пробудилась!", 3);
             TranslationUtils.ILTranslate(il, "Royal Subject has awoken!", "Королевская особа пробудилась!", 4);
         }

         private void TranslationSetDefaultsHook(ILContext il) => TranslationUtils.ILTranslate(il, "Duke Fishron EX", "Герцог Рыброн ЕХ");

         private void TranslationPreAIHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, " sucked dry.", " выдохся.");
             TranslationUtils.ILTranslate(il, "A Clown has begun ticking!", "Клоун начал тикать!");
             TranslationUtils.ILTranslate(il, "A Clown has begun ticking!", "Клоун начал тикать!", 2);
             TranslationUtils.ILTranslate(il, "A Clown has exploded!", "Клоун взорвался!");
             TranslationUtils.ILTranslate(il, "A Clown has exploded!", "Клоун взорвался!", 2);
         }

         private void TranslationOnHitPlayerHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, " was eaten alive by a Man Eater.", " был съеден заживо людоедом.");
             TranslationUtils.ILTranslate(il, " was eaten alive by an Angry Trapper.", " был съеден заживо злым ловцом.");
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!");
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 2);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 3);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 4);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 5);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 6);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 7);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 8);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 9);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 10);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 11);
             TranslationUtils.ILTranslate(il, "An item was stolen from you!", "У вас украли предмет!", 12);
         }

         private void TranslationCheckDeadHook(ILContext il)
         {
             TranslationUtils.ILTranslate(il, "Skeletron has entered Dungeon Guardian form!", "Скелетрон принял форму стража темницы!");
             TranslationUtils.ILTranslate(il, "Skeletron has entered Dungeon Guardian form!", "Скелетрон принял форму стража темницы!", 2);
             TranslationUtils.ILTranslate(il, "Duke Fishron EX has been defeated!", "Герцог Рыброн ЕХ был побеждён!");
             TranslationUtils.ILTranslate(il, "Duke Fishron EX has been defeated!", "Герцог Рыброн ЕХ был побеждён!", 2);
         }

         private void TranslationModifyHitByItemHook(ILContext il) => TranslationUtils.ILTranslate(il, " was impaled by a Giant Tortoise.", " был пронзён гигантской черепахой.");
     }

    public class MutantsFuryIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => MutantsFury.UseItem += TranslationMutantsFuryHook;

        public override void Unload() => MutantsFury.UseItem -= TranslationMutantsFuryHook;

        private void TranslationMutantsFuryHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Mutant is angered!", "Мутант в ярости!");
            TranslationUtils.ILTranslate(il, "Mutant is calm.", "Мутант спокоен.");
        }
    }

    public class AbominationnVoodooDollIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => AbominationnVoodooDoll.Update += TranslationAbominationnVoodooDollHook;

        public override void Unload() => AbominationnVoodooDoll.Update -= TranslationAbominationnVoodooDollHook;

        private void TranslationAbominationnVoodooDollHook(ILContext il) => TranslationUtils.ILTranslate(il, "Mutant has been enraged by the death of his brother!", "Мутант в ярости от гибели брата!");
    }

    public class AbomsCurseIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => AbomsCurse.UseItem += TranslationAbomsCurseHook;

        public override void Unload() => AbomsCurse.UseItem -= TranslationAbomsCurseHook;

        private void TranslationAbomsCurseHook(ILContext il) => TranslationUtils.ILTranslate(il, "Abominationn has awoken!", "Мерзостть пробудился!");
    }

    public class DevisCurseIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => DevisCurse.UseItem += TranslationDevisCurseHook;

        public override void Unload() => DevisCurse.UseItem -= TranslationDevisCurseHook;

        private void TranslationDevisCurseHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Deviantt has awoken!", "Девиантт пробудился!");
            TranslationUtils.ILTranslate(il, "Deviantt has awoken!", "Девиантт пробудился!", 2);
        }
    }

    public class MutantsCurseIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => MutantsCurse.UseItem += TranslationMutantsCurseHook;

        public override void Unload() => MutantsCurse.UseItem -= TranslationMutantsCurseHook;

        private void TranslationMutantsCurseHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Mutant has awoken!", "Мутант пробудился!");
            TranslationUtils.ILTranslate(il, "Mutant has awoken!", "Мутант пробудился!", 2);
        }
    }

    public class SigilOfChampionsIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => SigilOfChampions.UseItem += TranslationSigilOfChampionsHook;

        public override void Unload() => SigilOfChampions.UseItem -= TranslationSigilOfChampionsHook;

        private void TranslationSigilOfChampionsHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "A strong spirit stirs...", "Сильный дух будоражит...");
            TranslationUtils.ILTranslate(il, "The core of the planet rumbles...", "Ядро планеты урчит...");
            TranslationUtils.ILTranslate(il, "A verdant wind is blowing...", "Дует зелёный ветер...");
            TranslationUtils.ILTranslate(il, "The stones tremble around you...", "Камни дрожат вокруг вас...");
            TranslationUtils.ILTranslate(il, "The stars are aligning...", "Звезды выравниваются...");
            TranslationUtils.ILTranslate(il, "Metallic groans echo from the depths...", "Металлические стоны эхом разносятся из глубины...");
            TranslationUtils.ILTranslate(il, "A wave of warmth passes over you...", "Волна тепла проходит по тебе...");
            TranslationUtils.ILTranslate(il, "The darkness of the night feels deeper...", "Темнота ночи кажется глубже...");
            TranslationUtils.ILTranslate(il, "You are surrounded by the rustling of trees...", "Вы окружены шорохом деревьев...");
            TranslationUtils.ILTranslate(il, "Nothing seems to answer the call...", "Кажется, никто не отвечает на звонок...");
        }
    }

    public class PiranhaPlantVoodooDollIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => PiranhaPlantVoodooDoll.UseItem += TranslationPiranhaPlantVoodooDollHook;

        public override void Unload() => PiranhaPlantVoodooDoll.UseItem -= TranslationPiranhaPlantVoodooDollHook;

        private void TranslationPiranhaPlantVoodooDollHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "The suffering continues.", "Страдания продолжаются.");
            TranslationUtils.ILTranslate(il, "The suffering wanes.", "Страдания ослабевают.");
        }
    }

    public class PatreonPlayerIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => PatreonPlayer.OnEnterWorld += TranslationPatreonPlayerHook;

        public override void Unload() => PatreonPlayer.OnEnterWorld -= TranslationPatreonPlayerHook;

        private void TranslationPatreonPlayerHook(ILContext il) => TranslationUtils.ILTranslate(il, "Your special patreon effects are active ", "Ваш особый эффект патреона - ");
    }

    public class MutantSpawnIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => MutantSpawn.BeCompanionCube += TranslationMutantSpawnHook;

        public override void Unload() => MutantSpawn.BeCompanionCube -= TranslationMutantSpawnHook;

        private void TranslationMutantSpawnHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Mutant has awoken!", "Мутант пробудился!");
            TranslationUtils.ILTranslate(il, "Mutant has awoken!", "Мутант пробудился!", 2);
            TranslationUtils.ILTranslate(il, "You think you're safe?", "Думаете, вы в безопасности?");
        }
    }

    public class MasochistIL : ILEdit
    {
        public override bool Autoload() => ModsCall.FargoSouls != null && TranslationUtils.IsRussianLanguage;

        public override void Load() => Masochist.UseItem += TranslationUseItemHook;

        public override void Unload() => Masochist.UseItem -= TranslationUseItemHook;

        private void TranslationUseItemHook(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "Eternity Mode initiated!", "Режим Вечности активирован!");
            TranslationUtils.ILTranslate(il, "Eternity Mode deactivated!", "Режим Вечности деактивирован!");
            TranslationUtils.ILTranslate(il, "Deviantt has awoken!", "Девиантт пробудился!");
            TranslationUtils.ILTranslate(il, "Deviantt has awoken!", "Девиантт пробудился!", 2);
        }
    }
}