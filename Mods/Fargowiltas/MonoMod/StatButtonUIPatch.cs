// using System;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using Fargowiltas;
// using Fargowiltas.Items.Misc;
// using Fargowiltas.UI;
// using MonoMod.Cil;
// using MonoMod.RuntimeDetour.HookGen;
// using Terraria;
// using Terraria.ID;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;
//
// [JITWhenModsEnabled("Fargowiltas")]
// public class StatButtonUIRebuildStatList : ILEdit
// {
//     private MethodInfo _rebuildStatList => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.RebuildStatList));
//
//     private delegate void orig_RebuildStatList(StatSheetUI self);
//     private delegate void hook_RebuildStatList(orig_RebuildStatList orig, StatSheetUI self);
//
//     private event hook_RebuildStatList OnRebuildStatList
//     {
//         add => HookEndpointManager.Add<hook_RebuildStatList>(_rebuildStatList, value);
//         remove => HookEndpointManager.Remove<hook_RebuildStatList>(_rebuildStatList, value);
//     }
//     
//     public override bool Autoload() => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;
//
//     public override void Load()
//     {
//         OnRebuildStatList += Translation;
//     }
//     
//     public override void Unload()
//     {
//         OnRebuildStatList -= Translation;
//     }
//
//     private void Translation(orig_RebuildStatList orig, StatSheetUI self)
//     {
//         Player player = Main.LocalPlayer;
//         FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>();
//
//         self.InnerPanel.RemoveAllChildren();
//         self.ColumnCounter = self.LineCounter = 0;
//
//         double Damage(DamageClass damageClass) => Math.Round(player.GetTotalDamage(damageClass).Additive * player.GetTotalDamage(damageClass).Multiplicative * 100 - 100);
//         int Crit(DamageClass damageClass) => (int)player.GetTotalCritChance(damageClass);
//
//         self.AddStat($"Урон ближнего боя: {Damage(DamageClass.Melee)}%", ItemID.CopperBroadsword);
//         self.AddStat($"Шанс критического удара ближнего боя: {Crit(DamageClass.Melee)}%", ItemID.CopperBroadsword);
//         self.AddStat($"Скорость атаки ближнего боя: {(int)(1f / player.GetAttackSpeed(DamageClass.Melee) * 100)}%", ItemID.CopperBroadsword);
//         self.AddStat($"Стрелковый урон: {Damage(DamageClass.Ranged)}%", ItemID.CopperBow);
//         self.AddStat($"Стрелковый шанс критического удара: {Crit(DamageClass.Ranged)}%", ItemID.CopperBow);
//         self.AddStat($"Магический урон: {Damage(DamageClass.Magic)}%", ItemID.WandofSparking);
//         self.AddStat($"Магический шанс критического удара: {Crit(DamageClass.Magic)}%", ItemID.WandofSparking);
//         self.AddStat($"Расход маны: {Math.Round((1.0 - player.manaCost) * 100)}%", ItemID.WandofSparking);
//         self.AddStat($"Урон призывателя: {Damage(DamageClass.Summon)}%", ItemID.SlimeStaff);
//         if (ModsCall.TryGetFargoSouls)
//         {
//             self.AddStat($"Шанс критического удара призывателя: {(int)ModLoader.GetMod("FargowiltasSouls").Call("GetSummonCrit")}%", ItemID.SlimeStaff);
//         }
//         else
//         {
//             self.AddStat("");
//         }
//
//         self.AddStat($"Максимальное число миньонов: {player.maxMinions}", ItemID.SlimeStaff);
//         self.AddStat($"Максимальное число стражей: {player.maxTurrets}", ItemID.SlimeStaff);
//
//         self.AddStat($"Пробивание брони: {player.GetArmorPenetration(DamageClass.Generic)}", ItemID.SharkToothNecklace);
//         self.AddStat($"Агрессия: {player.aggro}", ItemID.FleshKnuckles);
//         
//         self.AddStat($"Здоровье: {player.statLifeMax2}", ItemID.LifeCrystal);
//         self.AddStat($"Регенерация здоровья: {player.lifeRegen / 2}/сек", ItemID.BandofRegeneration);
//         self.AddStat($"Мана: {player.statManaMax2}", ItemID.ManaCrystal);
//         self.AddStat($"Восстановление маны: {player.manaRegen / 2}/sec", ItemID.ManaCrystal);
//         self.AddStat($"Защита: {player.statDefense}", ItemID.CobaltShield);
//         self.AddStat($"Сопротивление урону: {Math.Round(player.endurance * 100)}%", ItemID.WormScarf);
//         self.AddStat($"Удача: {Math.Round(player.luck, 2)}", ItemID.Torch);
//         self.AddStat($"Выполненных заданий рыбака: {player.anglerQuestsFinished}", ItemID.AnglerEarring);
//         self.AddStat($"Максимальная скорость: {(int)((player.accRunSpeed + player.maxRunSpeed) / 2f * player.moveSpeed * 6)} км/ч", ItemID.HermesBoots);
//
//         string RenderWingStat(double stat) => stat <= 0 ? "???" : stat.ToString();
//         self.AddStat(player.wingTimeMax / 60 > 60 || player.empressBrooch ? "Время полёта: Да" : $"Время полёта: {RenderWingStat(Math.Round(player.wingTimeMax / 60.0, 2))} сек", ItemID.AngelWings);
//         self.AddStat($"Максимальная скорость крыльев: {RenderWingStat(Math.Round(modPlayer.StatSheetWingSpeed * 32 / 6.25))} км/ч", ItemID.AngelWings);
//         self.AddStat($"Модификатор взлёта крыльев: {RenderWingStat(Math.Round(modPlayer.StatSheetMaxAscentMultiplier * 100))}%", ItemID.AngelWings);
//         self.AddStat($"Способность крыльев зависать: {(modPlayer.CanHover == null ? "???" : (bool) modPlayer.CanHover ? "Да" : "Нет")}", ItemID.AngelWings);
//     }
// } 
//
// [JITWhenModsEnabled("Fargowiltas")]
// public class StatButtonAddStat : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.AddStat));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, 296, 460);
//     };
// }
//
// [JITWhenModsEnabled("Fargowiltas")]
// public class StatButtonOnInitialize : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.TryGetFargo && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.OnInitialize));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, 600f, 700f);
//         TranslationHelper.ModifyIL(il, 588f, 700f);
//         TranslationHelper.ModifyIL(il, 592, 700);
//     };
// }