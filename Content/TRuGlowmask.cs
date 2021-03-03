using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content
{
    public class TRuGlowmask : ModPlayer
    {
        private static readonly Dictionary<int, Texture2D> ItemGlowMask = new Dictionary<int, Texture2D>();

        internal static void Unload()
        {
            ItemGlowMask.Clear();
        }
        
        public static void AddGlowMask(int itemType, string texturePath)
        {
            ItemGlowMask[itemType] = ModContent.GetTexture(texturePath);
        }

        public override void ModifyDrawLayers(List<PlayerLayer> layers)
        {
	        Texture2D textureHead;
	        if (!player.armor[10].IsAir)
	        {
		        if (player.armor[10].type >= 3930 && ItemGlowMask.TryGetValue(player.armor[10].type, out textureHead))
		        {
			        InsertAfterVanillaLayer(layers, "Head", new PlayerLayer(mod.Name, "GlowMaskHead", delegate(PlayerDrawInfo info)
			        {
				        DrawArmorGlowMask(EquipType.Head, textureHead, info);
			        }));
		        }
	        }
	        else if (player.armor[0].type >= 3930 && ItemGlowMask.TryGetValue(player.armor[0].type, out textureHead))
	        {
		        InsertAfterVanillaLayer(layers, "Head", new PlayerLayer(mod.Name, "GlowMaskHead", delegate(PlayerDrawInfo info)
		        {
			        DrawArmorGlowMask(EquipType.Head, textureHead, info);
		        }));
	        }
	        
	        Texture2D textureBody;
	        if (!player.armor[11].IsAir)
	        {
	        	if (player.armor[11].type >= 3930 && ItemGlowMask.TryGetValue(player.armor[11].type, out textureBody))
	        	{
	        		InsertAfterVanillaLayer(layers, "Body", new PlayerLayer(mod.Name, "GlowMaskBody", delegate(PlayerDrawInfo info)
	        		{
	        			DrawArmorGlowMask(EquipType.Body, textureBody, info);
	        		}));
	        	}
	        }
	        else if (player.armor[1].type >= 3930 && ItemGlowMask.TryGetValue(player.armor[1].type, out textureBody))
	        {
	        	InsertAfterVanillaLayer(layers, "Body", new PlayerLayer(mod.Name, "GlowMaskBody", delegate(PlayerDrawInfo info)
	        	{
	        		DrawArmorGlowMask(EquipType.Body, textureBody, info);
	        	}));
	        }

	        Texture2D textureArms;
	        if (!player.armor[11].IsAir)
	        {
		        if (player.armor[11].type >= 3930 && ItemGlowMask.TryGetValue(player.armor[11].type, out textureArms))
		        {
			        InsertAfterVanillaLayer(layers, "Arms", new PlayerLayer(mod.Name, "GlowMaskBody", delegate(PlayerDrawInfo info)
			        {
				        DrawArmorGlowMask(EquipType.Body, textureArms, info);
			        }));
		        }
	        }
	        else if (player.armor[1].type >= 3930 && ItemGlowMask.TryGetValue(player.armor[1].type, out textureArms))
	        {
		        InsertAfterVanillaLayer(layers, "Arms", new PlayerLayer(mod.Name, "GlowMaskBody", delegate(PlayerDrawInfo info)
		        {
			        DrawArmorGlowMask(EquipType.Body, textureArms, info);
		        }));
	        }
	        
	        Texture2D textureLegs;
            if (!player.armor[12].IsAir)
            {
                if (player.armor[12].type >= 3930 && ItemGlowMask.TryGetValue(player.armor[12].type, out textureLegs))
                {
                    InsertAfterVanillaLayer(layers, "Legs", new PlayerLayer(mod.Name, "GlowMaskLegs", delegate(PlayerDrawInfo info)
                    {
                        DrawArmorGlowMask(EquipType.Legs, textureLegs, info);
                    }));
                }
            }
            else if (player.armor[2].type >= 3930 && ItemGlowMask.TryGetValue(player.armor[2].type, out textureLegs))
			{
				InsertAfterVanillaLayer(layers, "Legs", new PlayerLayer(mod.Name, "GlowMaskLegs", delegate(PlayerDrawInfo info)
				{
					DrawArmorGlowMask(EquipType.Legs, textureLegs, info);
				}));
			}
        }

        public static void InsertAfterVanillaLayer(List<PlayerLayer> layers, string vanillaLayerName, PlayerLayer newPlayerLayer)
        {
            for (int i = 0; i < layers.Count; i++)
            {
                if (layers[i].Name == vanillaLayerName && layers[i].mod == "Terraria")
                {
                    layers.Insert(i + 1, newPlayerLayer);
                    return;
                }
            }
            layers.Add(newPlayerLayer);
        }
        
        public static void DrawArmorGlowMask(EquipType type, Texture2D texture, PlayerDrawInfo drawInfo)
        {
	        switch (type)
	        {
		        case EquipType.Head:
		        {
			        Player drawPlayer = drawInfo.drawPlayer;
			        Color color = drawPlayer.GetImmuneAlphaPure(Color.White, drawInfo.shadow);
			        Vector2 drawPos = drawInfo.position - Main.screenPosition + new Vector2(drawPlayer.width / 2 - drawPlayer.bodyFrame.Width / 2, drawPlayer.height - drawPlayer.bodyFrame.Height + 4f) + drawPlayer.headPosition;
			        DrawData drawData = new DrawData(texture, drawPos.Floor() + drawInfo.headOrigin, drawPlayer.bodyFrame, color, drawPlayer.headRotation, drawInfo.headOrigin, 1f, drawInfo.spriteEffects, 0)
			        {
				        shader = drawInfo.headArmorShader
			        };
			        Main.playerDrawData.Add(drawData);
			        break;
		        }
		        
		        case EquipType.Body:
		        {
			        Player drawPlayer = drawInfo.drawPlayer;
			        Color color = drawPlayer.GetImmuneAlphaPure(Color.White, drawInfo.shadow);
			        Vector2 drawPos = drawInfo.position - Main.screenPosition + new Vector2(drawPlayer.width / 2 - drawPlayer.bodyFrame.Width / 2, drawPlayer.height - drawPlayer.bodyFrame.Height + 4f) + drawPlayer.bodyPosition;
			        DrawData drawData = new DrawData(texture, drawPos.Floor() + drawPlayer.bodyFrame.Size() / 2, drawPlayer.bodyFrame, color, drawPlayer.bodyRotation, drawInfo.bodyOrigin, 1f, drawInfo.spriteEffects, 0)
			        {
				        shader = drawInfo.bodyArmorShader
			        };
			        Main.playerDrawData.Add(drawData);
			        break;
		        }

		        case EquipType.Legs:
		        {
			        Player drawPlayer = drawInfo.drawPlayer;
			        Color color = drawPlayer.GetImmuneAlphaPure(Color.White, drawInfo.shadow);
			        Vector2 drawPos = drawInfo.position - Main.screenPosition + new Vector2(drawPlayer.width / 2 - drawPlayer.legFrame.Width / 2, drawPlayer.height - drawPlayer.legFrame.Height + 4f) + drawPlayer.legPosition;
			        DrawData drawData = new DrawData(texture, drawPos.Floor() + drawInfo.legOrigin, drawPlayer.legFrame, color, drawPlayer.legRotation, drawInfo.legOrigin, 1f, drawInfo.spriteEffects, 0)
			        {
				        shader = drawInfo.legArmorShader
			        };
			        Main.playerDrawData.Add(drawData);
			        break;
		        }
	        }
        }
    }
}