using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Placeable
{
	public class AstralBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astral Bar");
			Tooltip.SetDefault("The Wyvern Steel");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 59; // influences the inventory sort order. 59 is PlatinumBar, higher is more valuable.
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(4, 2));
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 20;
			item.maxStack = 999;
			item.value = 75;
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<AstrumOre>(), 4);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}