// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using MonoMod.Cil;
// using MonoMod.RuntimeDetour.HookGen;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.SpiritMod
// {
//     public class UISpiritArtStateIL : ILEdit
//     {
//         private event ILContext.Manipulator ChangeTextureHook
//         {
//             add => HookEndpointManager.Modify(ModsCall.Spirit.Code.GetType("SpiritMod.Items.Books.UI.UISpiritArtState").GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(ModsCall.Spirit.Code.GetType("SpiritMod.Items.Books.UI.UISpiritArtState").GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => ModsCall.Spirit != null && TranslationUtils.IsRussianLanguage;
//
//         public override void Load() => ChangeTextureHook += TranslationChangeTextureHook;
//         
//         public override void Unload() => ChangeTextureHook -= TranslationChangeTextureHook;
//
//         private void TranslationChangeTextureHook(ILContext il) => TranslationUtils.ILTranslate(il, "SpiritMod/Items/Books/UI/TheSpirit", "CalamityRuTranslate/Mods/SpiritMod/TheSpirit");
//     }
//     
//     public class UILumothPageStateIL : ILEdit
//     {
//         private event ILContext.Manipulator ChangeTextureHook
//         {
//             add => HookEndpointManager.Modify(ModsCall.Spirit.Code.GetType("SpiritMod.Items.Books.UI.UILumothPageState").GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(ModsCall.Spirit.Code.GetType("SpiritMod.Items.Books.UI.UILumothPageState").GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => ModsCall.Spirit != null && TranslationUtils.IsRussianLanguage;
//
//         public override void Load() => ChangeTextureHook += TranslationChangeTextureHook;
//         
//         public override void Unload() => ChangeTextureHook -= TranslationChangeTextureHook;
//
//         private void TranslationChangeTextureHook(ILContext il) => TranslationUtils.ILTranslate(il, "SpiritMod/Items/Books/UI/LumothPage", "CalamityRuTranslate/Mods/SpiritMod/LumothPage");
//     }
//     
//     public class QuestBookUI : ILEdit
//     {
//         private event ILContext.Manipulator OnInitializeHook
//         {
//             add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.UI.QuestUI.QuestBookUI").GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.UI.QuestUI.QuestBookUI").GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         private event ILContext.Manipulator SelectQuestHook
//         {
//             add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.UI.QuestUI.QuestBookUI").GetMethod("SelectQuest", BindingFlags.Public | BindingFlags.Instance), value);
//         
//             remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.UI.QuestUI.QuestBookUI").GetMethod("SelectQuest", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         public override bool Autoload() => ModLoader.GetMod("SpiritMod") != null && TranslationUtils.IsRussianLanguage;
//         
//         public override void Load()
//         {
//             OnInitializeHook += TranslationOnInitializeHook;
//             SelectQuestHook += TranslationSelectQuestHook;
//         }
//     
//         public override void Unload()
//         {
//             OnInitializeHook -= TranslationOnInitializeHook;
//             SelectQuestHook += TranslationSelectQuestHook;
//         }
//         
//         private void TranslationOnInitializeHook(ILContext il)
//         {
//             TranslationUtils.ILTranslate(il, "Available", "Доступные");
//             TranslationUtils.ILTranslate(il, "Active", "Активные");
//             TranslationUtils.ILTranslate(il, "Completed", "Завершённые");
//             TranslationUtils.ILTranslate(il, "All", "Все");
//             TranslationUtils.ILTranslate(il, "Main", "Главные");
//             TranslationUtils.ILTranslate(il, "Explorer", "Иследование");
//             TranslationUtils.ILTranslate(il, "Forager", "Добыча");
//             TranslationUtils.ILTranslate(il, "Slayer", "Убийства");
//             TranslationUtils.ILTranslate(il, "Other", "Другие");
//             TranslationUtils.ILTranslate(il, "Activate", "Активировать");
//             TranslationUtils.ILTranslate(il, "Client - ", "Клиент - ");
//             TranslationUtils.ILTranslate(il, "Rewards", "Награды");
//             TranslationUtils.ILTranslate(il, "You cannot activate any more quests.", "Вы не можете активировать больше заданий.");
//             TranslationUtils.ILTranslate(il, "Are you sure? You will [c/910000:lose your progress].", "Вы уверены? Вы можете [c/910000:потерять весь ваш прогресс].");
//         }
//         
//         private void TranslationSelectQuestHook(ILContext il)
//         {
//             TranslationUtils.ILTranslate(il, "This quest hasn't been discovered.", "Это задание ещё не открыто.");
//             TranslationUtils.ILTranslate(il, "Objectives", "Цели");
//             TranslationUtils.ILTranslate(il, "Rewards", "Награды");
//             TranslationUtils.ILTranslate(il, "Claim rewards!", "Забрать награды!");
//             TranslationUtils.ILTranslate(il, "Deactivate", "Деактивировать");
//             TranslationUtils.ILTranslate(il, "Activate", "Активировать");
//             TranslationUtils.ILTranslate(il, "Client - ", "Клиент - ");
//         }
//     }
//     
//     // public class SlayerQuestOccultist : ILEdit
//     // {
//     //     private event ILContext.Manipulator QuestClientHook
//     //     {
//     //         add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.SlayerQuestOccultist").GetMethod("get_QuestClient", BindingFlags.Public | BindingFlags.Instance), value);
//     //     
//     //         remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.SlayerQuestOccultist").GetMethod("get_QuestClient", BindingFlags.Public | BindingFlags.Instance), value);
//     //     }
//     //     
//     //     private event ILContext.Manipulator QuestDescriptionHook
//     //     {
//     //         add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.SlayerQuestOccultist").GetMethod("get_QuestDescription", BindingFlags.Public | BindingFlags.Instance), value);
//     //     
//     //         remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.SlayerQuestOccultist").GetMethod("get_QuestDescription", BindingFlags.Public | BindingFlags.Instance), value);
//     //     }
//     //     
//     //     private event ILContext.Manipulator QuestCategoryHook
//     //     {
//     //         add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.SlayerQuestOccultist").GetMethod("get_QuestCategory", BindingFlags.Public | BindingFlags.Instance), value);
//     //     
//     //         remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.SlayerQuestOccultist").GetMethod("get_QuestCategory", BindingFlags.Public | BindingFlags.Instance), value);
//     //     }
//     //     
//     //     private event ILContext.Manipulator GetObjectivesHook
//     //     {
//     //         add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.SlayTask").GetMethod("GetObjectives", BindingFlags.Public | BindingFlags.Instance), value);
//     //     
//     //         remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.SlayTask").GetMethod("GetObjectives", BindingFlags.Public | BindingFlags.Instance), value);
//     //     }
//     //     
//     //     private event ILContext.Manipulator LoadHook
//     //     {
//     //         add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.QuestManager").GetMethod("Load", BindingFlags.Public | BindingFlags.Static), value);
//     //     
//     //         remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.QuestManager").GetMethod("Load", BindingFlags.Public | BindingFlags.Static), value);
//     //     }
//     //
//     //     public override bool Autoload() => ModLoader.GetMod("SpiritMod") != null && TranslationUtils.IsRussianLanguage;
//     //     
//     //     public override void Load()
//     //     {
//     //         QuestClientHook += TranslationQuestClientHook;
//     //         QuestDescriptionHook += TranslationQuestDescriptionHook;
//     //         QuestCategoryHook += TranslationQuestCategoryHook;
//     //         GetObjectivesHook += TranslationGetObjectivesHook;
//     //         //LoadHook += TranslationLoadHook;
//     //     }
//     //
//     //     public override void Unload()
//     //     {
//     //         QuestClientHook -= TranslationQuestClientHook;
//     //         QuestDescriptionHook -= TranslationQuestDescriptionHook;
//     //         QuestCategoryHook -= TranslationQuestCategoryHook;
//     //         GetObjectivesHook -= TranslationGetObjectivesHook;
//     //         //LoadHook -= TranslationLoadHook;
//     //     }
//     //     
//     //     private void TranslationQuestClientHook(ILContext il) => TranslationUtils.ILTranslate(il, "The Adventurer", "Авантюрист");
//     //     
//     //     private void TranslationQuestDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "As if these freaky Blood Moons weren't enough, a new necromancer has taken control over a horde of zombies! The freakshow keeps summonin' zombies and is sure to overrun our town if we don't do anythin'. If you see one, take it out immediately, you hear?", "Как будто этих жутких Кровавых Лун было недостаточно, новый некромант взял под контроль орду зомби! Чудовище продолжает вызывать зомби и, если мы ничего не предпримем, оно захватит наш город. Если увидите, немедленно уберите его, слышите?");
//     //     
//     //     private void TranslationGetObjectivesHook(ILContext il)
//     //     {
//     //         TranslationUtils.ILTranslate(il, "Kill ", "Убейте ");
//     //         //TranslationUtils.ILTranslate(il, "a", "");
//     //     }
//     //
//     //     private void TranslationQuestCategoryHook(ILContext il)
//     //     {
//     //         //TranslationUtils.ILTranslate(il, "Slayer", "Сlayer");
//     //     }
//     //     
//     //     private void TranslationLoadHook(ILContext il)
//     //     {
//     //         TranslationUtils.ILTranslate(il, "Slayer", "Убийство");
//     //     }
//     //     
//     //
//     //
//     //     //private void TranslationQuestCategoryHook(ILContext il) => TranslationUtils.ILTranslate(il, "Slayer", "Убийство");
//     // }
//     
//     public class UnidentifiedFloatingObjects : ILEdit
//     {
//         private event ILContext.Manipulator QuestNameHook
//         {
//             add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.FirstAdventure").GetMethod("get_QuestName", BindingFlags.Public | BindingFlags.Instance), value);
//     
//             remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.FirstAdventure").GetMethod("get_QuestName", BindingFlags.Public | BindingFlags.Instance), value);
//         }
//         
//         // private event ILContext.Manipulator QuestDescriptionHook
//         // {
//         //     add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.UnidentifiedFloatingObjects").GetMethod("get_QuestDescription", BindingFlags.Public | BindingFlags.Instance), value);
//         //
//         //     remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.UnidentifiedFloatingObjects").GetMethod("get_QuestDescription", BindingFlags.Public | BindingFlags.Instance), value);
//         // }
//         //
//         // private event ILContext.Manipulator QuestClientHook
//         // {
//         //     add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.UnidentifiedFloatingObjects").GetMethod("get_QuestClient", BindingFlags.Public | BindingFlags.Instance), value);
//         //
//         //     remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.UnidentifiedFloatingObjects").GetMethod("get_QuestClient", BindingFlags.Public | BindingFlags.Instance), value);
//         // }
//         //
//         // private event ILContext.Manipulator QuestCategoryHook
//         // {
//         //     add => HookEndpointManager.Modify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.UnidentifiedFloatingObjects").GetMethod("get_QuestCategory", BindingFlags.Public | BindingFlags.Instance), value);
//         //
//         //     remove => HookEndpointManager.Unmodify(ModLoader.GetMod("SpiritMod").Code.GetType("SpiritMod.Mechanics.QuestSystem.Quests.UnidentifiedFloatingObjects").GetMethod("get_QuestCategory", BindingFlags.Public | BindingFlags.Instance), value);
//         // }
//         
//         public override bool Autoload() => ModLoader.GetMod("SpiritMod") != null && TranslationUtils.IsRussianLanguage;
//         
//         public override void Load()
//         {
//             QuestNameHook += TranslationQuestNameHook;
//             // QuestDescriptionHook += TranslationQuestDescriptionHook;
//             // QuestClientHook += TranslationQuestClientHook;
//             // QuestCategoryHook += TranslationQuestCategoryHook;
//         }
//     
//         public override void Unload()
//         {
//             QuestNameHook -= TranslationQuestNameHook;
//             // QuestDescriptionHook -= TranslationQuestDescriptionHook;
//             // QuestClientHook -= TranslationQuestClientHook;
//             // QuestCategoryHook -= TranslationQuestCategoryHook;
//         }
//         
//         private void TranslationQuestNameHook(ILContext il) => TranslationUtils.ILTranslate(il, "The First Adventure", "Первое приключение");
//         
//         private void TranslationQuestDescriptionHook(ILContext il) => TranslationUtils.ILTranslate(il, "I quit drinkin' years ago, but I swear the sky's been lighting up something fierce recently! I've been doin' some research and I think the skies may be home to some mystical jellyfish swarms. Now, the only 'proof' I have are some sources of, er, ill repute, but I know I can count on you to check it out! And capture me the tastiest- I mean most interesting one!", "");
//         
//         private void TranslationQuestClientHook(ILContext il) => TranslationUtils.ILTranslate(il, "The Adventurer", "");
//         
//         private void TranslationQuestCategoryHook(ILContext il) => TranslationUtils.ILTranslate(il, "Main", "");
//     }
// }