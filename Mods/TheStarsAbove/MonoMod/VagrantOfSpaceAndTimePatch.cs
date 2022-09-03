﻿// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using StarsAbove.NPCs;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class VagrantOfSpaceAndTimePatch : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(VagrantOfSpaceAndTime).GetCachedMethod(nameof(VagrantOfSpaceAndTime.AI));
//
//     protected override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "You fall to the Vagrant of Space and Time...", "Вы пали перед Ходящим между пространством и временем...");
//         TranslationHelper.ModifyIL(il, "Ars Laevateinn prepares to strike!", "Арс Леватейн готовится к удару!");
//         TranslationHelper.ModifyIL(il, "Vagrant is protected by a shield of frost!", "Ходящий защищён щитом мороза!");
//         TranslationHelper.ModifyIL(il, "The Vagrant of Light is transcending his limits!", "Ходящий Светоносный выходит за свои лимиты!");
//         TranslationHelper.ModifyIL(il, "Concentrativity", "Концентративность");
//         TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад");
//         TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад", 2);
//         TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад", 3);
//         TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад", 4);
//         TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад", 5);
//         TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад", 6);
//         TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад", 7);
//         TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад", 8);
//         TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес");
//         TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес", 2);
//         TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес", 3);
//         TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес", 4);
//         TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес", 5);
//         TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес", 6);
//         TranslationHelper.ModifyIL(il, "A World Rent Asunder", "Разорванный мир");
//         TranslationHelper.ModifyIL(il, "A World Rent Asunder", "Разорванный мир", 2);
//         TranslationHelper.ModifyIL(il, "Surpassing Infinity", "За пределами бесконечности");
//         TranslationHelper.ModifyIL(il, "Surpassing Infinity", "За пределами бесконечности", 2);
//         TranslationHelper.ModifyIL(il, "Ascendance", "Вознесение");
//         TranslationHelper.ModifyIL(il, "Ascendance", "Вознесение", 2);
//         TranslationHelper.ModifyIL(il, "The Flood Of Light", "Поток света");
//         TranslationHelper.ModifyIL(il, "The Flood Of Light", "Поток света", 2);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber", "Корусантская сабля");
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II");
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 2);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 3);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 4);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 5);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 6);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 7);
//         TranslationHelper.ModifyIL(il, "Blazing Skies", "Пылающее небо");
//         TranslationHelper.ModifyIL(il, "Sanctified Slaughter", "Освящённая резня");
//         TranslationHelper.ModifyIL(il, "Sanctified Slaughter", "Освящённая резня", 2);
//         TranslationHelper.ModifyIL(il, "Sanctified Slaughter", "Освящённая резня", 3);
//         TranslationHelper.ModifyIL(il, "Sanctified Slaughter", "Освящённая резня", 4);
//         TranslationHelper.ModifyIL(il, "Sanctified Slaughter", "Освящённая резня", 5);
//         TranslationHelper.ModifyIL(il, "Sanctified Slaughter II", "Освящённая резня II");
//         TranslationHelper.ModifyIL(il, "Sanctified Slaughter II", "Освящённая резня II", 2);
//         TranslationHelper.ModifyIL(il, "Sanctified Slaughter II", "Освящённая резня II", 3);
//         TranslationHelper.ModifyIL(il, "Sanctified Slaughter II", "Освящённая резня II", 4);
//         TranslationHelper.ModifyIL(il, "Sanctified Slaughter II", "Освящённая резня II", 5);
//         TranslationHelper.ModifyIL(il, "Thousand Strikes", "Тысяча ударов");
//         TranslationHelper.ModifyIL(il, "Thousand Strikes", "Тысяча ударов", 2);
//         TranslationHelper.ModifyIL(il, "Thousand Strikes", "Тысяча ударов", 3);
//         TranslationHelper.ModifyIL(il, "Thousand Strikes", "Тысяча ударов", 4);
//         TranslationHelper.ModifyIL(il, "Thousand Strikes", "Тысяча ударов", 5);
//         TranslationHelper.ModifyIL(il, "Thousand Strikes ", "Тысяча ударов ");
//         TranslationHelper.ModifyIL(il, "Thousand Strikes ", "Тысяча ударов ", 2);
//         TranslationHelper.ModifyIL(il, "Thousand Strikes ", "Тысяча ударов ", 3);
//         TranslationHelper.ModifyIL(il, "Thousand Strikes ", "Тысяча ударов ", 4);
//         TranslationHelper.ModifyIL(il, "Thousand Strikes ", "Тысяча ударов ", 5);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II");
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 2);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 3);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 4);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 5);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 6);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 7);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец");
//         TranslationHelper.ModifyIL(il, "Synaptic Static", "Синаптическая статика");
//         TranslationHelper.ModifyIL(il, "Synaptic Static", "Синаптическая статика", 2);
//         TranslationHelper.ModifyIL(il, "Synaptic Static", "Синаптическая статика", 3);
//         TranslationHelper.ModifyIL(il, "Synaptic Static", "Синаптическая статика", 4);
//         TranslationHelper.ModifyIL(il, "Synaptic Static", "Синаптическая статика", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III");
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III");
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 6);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 7);
//         TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас");
//         TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас", 2);
//         TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас", 3);
//         TranslationHelper.ModifyIL(il, "Brain Drain", "Утечка мозгов");
//         TranslationHelper.ModifyIL(il, "Brain Drain", "Утечка мозгов", 2);
//         TranslationHelper.ModifyIL(il, "Brain Drain", "Утечка мозгов", 3);
//         TranslationHelper.ModifyIL(il, "Brain Drain", "Утечка мозгов", 4);
//         TranslationHelper.ModifyIL(il, "Brain Drain", "Утечка мозгов", 5);
//         TranslationHelper.ModifyIL(il, "Gravitational Anomaly", "Гравитационная аномалия");
//         TranslationHelper.ModifyIL(il, "Gravitational Anomaly", "Гравитационная аномалия", 2);
//         TranslationHelper.ModifyIL(il, "Gravitational Anomaly", "Гравитационная аномалия", 3);
//         TranslationHelper.ModifyIL(il, "Gravitational Anomaly", "Гравитационная аномалия", 4);
//         TranslationHelper.ModifyIL(il, "Gravitational Anomaly", "Гравитационная аномалия", 5);
//         TranslationHelper.ModifyIL(il, "Ars Laevateinn", "Арс Леватейн");
//         TranslationHelper.ModifyIL(il, "The Sword of Flames", "Меч пламени");
//         TranslationHelper.ModifyIL(il, "The Sword of Flames", "Меч пламени", 2);
//         TranslationHelper.ModifyIL(il, "The Sword of Flames", "Меч пламени", 3);
//         TranslationHelper.ModifyIL(il, "The Test Concludes", "Последнее испытание");
//         TranslationHelper.ModifyIL(il, "The Test Concludes", "Последнее испытание", 2);
//         TranslationHelper.ModifyIL(il, "The Test Concludes", "Последнее испытание", 3);
//         TranslationHelper.ModifyIL(il, "The Test Concludes", "Последнее испытание", 4);
//         TranslationHelper.ModifyIL(il, "The Test Concludes", "Последнее испытание", 5);
//         TranslationHelper.ModifyIL(il, "Aegis of Frost", "Эгида мороза");
//         TranslationHelper.ModifyIL(il, "Aegis of Frost", "Эгида мороза", 2);
//         TranslationHelper.ModifyIL(il, "Aegis of Frost", "Эгида мороза", 3);
//         TranslationHelper.ModifyIL(il, "Aegis of Frost", "Эгида мороза", 4);
//         TranslationHelper.ModifyIL(il, "Aegis of Frost", "Эгида мороза", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Thunder IV", "Абсолютная гроза IV");
//         TranslationHelper.ModifyIL(il, "Absolute Thunder IV", "Абсолютная гроза IV", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Thunder IV", "Абсолютная гроза IV", 3);
//         TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание");
//         TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание", 2);
//         TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость");
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 3);
//         TranslationHelper.ModifyIL(il, "Crack The Sky", "Расколоть небо");
//         TranslationHelper.ModifyIL(il, "Crack The Sky", "Расколоть небо", 2);
//         TranslationHelper.ModifyIL(il, "Crack The Sky", "Расколоть небо", 3);
//         TranslationHelper.ModifyIL(il, "Crack The Sky", "Расколоть небо", 4);
//         TranslationHelper.ModifyIL(il, "Crack The Sky", "Расколоть небо", 5);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты");
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 2);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 3);
//         TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ");
//         TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ", 2);
//         TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ", 3);
//         TranslationHelper.ModifyIL(il, "Light Rampant", "Раздолье света");
//         TranslationHelper.ModifyIL(il, "Light Rampant", "Раздолье света", 2);
//         TranslationHelper.ModifyIL(il, "Light Rampant", "Раздолье света", 3);
//         TranslationHelper.ModifyIL(il, "Radiant Braver", "Сияющий храбрец");
//         TranslationHelper.ModifyIL(il, "Radiant Braver", "Сияющий храбрец", 2);
//         TranslationHelper.ModifyIL(il, "Radiant Braver", "Сияющий храбрец", 3);
//         TranslationHelper.ModifyIL(il, "Radiant Desperado", "Сияющий отчаянный");
//         TranslationHelper.ModifyIL(il, "Radiant Desperado", "Сияющий отчаянный", 2);
//         TranslationHelper.ModifyIL(il, "Radiant Desperado", "Сияющий отчаянный", 3);
//         TranslationHelper.ModifyIL(il, "Meteor Shower", "Метеоритный дождь");
//         TranslationHelper.ModifyIL(il, "Meteor Shower", "Метеоритный дождь", 2);
//         TranslationHelper.ModifyIL(il, "Meteor Shower", "Метеоритный дождь", 3);
//         TranslationHelper.ModifyIL(il, "Meteor Shower", "Метеоритный дождь", 4);
//         TranslationHelper.ModifyIL(il, "Meteor Shower", "Метеоритный дождь", 5);
//         TranslationHelper.ModifyIL(il, "Quasar Forthcoming", "Пришествие квазара");
//         TranslationHelper.ModifyIL(il, "Quasar Forthcoming", "Пришествие квазара", 2);
//         TranslationHelper.ModifyIL(il, "Quasar Forthcoming", "Пришествие квазара", 3);
//         TranslationHelper.ModifyIL(il, "Quasar Forthcoming", "Пришествие квазара", 4);
//         TranslationHelper.ModifyIL(il, "Unlimited Blade Works", "Клинков бесконечный край");
//         TranslationHelper.ModifyIL(il, "Unlimited Blade Works", "Клинков бесконечный край", 2);
//         TranslationHelper.ModifyIL(il, "Unlimited Blade Works", "Клинков бесконечный край", 3);
//         TranslationHelper.ModifyIL(il, "Unlimited Blade Works", "Клинков бесконечный край", 4);
//         TranslationHelper.ModifyIL(il, "Plutonic Barrage", "Плутониевый шквал");
//         TranslationHelper.ModifyIL(il, "Plutonic Barrage", "Плутониевый шквал", 2);
//         TranslationHelper.ModifyIL(il, "Plutonic Barrage", "Плутониевый шквал", 3);
//         TranslationHelper.ModifyIL(il, "Plutonic Barrage", "Плутониевый шквал", 4);
//         TranslationHelper.ModifyIL(il, "Theofania Inanis", "Теофаниа Инанис");
//         TranslationHelper.ModifyIL(il, "Theofania Inanis", "Теофаниа Инанис", 2);
//         TranslationHelper.ModifyIL(il, "Theofania Inanis", "Теофаниа Инанис", 3);
//         TranslationHelper.ModifyIL(il, "Theofania Inanis", "Теофаниа Инанис", 4);
//         TranslationHelper.ModifyIL(il, "Theofania Inanis", "Теофаниа Инанис", 5);
//         TranslationHelper.ModifyIL(il, "Theofania Inanis", "Теофаниа Инанис", 6);
//         TranslationHelper.ModifyIL(il, "Spatial Rip", "Пространственный разрыв");
//         TranslationHelper.ModifyIL(il, "Spatial Rip", "Пространственный разрыв", 2);
//         TranslationHelper.ModifyIL(il, "Spatial Rip", "Пространственный разрыв", 3);
//         TranslationHelper.ModifyIL(il, "Spatial Rip", "Пространственный разрыв", 4);
//         TranslationHelper.ModifyIL(il, "Spatial Rip", "Пространственный разрыв", 5);
//         TranslationHelper.ModifyIL(il, "Transplacement", "Перенос");
//         TranslationHelper.ModifyIL(il, "Transplacement", "Перенос", 2);
//         TranslationHelper.ModifyIL(il, "Transplacement", "Перенос", 3);
//         TranslationHelper.ModifyIL(il, "Transplacement", "Перенос", 4);
//         TranslationHelper.ModifyIL(il, "Transplacement", "Перенос", 5);
//         TranslationHelper.ModifyIL(il, "Recall", "Возврат");
//         TranslationHelper.ModifyIL(il, "Recall", "Возврат", 2);
//         TranslationHelper.ModifyIL(il, "Recall", "Возврат", 3);
//         TranslationHelper.ModifyIL(il, "Recall", "Возврат", 4);
//         TranslationHelper.ModifyIL(il, "Recall", "Возврат", 5);
//         TranslationHelper.ModifyIL(il, "Relinquish", "Отказ");
//         TranslationHelper.ModifyIL(il, "Relinquish", "Отказ", 2);
//         TranslationHelper.ModifyIL(il, "Relinquish", "Отказ", 3);
//         TranslationHelper.ModifyIL(il, "Relinquish", "Отказ", 4);
//         TranslationHelper.ModifyIL(il, "Relinquish", "Отказ", 5);
//         TranslationHelper.ModifyIL(il, "Relinquish", "Отказ", 6);
//         TranslationHelper.ModifyIL(il, "Relinquish", "Отказ", 7);
//         TranslationHelper.ModifyIL(il, "Nebula Channeling", "Канал туманности");
//         TranslationHelper.ModifyIL(il, "Nebula Channeling", "Канал туманности", 2);
//         TranslationHelper.ModifyIL(il, "Nebula Channeling", "Канал туманности", 3);
//         TranslationHelper.ModifyIL(il, "Nebula Channeling", "Канал туманности", 4);
//         TranslationHelper.ModifyIL(il, "Vorpal Channeling", "Вихревой канал");
//         TranslationHelper.ModifyIL(il, "Vorpal Channeling", "Вихревой канал", 2);
//         TranslationHelper.ModifyIL(il, "Vorpal Channeling", "Вихревой канал", 3);
//         TranslationHelper.ModifyIL(il, "Vorpal Channeling", "Вихревой канал", 4);
//         TranslationHelper.ModifyIL(il, "Solar Channeling", "Солнечный канал");
//         TranslationHelper.ModifyIL(il, "Solar Channeling", "Солнечный канал", 2);
//         TranslationHelper.ModifyIL(il, "Solar Channeling", "Солнечный канал", 3);
//         TranslationHelper.ModifyIL(il, "Solar Channeling", "Солнечный канал", 4);
//         TranslationHelper.ModifyIL(il, "Starlit Channeling", "Звёздный канал");
//         TranslationHelper.ModifyIL(il, "Starlit Channeling", "Звёздный канал", 2);
//         TranslationHelper.ModifyIL(il, "Starlit Channeling", "Звёздный канал", 3);
//         TranslationHelper.ModifyIL(il, "Starlit Channeling", "Звёздный канал", 4);
//         TranslationHelper.ModifyIL(il, "Galactic Swarm", "Галактический рой");
//         TranslationHelper.ModifyIL(il, "Galactic Swarm", "Галактический рой", 2);
//         TranslationHelper.ModifyIL(il, "Galactic Swarm", "Галактический рой", 3);
//         TranslationHelper.ModifyIL(il, "Galactic Swarm", "Галактический рой", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв");
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв", 2);
//         TranslationHelper.ModifyIL(il, "Radiant Meteor", "Лучезарный метеор");
//         TranslationHelper.ModifyIL(il, "Radiant Meteor", "Лучезарный метеор", 2);
//         TranslationHelper.ModifyIL(il, "Shadowblast", "Теневой взрыв");
//         TranslationHelper.ModifyIL(il, "Shadowblast", "Теневой взрыв", 2);
//     };
// }