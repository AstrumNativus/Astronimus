using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.Accessories
{
	public class CygmasFang : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cygmas Fang");
			Tooltip.SetDefault("The Fang of the Daughter\nCombines all vanilla PreHM Accessories");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = Item.buyPrice(0, 5, 75, 0); ;
			item.rare = ItemRarityID.Expert;
			item.accessory = true;
			item.defense = 2;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.strongBees = true;
			player.brainOfConfusion = true;
			player.endurance += 0.17f;
			player.dash = 2;
			player.npcTypeNoAggro[NPCID.BlueSlime] = true;
			player.npcTypeNoAggro[NPCID.IceSlime] = true;
			player.npcTypeNoAggro[NPCID.SpikedIceSlime] = true;
			player.npcTypeNoAggro[NPCID.SpikedJungleSlime] = true;
			player.npcTypeNoAggro[NPCID.SlimeSpiked] = true;
			player.npcTypeNoAggro[NPCID.MotherSlime] = true;
			player.npcTypeNoAggro[NPCID.CorruptSlime] = true;
			player.npcTypeNoAggro[NPCID.DungeonSlime] = true;
			player.npcTypeNoAggro[NPCID.IlluminantSlime] = true;
			player.npcTypeNoAggro[NPCID.Crimslime] = true;
			player.npcTypeNoAggro[NPCID.LavaSlime] = true;
			player.npcTypeNoAggro[NPCID.RainbowSlime] = true;
			player.npcTypeNoAggro[NPCID.UmbrellaSlime] = true;
			player.npcTypeNoAggro[NPCID.SandSlime] = true;
			player.npcTypeNoAggro[NPCID.Slimer] = true;
		}
	}
}


