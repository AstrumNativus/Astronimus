using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	public class ScrollOfNativus : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scroll Of Nativus");
			Tooltip.SetDefault("Ah, another one."
				+"\nI suppose you are wondering what you need to be doing"
				+"\nWell, at the bottom of the tModLoader Recipe Browser, you should find the recipes of all the items of this mod, if you are using this mod from a direct download, well, you might be fucked"
				+"\nYour first steps would be to fight the Earthen Guardian, summoned by a Piece of Earth"
				+"\nA simple foe, should pose no problem if you were to fight it right now, but you'd need an Anvil, and maybe make a bow too.");

		}
	}
}