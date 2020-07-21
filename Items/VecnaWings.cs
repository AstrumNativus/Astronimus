using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace QuodAstrum.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class VecnaWings : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Whispered Cloak");
			Tooltip.SetDefault("Wings of the disgraced Lich");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 36;
			item.value = 10;
			item.rare = ItemRarityID.Expert;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 100;
			
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.05f;
			ascentWhenRising = 0.1f;
			maxCanAscendMultiplier = 0.5f;
			maxAscentMultiplier = 1f;
			constantAscend = 0.1f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 1.75f;
			acceleration *= 1.5f;
		}

	}
}