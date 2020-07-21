using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Accessories
{
	public class DuneCharm : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dune Charm");
			Tooltip.SetDefault("The Pendant of the Raider\nProvides heat immunities\nDecreases damage by 5%\nIncreases damage reduction by 5%");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 38;
			item.value = Item.buyPrice(0, 5, 75, 0); ;
			item.rare = ItemRarityID.Expert;
			item.accessory = true;
			item.defense = 5;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage -= 0.05f;
			player.endurance += 0.05f;
			player.buffImmune[BuffID.WindPushed] = true;
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Burning] = true;
		}
	}
}


