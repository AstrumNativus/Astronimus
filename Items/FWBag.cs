using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	public class FWBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("Frost Wyrm Treasure Bag");
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
			player.QuickSpawnItem(mod.ItemType("FrostCharm"));
			player.QuickSpawnItem(mod.ItemType("FrostScale"), Main.rand.Next(20, 40));
			if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ItemID.IceMirror);
			}
			if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ItemID.IceBlade);
			}
			if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ItemID.BlizzardinaBottle);
			}
			if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ItemID.IceSkates);
			}
			if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(10))
			{
				player.QuickSpawnItem(mod.ItemType("FrostWyrmMusicBox"));
			}
		}

	}
}
