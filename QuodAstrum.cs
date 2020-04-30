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
                bossChecklist.Call("AddBossWithInfo", "Antikythera", 9.1f, (Func<bool>)(() => AstrumWorld.downedMachina), "Construct a beacon to search for a lost machine");
				bossChecklist.Call("AddBossWithInfo", "Vecna", 5.9f, (Func<bool>)(() => AstrumWorld.downedVecna), "Create a sigil spoken about through only whispers");
			}

        }
		public override void Close()
		{
			// Fix a tModLoader bug.
			var slots = new int[] {
				GetSoundSlot(SoundType.Music, "Sounds/Music/TheRradelum"),
				GetSoundSlot(SoundType.Music, "Sounds/Music/Subterranea Stella"),

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