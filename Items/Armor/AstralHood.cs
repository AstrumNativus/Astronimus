using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class AstralHood : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astral Hood");
			Tooltip.SetDefault("A hood created from the essence of stars\n20% damage increase");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10;
			item.rare = 2;
			item.defense = 12;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("AstralBreastPlate") && legs.type == mod.ItemType("AstralLeggings");
		}
		public override void UpdateArmorSet(Player player)
		{
			player.allDamage += 0.5f;
			Lighting.AddLight(player.Center, 2f, 2f, 2f);
			player.runAcceleration += 2;
			player.jumpBoost = true;
		}
		public override void UpdateEquip(Player player)
		{
			player.allDamage -= 0.2f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("AstralBar"), 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}