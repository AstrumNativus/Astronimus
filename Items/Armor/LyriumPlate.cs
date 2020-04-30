using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class LyriumPlate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Lyrium Plate");
			Tooltip.SetDefault("Plate forged during the Age of Dragons\nPlus 10 armor penetration");

		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 1;
			item.rare = 2;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			player.armorPenetration += 10;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("LyriumBar"), 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}