using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace QuodAstrum.Items
{
	public class FrostWyrmMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Music Box (Frost Wyrm)");
			Tooltip.SetDefault("Plays 'Frosted Fractals' by B1ackIc3");
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
			item.rare = ItemRarityID.Cyan;
			item.value = 10;
			item.accessory = true;
		}

	}
}