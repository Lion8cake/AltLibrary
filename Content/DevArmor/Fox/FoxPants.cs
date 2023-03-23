﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AltLibrary.Content.DevArmor.Fox
{
	[AutoloadEquip(EquipType.Legs)]
	internal class FoxPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fox's Slacks");
			// Tooltip.SetDefault("Great for impersonating mod devs!");
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 14;
			Item.value = Item.sellPrice(gold: 5);
			Item.rare = ItemRarityID.Cyan;
			Item.vanity = true;
		}
	}
}
