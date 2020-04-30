using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class AstralLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Leggings created from the essence of stars"
				+ "\n50% increased movement speed and 200% increased max move speed"
				+ "\nnight vision"
				+ "\nDodge");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 10;
			item.rare = 2;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.5f;
			player.nightVision = true;
			player.onHitDodge = true;
			player.maxRunSpeed += 2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("AstralBar"), 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}