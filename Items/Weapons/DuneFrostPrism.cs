using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Weapons
{
	public class DuneFrostPrism : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dune Frost Prism");
			Tooltip.SetDefault("Channels the light of the desert sun and tundra moon");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can hold the weapon [Important]
			item.mana = 5;
			item.rare = ItemRarityID.Quest;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("DuneFrostLaser");
			item.value = Item.sellPrice(silver: 3);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DuneScale", 30);
			recipe.AddIngredient(mod, "FrostScale", 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}