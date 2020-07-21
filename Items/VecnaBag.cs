using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	public class VecnaBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("Vecna Treasure Bag");
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
			player.QuickSpawnItem(mod.ItemType("VecnaWings"));
			player.QuickSpawnItem(ItemID.Bone, 30);
			player.QuickSpawnItem(ItemID.GoldenKey, 10);
			if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(10))
			{
				player.QuickSpawnItem(mod.ItemType("VecnaMusicBox"));
			}
		}

	}
}
