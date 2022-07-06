// using System.Collections.Generic;
// using CalamityRuTranslate.Core;
// using Microsoft.Xna.Framework;
// using Microsoft.Xna.Framework.Graphics;
// using Terraria;
// using Terraria.DataStructures;
// using Terraria.ID;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Content
// {
//     public class TRuGlowmask : ModPlayer, ILoadable
//     {
//         private readonly Dictionary<int, Texture2D> _itemGlowMask = new Dictionary<int, Texture2D>();
//
//         public float Priority => 1f;
//         public void Load() { }
//
//         public void Unload()
//         {
// 	        _itemGlowMask.Clear();
//         }
//
//         public void AddGlowMask(int itemType, string texturePath)
//         {
//             _itemGlowMask[itemType] = ModContent.GetTexture(texturePath);
//         }
//
//         public override void ModifyDrawLayers(List<PlayerLayer> layers)
//         {
// 	        Texture2D textureHead;
// 	        if (!player.armor[10].IsAir)
// 	        {
// 		        if (player.armor[10].type >= ItemID.Count && _itemGlowMask.TryGetValue(Player.armor[10].type, out textureHead))
// 		        {
// 			        InsertAfterVanillaLayer(layers, "Head", new PlayerLayer(Mod.Name, "GlowMaskHead", delegate(PlayerDrawInfo info)
// 			        {
// 				        DrawArmorGlowMask(EquipType.Head, textureHead, info);
// 			        }));
// 		        }
// 	        }
// 	        else if (player.armor[0].type >= ItemID.Count && _itemGlowMask.TryGetValue(player.armor[0].type, out textureHead))
// 	        {
// 		        InsertAfterVanillaLayer(layers, "Head", new PlayerLayer(Mod.Name, "GlowMaskHead", delegate(PlayerDrawInfo info)
// 		        {
// 			        DrawArmorGlowMask(EquipType.Head, textureHead, info);
// 		        }));
// 	        }
//
// 	        Texture2D textureBody;
// 	        if (!player.armor[11].IsAir)
// 	        {
// 	        	if (player.armor[11].type >= ItemID.Count && _itemGlowMask.TryGetValue(player.armor[11].type, out textureBody))
// 	        	{
// 	        		InsertAfterVanillaLayer(layers, "Body", new PlayerLayer(Mod.Name, "GlowMaskBody", delegate(PlayerDrawInfo info)
// 	        		{
// 	        			DrawArmorGlowMask(EquipType.Body, textureBody, info);
// 	        		}));
// 	        	}
// 	        }
// 	        else if (player.armor[1].type >= ItemID.Count && _itemGlowMask.TryGetValue(player.armor[1].type, out textureBody))
// 	        {
// 	        	InsertAfterVanillaLayer(layers, "Body", new PlayerLayer(Mod.Name, "GlowMaskBody", delegate(PlayerDrawInfo info)
// 	        	{
// 	        		DrawArmorGlowMask(EquipType.Body, textureBody, info);
// 	        	}));
// 	        }
//
// 	        Texture2D textureArms;
// 	        if (!player.armor[11].IsAir)
// 	        {
// 		        if (player.armor[11].type >= ItemID.Count && _itemGlowMask.TryGetValue(player.armor[11].type, out textureArms))
// 		        {
// 			        InsertAfterVanillaLayer(layers, "Arms", new PlayerLayer(Mod.Name, "GlowMaskBody", delegate(PlayerDrawInfo info)
// 			        {
// 				        DrawArmorGlowMask(EquipType.Body, textureArms, info);
// 			        }));
// 		        }
// 	        }
// 	        else if (player.armor[1].type >= ItemID.Count && _itemGlowMask.TryGetValue(player.armor[1].type, out textureArms))
// 	        {
// 		        InsertAfterVanillaLayer(layers, "Arms", new PlayerLayer(Mod.Name, "GlowMaskBody", delegate(PlayerDrawInfo info)
// 		        {
// 			        DrawArmorGlowMask(EquipType.Body, textureArms, info);
// 		        }));
// 	        }
//
// 	        Texture2D textureLegs;
//             if (!player.armor[12].IsAir)
//             {
//                 if (player.armor[12].type >= ItemID.Count && _itemGlowMask.TryGetValue(player.armor[12].type, out textureLegs))
//                 {
//                     InsertAfterVanillaLayer(layers, "Legs", new PlayerLayer(Mod.Name, "GlowMaskLegs", delegate(PlayerDrawInfo info)
//                     {
//                         DrawArmorGlowMask(EquipType.Legs, textureLegs, info);
//                     }));
//                 }
//             }
//             else if (player.armor[2].type >= ItemID.Count && _itemGlowMask.TryGetValue(player.armor[2].type, out textureLegs))
// 			{
// 				InsertAfterVanillaLayer(layers, "Legs", new PlayerLayer(Mod.Name, "GlowMaskLegs", delegate(PlayerDrawInfo info)
// 				{
// 					DrawArmorGlowMask(EquipType.Legs, textureLegs, info);
// 				}));
// 			}
//         }
//
//         private void InsertAfterVanillaLayer(List<PlayerLayer> layers, string vanillaLayerName, PlayerLayer newPlayerLayer)
//         {
//             for (int i = 0; i < layers.Count; i++)
//             {
//                 if (layers[i].Name == vanillaLayerName && layers[i].mod == "Terraria")
//                 {
//                     layers.Insert(i + 1, newPlayerLayer);
//                     return;
//                 }
//             }
//             layers.Add(newPlayerLayer);
//         }
//
//         private void DrawArmorGlowMask(EquipType type, Texture2D texture, PlayerDrawInfo drawInfo)
//         {
// 	        switch (type)
// 	        {
// 		        case EquipType.Head:
// 		        {
// 			        Player drawPlayer = drawInfo.drawPlayer;
// 			        Color color = drawPlayer.GetImmuneAlphaPure(Color.White, drawInfo.shadow);
// 			        Vector2 drawPos = drawInfo.position - Main.screenPosition + new Vector2(drawPlayer.width / 2 - drawPlayer.bodyFrame.Width / 2, drawPlayer.height - drawPlayer.bodyFrame.Height + 4f) + drawPlayer.headPosition;
// 			        DrawData drawData = new DrawData(texture, drawPos.Floor() + drawInfo.headOrigin, drawPlayer.bodyFrame, color, drawPlayer.headRotation, drawInfo.headOrigin, 1f, drawInfo.spriteEffects, 0)
// 			        {
// 				        shader = drawInfo.headArmorShader
// 			        };
// 			        Main.playerDrawData.Add(drawData);
// 			        break;
// 		        }
//
// 		        case EquipType.Body:
// 		        {
// 			        Player drawPlayer = drawInfo.drawPlayer;
// 			        Color color = drawPlayer.GetImmuneAlphaPure(Color.White, drawInfo.shadow);
// 			        Vector2 drawPos = drawInfo.position - Main.screenPosition + new Vector2(drawPlayer.width / 2 - drawPlayer.bodyFrame.Width / 2, drawPlayer.height - drawPlayer.bodyFrame.Height + 4f) + drawPlayer.bodyPosition;
// 			        DrawData drawData = new DrawData(texture, drawPos.Floor() + drawPlayer.bodyFrame.Size() / 2, drawPlayer.bodyFrame, color, drawPlayer.bodyRotation, drawInfo.bodyOrigin, 1f, drawInfo.spriteEffects, 0)
// 			        {
// 				        shader = drawInfo.bodyArmorShader
// 			        };
// 			        Main.playerDrawData.Add(drawData);
// 			        break;
// 		        }
//
// 		        case EquipType.Legs:
// 		        {
// 			        Player drawPlayer = drawInfo.drawPlayer;
// 			        Color color = drawPlayer.GetImmuneAlphaPure(Color.White, drawInfo.shadow);
// 			        Vector2 drawPos = drawInfo.position - Main.screenPosition + new Vector2(drawPlayer.width / 2 - drawPlayer.legFrame.Width / 2, drawPlayer.height - drawPlayer.legFrame.Height + 4f) + drawPlayer.legPosition;
// 			        DrawData drawData = new DrawData(texture, drawPos.Floor() + drawInfo.legOrigin, drawPlayer.legFrame, color, drawPlayer.legRotation, drawInfo.legOrigin, 1f, drawInfo.spriteEffects, 0)
// 			        {
// 				        shader = drawInfo.legArmorShader
// 			        };
// 			        Main.playerDrawData.Add(drawData);
// 			        break;
// 		        }
// 	        }
//         }
//     }
// }