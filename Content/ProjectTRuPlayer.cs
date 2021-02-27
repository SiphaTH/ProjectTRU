// using System.Collections.Generic;
// using CalamityRuTranslate.Content.Vanity.Yum;
// using Microsoft.Xna.Framework;
// using Microsoft.Xna.Framework.Graphics;
// using Terraria;
// using Terraria.DataStructures;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Content
// {
//     public class ProjectTRuPlayer : ModPlayer
//     {
//         public bool SetYumAllowed = true;
//         public bool SetYum;
//         public bool SetYumDraw => SetYum && SetYumAllowed;
//
//         public override void ResetEffects()
//         {
//             SetYumAllowed = true;
//             SetYum = false;
//         }
//         
//         public override void PostUpdateEquips()
//         {
//             int vanityHead = 10;
//             int vanityBody = 11;
//             int vanityLegs = 12;
//             
//             Item itemVanityHead = player.armor[vanityHead];
//             Item itemVanityBody = player.armor[vanityBody];
//             Item itemVanityLegs = player.armor[vanityLegs];
//             
//             if (itemVanityHead.type > 0 && itemVanityHead.type != ModContent.ItemType<YumHood>())
//             {
//                 SetYumAllowed = false;
//             }
//             
//             if (itemVanityBody.type > 0 && itemVanityBody.type != ModContent.ItemType<YumChest>())
//             {
//                 SetYumAllowed = false;
//             }
//             
//             if (itemVanityLegs.type > 0 && itemVanityLegs.type != ModContent.ItemType<YumBoots>())
//             {
//                 SetYumAllowed = false;
//             }
//         }
//
//         public override void ModifyDrawLayers(List<PlayerLayer> layers)
//         {
//             int index = layers.IndexOf(PlayerLayer.Head);
//             if (index != -1)
//             {
//                 layers.Insert(index + 1, HeadGlow);
//             }
//             index = layers.IndexOf(PlayerLayer.Body);
//             if (index != -1)
//             {
//                 layers.Insert(index + 1, BodyGlow);
//             }
//             index = layers.IndexOf(PlayerLayer.Arms);
//             if (index != -1)
//             {
//                 layers.Insert(index + 1, ArmsGlow);
//             }
//             
//             HeadGlow.visible = true;
//             BodyGlow.visible = true;
//             ArmsGlow.visible = true;
//         }
//
//         public static readonly PlayerLayer HeadGlow = new PlayerLayer("ProjectTRuPlayer", "HeadGlow", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
//         {
//             Player drawPlayer = drawInfo.drawPlayer;
//             ProjectTRuPlayer modPlayer = drawPlayer.GetModPlayer<ProjectTRuPlayer>();
//             Color color = drawPlayer.GetImmuneAlphaPure(Color.White, drawInfo.shadow);
//             Texture2D texture = null;
//
//             if (drawInfo.shadow != 0f || drawInfo.drawPlayer.invis)
//             {
//                 return;
//             }
//             
//             Mod mod = ModLoader.GetMod("CalamityRuTranslate");
//             
//             if (modPlayer.SetYumDraw)
//             {
//                 texture = mod.GetTexture("Content/Glowmasks/YumHood_Glow");
//             }
//             
//             if (texture == null)
//             {
//                 return;
//             }
//             
//             Vector2 drawPos = drawInfo.position - Main.screenPosition + new Vector2(drawPlayer.width / 2 - drawPlayer.bodyFrame.Width / 2, drawPlayer.height - drawPlayer.bodyFrame.Height + 4f) + drawPlayer.headPosition;
//             DrawData drawData = new DrawData(texture, drawPos.Floor() + drawInfo.headOrigin, drawPlayer.bodyFrame, color, drawPlayer.headRotation, drawInfo.headOrigin, 1f, drawInfo.spriteEffects, 0)
//             {
//                 shader = drawInfo.headArmorShader
//             };
//             Main.playerDrawData.Add(drawData);
//         });
//         
//         public static readonly PlayerLayer BodyGlow = new PlayerLayer("ProjectTRuPlayer", "BodyGlow", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
//         {
//             Player drawPlayer = drawInfo.drawPlayer;
//             ProjectTRuPlayer modPlayer = drawPlayer.GetModPlayer<ProjectTRuPlayer>();
//             Color color = drawPlayer.GetImmuneAlphaPure(Color.White, drawInfo.shadow);
//             Texture2D texture = null;
//
//             if (drawInfo.shadow != 0f || drawInfo.drawPlayer.invis)
//             {
//                 return;
//             }
//             
//             Mod mod = ModLoader.GetMod("CalamityRuTranslate");
//             
//             if (modPlayer.SetYumDraw)
//             {
//                 texture = mod.GetTexture(drawPlayer.Male ? "Content/Glowmasks/YumChest_Glow" : "Content/Glowmasks/YumChestFemale_Glow");
//             }
//             
//             if (texture == null)
//             {
//                 return;
//             }
//             
//             Vector2 drawPos = drawInfo.position - Main.screenPosition + new Vector2(drawPlayer.width / 2 - drawPlayer.bodyFrame.Width / 2, drawPlayer.height - drawPlayer.bodyFrame.Height + 4f) + drawPlayer.bodyPosition;
//             DrawData drawData = new DrawData(texture, drawPos.Floor() + drawPlayer.bodyFrame.Size() / 2, drawPlayer.bodyFrame, color, drawPlayer.bodyRotation, drawInfo.bodyOrigin, 1f, drawInfo.spriteEffects, 0)
//             {
//                 shader = drawInfo.bodyArmorShader
//             };
//             Main.playerDrawData.Add(drawData);
//         });
//         
//         public static readonly PlayerLayer ArmsGlow = new PlayerLayer("ProjectTRuPlayer", "ArmsGlow", PlayerLayer.Arms, delegate (PlayerDrawInfo drawInfo)
//         {
//             Player drawPlayer = drawInfo.drawPlayer;
//             ProjectTRuPlayer modPlayer = drawPlayer.GetModPlayer<ProjectTRuPlayer>();
//             Color color = drawPlayer.GetImmuneAlphaPure(Color.White, drawInfo.shadow);
//             Texture2D texture = null;
//
//             if (drawInfo.shadow != 0f || drawInfo.drawPlayer.invis)
//             {
//                 return;
//             }
//             Mod mod = ModLoader.GetMod("CalamityRuTranslate");
//
//             if (modPlayer.SetYumDraw)
//             {
//                 texture = mod.GetTexture("Content/Glowmasks/YumChestArms_Glow");
//             }
//
//             if (texture == null)
//             {
//                 return;
//             }
//
//             Vector2 drawPos = drawInfo.position - Main.screenPosition + new Vector2(drawPlayer.width / 2 - drawPlayer.bodyFrame.Width / 2, drawPlayer.height - drawPlayer.bodyFrame.Height + 4f) + drawPlayer.bodyPosition;
//             DrawData drawData = new DrawData(texture, drawPos.Floor() + drawPlayer.bodyFrame.Size() / 2, drawPlayer.bodyFrame, color, drawPlayer.bodyRotation, drawInfo.bodyOrigin, 1f, drawInfo.spriteEffects, 0)
//             {
//                 shader = drawInfo.bodyArmorShader
//             };
//             Main.playerDrawData.Add(drawData);
//         });
//     }
// }