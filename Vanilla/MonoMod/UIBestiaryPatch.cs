using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoMod.Cil;
using ReLogic.Content;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using NPCStatsReportInfoElement = On.Terraria.GameContent.Bestiary.NPCStatsReportInfoElement;
using UIBestiaryNPCEntryPortrait = On.Terraria.GameContent.UI.Elements.UIBestiaryNPCEntryPortrait;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class UIBestiaryPatch : ContentTranslation
{
    public override bool IsTranslationEnabled => TranslationHelper.IsRussianLanguage;

    public override float Priority => 1f;
    
    public override void LoadContent()
    {
        IL.Terraria.GameContent.UI.Elements.UIBestiaryEntryInfoPage.ctor += UIBestiaryEntryInfoPage;
        IL.Terraria.GameContent.UI.Elements.UIBestiaryNPCEntryPortrait.ctor += UIBestiaryNPCEntryPortrait;
        IL.Terraria.GameContent.UI.States.UIWorldCreation.BuildPage += UIWorldCreationOnBuildPage;
        IL.Terraria.GameContent.Bestiary.NPCPortraitInfoElement.ProvideUIElement += NPCPortraitInfoElementOnProvideUIElement;
        IL.Terraria.GameContent.Bestiary.FlavorTextBestiaryInfoElement.ProvideUIElement += FlavorTextBestiaryInfoElementOnProvideUIElement;
        On.Terraria.GameContent.UI.Elements.UIBestiaryNPCEntryPortrait.ctor += UIBestiaryNPCEntryPortraitOnctor;
	    NPCStatsReportInfoElement.ProvideUIElement += NPCStatsReportInfoElementOnProvideUIElement;
    }


    public override void UnloadContent()
    {
        IL.Terraria.GameContent.UI.Elements.UIBestiaryEntryInfoPage.ctor -= UIBestiaryEntryInfoPage;
        IL.Terraria.GameContent.UI.Elements.UIBestiaryNPCEntryPortrait.ctor -= UIBestiaryNPCEntryPortrait;
        IL.Terraria.GameContent.UI.States.UIWorldCreation.BuildPage -= UIWorldCreationOnBuildPage;
        IL.Terraria.GameContent.Bestiary.NPCPortraitInfoElement.ProvideUIElement -= NPCPortraitInfoElementOnProvideUIElement;
        IL.Terraria.GameContent.Bestiary.FlavorTextBestiaryInfoElement.ProvideUIElement -= FlavorTextBestiaryInfoElementOnProvideUIElement;
        On.Terraria.GameContent.UI.Elements.UIBestiaryNPCEntryPortrait.ctor -= UIBestiaryNPCEntryPortraitOnctor;
	    NPCStatsReportInfoElement.ProvideUIElement -= NPCStatsReportInfoElementOnProvideUIElement;
    }

    private void FlavorTextBestiaryInfoElementOnProvideUIElement(ILContext il)
    {
	    TranslationHelper.ModifyIL(il, 0.8f, 1f);
    }
    
    private void NPCPortraitInfoElementOnProvideUIElement(ILContext il)
    {
	    TranslationHelper.ModifyIL(il, 112f, 193f);
    }
    
    private void UIBestiaryEntryInfoPage(ILContext il)
    {
        TranslationHelper.ModifyIL(il, 230f, 370f);
    }
    
    private void UIBestiaryNPCEntryPortrait(ILContext il)
    {
	    TranslationHelper.ModifyIL(il, 193f, 333f);
	    TranslationHelper.ModifyIL(il, 112f, 193f);
	    //Убираем оригинальную рамку за границы экрана
        TranslationHelper.ModifyIL(il, 0.5f, -200f, 9);
    }
    
    private void UIWorldCreationOnBuildPage(ILContext il)
    {
        TranslationHelper.ModifyIL(il, 500f, 620f);
    }
    
    private void UIBestiaryNPCEntryPortraitOnctor(UIBestiaryNPCEntryPortrait.orig_ctor orig, Terraria.GameContent.UI.Elements.UIBestiaryNPCEntryPortrait self, BestiaryEntry entry, Asset<Texture2D> portraitbackgroundasset, Color portraitcolor, List<IBestiaryBackgroundOverlayAndColorProvider> overlays)
    {
        orig.Invoke(self, entry, portraitbackgroundasset, portraitcolor, overlays);
        Texture2D texture = ModContent.Request<Texture2D>("CalamityRuTranslate/Vanilla/UI/Portrait_Front", AssetRequestMode.ImmediateLoad).Value;
        self.Append(new UIImage(texture)
        {
            VAlign = 0.5f,
            HAlign = 0.5f,
            IgnoresMouseInteraction = true
        });
    }
    
    private UIElement NPCStatsReportInfoElementOnProvideUIElement(NPCStatsReportInfoElement.orig_ProvideUIElement orig, Terraria.GameContent.Bestiary.NPCStatsReportInfoElement self, BestiaryUICollectionInfo info)
    {
	    if (info.UnlockState == BestiaryEntryUnlockState.NotKnownAtAll_0)
		    return null;

	    int gameMode = Main.GameMode;
		if (self.GameMode != gameMode)
			return null;

		UIElement uIElement = new UIElement
		{
			Width = new StyleDimension(0f, 1f),
			Height = new StyleDimension(109f, 0f)
		};

		const int num = 169;
		const int num2 = 35;
		const int num3 = 3;
		const int num4 = 0;
		Texture2D statHP = ModContent.Request<Texture2D>("CalamityRuTranslate/Vanilla/UI/Stat_HP", AssetRequestMode.ImmediateLoad).Value;
		UIImage uIImage = new UIImage(statHP)
		{
			Top = new StyleDimension(num4, 0f),
			Left = new StyleDimension(num3, 0f)
		};

		Texture2D statAttack = ModContent.Request<Texture2D>("CalamityRuTranslate/Vanilla/UI/Stat_Attack", AssetRequestMode.ImmediateLoad).Value;
		UIImage uIImage2 = new UIImage(statAttack)
		{
			Top = new StyleDimension(num4 + num2, 0f),
			Left = new StyleDimension(num3, 0f)
		};

		Texture2D statDefense = ModContent.Request<Texture2D>("CalamityRuTranslate/Vanilla/UI/Stat_Defense", AssetRequestMode.ImmediateLoad).Value;
		UIImage uIImage3 = new UIImage(statDefense)
		{
			Top = new StyleDimension(num4 + num2, 0f),
			Left = new StyleDimension(num3 + num, 0f)
		};

		Texture2D statKnockback = ModContent.Request<Texture2D>("CalamityRuTranslate/Vanilla/UI/Stat_Knockback", AssetRequestMode.ImmediateLoad).Value;
		UIImage uIImage4 = new UIImage(statKnockback)
		{
			Top = new StyleDimension(num4, 0f),
			Left = new StyleDimension(num3 + num, 0f)
		};

		uIElement.Append(uIImage);
		uIElement.Append(uIImage2);
		uIElement.Append(uIImage3);
		uIElement.Append(uIImage4);
		const int num5 = -10;
		const int num6 = 0;
		int num7 = (int)self.MonetaryValue;
		string text = Utils.Clamp(num7 / 1000000, 0, 999).ToString();
		string text2 = Utils.Clamp(num7 % 1000000 / 10000, 0, 99).ToString();
		string text3 = Utils.Clamp(num7 % 10000 / 100, 0, 99).ToString();
		string text4 = Utils.Clamp(num7 % 100 / 1, 0, 99).ToString();
		if (num7 / 1000000 < 1)
			text = "-";

		if (num7 / 10000 < 1)
			text2 = "-";

		if (num7 / 100 < 1)
			text3 = "-";

		if (num7 < 1)
			text4 = "-";

		string text5 = self.LifeMax.ToString();
		string text6 = self.Damage.ToString();
		string text7 = self.Defense.ToString();
		string text8 = self.KnockbackResist > 0.8f ? Language.GetText("BestiaryInfo.KnockbackHigh").Value :
			self.KnockbackResist > 0.4f ? Language.GetText("BestiaryInfo.KnockbackMedium").Value :
			!(self.KnockbackResist > 0f) ? Language.GetText("BestiaryInfo.KnockbackNone").Value :
			Language.GetText("BestiaryInfo.KnockbackLow").Value;
		if (info.UnlockState < BestiaryEntryUnlockState.CanShowStats_2) {
			text = text2 = text3 = text4 = "?";
			text5 = text6 = text7 = text8 = "???";
		}

		UIText element = new UIText(text5)
		{
			HAlign = 1f,
			VAlign = 0.5f,
			Left = new StyleDimension(num5, 0f),
			Top = new StyleDimension(num6, 0f),
			IgnoresMouseInteraction = true
		};

		UIText element2 = new UIText(text8)
		{
			HAlign = 1f,
			VAlign = 0.5f,
			Left = new StyleDimension(num5, 0f),
			Top = new StyleDimension(num6, 0f),
			IgnoresMouseInteraction = true
		};

		UIText element3 = new UIText(text6)
		{
			HAlign = 1f,
			VAlign = 0.5f,
			Left = new StyleDimension(num5, 0f),
			Top = new StyleDimension(num6, 0f),
			IgnoresMouseInteraction = true
		};

		UIText element4 = new UIText(text7)
		{
			HAlign = 1f,
			VAlign = 0.5f,
			Left = new StyleDimension(num5, 0f),
			Top = new StyleDimension(num6, 0f),
			IgnoresMouseInteraction = true
		};

		uIImage.Append(element);
		uIImage2.Append(element3);
		uIImage3.Append(element4);
		uIImage4.Append(element2);
		if (num7 > 0)
		{
			UIHorizontalSeparator element5 = new UIHorizontalSeparator
			{
				Width = StyleDimension.FromPixelsAndPercent(0f, 1f),
				Color = new Color(89, 116, 213, 255) * 0.9f,
				Left = new StyleDimension(0f, 0f),
				Top = new StyleDimension(num6 + num2 * 2, 0f)
			};

			uIElement.Append(element5);
			int num8 = num3;
			int num9 = num6 + num2 * 2 + 8;
			int num10 = 85;
			
			Texture2D statPlatinum = ModContent.Request<Texture2D>("CalamityRuTranslate/Vanilla/UI/Stat_Platinum", AssetRequestMode.ImmediateLoad).Value;
			UIImage uIImage5 = new UIImage(statPlatinum)
			{
				Top = new StyleDimension(num9, 0f),
				Left = new StyleDimension(num8, 0f)
			};

			Texture2D statGold = ModContent.Request<Texture2D>("CalamityRuTranslate/Vanilla/UI/Stat_Gold", AssetRequestMode.ImmediateLoad).Value;
			UIImage uIImage6 = new UIImage(statGold)
			{
				Top = new StyleDimension(num9, 0f),
				Left = new StyleDimension(num8 + num10, 0f)
			};

			Texture2D statSilver = ModContent.Request<Texture2D>("CalamityRuTranslate/Vanilla/UI/Stat_Silver", AssetRequestMode.ImmediateLoad).Value;
			UIImage uIImage7 = new UIImage(statSilver)
			{
				Top = new StyleDimension(num9, 0f),
				Left = new StyleDimension(num8 + num10 * 2 + 1, 0f)
			};

			Texture2D statCopper = ModContent.Request<Texture2D>("CalamityRuTranslate/Vanilla/UI/Stat_Copper", AssetRequestMode.ImmediateLoad).Value;
			UIImage uIImage8 = new UIImage(statCopper)
			{
				Top = new StyleDimension(num9, 0f),
				Left = new StyleDimension(num8 + num10 * 3 + 1, 0f)
			};

			if (text != "-")
				uIElement.Append(uIImage5);

			if (text2 != "-")
				uIElement.Append(uIImage6);

			if (text3 != "-")
				uIElement.Append(uIImage7);

			if (text4 != "-")
				uIElement.Append(uIImage8);

			const int num11 = num5;
			UIText element6 = new UIText(text)
			{
				HAlign = 1f,
				VAlign = 0.5f,
				Left = new StyleDimension(num11, 0f),
				Top = new StyleDimension(num6, 0f)
			};

			UIText element7 = new UIText(text2)
			{
				HAlign = 1f,
				VAlign = 0.5f,
				Left = new StyleDimension(num11, 0f),
				Top = new StyleDimension(num6, 0f)
			};

			UIText element8 = new UIText(text3)
			{
				HAlign = 1f,
				VAlign = 0.5f,
				Left = new StyleDimension(num11, 0f),
				Top = new StyleDimension(num6, 0f)
			};

			UIText element9 = new UIText(text4)
			{
				HAlign = 1f,
				VAlign = 0.5f,
				Left = new StyleDimension(num11, 0f),
				Top = new StyleDimension(num6, 0f)
			};

			uIImage5.Append(element6);
			uIImage6.Append(element7);
			uIImage7.Append(element8);
			uIImage8.Append(element9);
		}
		else
		{
			uIElement.Height.Pixels = num6 + num2 * 2 - 4;
		}

		uIImage2.OnUpdate += ShowStats_Attack;
		uIImage3.OnUpdate += ShowStats_Defense;
		uIImage.OnUpdate += ShowStats_Life;
		uIImage4.OnUpdate += ShowStats_Knockback;
		return uIElement;

		void ShowStats_Attack(UIElement element)
		{
			if (element.IsMouseHovering)
				Main.instance.MouseText(Language.GetTextValue("BestiaryInfo.Attack"));
		}

		void ShowStats_Defense(UIElement element)
		{
			if (element.IsMouseHovering)
				Main.instance.MouseText(Language.GetTextValue("BestiaryInfo.Defense"));
		}
		
		void ShowStats_Knockback(UIElement element) {
			if (element.IsMouseHovering)
				Main.instance.MouseText(Language.GetTextValue("BestiaryInfo.Knockback"));
		}
		
		void ShowStats_Life(UIElement element) {
			if (element.IsMouseHovering)
				Main.instance.MouseText(Language.GetTextValue("BestiaryInfo.Life"));
		}
    }
}