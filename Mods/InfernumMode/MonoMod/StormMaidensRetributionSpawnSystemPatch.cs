using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode;
using InfernumMode.Content.Achievements;
using InfernumMode.Content.Projectiles.Rogue;
using InfernumMode.Core.GlobalInstances.Players;
using InfernumMode.Core.GlobalInstances.Systems;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class StormMaidensRetributionSpawnSystemPatch : OnPatcher
{
    private FieldInfo _AchievementInstances => typeof(AchievementPlayer).GetField("AchievementInstances", BindingFlags.Instance | BindingFlags.NonPublic);
    
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(StormMaidensRetributionSpawnSystem).GetCachedMethod(nameof(StormMaidensRetributionSpawnSystem.PostUpdateWorld));

    private delegate void PostUpdateWorldDelegate(StormMaidensRetributionSpawnSystem self);
    
    public override Delegate Delegate => Translation;

    private void Translation(PostUpdateWorldDelegate orig, StormMaidensRetributionSpawnSystem self)
    {
        if (!Main.rand.NextBool(1800) || !StormMaidensRetributionSpawnSystem.SpearCanBeSummoned)
            return;

        Vector2 spawnCenter = new Vector2(Main.spawnTileX, Main.spawnTileY) * 16f;
        Player closestPlayer = Main.player[Player.FindClosest(spawnCenter, 1, 1)];
        AchievementPlayer achievementPlayer = closestPlayer.GetModPlayer<AchievementPlayer>();
        List<Achievement> achievementInstances = (List<Achievement>) _AchievementInstances?.GetValue(achievementPlayer);
        if (achievementInstances.First(a => a.Name == "Плач").DoneCompletionEffects)
            return;

        if (closestPlayer.WithinRange(spawnCenter, 1800f))
        {
            Utilities.NewProjectileBetter(closestPlayer.Center + new Vector2(Main.rand.NextFromList(-1f, 1f) * Main.rand.NextFloat(150f, 500f), -1200f), Vector2.UnitY * 4f, ModContent.ProjectileType<StormMaidensRetributionWorldProj>(), 0, 0f);
        }
    }
}