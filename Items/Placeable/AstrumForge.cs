using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Placeable
{
	public class AstrumForge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astrum Forge");
			Tooltip.SetDefault("The forge of the stars");
		}

		public override void SetDefaults()
		{
			item.width = 50;
			item.height = 31;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 0;
			item.createTile = TileType<Tiles.AstrumForge>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(ItemID.Furnace);
			recipe.AddIngredient(ItemID.IronAnvil);
			recipe.AddIngredient(ItemID.TinkerersWorkshop);
			recipe.AddIngredient(ItemID.Sawmill);
			recipe.AddIngredient(ItemID.HeavyWorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(ItemID.Furnace);
			recipe.AddIngredient(ItemID.LeadAnvil);
			recipe.AddIngredient(ItemID.TinkerersWorkshop);
			recipe.AddIngredient(ItemID.Sawmill);
			recipe.AddIngredient(ItemID.HeavyWorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}