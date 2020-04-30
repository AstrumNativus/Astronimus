using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	
	public class StellarCleats : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stellar Cleats");
			Tooltip.SetDefault("Swim like a fish, run like a maniac");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 28;
			item.value = 10;
			item.rare = ItemRarityID.Expert;
			item.accessory = true;
			item.defense = 0;
			item.lifeRegen = 0;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed += 0.7f;
			player.runAcceleration += 0.5f;
			player.maxRunSpeed += 0.5f;
			player.accRunSpeed += 0.2f;
			player.fireWalk = true;
			player.accFlipper = true;
			player.ignoreWater = true;
			player.waterWalk = true;
			player.waterWalk2 = true;
			player.arcticDivingGear = true;
			player.carpet = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LavaWaders, 1);
			recipe.AddIngredient(ItemID.ArcticDivingGear, 1);
			recipe.AddIngredient(ItemID.FlyingCarpet, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}


