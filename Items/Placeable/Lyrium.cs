using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Placeable
{
	public class Lyrium : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lyrium");
			Tooltip.SetDefault("Metal harvested during the Age of Dragons");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = TileType<Tiles.LyriumOre>();
			item.width = 12;
			item.height = 12;
			item.value = 3;
		}
	}
}