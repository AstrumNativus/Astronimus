using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum
{
	public class QuodAstrum : Mod
	{
		public QuodAstrum()
		{
		}
        public override void PostSetupContent()
        {
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");
            if (bossChecklist != null)
            {
                // AddBoss, bossname, order or value in terms of vanilla bosses, inline method for retrieving downed value.
                // To include a description:
                bossChecklist.Call("AddBossWithInfo", "Terrum", 0f, (Func<bool>)(() => AstrumWorld.downedTerrum), "Create an amalgamate of the Terrarian Landscape");
                bossChecklist.Call("AddBossWithInfo", "Dune Raider", 3.5f, (Func<bool>)(() => AstrumWorld.downedDR), "Create an archaic chunk of sand");
				bossChecklist.Call("AddBossWithInfo", "Frost Wyrm", 3.5f, (Func<bool>)(() => AstrumWorld.downedFW), "Create an ancient piece of frost");
				bossChecklist.Call("AddBossWithInfo", "Maris", 2.4f, (Func<bool>)(() => AstrumWorld.downedMaris), "Create a Conch using materials from the ocean floor");
				bossChecklist.Call("AddBossWithInfo", "Vecna", 5.5f, (Func<bool>)(() => AstrumWorld.downedVecna), "Create a sigil spoken about through only whispers");
				bossChecklist.Call("AddBossWithInfo", "Cygma", 5.9999f, (Func<bool>)(() => AstrumWorld.downedCygma), "Come to terms with your mistakes\nClean out Pre Hardmode\nand raise the Cygma Star");
			}

        }
		public override void Load()
		{
			if (!Main.dedServ) // do not run this code on the server
			{
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Pulsar"), ItemType("PulsarMusicBox"), TileType("PulsarMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Icarus"), ItemType("IcarusMusicBox"), TileType("IcarusMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Suraci"), ItemType("SuraciMusicBox"), TileType("SuraciMusicBox"));
			}
		}
		public override void Close()
		{
			// Fix a tModLoader bug.
			var slots = new int[] {
				GetSoundSlot(SoundType.Music, "Sounds/Music/TheRradelum"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Subterranea Stella"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Pulsar"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Icarus"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Suraci"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/DuneRaider"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/FrostWyrm"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Maris"),

			};
			foreach (var slot in slots) // Other mods crashing during loading can leave Main.music in a weird state.
			{
				if (Main.music.IndexInRange(slot) && Main.music[slot]?.IsPlaying == true)
				{
					Main.music[slot].Stop(Microsoft.Xna.Framework.Audio.AudioStopOptions.Immediate);
				}
			}

			base.Close();
		}
	}
}