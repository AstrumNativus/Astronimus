using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	public class AstrumPet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Daft Helmet");
			Tooltip.SetDefault("Summons a Daft Helmet to follow behind you");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = ProjectileType<Projectiles.AstrumPet>();
			item.buffType = BuffType<Buffs.AstrumPet>();
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}