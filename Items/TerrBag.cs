using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	public class TerrBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("Astrum Terr Treasure Bag");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.rare = ItemRarityID.Expert;
			item.maxStack = 99;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(mod.ItemType("EarthenGuard"));
			player.QuickSpawnItem(ItemID.CopperOre, 30);
			player.QuickSpawnItem(ItemID.TinOre, 30);
			player.QuickSpawnItem(ItemID.LeadOre, 30);
			player.QuickSpawnItem(ItemID.IronOre, 30);
			player.QuickSpawnItem(ItemID.SilverOre, 40);
			player.QuickSpawnItem(ItemID.TungstenOre, 40);
			player.QuickSpawnItem(ItemID.GoldOre, 40);
			player.QuickSpawnItem(ItemID.PlatinumOre, 40);
			player.QuickSpawnItem(ItemID.FallenStar, 5);

		}

	}
}
