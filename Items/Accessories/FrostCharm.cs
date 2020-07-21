using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Accessories
{
	public class FrostCharm : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frost Charm");
			Tooltip.SetDefault("The Pendant of the Wyrm\nProvides ice immunities\nIncreases damage by 5%\nDecreases defense by 5\nDecreases damage reduction by 5%");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 38;
			item.value = Item.buyPrice(0, 5, 75, 0); ;
			item.rare = ItemRarityID.Expert;
			item.accessory = true;
			item.defense = -5;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage += 0.05f;
			player.endurance -= 0.05f;
			player.buffImmune[BuffID.Frostburn] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.buffImmune[BuffID.Frozen] = true;
		}
	}
}


