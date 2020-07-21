using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	public class DuneRaiderBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("Dune Raider Treasure Bag");
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
			player.QuickSpawnItem(mod.ItemType("DuneCharm"));
			player.QuickSpawnItem(mod.ItemType("DuneScale"), Main.rand.Next(20, 40));
			if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ItemID.FlyingCarpet);
			}
			if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ItemID.SandstorminaBottle);
			}
			if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ItemID.PharaohsMask);
				player.QuickSpawnItem(ItemID.PharaohsRobe);
			}
			if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(10))
			{
				player.QuickSpawnItem(mod.ItemType("DuneRaiderMusicBox"));
			}
		}

	}
}
