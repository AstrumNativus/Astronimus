using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.SkeletronHead) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {

                AstrumWorld.downedSkele = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == mod.NPCType("DuneRaiderH")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {

                AstrumWorld.downedDR = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == mod.NPCType("FrostWyrmHead")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {

                AstrumWorld.downedFW = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == mod.NPCType("CygmaH")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.downedCygma)
                {
                    Main.NewText("See to it that you defeat my dad, alright kid?", 123, 10, 168);
                }
                
                AstrumWorld.downedCygma = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == mod.NPCType("FrostWyrmHead")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {

                AstrumWorld.downedFW = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.EyeofCthulhu) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {

                AstrumWorld.downedEye = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.KingSlime) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {

                AstrumWorld.downedKS = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.QueenBee) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {

                AstrumWorld.downedQB = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.EaterofWorldsHead) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {

                AstrumWorld.downedEvil = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.BrainofCthulhu) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {

                AstrumWorld.downedEvil = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == mod.NPCType("AstrumTerr")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.spawnDragonAge)
                {                                                          //Red  Green Blue
                    Main.NewText("Lyrium has developed in the world caverns", 50, 100, 225);
                    Main.NewText("You are a unique failure, but a failure nonetheless", 255, 0, 247);//this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer) * 40E-05); k++)   //40E-05 is how many veins ore is going to spawn , change 40 to a lover value if you want less vains ore or higher value for more veins ore
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer); //this is the coordinates where the veins ore will spawn, so in Cavern layer
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9), (ushort)mod.TileType("LyriumOre"));   //WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9) is the vein ore sizes, so 9 to 15 blocks or 5 to 9 blocks, mod.TileType("CustomOreTile") is the custom tile that will spawn
                    }
                }
                AstrumWorld.spawnDragonAge = true;
                AstrumWorld.downedTerrum = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.WallofFlesh)
            //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.spawnWyvernSteel)
                {
                    Main.NewText("You have overcome the first major hurdle in your quest. It will not be the last, nor the hardest.", 255, 0, 247);
                }
                AstrumWorld.spawnWyvernSteel = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == mod.NPCType("AstrumMachina")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.downedMachina)
                {                                                          //Red  Green Blue

                    Main.NewText("So, the lost machine has become found once more... pity you had to destroy it.", 255, 0, 247);//this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color

                }

                AstrumWorld.downedMachina = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.Plantera)
            //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.downedPlant)
                {                                                          //Red  Green Blue
                    Main.NewText("As a good friend of mine once said, 'Congratulations! You killed a plant!'", 255, 0, 247);//this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    
                }
                AstrumWorld.downedPlant = true;
            }
            if (npc.type == mod.NPCType("Vecna")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.downedVecna)
                {                                                          //Red  Green Blue

                    Main.NewText("It appears you've put the Lich to rest. But be warned, the whispers of his wrath shall never fully stop, there's always one who still believes...", 255, 0, 247);//this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color

                }

                AstrumWorld.downedVecna = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }

        }
    }
}