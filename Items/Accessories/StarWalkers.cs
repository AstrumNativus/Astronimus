using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	[AutoloadEquip(EquipType.Shoes)]
	public class StarWalkers : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Starlight Treads");
			Tooltip.SetDefault("Making your way to the Dungeon, walking fast");
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
			player.runAcceleration += 0.1f;
			player.iceSkate = true;
			player.maxRunSpeed += 0.5f;
			player.accRunSpeed += 0.2f;
			player.doubleJumpCloud = true;
			player.jumpBoost = true;
			player.jumpSpeedBoost += 0.5f;
			player.autoJump = true;
			player.noFallDmg = true;
			player.rocketBoots = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FrostsparkBoots, 1);
			recipe.AddIngredient(ItemID.BlueHorseshoeBalloon, 1);
			recipe.AddIngredient(ItemID.FrogLeg, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}


