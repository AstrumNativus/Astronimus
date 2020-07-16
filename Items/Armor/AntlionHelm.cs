using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class AntlionHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Antlion Helm");
			Tooltip.SetDefault("A helm created from desert monsters\n5% minion damage increase");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10;
			item.rare = 2;
			item.defense = 1;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("AntlionPlate") && legs.type == mod.ItemType("AntlionGreaves");
		}
		public override void UpdateArmorSet(Player player)
		{
			player.maxMinions += 1;
		}
		public override void UpdateEquip(Player player)
		{
			player.minionDamage += 0.05f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AntlionMandible, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}