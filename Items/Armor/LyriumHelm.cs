using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class LyriumHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lyrium Helm");
			Tooltip.SetDefault("A helm forged during the Age of Dragons\n5% damage increase");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10;
			item.rare = 2;
			item.defense = 6;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("LyriumPlate") && legs.type == mod.ItemType("LyriumGreaves");
		}
		public override void UpdateArmorSet(Player player)
		{
			player.allDamage += 0.2f;
			Lighting.AddLight(player.Center, 1f, 1f, 1f);
			player.runAcceleration += 0.2f;
			player.jumpBoost = true;
		}
		public override void UpdateEquip(Player player)
		{
			player.allDamage -= 0.05f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("LyriumBar"), 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}