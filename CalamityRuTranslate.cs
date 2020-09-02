using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using CalamityRuTranslate.CalamityMod.Buffs;
using CalamityRuTranslate.CalamityMod.Items;
using CalamityRuTranslate.CalamityMod.Localization;
using CalamityRuTranslate.CalamityMod.NPCs;
using CalamityRuTranslate.CalamityMod.Projectiles;
using CalamityRuTranslate.CalamityMod.Tiles;
using CalamityRuTranslate.ElementsAwoken.Buffs;
using CalamityRuTranslate.ElementsAwoken.Items;
using CalamityRuTranslate.ElementsAwoken.ModSupport;
using CalamityRuTranslate.ElementsAwoken.NPCs;
using CalamityRuTranslate.ElementsAwoken.Tiles;
using CalamityRuTranslate.ModOfRedemption.Buffs;
using CalamityRuTranslate.ModOfRedemption.Items;
using CalamityRuTranslate.ModOfRedemption.ModSupport;
using CalamityRuTranslate.ModOfRedemption.NPCs;
using CalamityRuTranslate.ModOfRedemption.Tiles;
using CalamityRuTranslate.ThoriumMod.Buffs;
using CalamityRuTranslate.ThoriumMod.Items;
using CalamityRuTranslate.ThoriumMod.ModSupport;
using CalamityRuTranslate.ThoriumMod.NPCs;
using CalamityRuTranslate.ThoriumMod.Tiles;
using ReLogic.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;
using Terraria.UI;

namespace CalamityRuTranslate
{
    public class CalamityRuTranslate : Mod
	{
		public override void Load()
		{
			if (LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
			{
				Instance = this;
				
				if (tRuConfig.NewRussianTerrariaFont)
				{
					if(!Main.dedServ)
                    {
                        ItemStack = GetFont("Fonts/Item_Stack");
                        MouseText = GetFont("Fonts/Mouse_Text");
                        DeathText = GetFont("Fonts/Death_Text");
                        CombatText = GetFont("Fonts/Combat_Text");
                        CombatCrit = GetFont("Fonts/Combat_Crit");
                        
                        Main.fontItemStack = ItemStack;
                        Main.fontMouseText = MouseText;
                        Main.fontDeathText = DeathText;
                        Main.fontCombatText[0] = CombatText;
                        Main.fontCombatText[1] = CombatCrit;
                    }
                }

                if (Calamity != null)
                {
                    CalamityLocalization.CalamityAddLocalizations();
                    ModifyCalamityIL.Setup();
                }

                if (Thorium != null)
                {
                    ThoriumSupport.ThoriumAddLocalizations();
                }

                if (Redemption != null)
                {
                    MoRSupport.RedemptionAddLocalizations();
                }
                
                LoadAlternateRussian(LanguageManager.Instance, "Terraria.Localization.Content.");
			}
		}

        public override void Unload()
		{
            tRuConfig = null;
            ItemStack = null;
            MouseText = null;
            DeathText = null;
            CombatText = null;
            CombatCrit = null;
            Instance = null;
            
            ModifyCalamityIL.Unload();
		}
		
		public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
		{
            if (LanguageManager.Instance.ActiveCulture == GameCulture.Russian)
            {
                if (Calamity != null)
                {
                    CalamityLocalization.CalamityNpcChat();
                }

                if (Thorium != null)
                {
                    ThoriumSupport.ThoriumNpcChat();
                    ThoriumSupport.ThoriumBardClass();
                }

                if (ElementsAwoken != null)
                {
                    ModEASupport.ElementsAwokenNpcChat();
                }

                if (Redemption != null)
                {
                    MoRSupport.CombatText();
                    MoRSupport.NpcChat();
                }
            }
        }
		
		public override void PostSetupContent()
		{
			if (Calamity != null)
			{
				CalamityBuffs.Setup();
				CalamityItemName.Setup();
				CalamityItemTooltip.Setup();
				CalamityNpc.Setup(); 
                CalamityProjectiles.Setup();
                CalamityTiles.Setup();
                CalamityPrefixName.Setup();
                CalamityChestName.Setup();
			}

			if (Thorium != null)
			{
				ThoriumBuffs.Setup();
				ThoriumTiles.Setup();
                ThoriumChestName.Setup();
				ThoriumNpc.Setup();
				ThoriumItemName.Setup();
				ThoriumItemTooltip.Setup();
				ThoriumPrefixName.Setup();
			}
			
			if (ElementsAwoken != null)
			{
				ElementsAwokenBuffs.Setup();
				ElementsAwokenItemName.Setup();
				ElementsAwokenItemTooltip.Setup();
				ElementsAwokenNPCs.Setup();
				ElementsAwokenTiles.Setup();
			}
			
			if (Redemption != null)
			{
				RedemptionBuffs.Setup();
				RedemptionItemName.Setup();
				RedemptionItemTooltip.Setup();
				RedemptionNPCs.Setup();
				RedemptionTiles.Setup();
			}
		}
		
        private void LoadAlternateRussian(LanguageManager languageManager, string prefix)
		{
			if (languageManager.ActiveCulture == GameCulture.Russian)
			{
				foreach (TmodFile.FileEntry item in typeof(Mod).GetProperty("File", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this) as TmodFile)
				{
					if (Path.GetFileNameWithoutExtension(item.Name).StartsWith(prefix + languageManager.ActiveCulture.CultureInfo.Name) && item.Name.EndsWith(".json"))
					{
						try
						{
							languageManager.LoadLanguageFromFileText(Encoding.UTF8.GetString(GetFileBytes(item.Name)));
						}
						catch
						{
							Logger.InfoFormat("Failed to load language file: " + item);
						}
					}
				}
			}
		}

        private Mod Calamity => ModLoader.GetMod("CalamityMod");
        private Mod Thorium => ModLoader.GetMod("ThoriumMod");
        private Mod Redemption => ModLoader.GetMod("Redemption");
        private Mod ElementsAwoken => ModLoader.GetMod("ElementsAwoken");
        
        private DynamicSpriteFont ItemStack;
		private DynamicSpriteFont MouseText;
		private DynamicSpriteFont DeathText;
		private DynamicSpriteFont CombatText;
		private DynamicSpriteFont CombatCrit;
		internal static Config tRuConfig;
		internal static CalamityRuTranslate Instance;
    }
}
