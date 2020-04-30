using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class AstralBreastPlate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Astral Breastplate");
			Tooltip.SetDefault("A breastplate created from the essence of stars\nInvincibility frames increased\nyou attract healing hearts\n+2 minion slots\n+50 maximum life and mana\n75% increased throwing velocity\n50% increased wing time");

		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 1;
			item.rare = 2;
			item.defense = 16;
		}

		public override void UpdateEquip(Player player)
		{
			player.longInvince = true;
			player.statManaMax2 += 50;
			player.lifeMagnet = true;
			player.maxMinions += 2;
			player.statLifeMax2 += 50;
			player.thrownVelocity += 0.75f;
			player.wingTimeMax += (int)(player.wingTimeMax * 1.5f);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("AstralBar"), 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}