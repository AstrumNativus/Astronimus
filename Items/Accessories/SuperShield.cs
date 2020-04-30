using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	public class SuperShield : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Shield");
			Tooltip.SetDefault("so you wanna be a tank, eh?");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 34;
			item.value = 0;
			item.rare = 2;
			item.accessory = true;
			item.defense = 30;
			item.lifeRegen += 10;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			for (int i = 0; i < player.buffImmune.Length; i++)
			{
				if (Main.debuff[i])  //This buff/debuff is actually a debuff
					player.buffImmune[i] = true;  //Make the player immune
			}
			player.defendedByPaladin = true;
			player.hasPaladinShield = true;
			player.sporeSac = true;
			player.thorns = 10f;
			player.resistCold = true;
			player.brainOfConfusion = true;
			player.panic = true;
			player.starCloak = true;
			player.bee = true;
			player.noKnockback = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AnkhShield, 1);
			recipe.AddIngredient(ItemID.PaladinsShield, 1);
			recipe.AddIngredient(ItemID.HandWarmer, 1);
			recipe.AddIngredient(ItemID.SporeSac, 1);
			recipe.AddIngredient(ItemID.WormScarf, 1);
			recipe.AddIngredient(ItemID.BrainOfConfusion, 1);
			recipe.AddIngredient(ItemID.BeeCloak);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
	
	
