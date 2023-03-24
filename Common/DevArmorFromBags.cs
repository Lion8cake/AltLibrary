using AltLibrary.Content.DevArmor.Cace;
using AltLibrary.Content.DevArmor.Fox;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace AltLibrary.Common
{
	internal class DevArmorFromBags : GlobalItem
	{
		public override bool AppliesToEntity(Item item, bool lateInstatiation)
		{
			return ItemID.Sets.BossBag[item.type] && (!ItemID.Sets.PreHardmodeLikeBossBag[item.type] || Main.tenthAnniversaryWorld) && Main.rand.NextBool(Main.tenthAnniversaryWorld ? 10 : 20);
		}
		public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
		{
			switch (Main.rand.Next(2))
			{
				case 0:
					itemLoot.Add(ItemDropRule.BossBag(ModContent.ItemType<FoxMask>()));
					itemLoot.Add(ItemDropRule.BossBag(ModContent.ItemType<FoxShirt>()));
					itemLoot.Add(ItemDropRule.BossBag(ModContent.ItemType<FoxPants>()));
					break;
				case 1:
					itemLoot.Add(ItemDropRule.BossBag(ModContent.ItemType<CaceEars>()));
					break;
			}
		}
	}
}