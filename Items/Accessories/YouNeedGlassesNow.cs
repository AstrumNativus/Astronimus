using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	public class YouNeedGlassesNow : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Core of J U M P");
			Tooltip.SetDefault("J U M P");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 0;
			item.rare = 2;
			item.accessory = true;
			item.defense = 0;
			item.lifeRegen = 0;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.doubleJumpBlizzard = true;
			player.doubleJumpUnicorn = true;
			player.doubleJumpFart = true;
			player.doubleJumpSail = true;
			player.doubleJumpSandstorm = true;
			player.doubleJumpCloud = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BundleofBalloons, 1);
			recipe.AddIngredient(ItemID.SharkronBalloon, 1);
			recipe.AddIngredient(ItemID.FartInABalloon, 1);
			recipe.AddIngredient(ItemID.BlessedApple);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
	
	
