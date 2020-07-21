
using QuodAstrum.Items;
using QuodAstrum.NPCs;
using QuodAstrum.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum
{
	// ModPlayer classes provide a way to attach data to Players and act on that data. ExamplePlayer has a lot of functionality related to 
	// several effects and items in ExampleMod. See SimpleModPlayer for a very simple example of how ModPlayer classes work.
	public class AstrumPlayer : ModPlayer
	{
		public bool AstrumPet;
		public bool noFly;

        // In MP, other clients need accurate information about your player or else bugs happen.
        // clientClone, SyncPlayer, and SendClientChanges, ensure that information is correct.
        // We only need to do this for data that is changed by code not executed by all clients, 
        // or data that needs to be shared while joining a world.
        // For example, examplePet doesn't need to be synced because all clients know that the player is wearing the ExamplePet item in an equipment slot. 
        // The examplePet bool is set for that player on every clients computer independently (via the Buff.Update), keeping that data in sync.
        // ExampleLifeFruits, however might be out of sync. For example, when joining a server, we need to share the exampleLifeFruits variable with all other clients.
        // In addition, in ExampleUI we have a button that toggles "Non-Stop Party". We need to sync this whenever it changes.
        public override void ResetEffects()
        {
			noFly = false;
        }
		public override void UpdateBadLifeRegen()
		{
			if (noFly)
			{
				if (player.wingTimeMax > 20)
				{
					player.wingTimeMax = 20;
				}
			}
		}
		public override void clientClone(ModPlayer clientClone)
		{
			AstrumPlayer clone = clientClone as AstrumPlayer;
			// Here we would make a backup clone of values that are only correct on the local players Player instance.
			// Some examples would be RPG stats from a GUI, Hotkey states, and Extra Item Slots
		}

		//public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
		//{
		//	ModPacket packet = mod.GetPacket();
		//	packet.Write((byte)ExampleModMessageType.ExamplePlayerSyncPlayer);
		//	packet.Write((byte)player.whoAmI);
		//	packet.Write(exampleLifeFruits);
		//	packet.Write(nonStopParty); // While we sync nonStopParty in SendClientChanges, we still need to send it here as well so newly joining players will receive the correct value.
		//	packet.Send(toWho, fromWho);
		//}

		//public override void SendClientChanges(ModPlayer clientPlayer)
		//{
		// Here we would sync something like an RPG stat whenever the player changes it.
		//	ExamplePlayer clone = clientPlayer as ExamplePlayer;
		//	if (clone.nonStopParty != nonStopParty)
		//	{
		//		// Send a Mod Packet with the changes.
		//		var packet = mod.GetPacket();
		//		packet.Write((byte)ExampleModMessageType.NonStopPartyChanged);
		//		packet.Write((byte)player.whoAmI);
		//		packet.Write(nonStopParty);
		//		packet.Send();
		//	}
		//}

		public override void UpdateDead()
		{
		}

		//public override TagCompound Save()
		//{
		// Read https://github.com/tModLoader/tModLoader/wiki/Saving-and-loading-using-TagCompound to better understand Saving and Loading data.
		//return new TagCompound {
		// {"somethingelse", somethingelse}, // To save more data, add additional lines
		//	{"score", score},
		//	{"exampleLifeFruits", exampleLifeFruits},
		//	{"nonStopParty", nonStopParty},
		//	{nameof(examplePersonGiftReceived), examplePersonGiftReceived},
		//};
		//note that C# 6.0 supports indexer initializers
		//return new TagCompound {
		//	["score"] = score
		//};
		//}

		//public override void Load(TagCompound tag)
		//{
		//	score = tag.GetInt("score");
		//	exampleLifeFruits = tag.GetInt("exampleLifeFruits");
		//	// nonStopParty was added after the initial ExampleMod release. Read https://github.com/tModLoader/tModLoader/wiki/Saving-and-loading-using-TagCompound#mod-version-updates for information about how to handle version updates in your mod without messing up current users of your mod.
		//	nonStopParty = tag.GetBool("nonStopParty");
		////	examplePersonGiftReceived = tag.GetBool(nameof(examplePersonGiftReceived));
		//}

		//public override void LoadLegacy(BinaryReader reader)
		//{
		////	int loadVersion = reader.ReadInt32();
		//	score = reader.ReadInt32();
		//}
		//
		public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath)
		{
			Item item = new Item();
			item.SetDefaults(ItemType<ScrollOfNativus>());
			item.stack = 1;
			items.Add(item);
		}

		//public override void UpdateBiomes()
		//{
		//ZoneExample = AstrumWorld.exampleTiles > 50;
		//}

		//public override bool CustomBiomesMatch(Player other)
		//{
		//AstrumPlayer modOther = other.GetModPlayer<AstrumPlayer>();
		//return ZoneExample == modOther.ZoneExample;
		// If you have several Zones, you might find the &= operator or other logic operators useful:
		// bool allMatch = true;
		// allMatch &= ZoneExample == modOther.ZoneExample;
		// allMatch &= ZoneModel == modOther.ZoneModel;
		// return allMatch;
		// Here is an example just using && chained together in one statemeny 
		// return ZoneExample == modOther.ZoneExample && ZoneModel == modOther.ZoneModel;
		//}

		//public override void CopyCustomBiomesTo(Player other)
		//{
		//	ExamplePlayer modOther = other.GetModPlayer<ExamplePlayer>();
		//	modOther.ZoneExample = ZoneExample;
		//}

		//public override void SendCustomBiomes(BinaryWriter writer)
		//{
		//BitsByte flags = new BitsByte();
		//flags[0] = ZoneExample;
		//writer.Write(flags);
		//}

		//public override void ReceiveCustomBiomes(BinaryReader reader)
		//{
		//BitsByte flags = reader.ReadByte();
		//ZoneExample = flags[0];
		//}




		//public override Texture2D GetMapBackgroundImage()
		//{
		//	if (ZoneExample)
		//	{
		//		return mod.GetTexture("ExampleBiomeMapBackground");
		//	}
		//	return null;
		//}


		//public override void ProcessTriggers(TriggersSet triggersSet)
		//{
		//	if (ExampleMod.RandomBuffHotKey.JustPressed)
		//	{
		//		int buff = Main.rand.Next(BuffID.Count);
		//		player.AddBuff(buff, 600);
		//	}
		//}



		//public override void UpdateVanityAccessories()
		//{
		//for (int n = 13; n < 18 + player.extraAccessorySlots; n++)
		//{
		//	Item item = player.armor[n];
		//	if (item.type == ItemType<Items.Armor.ExampleCostume>())
		//	{
		//		blockyHideVanity = false;
		//		blockyForceVanity = true;
		//	}
		//	}
		//}


	}
}