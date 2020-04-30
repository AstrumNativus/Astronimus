using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	public class Celestia : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestia");
			Tooltip.SetDefault("The core of the universe"
							+ "\nGrants nearly every bonus possible");
		}

		public override void SetDefaults()
		{
			item.width = 56;
			item.height = 56;
			item.value = 10000000;
			item.rare = ItemRarityID.Expert;
			item.accessory = true;
			item.defense = 100;
			item.lifeRegen += 25;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed += 3f;
			player.allDamage += 5;
			Lighting.AddLight(player.Center, 10f, 10f, 10f);
			player.runAcceleration += 10f;
			player.jumpBoost = true;
			player.armorPenetration += 100;
			player.jumpBoost = true;
			player.accFlipper = true;
			player.fireWalk = true;
			player.lavaImmune = true;
			player.iceSkate = true;
			player.noFallDmg = true;
			player.gravity /= 0.5f;
			player.waterWalk = true;
			player.waterWalk2 = true;
			player.ignoreWater = true;
			player.gravControl = true;
			player.maxRunSpeed += 3f;
			player.accRunSpeed += 3f;
			player.autoJump = true;
			player.carpet = true;
			player.maxMinions += 10;
			player.nightVision = true;
			player.onHitDodge = true;
			player.palladiumRegen = true;
			player.pickSpeed += 10;
			player.resistCold = true;
			player.runSlowdown += 10f;
			player.stardustGuardian = true;
			player.thorns = 10f;
			player.wingTimeMax += (int)(player.wingTimeMax * 5f);
			player.statLifeMax2 += 1000;
			player.statManaMax2 += 500;
			player.noKnockback = true;
			for (int i = 0; i < player.buffImmune.Length; i++)
			{
				if (Main.debuff[i])  //This buff/debuff is actually a debuff
					player.buffImmune[i] = true;  //Make the player immune
			}
			player.doubleJumpBlizzard = true;
			player.doubleJumpUnicorn = true;
			player.doubleJumpFart = true;
			player.doubleJumpSail = true;
			player.doubleJumpSandstorm = true;
			player.doubleJumpCloud = true;
			player.defendedByPaladin = true;
			player.hasPaladinShield = true;
			player.iceSkate = true;
			player.yoyoGlove = true;
			player.yoyoString = true;
			player.crimsonRegen = true;
			player.sporeSac = true;
			player.kbGlove = true;
			player.magicQuiver = true;
			player.magmaStone = true;
			player.manaFlower = true;
			player.maxMinions += 10;
			player.respawnTimer -= 10;
			player.setSolar = true;
			player.setStardust = true;
			player.accMerman = true;
			player.arcticDivingGear = true;
			player.brainOfConfusion = true;
			player.panic = true;
			player.starCloak = true;
			player.bee = true;
			player.endurance += 0.25f;
			player.counterWeight += 2;
		}
		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 10f;
			acceleration *= 5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StarWalkers"), 1);
			recipe.AddIngredient(mod.ItemType("EnchantmentLyrium"), 1);
			recipe.AddIngredient(mod.ItemType("EnchantmentAstral"), 1);
			recipe.AddIngredient(mod.ItemType("YouNeedGlassesNow"), 1);
			recipe.AddIngredient(mod.ItemType("SuperShield"), 1);
			recipe.AddIngredient(ItemID.LunarBar, 100);
			recipe.AddIngredient(ItemID.CelestialShell, 1);
			recipe.AddIngredient(ItemID.MagicQuiver, 1);
			recipe.AddIngredient(ItemID.ManaFlower, 1);
			recipe.AddIngredient(ItemID.FireGauntlet, 1);
			recipe.AddIngredient(ItemID.ArcticDivingGear, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
	
	
