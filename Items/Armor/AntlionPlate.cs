using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class AntlionPlate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Antlion Plate");
			Tooltip.SetDefault("Plate created from desert monsters\n5% increased minion knockback");

		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 1;
			item.rare = 2;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
			player.minionKB += 0.05f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AntlionMandible, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}