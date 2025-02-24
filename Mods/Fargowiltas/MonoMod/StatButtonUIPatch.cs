﻿using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas;
using Fargowiltas.Items.Misc;
using Fargowiltas.UI;
using MonoMod.Cil;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class StatButtonUIRebuildStatList : OnPatcher
{
    private FieldInfo BattleCry => typeof(FargoPlayer).GetCachedField("BattleCry");
    private FieldInfo CalmingCry => typeof(FargoPlayer).GetCachedField("CalmingCry");

    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.RebuildStatList));
    
    private delegate void RebuildStatListDelegate(StatSheetUI self);

    public override Delegate Delegate => Translation;
    
    private void Translation(RebuildStatListDelegate orig, StatSheetUI self)
    {
        Player player = Main.LocalPlayer;
        FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>();

        self.InnerPanel.RemoveAllChildren();
        self.ColumnCounter = self.LineCounter = 0;

        double Damage(DamageClass damageClass) => Math.Round(player.GetTotalDamage(damageClass).Additive * player.GetTotalDamage(damageClass).Multiplicative * 100 - 100);
        int Crit(DamageClass damageClass) => (int)player.GetTotalCritChance(damageClass);

        self.AddStat($"Урон ближнего боя: {Damage(DamageClass.Melee)}%", ItemID.CopperBroadsword);
        self.AddStat($"Шанс крит. удара ближнего боя: {Crit(DamageClass.Melee)}%", ItemID.CopperBroadsword);
        self.AddStat($"Скорость атаки ближнего боя: {(int)Math.Round(player.GetAttackSpeed(DamageClass.Melee) * 100)}%", ItemID.CopperBroadsword);
        self.AddStat($"Стрелковый урон: {Damage(DamageClass.Ranged)}%", ItemID.CopperBow);
        self.AddStat($"Стрелковый шанс крит. удара: {Crit(DamageClass.Ranged)}%", ItemID.CopperBow);
        self.AddStat($"Магический урон: {Damage(DamageClass.Magic)}%", ItemID.WandofSparking);
        self.AddStat($"Магический шанс крит. удара: {Crit(DamageClass.Magic)}%", ItemID.WandofSparking);
        self.AddStat($"Расход маны: {Math.Round((1.0 - player.manaCost) * 100)}%", ItemID.WandofSparking);
        self.AddStat($"Урон призывателя: {Damage(DamageClass.Summon)}%", ItemID.SlimeStaff);
        
        if (ModsCall.FargoSouls != null)
        {
            self.AddStat($"Шанс крит. удара призывателя: {(int)ModsCall.FargoSouls.Call("GetSummonCrit")}%", ItemID.SlimeStaff);
        }
        else
        {
            self.AddStat("");
        }

        self.AddStat($"Максимальное число миньонов: {player.maxMinions}", ItemID.SlimeStaff);
        self.AddStat($"Максимальное число стражей: {player.maxTurrets}", ItemID.SlimeStaff);

        self.AddStat($"Пробивание брони: {player.GetArmorPenetration(DamageClass.Generic)}", ItemID.SharkToothNecklace);
        self.AddStat($"Агрессия: {player.aggro}", ItemID.FleshKnuckles);
        
        self.AddStat($"Здоровье: {player.statLifeMax2}", ItemID.LifeCrystal);
        self.AddStat($"Регенерация здоровья: {player.lifeRegen / 2}/сек", ItemID.BandofRegeneration);
        self.AddStat($"Мана: {player.statManaMax2}", ItemID.ManaCrystal);
        self.AddStat($"Восстановление маны: {player.manaRegen / 2}/sec", ItemID.ManaCrystal);
        self.AddStat($"Защита: {player.statDefense}", ItemID.CobaltShield);
        self.AddStat($"Сопротивление урону: {Math.Round(player.endurance * 100)}%", ItemID.WormScarf);
        self.AddStat($"Удача: {Math.Round(player.luck, 2)}", ItemID.Torch);
        self.AddStat($"Выполненных заданий рыбака: {player.anglerQuestsFinished}", ItemID.AnglerEarring);
        self.AddStat($"Боевой клич: {((bool) BattleCry.GetValue(modPlayer)! ? "[c/ff0000:Боевой]" : (bool) CalmingCry.GetValue(modPlayer)! ? "[c/00ffff:Успокаивающий]" : "Нет")}", ModContent.ItemType<BattleCry>());
        self.AddStat($"Максимальная скорость: {(int)((player.accRunSpeed + player.maxRunSpeed) / 2f * player.moveSpeed * 3)} км/ч", ItemID.HermesBoots);

        string RenderWingStat(double stat) => stat <= 0 ? "???" : stat.ToString();
        self.AddStat(player.wingTimeMax / 60 > 60 || player.empressBrooch ? "Время полёта: Да" : $"Время полёта: {RenderWingStat(Math.Round(player.wingTimeMax / 60.0, 2))} сек", ItemID.AngelWings);
        self.AddStat($"Максимальная скорость крыльев: {RenderWingStat(Math.Round(modPlayer.StatSheetWingSpeed * 32 / 6.25))} км/ч", ItemID.AngelWings);
        self.AddStat($"Модификатор взлёта крыльев: {RenderWingStat(Math.Round(modPlayer.StatSheetMaxAscentMultiplier * 100))}%", ItemID.AngelWings);
        self.AddStat($"Способность крыльев зависать: {(modPlayer.CanHover == null ? "???" : (bool) modPlayer.CanHover ? "Да" : "Нет")}", ItemID.AngelWings);
    }
}

public class StatButtonAddStat : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.AddStat));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 296, 390);
    };
}