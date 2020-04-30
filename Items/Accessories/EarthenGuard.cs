using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
	public class EarthenGuard : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Earthen Guard");
			Tooltip.SetDefault("The Shield of the Earth\nGives certain earthen advantages");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = Item.buyPrice(0, 5, 75, 0); ;
			item.rare = ItemRarityID.Expert;
			item.accessory = true;
			item.defense = 5;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.iceSkate = true;
			player.pickSpeed += 0.1f;
			player.buffImmune[BuffID.WindPushed] = true;
			if (player.whoAmI == Main.myPlayer && player.velocity.Y == 0f && player.grappling[0] == -1)
			{
				int num = (int)player.Center.X / 16;
				int num2 = (int)(player.position.Y + (float)player.height - 1f) / 16;
				if (Main.tile[num, num2] == null)
				{
					Main.tile[num, num2] = new Tile();
				}
				if (!Main.tile[num, num2].active() && Main.tile[num, num2].liquid == 0 && Main.tile[num, num2 + 1] != null && WorldGen.SolidTile(num, num2 + 1))
				{
					Main.tile[num, num2].frameY = 0;
					Main.tile[num, num2].slope(0);
					Main.tile[num, num2].halfBrick(false);
					if (Main.tile[num, num2 + 1].type == 2)
					{
						if (Main.rand.Next(2) == 0)
						{
							Main.tile[num, num2].active(true);
							Main.tile[num, num2].type = 3;
							Main.tile[num, num2].frameX = (short)(18 * Main.rand.Next(6, 11));
							while (Main.tile[num, num2].frameX == 144)
							{
								Main.tile[num, num2].frameX = (short)(18 * Main.rand.Next(6, 11));
							}
						}
						else
						{
							Main.tile[num, num2].active(true);
							Main.tile[num, num2].type = 73;
							Main.tile[num, num2].frameX = (short)(18 * Main.rand.Next(6, 21));
							while (Main.tile[num, num2].frameX == 144)
							{
								Main.tile[num, num2].frameX = (short)(18 * Main.rand.Next(6, 21));
							}
						}
						if (Main.netMode == 1)
						{
							NetMessage.SendTileSquare(-1, num, num2, 1, TileChangeType.None);
						}
					}
					else if (Main.tile[num, num2 + 1].type == 109)
					{
						if (Main.rand.Next(2) == 0)
						{
							Main.tile[num, num2].active(true);
							Main.tile[num, num2].type = 110;
							Main.tile[num, num2].frameX = (short)(18 * Main.rand.Next(4, 7));
							while (Main.tile[num, num2].frameX == 90)
							{
								Main.tile[num, num2].frameX = (short)(18 * Main.rand.Next(4, 7));
							}
						}
						else
						{
							Main.tile[num, num2].active(true);
							Main.tile[num, num2].type = 113;
							Main.tile[num, num2].frameX = (short)(18 * Main.rand.Next(2, 8));
							while (Main.tile[num, num2].frameX == 90)
							{
								Main.tile[num, num2].frameX = (short)(18 * Main.rand.Next(2, 8));
							}
						}
						if (Main.netMode == 1)
						{
							NetMessage.SendTileSquare(-1, num, num2, 1, TileChangeType.None);
						}
					}
					else if (Main.tile[num, num2 + 1].type == 60)
					{
						Main.tile[num, num2].active(true);
						Main.tile[num, num2].type = 74;
						Main.tile[num, num2].frameX = (short)(18 * Main.rand.Next(9, 17));
						if (Main.netMode == 1)
						{
							NetMessage.SendTileSquare(-1, num, num2, 1, TileChangeType.None);
						}
					}
				}
			}
		}
	}
}


