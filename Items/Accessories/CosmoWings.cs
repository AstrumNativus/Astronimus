using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class CosmoWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmo Wings");
			Tooltip.SetDefault("Flashy wings not even singers would wear");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 10;
			item.rare = 2;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 105;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.5f;
			maxCanAscendMultiplier = 5f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 4f;
			acceleration *= 2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("LyriumBar"), 20);
			recipe.AddIngredient(mod.ItemType("AstralGel"), 30);
			recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}