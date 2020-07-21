using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace QuodAstrum.Items
{
	public class TerrumMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Music Box (Terrum)");
			Tooltip.SetDefault("Plays 'Subterranea Stella' by Astrum Deorum");
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Green;
			item.value = 1;
			item.accessory = true;
		}

	}
}